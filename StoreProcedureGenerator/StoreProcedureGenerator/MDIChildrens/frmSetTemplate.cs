using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

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
                this.txtExtension.KeyPress += new KeyPressEventHandler(txtExtension_KeyPress);

                objTemplate = new Template();
            }

            public frmSetTemplate(Template tmp) : this()
            {
                objTemplate = tmp;
            }

        #endregion

        #region "Form Attributes"

            Template objTemplate;
            string[] KeyWords = {"<Database_Name>", 
                                 "<Creation_Date>", 
                                 "<Schema>",
                                 "<Table_Name>",
                                 "<Data_Type>", 
                                 "<Params>", 
                                 "<Attribute>|<@Attribute>"};
            Color[] colors = {Color.Red,
                              Color.DarkGray, 
                              Color.Aqua,
                              Color.Blue,
                              Color.Pink,
                              Color.Fuchsia,
                              Color.Green};

        #endregion

        #region "Form Events"

            private void frmSetTemplate_Load(object sender, EventArgs e)
            {
                if (objTemplate != null)
                {
                    txtTemplateName.Text = objTemplate.TemplateName;
                    txtFileName.Text = objTemplate.FileName;
                    txtExtension.Text = objTemplate.Extension;
                    txtTemplateCode.Lines = objTemplate.TemplateCode;
                }

                this.CheckKeywords();
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
                        objTemplate.TemplateName = txtTemplateName.Text;
                        objTemplate.FileName = txtFileName.Text;
                        objTemplate.Extension = txtExtension.Text;
                        objTemplate.TemplateCode = txtTemplateCode.Lines;

                        FileStream objStream = new FileStream(Application.StartupPath + "\\Templates\\" + txtTemplateName.Text + ".tml", FileMode.Create);
                        XmlSerializer objSerializer = new XmlSerializer(objTemplate.GetType());
                        objSerializer.Serialize(objStream, objTemplate);
                        objStream.Close();
                    }
                }


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

        #region Form Methods"

            private void CheckKeywords()
            {
                
                System.Drawing.Font objFont = txtTemplateCode.SelectionFont;
                System.Drawing.FontStyle objFontStyle = FontStyle.Bold;

                for (int i = 0; i < this.KeyWords.Length ; i++)
                {
                    Regex objRegex = new Regex(KeyWords[i]);

                    foreach (Match objMatch in objRegex.Matches(txtTemplateCode.Text))
                    {
                        txtTemplateCode.Select(objMatch.Index, objMatch.Length);
                        txtTemplateCode.SelectionFont = new Font(objFont.FontFamily, objFont.Size, objFontStyle);
                        txtTemplateCode.SelectionColor = colors[i];
                    }

                }

            }

        #endregion

    }
}
