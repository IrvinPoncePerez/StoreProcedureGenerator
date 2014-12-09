namespace StoreProcedureGenerator
{
    partial class MDIMaster
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMaster));
            this.ssrStatus = new System.Windows.Forms.StatusStrip();
            this.tsrStatus_Connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenus = new System.Windows.Forms.MenuStrip();
            this.tsmiSession = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiObjectExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDataTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.ssrStatus.SuspendLayout();
            this.msMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssrStatus
            // 
            this.ssrStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrStatus_Connection});
            this.ssrStatus.Location = new System.Drawing.Point(0, 479);
            this.ssrStatus.Name = "ssrStatus";
            this.ssrStatus.Size = new System.Drawing.Size(935, 22);
            this.ssrStatus.TabIndex = 1;
            this.ssrStatus.Text = "statusStrip1";
            // 
            // tsrStatus_Connection
            // 
            this.tsrStatus_Connection.Image = global::StoreProcedureGenerator.Properties.Resources.disconnect;
            this.tsrStatus_Connection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsrStatus_Connection.Name = "tsrStatus_Connection";
            this.tsrStatus_Connection.Size = new System.Drawing.Size(82, 17);
            this.tsrStatus_Connection.Text = "Disconnect";
            this.tsrStatus_Connection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msMenus
            // 
            this.msMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSession,
            this.tsmiGenerator,
            this.tsmiSettings});
            this.msMenus.Location = new System.Drawing.Point(0, 0);
            this.msMenus.Name = "msMenus";
            this.msMenus.Size = new System.Drawing.Size(935, 24);
            this.msMenus.TabIndex = 3;
            this.msMenus.Text = "menuStrip1";
            // 
            // tsmiSession
            // 
            this.tsmiSession.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnect,
            this.tsmiDisconnect});
            this.tsmiSession.Name = "tsmiSession";
            this.tsmiSession.Size = new System.Drawing.Size(70, 20);
            this.tsmiSession.Text = "  &Session  ";
            // 
            // tsmiConnect
            // 
            this.tsmiConnect.Name = "tsmiConnect";
            this.tsmiConnect.Size = new System.Drawing.Size(133, 22);
            this.tsmiConnect.Text = "&Connect";
            // 
            // tsmiDisconnect
            // 
            this.tsmiDisconnect.Enabled = false;
            this.tsmiDisconnect.Name = "tsmiDisconnect";
            this.tsmiDisconnect.Size = new System.Drawing.Size(133, 22);
            this.tsmiDisconnect.Text = "&Disconnect";
            // 
            // tsmiGenerator
            // 
            this.tsmiGenerator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiObjectExplorer,
            this.tsmiTemplates});
            this.tsmiGenerator.Enabled = false;
            this.tsmiGenerator.Name = "tsmiGenerator";
            this.tsmiGenerator.Size = new System.Drawing.Size(71, 20);
            this.tsmiGenerator.Text = "     &View    ";
            // 
            // tsmiObjectExplorer
            // 
            this.tsmiObjectExplorer.Enabled = false;
            this.tsmiObjectExplorer.Name = "tsmiObjectExplorer";
            this.tsmiObjectExplorer.Size = new System.Drawing.Size(154, 22);
            this.tsmiObjectExplorer.Text = "&Object Explorer";
            // 
            // tsmiTemplates
            // 
            this.tsmiTemplates.Enabled = false;
            this.tsmiTemplates.Name = "tsmiTemplates";
            this.tsmiTemplates.Size = new System.Drawing.Size(154, 22);
            this.tsmiTemplates.Text = "&Templates";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDataTypes});
            this.tsmiSettings.Enabled = false;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(76, 20);
            this.tsmiSettings.Text = "   S&ettings  ";
            // 
            // tsmiDataTypes
            // 
            this.tsmiDataTypes.Enabled = false;
            this.tsmiDataTypes.Name = "tsmiDataTypes";
            this.tsmiDataTypes.Size = new System.Drawing.Size(132, 22);
            this.tsmiDataTypes.Text = "D&ata Types";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 24);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 455);
            this.pnlLeft.TabIndex = 5;
            this.pnlLeft.Visible = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(685, 24);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(250, 455);
            this.pnlRight.TabIndex = 7;
            this.pnlRight.Visible = false;
            // 
            // MDIMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 501);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.ssrStatus);
            this.Controls.Add(this.msMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenus;
            this.Name = "MDIMaster";
            this.Text = "Store Procedure Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ssrStatus.ResumeLayout(false);
            this.ssrStatus.PerformLayout();
            this.msMenus.ResumeLayout(false);
            this.msMenus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssrStatus;
        private System.Windows.Forms.MenuStrip msMenus;
        private System.Windows.Forms.ToolStripMenuItem tsmiSession;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnect;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisconnect;
        public System.Windows.Forms.ToolStripStatusLabel tsrStatus_Connection;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenerator;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmiObjectExplorer;
        private System.Windows.Forms.ToolStripMenuItem tsmiTemplates;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataTypes;
    }
}

