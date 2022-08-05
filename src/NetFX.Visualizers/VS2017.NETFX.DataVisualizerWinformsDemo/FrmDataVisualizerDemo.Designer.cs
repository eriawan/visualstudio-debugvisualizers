namespace VS2017.NETFX.DataVisualizerWinformsDemo
{
    partial class FrmDataVisualizerDemo
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
            this.paneHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabVisualizerDemo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCaptionDataSetName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowDatasetNWDemo = new System.Windows.Forms.Button();
            this.paneHeader.SuspendLayout();
            this.tabVisualizerDemo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneHeader
            // 
            this.paneHeader.Controls.Add(this.label1);
            this.paneHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneHeader.Location = new System.Drawing.Point(0, 0);
            this.paneHeader.Name = "paneHeader";
            this.paneHeader.Size = new System.Drawing.Size(910, 78);
            this.paneHeader.TabIndex = 0;
            this.paneHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.paneHeader_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "VS 2017 Visualizer Demo";
            // 
            // tabVisualizerDemo
            // 
            this.tabVisualizerDemo.Controls.Add(this.tabPage1);
            this.tabVisualizerDemo.Controls.Add(this.tabPage2);
            this.tabVisualizerDemo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVisualizerDemo.Location = new System.Drawing.Point(12, 84);
            this.tabVisualizerDemo.Name = "tabVisualizerDemo";
            this.tabVisualizerDemo.SelectedIndex = 0;
            this.tabVisualizerDemo.Size = new System.Drawing.Size(886, 386);
            this.tabVisualizerDemo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnShowDatasetNWDemo);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblCaptionDataSetName);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dataset Visalizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataTable Visualizer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCaptionDataSetName
            // 
            this.lblCaptionDataSetName.AutoSize = true;
            this.lblCaptionDataSetName.Location = new System.Drawing.Point(31, 20);
            this.lblCaptionDataSetName.Name = "lblCaptionDataSetName";
            this.lblCaptionDataSetName.Size = new System.Drawing.Size(86, 15);
            this.lblCaptionDataSetName.TabIndex = 0;
            this.lblCaptionDataSetName.Text = "DataSet Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "DATASET1";
            // 
            // btnShowDatasetNWDemo
            // 
            this.btnShowDatasetNWDemo.Location = new System.Drawing.Point(34, 74);
            this.btnShowDatasetNWDemo.Name = "btnShowDatasetNWDemo";
            this.btnShowDatasetNWDemo.Size = new System.Drawing.Size(411, 23);
            this.btnShowDatasetNWDemo.TabIndex = 2;
            this.btnShowDatasetNWDemo.Text = "Show sample Visualizer of Northwind Customers, Orders and Order Details";
            this.btnShowDatasetNWDemo.UseVisualStyleBackColor = true;
            this.btnShowDatasetNWDemo.Click += new System.EventHandler(this.btnShowDatasetNWDemo_Click);
            // 
            // FrmDataVisualizerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 493);
            this.Controls.Add(this.tabVisualizerDemo);
            this.Controls.Add(this.paneHeader);
            this.Name = "FrmDataVisualizerDemo";
            this.Text = "VS 2017 Data Visualizer DEMO";
            this.Load += new System.EventHandler(this.FrmDataVisualizerDemo_Load);
            this.paneHeader.ResumeLayout(false);
            this.paneHeader.PerformLayout();
            this.tabVisualizerDemo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneHeader;
        private System.Windows.Forms.TabControl tabVisualizerDemo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaptionDataSetName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowDatasetNWDemo;
    }
}

