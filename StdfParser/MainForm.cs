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
            dataGridViewTestItems.ColumnHeadersVisible = false;
            DisVisiableRadioButton();
        }

        StdfFile stdfFile { get; set; }
        Dictionary<uint,string> testItems { get; set; }

        byte[] siteNums { get; set; }
        byte selectedSite { get; set; }
        uint selectedtestNumber { get; set; }
        bool radioButtonUpdateChartEnabled { get; set; }
        private void OpenStdfFileDialog(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog() {Filter="stdf|*.stdf;*.std",
            InitialDirectory=@"..\"};
            fileDialog.ShowDialog();
            try
            {
                if (fileDialog.FileName!="")
                {
                    ClearTestItems();
                    DisVisiableRadioButton();
                    formsPlotScatter.Plot.Clear();
                    formsPlotHsitogram.Plot.Clear();
                    stdfFile = new StdfFile(fileDialog.FileName);
                    toolStripStatusFileName.Text = fileDialog.FileName;
                    testItems = new Dictionary<uint, string> { };
                    UpdateTestItems();
                    radioButtonUpdateChartEnabled = false;
                    UpdateRadioButton();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTestItems()
        {
            var results = stdfFile.GetRecords().OfExactType<Tsr>();
            
            toolStripProgressBarFileOpen.Maximum = results.Count();
            foreach (var result in results)
            {
                try
                {
                    toolStripProgressBarFileOpen.Value++;
                    testItems.Add(result.TestNumber, result.TestName);
                }
                catch { }
            }
            foreach (var item in testItems)
            {
                dataGridViewTestItems.Rows.Add(item.Key,item.Value);
            }
            dataGridViewTestItems.ColumnHeadersVisible = true;
            toolStripProgressBarFileOpen.Value = 0;
        }

        private void UpdateRadioButton()
        {
            var results = stdfFile.GetRecords().OfExactType<Sdr>();
            foreach (var result in results)
            {
                siteNums = result.SiteNumbers;
            }
            foreach (var siteNum in siteNums)
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
        private void ClearTestItems()
        {
            dataGridViewTestItems.Rows.Clear();
            toolStripProgressBarFileOpen.Value = 0;
            toolStripStatusFileName.Text = "";

        }

        private void UpdateScatter(double[] dataX,double[] dataY)
        {
            formsPlotScatter.Plot.Clear();
            formsPlotScatter.Plot.AddScatterPoints(dataX,dataY);
            formsPlotScatter.Refresh();
        }

        private void UpdateHistogram(double[] dataY)
        {
            try
            {
                formsPlotHsitogram.Plot.Clear();
                formsPlotHsitogram.Refresh();
                var stats = new ScottPlot.Statistics.BasicStats(dataY);
                double maxValue =stats.Mean+(dataY.Max()-dataY.Min());
                double minValue =stats.Mean - (dataY.Max()-dataY.Min());
                double binWidth = (maxValue - minValue) / 50;
                (double[] counts, double[] binEdges) = ScottPlot.Statistics.Common.Histogram(dataY, min: minValue, max: maxValue, binSize: binWidth);
                double[] leftEdges = binEdges.Take(binEdges.Length - 1).ToArray();
                var bar = formsPlotHsitogram.Plot.AddBar(values: counts, positions: leftEdges);
                bar.FillColor = ColorTranslator.FromHtml("#9bc3eb");
                bar.BorderLineWidth = 1f;
                bar.BarWidth = binWidth;
                double[] smoothEdges = ScottPlot.DataGen.Range(start: binEdges.First(), stop: binEdges.Last(), step: binWidth/2, includeStop: true);
                double[] smoothDensities = ScottPlot.Statistics.Common.ProbabilityDensity(dataY, smoothEdges, percent: true);
                var probPlot = formsPlotHsitogram.Plot.AddScatterLines(
                    xs: smoothEdges,
                    ys: smoothDensities,
                    lineWidth: 2,
                    lineStyle: LineStyle.Dot,
                    color: Color.Red,
                    label: "probability") ;
                probPlot.YAxisIndex = 1;
                formsPlotHsitogram.Plot.YAxis2.Ticks(true);

                formsPlotHsitogram.Plot.AddVerticalLine(stats.Mean, Color.Blue, 2, LineStyle.DashDot, "mean");

                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Mean - stats.StDev, Color.Gray, 2, LineStyle.Dot, "1σ");
                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Mean + stats.StDev, Color.Gray, 2, LineStyle.Dot);

                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Mean - stats.StDev * 2, Color.Gray, 2, LineStyle.Dot, "2σ");
                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Mean + stats.StDev * 2, Color.Gray, 2, LineStyle.Dot);

                formsPlotHsitogram.Plot.AddVerticalLine(stats.Mean - stats.StDev * 3, Color.Gray, 2, LineStyle.Dot, "3σ");
                formsPlotHsitogram.Plot.AddVerticalLine(stats.Mean + stats.StDev * 3, Color.Gray, 2, LineStyle.Dot);

                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Min, Color.Gray, 1, LineStyle.Dash, "min/max");
                //formsPlotHsitogram.Plot.AddVerticalLine(stats.Max, Color.Gray, 1, LineStyle.Dash);

                formsPlotHsitogram.Plot.Legend(location: Alignment.UpperRight);
                formsPlotHsitogram.Plot.YAxis.Label("Count (#)");
                formsPlotHsitogram.Plot.XAxis.Label("Value");
                formsPlotHsitogram.Plot.SetAxisLimits(yMin: 0);
                formsPlotHsitogram.Refresh();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
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
            var values = stdfFile.GetRecords().OfExactType<Ptr>().Where(p => p.TestNumber == selectedtestNumber && p.SiteNumber == selectedSite).Select(p => p.Result);
            double[] dataY = new double[values.Count()];
            double[] dataX = new double[values.Count()];
            int i = 0;
            foreach (var value in values)
            {
                dataY[i] = (double)value;
                dataX[i] = i;
                i++;
            }
            UpdateScatter(dataX, dataY);
            UpdateHistogram(dataY);
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
            if (radioButtonUpdateChartEnabled == true)
            {
                UpdateChart();
            }
        }

        private void textBoxFilte_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                var results = testItems.Where(p => p.Key.ToString().Contains(textBoxFilter.Text) || p.Value.ToUpper().Contains(textBoxFilter.Text.ToUpper()));
                dataGridViewTestItems.Rows.Clear();
                foreach (var result in results)
                {
                    dataGridViewTestItems.Rows.Add(result.Key, result.Value);
                }
            }
            catch { }
        }
    }
}
