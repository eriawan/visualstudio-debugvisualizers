using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

[assembly: System.Diagnostics.DebuggerVisualizer(typeof(VS2017.NETFX.DataVisualizer.DataVisualizerDebugger),
    typeof(VisualizerObjectSource),
    Target = typeof(System.Data.DataSet),
    Description = "VS 2017 Data Visualizer")]
[assembly: System.Diagnostics.DebuggerVisualizer(typeof(VS2017.NETFX.DataVisualizer.DataVisualizerDebugger),
    typeof(VisualizerObjectSource),
    Target = typeof(System.Data.DataTable),
    Description = "VS 2017 Data Visualizer")]
namespace VS2017.NETFX.DataVisualizer
{
    public class DataVisualizerDebugger : DialogDebuggerVisualizer
    {
        public DataVisualizerDebugger() : base()
        {

        }
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            FrmVS2017DataVisualizer vS2017DataVisualizer = new FrmVS2017DataVisualizer();
            object dataToVisualize = objectProvider.GetObject();
            Type objectToVisualizeType = dataToVisualize.GetType();
            if (typeof(IListSource).IsInstanceOfType(dataToVisualize))
            {
                if (typeof(DataSet).IsInstanceOfType(dataToVisualize))
                {
                    DataSet dataSet = dataToVisualize as DataSet;
                    vS2017DataVisualizer.GridViewDataSource = dataSet;
                    if (String.IsNullOrWhiteSpace(dataSet.DataSetName))
                    {
                        vS2017DataVisualizer.lblDataSetName.Text = "<NONAME DataSet>";
                    }
                    else
                    {
                        vS2017DataVisualizer.lblDataSetName.Text = dataSet.DataSetName;
                    }
                    if (dataSet.Tables.Count > 0)
                    {
                        int notablenameCounter = 0;
                        foreach (DataTable dtItem in dataSet.Tables)
                        {
                            if (!String.IsNullOrWhiteSpace(dtItem.TableName))
                            {
                                vS2017DataVisualizer.cmbDataTables.Items.Add(dtItem.TableName);
                            }
                            else
                            {
                                vS2017DataVisualizer.cmbDataTables.Items.Add($"<NONAME TABLE{notablenameCounter}>");
                            }
                            notablenameCounter++;
                        }
                        // Set selected index as 0 by default to select first dataset by default
                        vS2017DataVisualizer.cmbDataTables.SelectedIndex = 0;

                    }
                    // if object to visualize is DataSet, the Label display for single datatable's TableName is not relevant to display anymore.
                    vS2017DataVisualizer.lblDataTableName.Text = "";
                    vS2017DataVisualizer.lblDataTableName.Visible = false;
                }
                if (typeof(DataTable).IsInstanceOfType(dataToVisualize))
                {
                    vS2017DataVisualizer.lblDataSetName.Text = "";
                    vS2017DataVisualizer.lblDataSetName.Visible = false;
                    vS2017DataVisualizer.lblDataSetName.Text = "";
                    vS2017DataVisualizer.lblDataTablesToDisplay.Visible = false;
                    vS2017DataVisualizer.cmbDataTables.Visible = false;
                    vS2017DataVisualizer.cmbDataTables.Size = new System.Drawing.Size(1, 1);
                    DataTable dataTableToVisualize = dataToVisualize as DataTable;
                    vS2017DataVisualizer.GridViewDataSource = dataTableToVisualize;
                    vS2017DataVisualizer.lblDataTableName.Text += String.IsNullOrEmpty(dataTableToVisualize.TableName) ? "<NONAME TABLE>" : dataTableToVisualize.TableName;
                }
            }
            vS2017DataVisualizer.ShowDialog();
        }

        public static void TestShowVisualizer(IListSource dataToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(dataToVisualize, typeof(DataVisualizerDebugger));
            visualizerHost.ShowVisualizer();
        }
    }
}
