
namespace VS2019.NETFX.DataVisualizerWinformsDemo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnShowDataSetVisualizer = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(438, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Visual Studio 2019 Visualizer demo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 383);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnShowDataSetVisualizer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataSet Visualizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnShowDataSetVisualizer
            // 
            this.BtnShowDataSetVisualizer.Location = new System.Drawing.Point(227, 134);
            this.BtnShowDataSetVisualizer.Name = "BtnShowDataSetVisualizer";
            this.BtnShowDataSetVisualizer.Size = new System.Drawing.Size(308, 70);
            this.BtnShowDataSetVisualizer.TabIndex = 0;
            this.BtnShowDataSetVisualizer.Text = "Show DataSet Sample";
            this.BtnShowDataSetVisualizer.UseVisualStyleBackColor = true;
            this.BtnShowDataSetVisualizer.Click += new System.EventHandler(this.BtnShowDataSetVisualizer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataTable Visualizer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmDataVisualizerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmDataVisualizerDemo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDataVisualizerDemo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnShowDataSetVisualizer;
    }
}

