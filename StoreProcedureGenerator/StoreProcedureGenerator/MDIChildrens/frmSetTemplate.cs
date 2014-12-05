using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreProcedureGenerator.MDIChildrens
{
    public partial class frmSetTemplate : Form
    {

        #region "Initialize Components"

            public frmSetTemplate()
            {
                InitializeComponent();

                this.Load += new EventHandler(frmSetTemplate_Load);
                this.FormClosing += new FormClosingEventHandler(frmSetTemplate_FormClosing);
            }

        #endregion

        #region "Form Attributes"

            private int Id_Template;
            private string TemplateName;
            private string FileName;
            private string Author;
            private string Description;
            private string Extension;
            private string[] TemplateCode;

        #endregion

        #region "Form Events"

            private void frmSetTemplate_Load(object sender, EventArgs e)
            {
                
            }

            private void frmSetTemplate_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (!this.IsEmpty())
                {
                    DialogResult objResult = MessageBox.Show("Do you want to save the template?",
                                                             "Save Template",
                                                             MessageBoxButtons.YesNoCancel,
                                                             MessageBoxIcon.Question);
                    if (objResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                    else if (objResult == System.Windows.Forms.DialogResult.Yes)
                    {

                    }
                }
            }

        #endregion

        #region "Form Functions"

            private bool IsEmpty()
            {
                if (txtTemplateName.Text != String.Empty)
                {
                    return false;
                }

                if (txtFileName.Text != String.Empty)
                {
                    return false;
                }

                if (txtAuthor.Text != String.Empty)
                {
                    return false;
                }

                if (txtDescription.Text != String.Empty)
                {
                    return false;
                }

                if (txtExtension.Text != String.Empty)
                {
                    return false;
                }

                string[] tmpLines = txtTemplateCode.Lines;
                if (tmpLines.Length > 0)
                {
                    return false;
                }

                return true;
            }

        #endregion

    }
}
