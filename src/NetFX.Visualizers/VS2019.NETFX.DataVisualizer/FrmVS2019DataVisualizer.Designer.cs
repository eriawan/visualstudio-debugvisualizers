
namespace VS2019.NETFX.DataVisualizer
{
    partial class FrmVS2019DataVisualizer
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
            this.DgvDataVisualizer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataTableName = new System.Windows.Forms.Label();
            this.CmbDataTables = new System.Windows.Forms.ComboBox();
            this.lblTablesName = new System.Windows.Forms.Label();
            this.lblDataSetName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVisualizer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDataVisualizer
            // 
            this.DgvDataVisualizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDataVisualizer.Location = new System.Drawing.Point(12, 99);
            this.DgvDataVisualizer.Name = "DgvDataVisualizer";
            this.DgvDataVisualizer.ReadOnly = true;
            this.DgvDataVisualizer.RowHeadersWidth = 51;
            this.DgvDataVisualizer.RowTemplate.Height = 24;
            this.DgvDataVisualizer.Size = new System.Drawing.Size(776, 330);
            this.DgvDataVisualizer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDataTableName);
            this.panel1.Controls.Add(this.CmbDataTables);
            this.panel1.Controls.Add(this.lblTablesName);
            this.panel1.Controls.Add(this.lblDataSetName);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblDataTableName
            // 
            this.lblDataTableName.AutoSize = true;
            this.lblDataTableName.Location = new System.Drawing.Point(400, 9);
            this.lblDataTableName.Name = "lblDataTableName";
            this.lblDataTableName.Size = new System.Drawing.Size(115, 17);
            this.lblDataTableName.TabIndex = 3;
            this.lblDataTableName.Text = "DataTableName:";
            // 
            // CmbDataTables
            // 
            this.CmbDataTables.FormattingEnabled = true;
            this.CmbDataTables.Location = new System.Drawing.Point(188, 6);
            this.CmbDataTables.Name = "CmbDataTables";
            this.CmbDataTables.Size = new System.Drawing.Size(185, 24);
            this.CmbDataTables.TabIndex = 2;
            this.CmbDataTables.SelectedIndexChanged += new System.EventHandler(this.CmbDataTables_SelectedIndexChanged);
            // 
            // lblTablesName
            // 
            this.lblTablesName.AutoSize = true;
            this.lblTablesName.Location = new System.Drawing.Point(127, 9);
            this.lblTablesName.Name = "lblTablesName";
            this.lblTablesName.Size = new System.Drawing.Size(55, 17);
            this.lblTablesName.TabIndex = 1;
            this.lblTablesName.Text = "Tables:";
            // 
            // lblDataSetName
            // 
            this.lblDataSetName.AutoSize = true;
            this.lblDataSetName.Location = new System.Drawing.Point(16, 9);
            this.lblDataSetName.Name = "lblDataSetName";
            this.lblDataSetName.Size = new System.Drawing.Size(104, 17);
            this.lblDataSetName.TabIndex = 0;
            this.lblDataSetName.Text = "DataSetName :";
            // 
            // FrmVS2019DataVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvDataVisualizer);
            this.Name = "FrmVS2019DataVisualizer";
            this.Text = "FrmVS2019DataVisualizer";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDataVisualizer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDataVisualizer;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblDataSetName;
        internal System.Windows.Forms.ComboBox CmbDataTables;
        internal System.Windows.Forms.Label lblDataTableName;
        internal System.Windows.Forms.Label lblTablesName;
    }
}