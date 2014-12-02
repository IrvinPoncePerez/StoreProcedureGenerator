using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoreProcedureGenerator.Session;
using StoreProcedureGenerator.Static_Class;

namespace StoreProcedureGenerator
{
    public partial class MDIMaster : Form
    {

        #region "Initial Components"

            public MDIMaster()
            {
                InitializeComponent();

                this.tsmiConnect.Click += new EventHandler(tsmiConnect_Click);
                this.tsmiDisconnect.Click += new EventHandler(tsmiDisconnect_Click);
            }

        #endregion

        #region "Form Buttons"

            private void tsmiConnect_Click(object sender, EventArgs e)
            {
                frmConnect objForm = new frmConnect();
                objForm.MdiParent = this;
                objForm.Show();
            }

            private void tsmiDisconnect_Click(object sender, EventArgs e)
            {
                StaticMain.ServerName = String.Empty;
                StaticMain.AuthenticationMode = 0;
                StaticMain.UserName = String.Empty;
                StaticMain.Password = String.Empty;
                StaticMain.ConnectionString = String.Empty;

                this.tsrStatus_Connection.Image = global::StoreProcedureGenerator.Properties.Resources.disconnect;
                this.ConnectionState(false);
            }


        #endregion

        #region "Form Methods"

            public void ConnectionState(Boolean state)
            {
                if (state)
                {
                    this.tsrStatus_Connection.Image = global::StoreProcedureGenerator.Properties.Resources.connect;
                    this.tsrStatus_Connection.Text = "Connect";
                }
                else
                {
                    this.tsrStatus_Connection.Image = global::StoreProcedureGenerator.Properties.Resources.disconnect;
                    this.tsrStatus_Connection.Text = "Disconnect";
                }

                tsmiConnect.Enabled = !state;
                tsmiDisconnect.Enabled = state;




            }

        #endregion

    }
}
