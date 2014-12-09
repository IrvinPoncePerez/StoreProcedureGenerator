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
using StoreProcedureGenerator.View;
using StoreProcedureGenerator.MDIChildrens;

namespace StoreProcedureGenerator
{

    public partial class MDIMaster : Form
    {

        #region "Initial Components"

            public MDIMaster()
            {
                InitializeComponent();

                this.Load += new EventHandler(MDIMaster_Load);
                this.tsmiConnect.Click += new EventHandler(tsmiConnect_Click);
                this.tsmiDisconnect.Click += new EventHandler(tsmiDisconnect_Click);
                this.tsmiObjectExplorer.Click += new EventHandler(tsmiObjectExplorer_Click);
                this.tsmiTemplates.Click += new EventHandler(tsmiTemplates_Click);
                this.tsmiDataTypes.Click += new EventHandler(tsmiDataTypes_Click);
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

            private void tsmiObjectExplorer_Click(object sender, EventArgs e)
            {
                frmObjectExplorer objForm = new frmObjectExplorer();
                objForm.TopLevel = false;
                objForm.Dock = DockStyle.Fill;
                pnlLeft.Controls.Add(objForm);
                pnlLeft.Show();
                objForm.Show();
            }

            private void tsmiTemplates_Click(object sender, EventArgs e)
            {
                frmTemplates objForm = new frmTemplates();
                objForm.TopLevel = false;
                objForm.Dock = DockStyle.Fill;
                pnlRight.Controls.Add(objForm);
                pnlRight.Show();
                objForm.Show();
            }

            private void tsmiDataTypes_Click(object sender, EventArgs e)
            {
                frmDataTypesDefinition objDataTypes = new frmDataTypesDefinition();
                objDataTypes.MdiParent = this;
                objDataTypes.Show();
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
                tsmiObjectExplorer.Enabled = state;
                tsmiTemplates.Enabled = state;
                tsmiSettings.Enabled = state;
                tsmiDataTypes.Enabled = state;

            }

        #endregion

        #region "Form Events"

            private void MDIMaster_Load(object sender, EventArgs e)
            {
                StaticMain.MDIMaster = this;
            }

        #endregion

    }
}
