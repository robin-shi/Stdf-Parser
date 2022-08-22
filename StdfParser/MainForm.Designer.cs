
namespace StdfParser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTestItems = new System.Windows.Forms.DataGridView();
            this.TestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarFileOpen = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFilte = new System.Windows.Forms.TextBox();
            this.labelFilte = new System.Windows.Forms.Label();
            this.formsPlotScatter = new ScottPlot.FormsPlot();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControlChart = new System.Windows.Forms.TabControl();
            this.tabPageScatter = new System.Windows.Forms.TabPage();
            this.tabPageHsitogram = new System.Windows.Forms.TabPage();
            this.formsPlotHsitogram = new ScottPlot.FormsPlot();
            this.radioButtonSite0 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite3 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControlChart.SuspendLayout();
            this.tabPageScatter.SuspendLayout();
            this.tabPageHsitogram.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1101, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 25);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenStdfFileDialog);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
            this.toolStripMenuItem3.Text = "Export to Csv";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuItem2.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.aboutToolStripMenuItem.Text = "About StdfParser";
            // 
            // dataGridViewTestItems
            // 
            this.dataGridViewTestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTestItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTestItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTestItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTestItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewTestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestNum,
            this.TestItem});
            this.dataGridViewTestItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTestItems.GridColor = System.Drawing.Color.White;
            this.dataGridViewTestItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTestItems.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewTestItems.MultiSelect = false;
            this.dataGridViewTestItems.Name = "dataGridViewTestItems";
            this.dataGridViewTestItems.ReadOnly = true;
            this.dataGridViewTestItems.RowHeadersVisible = false;
            this.dataGridViewTestItems.RowHeadersWidth = 200;
            this.dataGridViewTestItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTestItems.RowTemplate.Height = 23;
            this.dataGridViewTestItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTestItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTestItems.Size = new System.Drawing.Size(365, 550);
            this.dataGridViewTestItems.TabIndex = 1;
            this.dataGridViewTestItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTestItems_CellMouseClick);
            // 
            // TestNum
            // 
            this.TestNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TestNum.HeaderText = "TestNum";
            this.TestNum.Name = "TestNum";
            this.TestNum.ReadOnly = true;
            this.TestNum.Width = 104;
            // 
            // TestItem
            // 
            this.TestItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TestItem.HeaderText = "TestItem";
            this.TestItem.Name = "TestItem";
            this.TestItem.ReadOnly = true;
            this.TestItem.Width = 101;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarFileOpen,
            this.toolStripStatusFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 691);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1101, 34);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBarFileOpen
            // 
            this.toolStripProgressBarFileOpen.Name = "toolStripProgressBarFileOpen";
            this.toolStripProgressBarFileOpen.Size = new System.Drawing.Size(167, 28);
            this.toolStripProgressBarFileOpen.Step = 100;
            this.toolStripProgressBarFileOpen.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusFileName
            // 
            this.toolStripStatusFileName.Name = "toolStripStatusFileName";
            this.toolStripStatusFileName.Size = new System.Drawing.Size(0, 29);
            // 
            // textBoxFilte
            // 
            this.textBoxFilte.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFilte.Location = new System.Drawing.Point(77, 54);
            this.textBoxFilte.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFilte.Name = "textBoxFilte";
            this.textBoxFilte.Size = new System.Drawing.Size(194, 29);
            this.textBoxFilte.TabIndex = 3;
            this.textBoxFilte.Tag = "";
            // 
            // labelFilte
            // 
            this.labelFilte.AutoSize = true;
            this.labelFilte.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFilte.Location = new System.Drawing.Point(21, 57);
            this.labelFilte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFilte.Name = "labelFilte";
            this.labelFilte.Size = new System.Drawing.Size(52, 21);
            this.labelFilte.TabIndex = 4;
            this.labelFilte.Text = "Filter:";
            // 
            // formsPlotScatter
            // 
            this.formsPlotScatter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotScatter.Location = new System.Drawing.Point(3, 3);
            this.formsPlotScatter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formsPlotScatter.Name = "formsPlotScatter";
            this.formsPlotScatter.Size = new System.Drawing.Size(714, 430);
            this.formsPlotScatter.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 658);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonSite3);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonSite2);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonSite1);
            this.splitContainer2.Panel1.Controls.Add(this.radioButtonSite0);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxFilte);
            this.splitContainer2.Panel1.Controls.Add(this.labelFilte);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewTestItems);
            this.splitContainer2.Size = new System.Drawing.Size(365, 656);
            this.splitContainer2.SplitterDistance = 102;
            this.splitContainer2.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControlChart);
            this.splitContainer3.Size = new System.Drawing.Size(728, 656);
            this.splitContainer3.SplitterDistance = 470;
            this.splitContainer3.TabIndex = 7;
            // 
            // tabControlChart
            // 
            this.tabControlChart.Controls.Add(this.tabPageScatter);
            this.tabControlChart.Controls.Add(this.tabPageHsitogram);
            this.tabControlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChart.Location = new System.Drawing.Point(0, 0);
            this.tabControlChart.Name = "tabControlChart";
            this.tabControlChart.SelectedIndex = 0;
            this.tabControlChart.Size = new System.Drawing.Size(728, 470);
            this.tabControlChart.TabIndex = 6;
            // 
            // tabPageScatter
            // 
            this.tabPageScatter.Controls.Add(this.formsPlotScatter);
            this.tabPageScatter.Location = new System.Drawing.Point(4, 30);
            this.tabPageScatter.Name = "tabPageScatter";
            this.tabPageScatter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScatter.Size = new System.Drawing.Size(720, 436);
            this.tabPageScatter.TabIndex = 0;
            this.tabPageScatter.Text = "Scatter";
            this.tabPageScatter.UseVisualStyleBackColor = true;
            // 
            // tabPageHsitogram
            // 
            this.tabPageHsitogram.Controls.Add(this.formsPlotHsitogram);
            this.tabPageHsitogram.Location = new System.Drawing.Point(4, 22);
            this.tabPageHsitogram.Name = "tabPageHsitogram";
            this.tabPageHsitogram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHsitogram.Size = new System.Drawing.Size(720, 444);
            this.tabPageHsitogram.TabIndex = 1;
            this.tabPageHsitogram.Text = "Histogram";
            this.tabPageHsitogram.UseVisualStyleBackColor = true;
            // 
            // formsPlotHsitogram
            // 
            this.formsPlotHsitogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotHsitogram.Location = new System.Drawing.Point(3, 3);
            this.formsPlotHsitogram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formsPlotHsitogram.Name = "formsPlotHsitogram";
            this.formsPlotHsitogram.Size = new System.Drawing.Size(714, 438);
            this.formsPlotHsitogram.TabIndex = 0;
            // 
            // radioButtonSite0
            // 
            this.radioButtonSite0.AutoSize = true;
            this.radioButtonSite0.Location = new System.Drawing.Point(43, 21);
            this.radioButtonSite0.Name = "radioButtonSite0";
            this.radioButtonSite0.Size = new System.Drawing.Size(65, 25);
            this.radioButtonSite0.TabIndex = 0;
            this.radioButtonSite0.TabStop = true;
            this.radioButtonSite0.Text = "Site0";
            this.radioButtonSite0.UseVisualStyleBackColor = true;
            this.radioButtonSite0.CheckedChanged += new System.EventHandler(this.radioButtonSiteN_CheckedChanged);
            // 
            // radioButtonSite1
            // 
            this.radioButtonSite1.AutoSize = true;
            this.radioButtonSite1.Location = new System.Drawing.Point(114, 21);
            this.radioButtonSite1.Name = "radioButtonSite1";
            this.radioButtonSite1.Size = new System.Drawing.Size(65, 25);
            this.radioButtonSite1.TabIndex = 0;
            this.radioButtonSite1.TabStop = true;
            this.radioButtonSite1.Text = "Site1";
            this.radioButtonSite1.UseVisualStyleBackColor = true;
            this.radioButtonSite1.CheckedChanged += new System.EventHandler(this.radioButtonSiteN_CheckedChanged);
            // 
            // radioButtonSite2
            // 
            this.radioButtonSite2.AutoSize = true;
            this.radioButtonSite2.Location = new System.Drawing.Point(185, 21);
            this.radioButtonSite2.Name = "radioButtonSite2";
            this.radioButtonSite2.Size = new System.Drawing.Size(65, 25);
            this.radioButtonSite2.TabIndex = 0;
            this.radioButtonSite2.TabStop = true;
            this.radioButtonSite2.Text = "Site2";
            this.radioButtonSite2.UseVisualStyleBackColor = true;
            this.radioButtonSite2.CheckedChanged += new System.EventHandler(this.radioButtonSiteN_CheckedChanged);
            // 
            // radioButtonSite3
            // 
            this.radioButtonSite3.AutoSize = true;
            this.radioButtonSite3.Location = new System.Drawing.Point(256, 21);
            this.radioButtonSite3.Name = "radioButtonSite3";
            this.radioButtonSite3.Size = new System.Drawing.Size(65, 25);
            this.radioButtonSite3.TabIndex = 0;
            this.radioButtonSite3.TabStop = true;
            this.radioButtonSite3.Text = "Site3";
            this.radioButtonSite3.UseVisualStyleBackColor = true;
            this.radioButtonSite3.CheckedChanged += new System.EventHandler(this.radioButtonSiteN_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 725);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "StdfParser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestItems)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControlChart.ResumeLayout(false);
            this.tabPageScatter.ResumeLayout(false);
            this.tabPageHsitogram.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTestItems;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFileName;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarFileOpen;
        private System.Windows.Forms.TextBox textBoxFilte;
        private System.Windows.Forms.Label labelFilte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestItem;
        private ScottPlot.FormsPlot formsPlotScatter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControlChart;
        private System.Windows.Forms.TabPage tabPageScatter;
        private System.Windows.Forms.TabPage tabPageHsitogram;
        private ScottPlot.FormsPlot formsPlotHsitogram;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.RadioButton radioButtonSite3;
        private System.Windows.Forms.RadioButton radioButtonSite2;
        private System.Windows.Forms.RadioButton radioButtonSite1;
        private System.Windows.Forms.RadioButton radioButtonSite0;
    }
}

