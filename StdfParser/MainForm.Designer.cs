
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.TestNums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarFileOpen = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.labelFilte = new System.Windows.Forms.Label();
            this.formsPlotScatter = new ScottPlot.FormsPlot();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radioButtonSite3 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite0 = new System.Windows.Forms.RadioButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControlChart = new System.Windows.Forms.TabControl();
            this.tabPageScatter = new System.Windows.Forms.TabPage();
            this.tabPageHsitogram = new System.Windows.Forms.TabPage();
            this.formsPlotHsitogram = new ScottPlot.FormsPlot();
            this.labelStats = new System.Windows.Forms.Label();
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.SiteNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControlChart.SuspendLayout();
            this.tabPageScatter.SuspendLayout();
            this.tabPageHsitogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1264, 33);
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataGridViewTestItems
            // 
            this.dataGridViewTestItems.AllowUserToAddRows = false;
            this.dataGridViewTestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTestItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTestItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTestItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTestItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewTestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestNums,
            this.TestNames});
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
            this.dataGridViewTestItems.Size = new System.Drawing.Size(348, 554);
            this.dataGridViewTestItems.TabIndex = 1;
            this.dataGridViewTestItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTestItems_CellMouseClick);
            // 
            // TestNums
            // 
            this.TestNums.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TestNums.HeaderText = "TestNums";
            this.TestNums.Name = "TestNums";
            this.TestNums.ReadOnly = true;
            this.TestNums.Width = 111;
            // 
            // TestNames
            // 
            this.TestNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TestNames.HeaderText = "TestNames";
            this.TestNames.Name = "TestNames";
            this.TestNames.ReadOnly = true;
            this.TestNames.Width = 119;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarFileOpen,
            this.toolStripStatusFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1264, 34);
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
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFilter.Location = new System.Drawing.Point(77, 54);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(194, 29);
            this.textBoxFilter.TabIndex = 3;
            this.textBoxFilter.Tag = "";
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilte_TextChanged);
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
            this.formsPlotScatter.Size = new System.Drawing.Size(894, 494);
            this.formsPlotScatter.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer1.Size = new System.Drawing.Size(1264, 662);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer2.Panel1.Controls.Add(this.textBoxFilter);
            this.splitContainer2.Panel1.Controls.Add(this.labelFilte);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewTestItems);
            this.splitContainer2.Size = new System.Drawing.Size(348, 660);
            this.splitContainer2.SplitterDistance = 102;
            this.splitContainer2.TabIndex = 5;
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
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControlChart);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.labelStats);
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewStats);
            this.splitContainer3.Size = new System.Drawing.Size(908, 660);
            this.splitContainer3.SplitterDistance = 534;
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
            this.tabControlChart.Size = new System.Drawing.Size(908, 534);
            this.tabControlChart.TabIndex = 6;
            // 
            // tabPageScatter
            // 
            this.tabPageScatter.Controls.Add(this.formsPlotScatter);
            this.tabPageScatter.Location = new System.Drawing.Point(4, 30);
            this.tabPageScatter.Name = "tabPageScatter";
            this.tabPageScatter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScatter.Size = new System.Drawing.Size(900, 500);
            this.tabPageScatter.TabIndex = 0;
            this.tabPageScatter.Text = "Scatter";
            this.tabPageScatter.UseVisualStyleBackColor = true;
            // 
            // tabPageHsitogram
            // 
            this.tabPageHsitogram.Controls.Add(this.formsPlotHsitogram);
            this.tabPageHsitogram.Location = new System.Drawing.Point(4, 30);
            this.tabPageHsitogram.Name = "tabPageHsitogram";
            this.tabPageHsitogram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHsitogram.Size = new System.Drawing.Size(900, 500);
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
            this.formsPlotHsitogram.Size = new System.Drawing.Size(894, 494);
            this.formsPlotHsitogram.TabIndex = 0;
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.BackColor = System.Drawing.Color.White;
            this.labelStats.Location = new System.Drawing.Point(414, 75);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(76, 21);
            this.labelStats.TabIndex = 2;
            this.labelStats.Text = "Statistics";
            // 
            // dataGridViewStats
            // 
            this.dataGridViewStats.AllowUserToAddRows = false;
            this.dataGridViewStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStats.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiteNum,
            this.TestNum,
            this.TestName,
            this.Unit,
            this.LowLimit,
            this.HighLimit,
            this.Mean,
            this.StdDev,
            this.Min,
            this.Max});
            this.dataGridViewStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStats.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStats.Name = "dataGridViewStats";
            this.dataGridViewStats.RowHeadersVisible = false;
            this.dataGridViewStats.RowTemplate.Height = 23;
            this.dataGridViewStats.Size = new System.Drawing.Size(908, 122);
            this.dataGridViewStats.TabIndex = 1;
            this.dataGridViewStats.Tag = "";
            // 
            // SiteNum
            // 
            this.SiteNum.HeaderText = "SiteNum";
            this.SiteNum.Name = "SiteNum";
            this.SiteNum.Width = 101;
            // 
            // TestNum
            // 
            this.TestNum.HeaderText = "TestNum";
            this.TestNum.Name = "TestNum";
            this.TestNum.Width = 104;
            // 
            // TestName
            // 
            this.TestName.HeaderText = "TestName";
            this.TestName.Name = "TestName";
            this.TestName.Width = 112;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 67;
            // 
            // LowLimit
            // 
            this.LowLimit.HeaderText = "LowLimit";
            this.LowLimit.Name = "LowLimit";
            this.LowLimit.Width = 103;
            // 
            // HighLimit
            // 
            this.HighLimit.HeaderText = "HighLimit";
            this.HighLimit.Name = "HighLimit";
            this.HighLimit.Width = 108;
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.Name = "Mean";
            this.Mean.Width = 79;
            // 
            // StdDev
            // 
            this.StdDev.HeaderText = "StdDev";
            this.StdDev.Name = "StdDev";
            this.StdDev.Width = 89;
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            this.Min.Width = 65;
            // 
            // Max
            // 
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
            this.Max.Width = 68;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "StdfParser";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
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
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControlChart.ResumeLayout(false);
            this.tabPageScatter.ResumeLayout(false);
            this.tabPageHsitogram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label labelFilte;
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
        private System.Windows.Forms.DataGridView dataGridViewStats;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNums;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
    }
}

