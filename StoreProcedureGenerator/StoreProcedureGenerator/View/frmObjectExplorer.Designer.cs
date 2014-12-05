namespace StoreProcedureGenerator.View
{
    partial class frmObjectExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObjectExplorer));
            this.tvwObjectExplorer = new System.Windows.Forms.TreeView();
            this.imgNodes = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvwObjectExplorer
            // 
            this.tvwObjectExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwObjectExplorer.Location = new System.Drawing.Point(0, 0);
            this.tvwObjectExplorer.Name = "tvwObjectExplorer";
            this.tvwObjectExplorer.Size = new System.Drawing.Size(284, 261);
            this.tvwObjectExplorer.TabIndex = 0;
            // 
            // imgNodes
            // 
            this.imgNodes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNodes.ImageStream")));
            this.imgNodes.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNodes.Images.SetKeyName(0, "database.png");
            this.imgNodes.Images.SetKeyName(1, "table.png");
            // 
            // frmObjectExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tvwObjectExplorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmObjectExplorer";
            this.Text = "Object Explorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwObjectExplorer;
        private System.Windows.Forms.ImageList imgNodes;
    }
}