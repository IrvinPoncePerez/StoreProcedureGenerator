namespace StoreProcedureGenerator.View
{
    partial class frmTemplates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplates));
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.btnUpdateTemplate = new System.Windows.Forms.Button();
            this.btnRemoveTemplate = new System.Windows.Forms.Button();
            this.tvwTemplates = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateTemplate.Image")));
            this.btnCreateTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateTemplate.Location = new System.Drawing.Point(0, 192);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(284, 23);
            this.btnCreateTemplate.TabIndex = 1;
            this.btnCreateTemplate.Text = "&1. Create Template";
            this.btnCreateTemplate.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTemplate
            // 
            this.btnUpdateTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateTemplate.Image = global::StoreProcedureGenerator.Properties.Resources.alter;
            this.btnUpdateTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateTemplate.Location = new System.Drawing.Point(0, 215);
            this.btnUpdateTemplate.Name = "btnUpdateTemplate";
            this.btnUpdateTemplate.Size = new System.Drawing.Size(284, 23);
            this.btnUpdateTemplate.TabIndex = 2;
            this.btnUpdateTemplate.Text = "&2. Update Template";
            this.btnUpdateTemplate.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTemplate
            // 
            this.btnRemoveTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemoveTemplate.Image = global::StoreProcedureGenerator.Properties.Resources.remove;
            this.btnRemoveTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveTemplate.Location = new System.Drawing.Point(0, 238);
            this.btnRemoveTemplate.Name = "btnRemoveTemplate";
            this.btnRemoveTemplate.Size = new System.Drawing.Size(284, 23);
            this.btnRemoveTemplate.TabIndex = 3;
            this.btnRemoveTemplate.Text = "3. Remove Template";
            this.btnRemoveTemplate.UseVisualStyleBackColor = true;
            // 
            // tvwTemplates
            // 
            this.tvwTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwTemplates.Location = new System.Drawing.Point(0, 0);
            this.tvwTemplates.Name = "tvwTemplates";
            this.tvwTemplates.Size = new System.Drawing.Size(284, 192);
            this.tvwTemplates.TabIndex = 0;
            // 
            // frmTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tvwTemplates);
            this.Controls.Add(this.btnCreateTemplate);
            this.Controls.Add(this.btnUpdateTemplate);
            this.Controls.Add(this.btnRemoveTemplate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTemplates";
            this.Text = "Templates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTemplate;
        private System.Windows.Forms.Button btnUpdateTemplate;
        private System.Windows.Forms.Button btnRemoveTemplate;
        private System.Windows.Forms.TreeView tvwTemplates;
    }
}