namespace StoreProcedureGenerator.MDIChildrens
{
    partial class frmCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeGenerator));
            this.dgvTableView = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnCodeGenerator = new System.Windows.Forms.Button();
            this.btnChangeDirectory = new System.Windows.Forms.Button();
            this.fbdBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTableView
            // 
            this.dgvTableView.AllowUserToAddRows = false;
            this.dgvTableView.AllowUserToDeleteRows = false;
            this.dgvTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTableView.BackgroundColor = System.Drawing.Color.White;
            this.dgvTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colSchema,
            this.colTable,
            this.colColumn,
            this.colType,
            this.colLength,
            this.colNullable});
            this.dgvTableView.GridColor = System.Drawing.Color.White;
            this.dgvTableView.Location = new System.Drawing.Point(12, 12);
            this.dgvTableView.MultiSelect = false;
            this.dgvTableView.Name = "dgvTableView";
            this.dgvTableView.ReadOnly = true;
            this.dgvTableView.RowHeadersVisible = false;
            this.dgvTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableView.Size = new System.Drawing.Size(560, 314);
            this.dgvTableView.TabIndex = 1;
            // 
            // colIndex
            // 
            this.colIndex.DataPropertyName = "INDEX";
            this.colIndex.HeaderText = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            this.colIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIndex.Width = 39;
            // 
            // colSchema
            // 
            this.colSchema.DataPropertyName = "SCHEMA";
            this.colSchema.HeaderText = "Schema";
            this.colSchema.Name = "colSchema";
            this.colSchema.ReadOnly = true;
            this.colSchema.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSchema.Width = 52;
            // 
            // colTable
            // 
            this.colTable.DataPropertyName = "TABLE";
            this.colTable.HeaderText = "Table";
            this.colTable.Name = "colTable";
            this.colTable.ReadOnly = true;
            this.colTable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTable.Width = 40;
            // 
            // colColumn
            // 
            this.colColumn.DataPropertyName = "COLUMN";
            this.colColumn.HeaderText = "Column";
            this.colColumn.Name = "colColumn";
            this.colColumn.ReadOnly = true;
            this.colColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colColumn.Width = 48;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "TYPE";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colType.Width = 37;
            // 
            // colLength
            // 
            this.colLength.DataPropertyName = "LENGTH";
            this.colLength.HeaderText = "Length";
            this.colLength.Name = "colLength";
            this.colLength.ReadOnly = true;
            this.colLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLength.Width = 46;
            // 
            // colNullable
            // 
            this.colNullable.DataPropertyName = "NULLABLE";
            this.colNullable.HeaderText = "Nulable";
            this.colNullable.Name = "colNullable";
            this.colNullable.ReadOnly = true;
            this.colNullable.Width = 49;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 12;
            this.lineShape2.X2 = 570;
            this.lineShape2.Y1 = 338;
            this.lineShape2.Y2 = 338;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 570;
            this.lineShape1.Y1 = 339;
            this.lineShape1.Y2 = 339;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(584, 411);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(12, 362);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(279, 20);
            this.txtPath.TabIndex = 2;
            // 
            // btnCodeGenerator
            // 
            this.btnCodeGenerator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCodeGenerator.Image = global::StoreProcedureGenerator.Properties.Resources.generate;
            this.btnCodeGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCodeGenerator.Location = new System.Drawing.Point(479, 360);
            this.btnCodeGenerator.Name = "btnCodeGenerator";
            this.btnCodeGenerator.Size = new System.Drawing.Size(92, 23);
            this.btnCodeGenerator.TabIndex = 4;
            this.btnCodeGenerator.Text = "Generate";
            this.btnCodeGenerator.UseVisualStyleBackColor = true;
            // 
            // btnChangeDirectory
            // 
            this.btnChangeDirectory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnChangeDirectory.Image = global::StoreProcedureGenerator.Properties.Resources.folder;
            this.btnChangeDirectory.Location = new System.Drawing.Point(297, 361);
            this.btnChangeDirectory.Name = "btnChangeDirectory";
            this.btnChangeDirectory.Size = new System.Drawing.Size(40, 22);
            this.btnChangeDirectory.TabIndex = 3;
            this.btnChangeDirectory.UseVisualStyleBackColor = true;
            // 
            // fbdBrowser
            // 
            this.fbdBrowser.Description = "Select the directory that you want to use as the default.";
            // 
            // frmCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnCodeGenerator);
            this.Controls.Add(this.btnChangeDirectory);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.dgvTableView);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "frmCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator <Schema>.<Table_Name>";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTableView;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChangeDirectory;
        private System.Windows.Forms.Button btnCodeGenerator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colNullable;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowser;
    }
}