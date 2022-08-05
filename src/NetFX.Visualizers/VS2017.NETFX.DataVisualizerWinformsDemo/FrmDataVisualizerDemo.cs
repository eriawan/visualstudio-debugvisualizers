using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VS2017.NETFX.DataVisualizer;

namespace VS2017.NETFX.DataVisualizerWinformsDemo
{
    public partial class FrmDataVisualizerDemo : Form
    {
        public FrmDataVisualizerDemo()
        {
            InitializeComponent();
        }

        public DataSet NorthwindDS { get; set; }

        private void paneHeader_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(paneHeader.ClientRectangle, Color.LightBlue, Color.LightBlue, LinearGradientMode.Horizontal);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 2/6f, 3/6f, 4/6f, 1 };
            cb.Colors = new[] { Color.LightBlue, Color.LightPink, Color.Azure, Color.LightPink, Color.LightBlue };
            brush.InterpolationColors = cb;
            e.Graphics.FillRectangle(brush, paneHeader.ClientRectangle);
        }

        private void FrmDataVisualizerDemo_Load(object sender, EventArgs e)
        {
            // Load the XML of Northwind as DataSet
            NorthwindDS = new DataSet("DATASET1");
            NorthwindDS.ReadXml("NorthwindDS.xml", XmlReadMode.ReadSchema);
        }

        private void btnShowDatasetNWDemo_Click(object sender, EventArgs e)
        {
            DataVisualizerDebugger.TestShowVisualizer(NorthwindDS);
        }
    }
}
