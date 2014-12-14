using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreProcedureGenerator.Static_Class;
using System.IO;
using System.Xml.Serialization;

namespace StoreProcedureGenerator.MDIChildrens
{
    public partial class frmCodeGenerator : Form
    {

        #region "Initialize Components"

            private frmCodeGenerator()
            {
                InitializeComponent();

                this.btnChangeDirectory.Click += new EventHandler(btnChangeDirectory_Click);
                this.Load += new EventHandler(frmCodeGenerator_Load);
                this.btnCodeGenerator.Click += new EventHandler(btnCodeGenerator_Click);
            }

            public frmCodeGenerator(string database_name, string table_name) : this()
            {
                this.database_name = database_name;
                int index = table_name.IndexOf(".", 0);
                this.table_name = table_name.Remove(0, index + 1);
                this.schema_name = table_name.Remove(index);
            }

        #endregion

        #region "Form Attributes"

            private string database_name;
            private string table_name;
            private string schema_name;
            private DataTable DataTypes;

        #endregion

        #region "Form Actions"

            private void btnChangeDirectory_Click(object sender, EventArgs e)
            {
                fbdBrowser.SelectedPath = txtPath.Text;
                DialogResult objResult = fbdBrowser.ShowDialog();
                if (objResult == System.Windows.Forms.DialogResult.OK)
                {
                    txtPath.Text = fbdBrowser.SelectedPath;
                    StaticMain.DefaultPath = fbdBrowser.SelectedPath;
                }
            }

