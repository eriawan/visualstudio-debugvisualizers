using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019.NETFX.DataVisualizer
{
    public partial class FrmVS2019DataVisualizer : Form
    {
        public FrmVS2019DataVisualizer()
        {
            InitializeComponent();
        }

        internal IListSource GridViewSourceData { get; set; }

        private void CmbDataTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GridViewSourceData is DataSet)
            {
                DataSet gVDataSource = GridViewSourceData as DataSet;
                if (gVDataSource.Tables.Count > 0 && CmbDataTables.Items.Count > 0)
                {
                    DgvDataVisualizer.DataSource = null;
                    DgvDataVisualizer.DataSource = gVDataSource.Tables[CmbDataTables.SelectedIndex];
                    Refresh();
                }
            }
        }
    }
}
