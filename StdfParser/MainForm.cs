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
        List<string> TestNames { get; set; }
        private void OpenStdfFileDialog(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog() {Filter="stdf|*.stdf;*.std",
            InitialDirectory=@"..\"};
            fileDialog.ShowDialog();
            try
            {
                stdfFile = new StdfFile(fileDialog.FileName);
                toolStripStatusFileName.Text = fileDialog.FileName;
                UpdateTestItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTestItems()
        {
            var results = stdfFile.GetRecords().OfExactType<Tsr>().Select(p=>p.TestName);
            toolStripProgressBarFileOpen.Maximum = results.Count();
            toolStripProgressBarFileOpen.Value = 0;
            foreach (var result in results)
            {
                //TestNames.Add(result);
                dataGridViewTestItems.Rows.Add(result);
                toolStripProgressBarFileOpen.Value++;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
