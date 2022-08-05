namespace VS2017.NETFX.DataVisualizer
{
    partial class FrmVS2017DataVisualizer
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
            this.dgvIListSourceVisualizer = new System.Windows.Forms.DataGridView();
            this.paneHeader = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDataSetName = new System.Windows.Forms.Label();
            this.lblDataTablesToDisplay = new System.Windows.Forms.Label();
            this.cmbDataTables = new System.Windows.Forms.ComboBox();
            this.lblDataTableName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIListSourceVisualizer)).BeginInit();
            this.paneHeader.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIListSourceVisualizer
            // 
            this.dgvIListSourceVisualizer.AllowUserToResizeRows = false;
            this.dgvIListSourceVisualizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIListSourceVisualizer.Location = new System.Drawing.Point(9, 71);
            this.dgvIListSourceVisualizer.Name = "dgvIListSourceVisualizer";
            this.dgvIListSourceVisualizer.ReadOnly = true;
            this.dgvIListSourceVisualizer.Size = new System.Drawing.Size(617, 255);
            this.dgvIListSourceVisualizer.TabIndex = 0;
            // 
            // paneHeader
            // 
            this.paneHeader.Controls.Add(this.flowLayoutPanel1);
            this.paneHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneHeader.Location = new System.Drawing.Point(0, 0);
            this.paneHeader.Name = "paneHeader";
            this.paneHeader.Size = new System.Drawing.Size(638, 54);
            this.paneHeader.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDataSetName);
            this.flowLayoutPanel1.Controls.Add(this.lblDataTablesToDisplay);
            this.flowLayoutPanel1.Controls.Add(this.cmbDataTables);
            this.flowLayoutPanel1.Controls.Add(this.lblDataTableName);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(587, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblDataSetName
            // 
            this.lblDataSetName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataSetName.AutoSize = true;
            this.lblDataSetName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSetName.Location = new System.Drawing.Point(3, 6);
            this.lblDataSetName.Name = "lblDataSetName";
            this.lblDataSetName.Size = new System.Drawing.Size(85, 15);
            this.lblDataSetName.TabIndex = 0;
            this.lblDataSetName.Text = "Dataset name:";
            // 
            // lblDataTablesToDisplay
            // 
            this.lblDataTablesToDisplay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataTablesToDisplay.AutoSize = true;
            this.lblDataTablesToDisplay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTablesToDisplay.Location = new System.Drawing.Point(94, 6);
            this.lblDataTablesToDisplay.Name = "lblDataTablesToDisplay";
            this.lblDataTablesToDisplay.Size = new System.Drawing.Size(48, 15);
            this.lblDataTablesToDisplay.TabIndex = 3;
            this.lblDataTablesToDisplay.Text = "Tables: ";
            // 
            // cmbDataTables
            // 
            this.cmbDataTables.FormattingEnabled = true;
            this.cmbDataTables.Location = new System.Drawing.Point(148, 3);
            this.cmbDataTables.Name = "cmbDataTables";
            this.cmbDataTables.Size = new System.Drawing.Size(158, 21);
            this.cmbDataTables.TabIndex = 4;
            this.cmbDataTables.SelectedIndexChanged += new System.EventHandler(this.cmbDataTables_SelectedIndexChanged);
            // 
            // lblDataTableName
            // 
            this.lblDataTableName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataTableName.AutoSize = true;
            this.lblDataTableName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTableName.Location = new System.Drawing.Point(312, 6);
            this.lblDataTableName.Name = "lblDataTableName";
            this.lblDataTableName.Size = new System.Drawing.Size(103, 14);
            this.lblDataTableName.TabIndex = 2;
            this.lblDataTableName.Text = "DataTable name: ";
            // 
            // FrmVS2017DataVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 338);
            this.Controls.Add(this.paneHeader);
            this.Controls.Add(this.dgvIListSourceVisualizer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVS2017DataVisualizer";
            this.Text = "VS 2017 Data Visualizer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmVS2017DataVisualizer_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIListSourceVisualizer)).EndInit();
            this.paneHeader.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIListSourceVisualizer;
        private System.Windows.Forms.Panel paneHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Label lblDataSetName;
        internal System.Windows.Forms.ComboBox cmbDataTables;
        internal System.Windows.Forms.Label lblDataTablesToDisplay;
        internal System.Windows.Forms.Label lblDataTableName;
    }
}