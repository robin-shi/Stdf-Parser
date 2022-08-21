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

namespace StdfParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            toolStripProgressBarFileOpen.Value = 0;
        }
        private void ClearTestItems()
        {
            dataGridViewTestItems.Rows.Clear();
            toolStripProgressBarFileOpen.Value = 0;
            toolStripStatusFileName.Text = "";

        }

        private void CreatPlot(double[] dataX,double[] dataY)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatterPoints(dataX,dataY);
            formsPlot1.Refresh();
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
            CreatPlot(dataX,dataY);

        }
    }
}
