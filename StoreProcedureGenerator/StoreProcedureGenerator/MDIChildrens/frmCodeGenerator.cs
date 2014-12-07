﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using StoreProcedureGenerator.Static_Class;

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

        #endregion

        #region "Form Methods"

            

        #endregion

    }
}