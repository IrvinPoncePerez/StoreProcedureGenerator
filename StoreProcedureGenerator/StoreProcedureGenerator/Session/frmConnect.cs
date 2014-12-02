using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoreProcedureGenerator.Static_Class;
using System.Data.SqlClient;

namespace StoreProcedureGenerator.Session
{
    public partial class frmConnect : Form
    {
        #region "Initial Components"

            public frmConnect()
            {
                InitializeComponent();

                this.Load += new EventHandler(frmConnect_Load);
                this.cmbAuthenticationMode.SelectedIndexChanged += new EventHandler(cmbAuthenticationMode_SelectedIndexChanged);
                this.btnConnect.Click += new EventHandler(btnConnect_Click);
                this.btnCancel.Click += new EventHandler(btnCancel_Click);
            }

        #endregion

        #region "Form Events"

            private void frmConnect_Load(object sender, EventArgs e)
            {
                cmbAuthenticationMode.SelectedIndex = 0;
            }

            private void cmbAuthenticationMode_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cmbAuthenticationMode.SelectedIndex == 0)
                {
                    lblUserName.Enabled = false;
                    lblPassword.Enabled = false;
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;

                    txtUserName.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                }
                else if (cmbAuthenticationMode.SelectedIndex == 1)
                {
                    lblUserName.Enabled = true;
                    lblPassword.Enabled = true;
                    txtUserName.Enabled = true;
                    txtPassword.Enabled = true;
                }
            }

        #endregion

        #region "Form Actions"

            private void btnConnect_Click(object sender, EventArgs e)
            {
                MDIMaster mdi = this.MdiParent as MDIMaster;
                StaticMain.ServerName = this.txtServerName.Text;
                StaticMain.AuthenticationMode = this.cmbAuthenticationMode.SelectedIndex;
                StaticMain.UserName = this.txtUserName.Text;
                StaticMain.Password = this.txtPassword.Text;
                StaticMain.goMain();

                SqlConnection objConnection = new SqlConnection(StaticMain.ConnectionString);
                try
                {
                    objConnection.Open();

                    if (objConnection.State == ConnectionState.Open)
                    {
                        mdi.ConnectionState(true);
                        MessageBox.Show("Successfully Connection!",
                                        "Session",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        mdi.ConnectionState(false);
                        MessageBox.Show("Failed Connection!",
                                        "Session",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    mdi.ConnectionState(false);
                    MessageBox.Show("Failed Connection!",
                                        "Session",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }

                objConnection.Close();
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        #endregion

    }
}
