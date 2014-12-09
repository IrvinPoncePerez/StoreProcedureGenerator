using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using StoreProcedureGenerator.Static_Class;
using System.Xml.Serialization;

namespace StoreProcedureGenerator.MDIChildrens
{
    public partial class frmDataTypesDefinition : Form
    {

        #region "Initialize Components"

            public frmDataTypesDefinition()
            {
                InitializeComponent();

                this.Load += new EventHandler(frmDataTypesDefinition_Load);
                this.btnAddDefinition.Click += new EventHandler(btnAddDefinition_Click);
                this.txtExtension.KeyPress += new KeyPressEventHandler(txtExtension_KeyPress);
                this.FormClosing += new FormClosingEventHandler(frmDataTypesDefinition_FormClosing);
            }

        #endregion

        #region "Form Attributes"


        #endregion

        #region "Form Events"

            private void frmDataTypesDefinition_Load(object sender, EventArgs e)
            {
                DataTable objDataTypes = null;

                if (!File.Exists(Application.StartupPath + "\\DataTypes.xml"))
                {
                    objDataTypes = getDataTypes();
                }
                else
                {
                    objDataTypes = getFileDataTypes();
                }

                dgvDataTypes.DataSource = objDataTypes;
            }

            private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            private void frmDataTypesDefinition_FormClosing(object sender, EventArgs e)
            {
                try
                {
                    DataTable objDataTable = (DataTable)dgvDataTypes.DataSource;
                    FileStream objStream = new FileStream(Application.StartupPath + "\\DataTypes.xml", FileMode.Create);
                    XmlSerializer objSerializer = new XmlSerializer(objDataTable.GetType());
                    objSerializer.Serialize(objStream, objDataTable);
                    objStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Save DataTypes",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

        #endregion

        #region "Form Functions"

            private DataTable getDataTypes()
            {
                DataTable objDataTable = null;
                SqlConnection objConnection = StaticMain.Connection;
                objConnection.Open();
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "SELECT name AS 'sql' FROM sys.types";

                try
                {
                    SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
                    DataSet objDataSet = new DataSet();
                    objDataAdapter.Fill(objDataSet);
                    objDataTable = objDataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Data Types",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                finally
                {
                    objConnection.Close();
                }

                return objDataTable;
            }

            private DataTable getFileDataTypes()
            {
                DataTable objDataTable = null;

                try
                {
                    XmlSerializer objSerializer = new XmlSerializer(typeof(DataTable));
                    string path = Application.StartupPath + "\\DataTypes.xml";
                    FileStream objStream = new FileStream(path, FileMode.Open);
                    objDataTable = (DataTable)objSerializer.Deserialize(objStream);
                    objStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Open DataTypes File",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                
                return objDataTable;
            }

        #endregion

        #region "Form Methods"

        #endregion

        #region "Form Actions"

            private void btnAddDefinition_Click(object sender, EventArgs e)
            {
                if (txtExtension.Text != string.Empty)
                {
                    DataTable objDataTable = (DataTable)dgvDataTypes.DataSource;
                    DataColumn objColumn = objDataTable.Columns[txtExtension.Text];

                    if (objColumn == null)
                    {
                        objColumn = new DataColumn(txtExtension.Text);
                        objDataTable.Columns.Add(objColumn);
                    }   
                    
                    dgvDataTypes.DataSource = objDataTable;
                }

                txtExtension.Text = string.Empty;
            }

        #endregion

    }
}
