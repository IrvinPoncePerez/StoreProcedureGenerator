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
using StoreProcedureGenerator.MDIChildrens;

namespace StoreProcedureGenerator.View
{
    public partial class frmObjectExplorer : Form
    {

        #region "Initialize Components"

        public frmObjectExplorer()
            {
                InitializeComponent();

                this.FormClosed += new FormClosedEventHandler(frmDatabases_FormClosed);
                this.Load += new EventHandler(frmDatabases_Load);
                this.Move += new System.EventHandler(this.frmDatabases_Move);
                this.tvwObjectExplorer.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(tvwObjectExplorer_NodeMouseDoubleClick);
            }

        #endregion

        #region "Form Events"

            private void frmDatabases_FormClosed(object sender, EventArgs e)
            {
                this.Hide();
                Panel objPanel = this.Parent as Panel;
                objPanel.Hide();
            }

            private void frmDatabases_Load(object sender, EventArgs e)
            {
                Panel objPanel = this.Parent as Panel;
                this.MaximumSize = new Size(objPanel.Width, objPanel.Height);
                this.MinimumSize = new Size(objPanel.Width, objPanel.Height);

                this.createTreeView(this.getDatabases());
            }

            private void frmDatabases_Move(object sender, EventArgs e)
            {
                this.Location = new Point(1, 1);
            }

        #endregion

        #region "Form Methods"

            private void createTreeView(DataTable objData)
            {
                tvwObjectExplorer.ImageList = imgNodes;
                foreach (DataRow objRowDB in objData.Rows)
                {
                    TreeNode objNodeDatabase = tvwObjectExplorer.Nodes.Add(objRowDB["database_name"].ToString());
                    objNodeDatabase.ImageIndex = 0;
                    objNodeDatabase.SelectedImageIndex = 0;

                    foreach (DataRow objRowTB in this.getTables(objRowDB["database_name"].ToString()).Rows)
                    {
                        TreeNode objNodeTable = objNodeDatabase.Nodes.Add(objRowTB["SCHEMA"].ToString() + "." + objRowTB["TABLE"].ToString());
                        objNodeTable.ImageIndex = 1;
                        objNodeTable.SelectedImageIndex = 1;
                    }
                }
            }

        #endregion

        #region "Form Functions"

            private DataTable getDatabases()
            {
                SqlConnection objConnection = StaticMain.Connection;
                objConnection.Open();
                DataTable objDatabases = null; ;
                try
                {
                    objDatabases = objConnection.GetSchema("Databases");
                }
                catch (Exception ex)
                { }
                finally
                {
                    objConnection.Close();
                }
                return objDatabases;
            }

            private DataTable getTables(String database)
            {
                SqlConnection objConnection = StaticMain.Connection;
                objConnection.Open();
                objConnection.ChangeDatabase(database);
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "SELECT SH.name	AS	'SCHEMA', TB.name	AS	'TABLE' FROM sys.tables	TB, sys.schemas	SH WHERE TB.schema_id = SH.schema_id ORDER BY TB.name";
                DataTable objDataTable = null;

                try
                {
                    SqlDataAdapter objDataAdapter = new SqlDataAdapter(objCommand);
                    DataSet objDataSet = new DataSet();
                    objDataAdapter.Fill(objDataSet);
                    objDataTable = objDataSet.Tables[0];
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    objConnection.Close();
                }

                return objDataTable;

            }

        #endregion

        #region "Form Actions"

            private void tvwObjectExplorer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode objChildNode = e.Node;
                TreeNode objParentNode = null;
                string database_name = null;
                string table_name = null;

                if (objChildNode.ImageIndex == 1)
                {
                    objParentNode = objChildNode.Parent;
                    database_name = objParentNode.Text;
                    table_name = objChildNode.Text;

                    frmCodeGenerator objCodeGenerator = new frmCodeGenerator(database_name, table_name);
                    objCodeGenerator.MdiParent = StaticMain.MDIMaster;
                    objCodeGenerator.Show();
                }

            }

        #endregion

    }
}
