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
        }

        StdfFile stdfFile { get; set; }
        Dictionary<uint,string> TestItems { get; set; }

        private void OpenStdfFileDialog(object sender, EventArgs e)
        {
            ClearTestItems();
            OpenFileDialog fileDialog = new OpenFileDialog() {Filter="stdf|*.stdf;*.std",
            InitialDirectory=@"..\"};
            fileDialog.ShowDialog();
            try
            {
                stdfFile = new StdfFile(fileDialog.FileName);
                toolStripStatusFileName.Text = fileDialog.FileName;
                TestItems = new Dictionary<uint, string> { };
                UpdateTestItems();
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
                    TestItems.Add(result.TestNumber, result.TestName);
                }
                catch { }
            }
            foreach (var item in TestItems)
            {
                dataGridViewTestItems.Rows.Add(item.Key,item.Value);
            }
            dataGridViewTestItems.ColumnHeadersVisible = true;
            toolStripProgressBarFileOpen.Value = 0;
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
                MessageBox.Show(ex.Message);
            }
        }
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewTestItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            uint testNumberSelected =(uint)dataGridViewTestItems.SelectedCells[0].Value;
            var values = stdfFile.GetRecords().OfExactType<Ptr>().Where(p => p.TestNumber == testNumberSelected && p.SiteNumber==0).Select(p => p.Result);
            double[] dataY = new double[values.Count()];
            double[] dataX = new double[values.Count()];
            int i = 0;
            foreach (var value in values)
            {
                dataY[i] = (double)value;
                dataX[i] = i;
                i++;
            }
            UpdateScatter(dataX,dataY);
            UpdateHistogram(dataY);

        }
    }
}
