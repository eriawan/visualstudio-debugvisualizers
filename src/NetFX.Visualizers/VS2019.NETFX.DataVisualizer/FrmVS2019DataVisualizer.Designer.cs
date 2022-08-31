
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataSetName = new System.Windows.Forms.Label();
            this.lblTablesName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDataTableName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDataTableName);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblTablesName);
            this.panel1.Controls.Add(this.lblDataSetName);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblDataSetName
            // 
            this.lblDataSetName.AutoSize = true;
            this.lblDataSetName.Location = new System.Drawing.Point(16, 9);
            this.lblDataSetName.Name = "lblDataSetName";
            this.lblDataSetName.Size = new System.Drawing.Size(104, 17);
            this.lblDataSetName.TabIndex = 0;
            this.lblDataSetName.Text = "DataSetName :";
            this.lblDataSetName.Click += new System.EventHandler(this.label1_Click);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 2;
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
            // FrmVS2019DataVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVS2019DataVisualizer";
            this.Text = "FrmVS2019DataVisualizer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataSetName;
        private System.Windows.Forms.Label lblTablesName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDataTableName;
    }
}