            private void btnCodeGenerator_Click(object sender, EventArgs e)
            {
                if (txtPath.Text != string.Empty)
                {
                    foreach (string objFileTemplate in Directory.GetFiles(Application.StartupPath + "\\Templates\\"))
                    {
                        FileStream objFileStream = new FileStream(objFileTemplate, FileMode.Open);
                        XmlSerializer objSerializer = new XmlSerializer(typeof(Template));
                        Template objTemplate = new Template();
                        objTemplate = (Template)objSerializer.Deserialize(objFileStream);
                        objFileStream.Close();

                        if (this.ProcessTemplate(objTemplate))
                        {
                            MessageBox.Show("Template " + objTemplate.TemplateName + " created!",
                                            "Code Generator",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }

        #endregion

        #region "Form Events"

            private void frmCodeGenerator_Load(object sender, EventArgs e)
            {
                string text = this.Text;
                text = text.Replace("<Schema>", this.schema_name);
                text = text.Replace("<Table_Name>", this.table_name);
                this.Text = text;

                this.txtPath.Text = StaticMain.DefaultPath;
                DataTable objTableItems = this.GetTableItems();
                dgvTableView.DataSource = objTableItems;

                this.LoadDataTypes();
            }

        #endregion

        #region "Form Functions"

            private DataTable GetTableItems()
            {
                SqlConnection objConnection = StaticMain.Connection;
                objConnection.Open();
                objConnection.ChangeDatabase(this.database_name);

                DataTable objDataTable = null;
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "SELECT SH.name AS 'SCHEMA'," +
                                                "TB.name AS 'TABLE'," +
                                                "CL.column_id AS 'INDEX'," +
                                                "CL.name AS 'COLUMN'," +
                                                "TP.name AS 'TYPE'," +
                                                "(CASE WHEN TP.name LIKE '%char%' THEN " +
                                                        "(CL.max_length / 2) " +
                                                      "ELSE " +
                                                        "NULL " +
                                                "END)			AS 'LENGTH'," +
                                                "CL.is_nullable	AS 'NULLABLE' " +
                                           "FROM sys.tables	TB," +
                                                "sys.schemas SH," +
                                                "sys.columns CL," +
                                                "sys.types	TP " +
                                          "WHERE TB.schema_id = SH.schema_id " +
                                            "AND TB.object_id = CL.object_id " +
                                            "AND CL.system_type_id = TP.system_type_id " +
                                            "AND CL.user_type_id = TP.user_type_id " +
                                            "AND TB.name = @TableName " +
                                          "ORDER BY TB.name," +
                                                   "CL.column_id";
                objCommand.Parameters.Add("@TableName", SqlDbType.NVarChar);
                objCommand.Parameters["@TableName"].Value = this.table_name;

                try
                {
                    SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
                    DataSet objDataSet = new DataSet();
                    objDataAdapter.Fill(objDataSet);
                    objDataTable = objDataSet.Tables[0];
                }
                catch
                {
                }
                finally
                {
                    objConnection.Close();
                }

                return objDataTable;
            }

            private bool ProcessTemplate(Template objTemplate)
            {
                string path = txtPath.Text + "\\" + this.schema_name + "." + this.table_name + "\\";
                Directory.CreateDirectory(path);

                StreamWriter objFile = null;
                objFile = this.CreateFile(path, objTemplate);
                this.WriteFile(objFile, objTemplate);
                objFile.Close();

                return true;
            }

            private StreamWriter CreateFile(string path, Template objTemplate)
            {
                StreamWriter objFile = null;

                try
                {
                    if (objTemplate.FileName.Contains("<Table_Name>")){
                        path += objTemplate.FileName.Replace("<Table_Name>", this.table_name);
                    }
                    else if (objTemplate.FileName.Contains("<TABLE_NAME>"))
                    {
                        path += objTemplate.FileName.Replace("<TABLE_NAME>", this.table_name.ToUpper());
                    }
                    path += "." + objTemplate.Extension;
                    objFile = new StreamWriter(path);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(objTemplate.FileName + " - " + objTemplate.TemplateName + " - " + ex.Message,
                                    "Create File",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                return objFile;
            }

            private string getDate()
            {
                string objTime = null;
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = StaticMain.Connection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "SELECT CONVERT(NVARCHAR, GETDATE(), 100)";
                StaticMain.Connection.Open();

                try
                {
                    objTime = (string)objCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Get Date",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                finally
                {
                    StaticMain.Connection.Close();
                }

                return objTime;
            }

            private string getDataType(string DataType, string extension)
            {
                string strDataType = string.Empty;

                DataView objView = new DataView(DataTypes);
                objView.RowFilter = " sql = " + "'" + DataType + "'";
                DataTable objTable = objView.ToTable();
                strDataType = objTable.Rows[0][extension].ToString();

                return strDataType;
            }

        #endregion

        #region "Form Methods"
        
            private void WriteFile(StreamWriter objFile, Template objTemplate)
            {
                foreach (string lineCode in objTemplate.TemplateCode)
                {
                    string line = lineCode;
                    bool Except_Last = false;

                    if (lineCode.Contains("<Database_Name>"))
                    {
                        line = line.Replace("<Database_Name>", this.database_name);
                    }

                    if (lineCode.Contains("<Schema>"))
                    {
                        line = line.Replace("<Schema>", this.schema_name);
                    }

                    if (lineCode.Contains("<Table_Name>"))
                    {
                        line = line.Replace("<Table_Name>", this.table_name);
                    }
                    else if (lineCode.Contains("<TABLE_NAME>"))
                    {
                        line = line.Replace("<TABLE_NAME>", this.table_name.ToUpper());
                    }

                    if (lineCode.Contains("<Creation_Date>"))
                    {
                        line = line.Replace("<Creation_Date>", this.getDate());
                    }

                    if (lineCode.Contains("<Params>"))
                    {

                        if (lineCode.Contains("<Except_Last>"))
                        {
                            Except_Last = true;
                        }
                        else
                        {
                            Except_Last = false;
                        }
                        
                        for (int i = 1; i < dgvTableView.Rows.Count; i++)
                        {
                            line = lineCode.Replace("<Params>", "");
                            line = line.Replace("<Except_Last>", "");

                            using (DataGridViewRow row = dgvTableView.Rows[i])
                            {
                                string strDataType = row.Cells["colType"].ToString();

                                line = line.Replace("<Attribute>", row.Cells["colColumn"].Value.ToString());

                                if (dgvTableView.Rows[i].Cells["colLength"].Value.ToString() != "" && objTemplate.Extension == "sql")
                                {
                                    line = line.Replace("<Data_Type>", this.getDataType(row.Cells["colType"].Value.ToString(), objTemplate.Extension) + "(" + row.Cells["colLength"].Value.ToString() + ")");
                                }
                                else
                                {
                                    line = line.Replace("<Data_Type>", this.getDataType(row.Cells["colType"].Value.ToString(), objTemplate.Extension));
                                }
                            }

                            
                            if (i == dgvTableView.Rows.Count - 1 && Except_Last == true)
                            {
                                int index = lineCode.IndexOf("<Except_Last>");
                                string strLast = lineCode.Substring(index - 1, 1);
                                line = line.Replace(strLast, "");
                            }

                            objFile.WriteLine(line);
                        }

                        continue;
                    }

                    objFile.WriteLine(line);
                }
            }

            private void LoadDataTypes()
            {
                try
                {
                    FileStream objStream = new FileStream(Application.StartupPath + "\\DataTypes.xml", FileMode.Open);
                    XmlSerializer objSerializer = new XmlSerializer(typeof(DataTable));
                    this.DataTypes = (DataTable)objSerializer.Deserialize(objStream);
                    objStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Load Data Types",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

        #endregion

    }
}
