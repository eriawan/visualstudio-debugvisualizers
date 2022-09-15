using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VS2019.NETFX.DataVisualizer;

namespace VS2019.NETFX.DataVisualizerWinformsDemo
{
    public partial class FrmDataVisualizerDemo : Form
    {
        public DataSet NorthwindDS { get; set; }

        public FrmDataVisualizerDemo()
        {
            InitializeComponent();
        }

        private void BtnShowDataSetVisualizer_Click(object sender, EventArgs e)
        {
            DataVisualizerDebugger.TestShowVisualizer(NorthwindDS);
        }

        private void FrmDataVisualizerDemo_Load(object sender, EventArgs e)
        {
            // Load the XML of Northwind as DataSet
            NorthwindDS = new DataSet("DATASET1");
            NorthwindDS.ReadXml("NorthwindDS.xml", XmlReadMode.ReadSchema);
        }
    }
}
