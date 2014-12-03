/**
 * About this : This is MDIMaster from StoreProcedureGenerator Application.
 * Creation Date : 30-Nov-2014
 * Created By : Irvin Ponce
 * Last Update Date : 01-Dic-2014
 * Last Update By : Irvin Ponce 
 */

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
using StoreProcedureGenerator.Generator;

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
                this.tsmiDatabases.Click += new EventHandler(tsmiDatabases_Click);
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
                StaticMain.ConnectionString = null;

                this.tsrStatus_Connection.Image = global::StoreProcedureGenerator.Properties.Resources.disconnect;
                this.ConnectionState(false);
            }

            private void tsmiDatabases_Click(object sender, EventArgs e)
            {
                frmDatabases objForm = new frmDatabases();
                objForm.TopLevel = false;
                objForm.Dock = DockStyle.Fill;
                pnlLeft.Controls.Add(objForm);
                pnlLeft.Show();
                objForm.Show();
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
                tsmiGenerator.Enabled = state;
                tsmiDatabases.Enabled = state;

            }

        #endregion

    }
}
