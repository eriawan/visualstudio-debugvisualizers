using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

[assembly: System.Diagnostics.DebuggerVisualizer(typeof(VS2019.NETFX.DataVisualizer.DataVisualizerDebugger),
    typeof(VisualizerObjectSource),
    Target = typeof(System.Data.DataSet),
    Description = "VS 2019 Data Visualizer")]
[assembly: System.Diagnostics.DebuggerVisualizer(typeof(VS2019.NETFX.DataVisualizer.DataVisualizerDebugger),
    typeof(VisualizerObjectSource),
    Target = typeof(System.Data.DataTable),
    Description = "VS 2019 Data Visualizer")]
namespace VS2019.NETFX.DataVisualizer
{
    public class DataVisualizerDebugger : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            FrmVS2019DataVisualizer vS2019DataVisualizer = new FrmVS2019DataVisualizer();
            object dataToVisualize = objectProvider.GetObject();

            if(typeof(IListSource).IsInstanceOfType(dataToVisualize))
            {
                if (typeof(DataSet).IsInstanceOfType(dataToVisualize))
                {
                    #region hide uncessary UI
                    vS2019DataVisualizer.lblDataTableName.Text = "";
                    vS2019DataVisualizer.lblDataTableName.Visible = false;
                    #endregion

                    DataSet dataSet = dataToVisualize as DataSet;
                    
                    if(String.IsNullOrWhiteSpace(dataSet.DataSetName))
                    {
                        vS2019DataVisualizer.lblDataSetName.Text = "No Data Set Name";
                    }
                    else
                    {
                        vS2019DataVisualizer.lblDataSetName.Text = dataSet.DataSetName;
                    }

                    if(dataSet.Tables.Count > 0)
                    {
                        int noNameCounter = 1;
                        foreach(DataTable dt in dataSet.Tables)
                        {
                            if(!String.IsNullOrWhiteSpace(dt.TableName))
                            {
                                vS2019DataVisualizer.CmbDataTables.Items.Add(dt.TableName);
                            }
                            else
                            {
                                vS2019DataVisualizer.CmbDataTables.Items.Add($"No DataTable[{noNameCounter}]");
                                noNameCounter++;
                            }
                        }
                    }

                }
                else if (typeof(DataTable).IsInstanceOfType(dataToVisualize))
                {
                    #region hide uncessary UI
                    vS2019DataVisualizer.lblDataSetName.Text = "";
                    vS2019DataVisualizer.lblDataSetName.Visible = false;
                    vS2019DataVisualizer.lblTablesName.Text = "";
                    vS2019DataVisualizer.lblTablesName.Visible = false;
                    #endregion

                    DataTable dataTable = dataToVisualize as DataTable;
                    vS2019DataVisualizer.GridViewSourceData = dataTable;
                    vS2019DataVisualizer.lblTablesName.Text += String.IsNullOrWhiteSpace(dataTable.TableName) ? "No Table Name" : dataTable.TableName;
                }
            }

            vS2019DataVisualizer.ShowDialog();
            throw new NotImplementedException();
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DataVisualizerDebugger));
            visualizerHost.ShowVisualizer();
        }

    }
}
