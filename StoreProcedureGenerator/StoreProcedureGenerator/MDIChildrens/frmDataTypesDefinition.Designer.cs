namespace StoreProcedureGenerator.MDIChildrens
{
    partial class frmDataTypesDefinition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataTypesDefinition));
            this.label1 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.btnAddDefinition = new System.Windows.Forms.Button();
            this.dgvDataTypes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTypes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extension :";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(198, 19);
            this.txtExtension.MaxLength = 5;
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(100, 20);
            this.txtExtension.TabIndex = 1;
            // 
            // btnAddDefinition
            // 
            this.btnAddDefinition.Location = new System.Drawing.Point(304, 17);
            this.btnAddDefinition.Name = "btnAddDefinition";
            this.btnAddDefinition.Size = new System.Drawing.Size(90, 23);
            this.btnAddDefinition.TabIndex = 2;
            this.btnAddDefinition.Text = "Add Definition";
            this.btnAddDefinition.UseVisualStyleBackColor = true;
            // 
            // dgvDataTypes
            // 
            this.dgvDataTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvDataTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataTypes.GridColor = System.Drawing.Color.White;
            this.dgvDataTypes.Location = new System.Drawing.Point(3, 16);
            this.dgvDataTypes.Name = "dgvDataTypes";
            this.dgvDataTypes.RowHeadersVisible = false;
            this.dgvDataTypes.Size = new System.Drawing.Size(554, 334);
            this.dgvDataTypes.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDataTypes);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 353);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Types";
            // 
            // frmDataTypesDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddDefinition);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "frmDataTypesDefinition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Types Definition";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTypes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Button btnAddDefinition;
        private System.Windows.Forms.DataGridView dgvDataTypes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}