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
    public partial class frmTemplates : Form
    {

        #region "Initialize Components"

            public frmTemplates()
            {
                InitializeComponent();

                this.FormClosed += new FormClosedEventHandler(frmTemplates_FormClosed);
                this.Load += new EventHandler(frmTemplates_Load);
                this.Move += new EventHandler(frmTemplates_Move);
                this.btnCreateTemplate.Click += new EventHandler(btnCreateTemplate_Click);
                this.btnUpdateTemplate.Click += new EventHandler(btnUpdateTemplate_Click);
                this.btnRemoveTemplate.Click += new EventHandler(btnRemoveTemplate_Click);
            }
        
        #endregion

        #region "Form Events"

            private void frmTemplates_FormClosed(object sender, EventArgs e)
            {
                this.Hide();
                Panel objPanel = this.Parent as Panel;
                objPanel.Hide();
            }

            private void frmTemplates_Load(object sender, EventArgs e)
            {
                Panel objPanel = this.Parent as Panel;
                this.MaximumSize = new Size(objPanel.Width, objPanel.Height);
                this.MinimumSize = new Size(objPanel.Width, objPanel.Height);
            }

            private void frmTemplates_Move(object sender, EventArgs e)
            {
                this.Location = new Point(1, 1);
            }

        #endregion

        #region "Form Methods"
        #endregion

        #region "Form Functions"
        #endregion

        #region "Form Actions"

            private void btnCreateTemplate_Click(object sender, EventArgs e)
            {
                frmSetTemplate objFormTemplate = new frmSetTemplate();
                objFormTemplate.MdiParent = StaticMain.MDIMaster;
                objFormTemplate.Show();
            }

            private void btnUpdateTemplate_Click(object sender, EventArgs e)
            {
            }

            private void btnRemoveTemplate_Click(object sender, EventArgs e)
            {
            }

        #endregion

    }
}
