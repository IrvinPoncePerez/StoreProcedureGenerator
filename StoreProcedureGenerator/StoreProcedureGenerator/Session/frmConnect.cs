using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
