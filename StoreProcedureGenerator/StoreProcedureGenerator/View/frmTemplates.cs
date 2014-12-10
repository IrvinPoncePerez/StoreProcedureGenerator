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
using System.IO;
using System.Xml.Serialization;

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
                this.tvwTemplates.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(tvwTemplates_NodeMouseDoubleClick);
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

                this.LoadTemplates();
            }

            private void frmTemplates_Move(object sender, EventArgs e)
            {
                this.Location = new Point(1, 1);
            }

            private void objFormTemplate_FormClosed(object sender, EventArgs e)
            {
                this.LoadTemplates();
            }

            private void tvwTemplates_NodeMouseDoubleClick(object sender, EventArgs e)
            {
                this.btnUpdateTemplate_Click(null, null);
            }

        #endregion

        #region "Form Methods"

            private void LoadTemplates()
            {
                tvwTemplates.Nodes.Clear();

                TreeNode objNode = tvwTemplates.Nodes.Add("Templates\\");
                objNode.ImageIndex = 0;
                objNode.SelectedImageIndex = 0;

                foreach (string FileName in ListTemplates())
                {
                    TreeNode objChildNode = objNode.Nodes.Add(FileName.Replace(Application.StartupPath + "\\Templates\\", ""));
                    objChildNode.ImageIndex = 1;
                    objChildNode.SelectedImageIndex = 1;
                }

                objNode.ExpandAll();

            }

        #endregion

        #region "Form Functions"

            private string[] ListTemplates()
            {
                string[] Files = Directory.GetFiles(Application.StartupPath + "\\Templates\\");
                return Files;
            }

        #endregion

        #region "Form Actions"

            private void btnCreateTemplate_Click(object sender, EventArgs e)
            {
                frmSetTemplate objFormTemplate = new frmSetTemplate();
                objFormTemplate.FormClosed += new FormClosedEventHandler(objFormTemplate_FormClosed);
                objFormTemplate.MdiParent = StaticMain.MDIMaster;
                objFormTemplate.Show();
            }

            private void btnUpdateTemplate_Click(object sender, EventArgs e)
            {
                Template objTemplate = null;
                try
                {
                    XmlSerializer objSerializer = new XmlSerializer(typeof(Template));
                    string path = Application.StartupPath + "\\Templates\\" + tvwTemplates.SelectedNode.Text;
                    FileStream objStream = new FileStream(path, FileMode.Open);
                    objTemplate = (Template)objSerializer.Deserialize(objStream);
                    objStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Open Templates",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                frmSetTemplate objFormTemplate = new frmSetTemplate(objTemplate);
                objFormTemplate.FormClosed += new FormClosedEventHandler(objFormTemplate_FormClosed);
                objFormTemplate.MdiParent = StaticMain.MDIMaster;
                objFormTemplate.Show();

            }

            private void btnRemoveTemplate_Click(object sender, EventArgs e)
            {
                DialogResult objResult = MessageBox.Show("Do you want to remove the selected template?",
                                                         "Template Explorer",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                if (objResult == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(Application.StartupPath + "\\Templates\\" + tvwTemplates.SelectedNode.Text);
                        this.LoadTemplates();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                                        "Remove Template",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }

            }

        #endregion

    }
}
