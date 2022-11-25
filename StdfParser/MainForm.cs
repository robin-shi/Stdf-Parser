using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToStdf;
using LinqToStdf.Records.V4;
using ScottPlot;

namespace StdfParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DisVisiableRadioButton();
        }

        StdfData stdfData { get; set; }
        byte selectedSite { get; set; }
        uint selectedtestNumber { get; set; }
        bool radioButtonUpdateChartEnabled { get; set; }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog() {Filter="stdf|*.stdf;*.std",
            InitialDirectory=@"..\"};
            fileDialog.ShowDialog();
            OpenStdfFileStream(fileDialog.FileName);
        }
        private void OpenStdfFileStream(string stdfFilePath)
        {
            if (stdfFilePath != ""&&stdfFilePath.Contains("std"))
            {
                //Clear display
                stdfData = new StdfData(stdfFilePath);
                dataGridViewTestItems.Rows.Clear();
                DisVisiableRadioButton();
                formsPlotScatter.Plot.Clear();
                formsPlotHsitogram.Plot.Clear();
                dataGridViewStats.Rows.Clear();
                //Update display
                toolStripStatusFileName.Text = stdfFilePath;
                UpdatedataGridViewTestItems();
                UpdateMirTab();
                radioButtonUpdateChartEnabled = false;
                UpdateRadioButton();
                textBoxFilter.Text = " ";//creat a value changed event
                textBoxFilter.Text = "";
            }
        }

        private void UpdatedataGridViewTestItems()
        {
            foreach (var item in stdfData.TestItems)
            {
                dataGridViewTestItems.Rows.Add(item.Key,item.Value);
            }
            toolStripProgressBarFileOpen.Value = 0;
        }

        private void UpdateRadioButton()
        {
            foreach (var siteNum in stdfData.SiteNums.Reverse())
            {
                if (siteNum == 0)
                {
                    radioButtonSite0.Visible = true;
                    radioButtonSite0.Checked = true;
                    selectedSite = 0;
                }
                else if (siteNum == 1)
                {
                    radioButtonSite1.Visible = true;
                    radioButtonSite1.Checked = true;
                    selectedSite = 1;
                }
                else if (siteNum == 2)
                {
                    radioButtonSite2.Visible = true;
                    radioButtonSite2.Checked = true;
                    selectedSite = 2;
                }
                    
                else if (siteNum == 3)
                {
                    radioButtonSite3.Visible = true;
                    radioButtonSite3.Checked = true;
                    selectedSite = 3;
                }
                    
            } 
        }
        private void DisVisiableRadioButton()
        {
            radioButtonSite0.Visible = false;
            radioButtonSite1.Visible = false;
            radioButtonSite2.Visible = false;
            radioButtonSite3.Visible = false;
        }


        private void UpdateScatter()
        {
            formsPlotScatter.Plot.Clear();
            formsPlotScatter.Plot.AddScatterPoints(stdfData.DataX, stdfData.DataY);
            formsPlotScatter.Plot.XAxis.Label("DUT Index(#)");
            formsPlotScatter.Plot.YAxis.Label($"Test Value({stdfData.Unit})");
            formsPlotScatter.Plot.Title($"Site{stdfData.Site}-{stdfData.TestNum}-{stdfData.TestName}");
            formsPlotScatter.Refresh();
        }

        private void UpdateHistogram()
        {
            try
            {
                formsPlotHsitogram.Plot.Clear();
                formsPlotHsitogram.Plot.YAxis.Label("DUT Count(#)");
                formsPlotHsitogram.Plot.XAxis.Label($"Test Value({stdfData.Unit})");
                formsPlotHsitogram.Plot.Title($"Site{stdfData.Site}-{stdfData.TestNum}-{stdfData.TestName}");
                formsPlotHsitogram.Refresh();
                double maxValue = stdfData.Mean + stdfData.StDev * 6;
                double minValue = stdfData.Mean - stdfData.StDev * 6;
                double binWidth = (maxValue - minValue) /50;
                (double[] counts, double[] binEdges) = ScottPlot.Statistics.Common.Histogram(stdfData.DataY, min: minValue, max: maxValue, binSize: binWidth);
                double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();
                for(int i=0;i<leftEdges.Length;i++)
                {
                    leftEdges[i] += binWidth / 2;
                }
                var bar = formsPlotHsitogram.Plot.AddBar(values: counts, positions: leftEdges);
                bar.FillColor = ColorTranslator.FromHtml("#9bc3eb");
                bar.BorderLineWidth = 1f;
                bar.BarWidth = binWidth;
                double[] smoothEdges = DataGen.Range(start: binEdges.First(), stop: binEdges.Last(), step: binWidth/2, includeStop: true);
                double[] smoothDensities = ScottPlot.Statistics.Common.ProbabilityDensity(stdfData.DataY, smoothEdges, percent: true);
                var probPlot = formsPlotHsitogram.Plot.AddScatterLines(
                    xs: smoothEdges,
                    ys: smoothDensities,
                    lineWidth: 2,
                    lineStyle: LineStyle.Dot,
                    color: Color.Red,
                    label: "probability") ;
                probPlot.YAxisIndex = 1;
                formsPlotHsitogram.Plot.YAxis2.Ticks(true);

                formsPlotHsitogram.Plot.AddVerticalLine(stdfData.Mean, Color.Blue, 2, LineStyle.DashDot, "mean");
                formsPlotHsitogram.Plot.AddVerticalLine(stdfData.Mean - stdfData.StDev * 3, Color.Gray, 2, LineStyle.Dot, "3σ");
                formsPlotHsitogram.Plot.AddVerticalLine(stdfData.Mean + stdfData.StDev * 3, Color.Gray, 2, LineStyle.Dot);

                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Min, Color.Gray, 1, LineStyle.Dash, "min/max");
                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Max, Color.Gray, 1, LineStyle.Dash);

                formsPlotHsitogram.Plot.Legend(location: Alignment.UpperRight);
                formsPlotHsitogram.Plot.SetAxisLimits(yMin: 0);
                formsPlotHsitogram.Refresh();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void UpdateMirTab()
        {
            dataGridViewInfo.Rows.Clear();
            foreach (var key in stdfData.MirData.Keys)
            {
                dataGridViewInfo.Rows.Add(key, stdfData.MirData[key]);
            }   
        }

        private void UpdateStatistics()
        {
            dataGridViewStats.Rows.Clear();
            dataGridViewStats.Rows.Add($"Site{stdfData.Site}",stdfData.TestNum,stdfData.TestName, stdfData.Unit, stdfData.LowLimt.ToString("f3"),
            stdfData.HighLimt.ToString("f3"),stdfData.Cpk.ToString("f3"), stdfData.Mean.ToString("f3"), stdfData.StDev.ToString("f3"), 
            stdfData.Min.ToString("f3"), stdfData.Max.ToString("f3"));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewTestItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedtestNumber = (uint)dataGridViewTestItems.SelectedCells[0].Value;
                UpdateChart();
                radioButtonUpdateChartEnabled = true;
            }
            catch
            {

            }

        }

        private void UpdateChart()
        {
            stdfData.UpdateResults(selectedSite,selectedtestNumber);
            UpdateStatistics();
            UpdateScatter();
            UpdateHistogram();
        }

        private void radioButtonSiteN_CheckedChanged(object sender, EventArgs e)
        {
            
            if (sender == radioButtonSite0)
            {
                selectedSite = 0;
            }
            else if (sender == radioButtonSite1)
            {
                selectedSite = 1;
            }
            else if (sender == radioButtonSite2)
            {
                selectedSite = 2;
            }
            else if (sender == radioButtonSite3)
            {
                selectedSite = 3;
            }
            if (radioButtonUpdateChartEnabled == true && ((RadioButton)sender).Checked == true)
            {
                UpdateChart();
            }
        }

        private void textBoxFilte_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                var results = stdfData.TestItems.Where(p => p.Key.ToString().Contains(textBoxFilter.Text) || p.Value.ToUpper().Contains(textBoxFilter.Text.ToUpper()));
                dataGridViewTestItems.Rows.Clear();
                foreach (var result in results)
                {
                    dataGridViewTestItems.Rows.Add(result.Key, result.Value);
                }
                selectedtestNumber = (uint)dataGridViewTestItems.SelectedCells[0].Value;
                UpdateChart();

            }
            catch { }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = new string[] {((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString() };
            OpenStdfFileStream(filePaths[0]);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;//重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }
    }
}
