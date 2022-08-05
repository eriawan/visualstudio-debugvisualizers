using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VS2017.NETFX.DataVisualizer
{
    public partial class FrmVS2017DataVisualizer : Form
    {
        public FrmVS2017DataVisualizer()
        {
            InitializeComponent();
        }

        internal IListSource GridViewDataSource { get; set; }

        private void cmbDataTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridViewDataSource is DataSet)
            {
                var internalGvDataSource = GridViewDataSource as DataSet;
                if (internalGvDataSource.Tables.Count > 0  && cmbDataTables.Items.Count > 0)
                {
                    dgvIListSourceVisualizer.DataSource = null;
                    dgvIListSourceVisualizer.DataSource = internalGvDataSource.Tables[cmbDataTables.SelectedIndex];
                    Refresh();
                }
            }
            else
            {
                // do nothing.
            }
        }

        private void FrmVS2017DataVisualizer_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(paneHeader.ClientRectangle, Color.Blue, Color.LightBlue, 150F);
            e.Graphics.FillRectangle(brush, paneHeader.ClientRectangle);
        }
    }
}
