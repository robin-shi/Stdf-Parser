﻿
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.scatterShowLimitLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTestItems = new System.Windows.Forms.DataGridView();
            this.TestNums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.labelFilte = new System.Windows.Forms.Label();
            this.formsPlotScatter = new ScottPlot.FormsPlot();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxHead = new System.Windows.Forms.GroupBox();
            this.radioButtonHead3 = new System.Windows.Forms.RadioButton();
            this.radioButtonHead1 = new System.Windows.Forms.RadioButton();
            this.radioButtonHead2 = new System.Windows.Forms.RadioButton();
            this.radioButtonHead0 = new System.Windows.Forms.RadioButton();
            this.groupBoxSite = new System.Windows.Forms.GroupBox();
            this.radioButtonSite3 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite2 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite1 = new System.Windows.Forms.RadioButton();
            this.radioButtonSite0 = new System.Windows.Forms.RadioButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControlChart = new System.Windows.Forms.TabControl();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.tabPageScatter = new System.Windows.Forms.TabPage();
            this.tabPageHsitogram = new System.Windows.Forms.TabPage();
            this.formsPlotHsitogram = new ScottPlot.FormsPlot();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewStats = new System.Windows.Forms.DataGridView();
            this.Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpk = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBoxHead.SuspendLayout();
            this.groupBoxSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControlChart.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.tabPageScatter.SuspendLayout();
            this.tabPageHsitogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStats)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1223, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.ExportDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 21);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // ExportDataToolStripMenuItem
            // 
            this.ExportDataToolStripMenuItem.Name = "ExportDataToolStripMenuItem";
            this.ExportDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExportDataToolStripMenuItem.Text = "Export Data..";
            this.ExportDataToolStripMenuItem.Click += new System.EventHandler(this.ExportDatatoolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scatterShowLimitLinesToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(47, 21);
            this.toolStripMenuItem4.Text = "View";
            // 
            // scatterShowLimitLinesToolStripMenuItem
            // 
            this.scatterShowLimitLinesToolStripMenuItem.Enabled = false;
            this.scatterShowLimitLinesToolStripMenuItem.Name = "scatterShowLimitLinesToolStripMenuItem";
            this.scatterShowLimitLinesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.scatterShowLimitLinesToolStripMenuItem.Text = "Scatter Show Limit Lines";
            this.scatterShowLimitLinesToolStripMenuItem.Click += new System.EventHandler(this.scatterShowLimitLinesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem2.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
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
            this.dataGridViewTestItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewTestItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewTestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestNums,
            this.TestNames});
            this.dataGridViewTestItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTestItems.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewTestItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTestItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewTestItems.MultiSelect = false;
            this.dataGridViewTestItems.Name = "dataGridViewTestItems";
            this.dataGridViewTestItems.ReadOnly = true;
            this.dataGridViewTestItems.RowHeadersVisible = false;
            this.dataGridViewTestItems.RowHeadersWidth = 200;
            this.dataGridViewTestItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTestItems.RowTemplate.Height = 23;
            this.dataGridViewTestItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTestItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTestItems.Size = new System.Drawing.Size(308, 508);
            this.dataGridViewTestItems.TabIndex = 1;
            this.dataGridViewTestItems.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTestItems_CellEnter);
            // 
            // TestNums
            // 
            this.TestNums.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TestNums.HeaderText = "Test Nums";
            this.TestNums.Name = "TestNums";
            this.TestNums.ReadOnly = true;
            this.TestNums.Width = 95;
            // 
            // TestNames
            // 
            this.TestNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestNames.HeaderText = "Test Names";
            this.TestNames.Name = "TestNames";
            this.TestNames.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 686);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1223, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusFileName
            // 
            this.toolStripStatusFileName.Name = "toolStripStatusFileName";
            this.toolStripStatusFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFilter.Location = new System.Drawing.Point(55, 118);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(241, 23);
            this.textBoxFilter.TabIndex = 3;
            this.textBoxFilter.Tag = "";
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilte_TextChanged);
            // 
            // labelFilte
            // 
            this.labelFilte.AutoSize = true;
            this.labelFilte.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFilte.Location = new System.Drawing.Point(12, 121);
            this.labelFilte.Name = "labelFilte";
            this.labelFilte.Size = new System.Drawing.Size(39, 17);
            this.labelFilte.TabIndex = 4;
            this.labelFilte.Text = "Filter:";
            // 
            // formsPlotScatter
            // 
            this.formsPlotScatter.BackColor = System.Drawing.Color.White;
            this.formsPlotScatter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotScatter.Location = new System.Drawing.Point(2, 2);
            this.formsPlotScatter.Margin = new System.Windows.Forms.Padding(2);
            this.formsPlotScatter.Name = "formsPlotScatter";
            this.formsPlotScatter.Size = new System.Drawing.Size(896, 523);
            this.formsPlotScatter.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1223, 659);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxHead);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxSite);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxFilter);
            this.splitContainer2.Panel1.Controls.Add(this.labelFilte);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewTestItems);
            this.splitContainer2.Size = new System.Drawing.Size(308, 657);
            this.splitContainer2.SplitterDistance = 146;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 5;
            // 
            // groupBoxHead
            // 
            this.groupBoxHead.Controls.Add(this.radioButtonHead3);
            this.groupBoxHead.Controls.Add(this.radioButtonHead1);
            this.groupBoxHead.Controls.Add(this.radioButtonHead2);
            this.groupBoxHead.Controls.Add(this.radioButtonHead0);
            this.groupBoxHead.Location = new System.Drawing.Point(12, 6);
            this.groupBoxHead.Name = "groupBoxHead";
            this.groupBoxHead.Size = new System.Drawing.Size(284, 51);
            this.groupBoxHead.TabIndex = 5;
            this.groupBoxHead.TabStop = false;
            this.groupBoxHead.Text = "Head Selection";
            // 
            // radioButtonHead3
            // 
            this.radioButtonHead3.AutoSize = true;
            this.radioButtonHead3.Location = new System.Drawing.Point(209, 21);
            this.radioButtonHead3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHead3.Name = "radioButtonHead3";
            this.radioButtonHead3.Size = new System.Drawing.Size(64, 21);
            this.radioButtonHead3.TabIndex = 0;
            this.radioButtonHead3.TabStop = true;
            this.radioButtonHead3.Text = "Head3";
            this.radioButtonHead3.UseVisualStyleBackColor = true;
            this.radioButtonHead3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonHead1
            // 
            this.radioButtonHead1.AutoSize = true;
            this.radioButtonHead1.Location = new System.Drawing.Point(73, 21);
            this.radioButtonHead1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHead1.Name = "radioButtonHead1";
            this.radioButtonHead1.Size = new System.Drawing.Size(64, 21);
            this.radioButtonHead1.TabIndex = 0;
            this.radioButtonHead1.TabStop = true;
            this.radioButtonHead1.Text = "Head1";
            this.radioButtonHead1.UseVisualStyleBackColor = true;
            this.radioButtonHead1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonHead2
            // 
            this.radioButtonHead2.AutoSize = true;
            this.radioButtonHead2.Location = new System.Drawing.Point(141, 21);
            this.radioButtonHead2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHead2.Name = "radioButtonHead2";
            this.radioButtonHead2.Size = new System.Drawing.Size(64, 21);
            this.radioButtonHead2.TabIndex = 0;
            this.radioButtonHead2.TabStop = true;
            this.radioButtonHead2.Text = "Head2";
            this.radioButtonHead2.UseVisualStyleBackColor = true;
            this.radioButtonHead2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonHead0
            // 
            this.radioButtonHead0.AutoSize = true;
            this.radioButtonHead0.Location = new System.Drawing.Point(5, 21);
            this.radioButtonHead0.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHead0.Name = "radioButtonHead0";
            this.radioButtonHead0.Size = new System.Drawing.Size(64, 21);
            this.radioButtonHead0.TabIndex = 0;
            this.radioButtonHead0.TabStop = true;
            this.radioButtonHead0.Text = "Head0";
            this.radioButtonHead0.UseVisualStyleBackColor = true;
            this.radioButtonHead0.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxSite
            // 
            this.groupBoxSite.Controls.Add(this.radioButtonSite3);
            this.groupBoxSite.Controls.Add(this.radioButtonSite2);
            this.groupBoxSite.Controls.Add(this.radioButtonSite1);
            this.groupBoxSite.Controls.Add(this.radioButtonSite0);
            this.groupBoxSite.Location = new System.Drawing.Point(12, 63);
            this.groupBoxSite.Name = "groupBoxSite";
            this.groupBoxSite.Size = new System.Drawing.Size(284, 51);
            this.groupBoxSite.TabIndex = 5;
            this.groupBoxSite.TabStop = false;
            this.groupBoxSite.Text = "Site Selection";
            // 
            // radioButtonSite3
            // 
            this.radioButtonSite3.AutoSize = true;
            this.radioButtonSite3.Location = new System.Drawing.Point(178, 21);
            this.radioButtonSite3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSite3.Name = "radioButtonSite3";
            this.radioButtonSite3.Size = new System.Drawing.Size(54, 21);
            this.radioButtonSite3.TabIndex = 0;
            this.radioButtonSite3.TabStop = true;
            this.radioButtonSite3.Text = "Site3";
            this.radioButtonSite3.UseVisualStyleBackColor = true;
            this.radioButtonSite3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSite2
            // 
            this.radioButtonSite2.AutoSize = true;
            this.radioButtonSite2.Location = new System.Drawing.Point(120, 21);
            this.radioButtonSite2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSite2.Name = "radioButtonSite2";
            this.radioButtonSite2.Size = new System.Drawing.Size(54, 21);
            this.radioButtonSite2.TabIndex = 0;
            this.radioButtonSite2.TabStop = true;
            this.radioButtonSite2.Text = "Site2";
            this.radioButtonSite2.UseVisualStyleBackColor = true;
            this.radioButtonSite2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSite1
            // 
            this.radioButtonSite1.AutoSize = true;
            this.radioButtonSite1.Location = new System.Drawing.Point(62, 21);
            this.radioButtonSite1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSite1.Name = "radioButtonSite1";
            this.radioButtonSite1.Size = new System.Drawing.Size(54, 21);
            this.radioButtonSite1.TabIndex = 0;
            this.radioButtonSite1.TabStop = true;
            this.radioButtonSite1.Text = "Site1";
            this.radioButtonSite1.UseVisualStyleBackColor = true;
            this.radioButtonSite1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSite0
            // 
            this.radioButtonSite0.AutoSize = true;
            this.radioButtonSite0.Location = new System.Drawing.Point(4, 21);
            this.radioButtonSite0.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSite0.Name = "radioButtonSite0";
            this.radioButtonSite0.Size = new System.Drawing.Size(54, 21);
            this.radioButtonSite0.TabIndex = 0;
            this.radioButtonSite0.TabStop = true;
            this.radioButtonSite0.Text = "Site0";
            this.radioButtonSite0.UseVisualStyleBackColor = true;
            this.radioButtonSite0.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControlChart);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewStats);
            this.splitContainer3.Size = new System.Drawing.Size(908, 657);
            this.splitContainer3.SplitterDistance = 555;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 7;
            // 
            // tabControlChart
            // 
            this.tabControlChart.Controls.Add(this.tabPageSummary);
            this.tabControlChart.Controls.Add(this.tabPageScatter);
            this.tabControlChart.Controls.Add(this.tabPageHsitogram);
            this.tabControlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChart.ImageList = this.imageListIcon;
            this.tabControlChart.Location = new System.Drawing.Point(0, 0);
            this.tabControlChart.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlChart.Name = "tabControlChart";
            this.tabControlChart.SelectedIndex = 0;
            this.tabControlChart.Size = new System.Drawing.Size(908, 555);
            this.tabControlChart.TabIndex = 6;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.textBoxSummary);
            this.tabPageSummary.ImageIndex = 0;
            this.tabPageSummary.Location = new System.Drawing.Point(4, 26);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Size = new System.Drawing.Size(900, 525);
            this.tabPageSummary.TabIndex = 2;
            this.tabPageSummary.Text = "Summary";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.BackColor = System.Drawing.Color.White;
            this.textBoxSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSummary.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxSummary.Location = new System.Drawing.Point(0, 0);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.ReadOnly = true;
            this.textBoxSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSummary.Size = new System.Drawing.Size(900, 525);
            this.textBoxSummary.TabIndex = 1;
            // 
            // tabPageScatter
            // 
            this.tabPageScatter.Controls.Add(this.formsPlotScatter);
            this.tabPageScatter.ImageIndex = 1;
            this.tabPageScatter.Location = new System.Drawing.Point(4, 23);
            this.tabPageScatter.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageScatter.Name = "tabPageScatter";
            this.tabPageScatter.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageScatter.Size = new System.Drawing.Size(900, 527);
            this.tabPageScatter.TabIndex = 0;
            this.tabPageScatter.Text = "Scatter";
            this.tabPageScatter.UseVisualStyleBackColor = true;
            // 
            // tabPageHsitogram
            // 
            this.tabPageHsitogram.Controls.Add(this.formsPlotHsitogram);
            this.tabPageHsitogram.ImageIndex = 2;
            this.tabPageHsitogram.Location = new System.Drawing.Point(4, 23);
            this.tabPageHsitogram.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHsitogram.Name = "tabPageHsitogram";
            this.tabPageHsitogram.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHsitogram.Size = new System.Drawing.Size(900, 527);
            this.tabPageHsitogram.TabIndex = 1;
            this.tabPageHsitogram.Text = "Histogram";
            this.tabPageHsitogram.UseVisualStyleBackColor = true;
            // 
            // formsPlotHsitogram
            // 
            this.formsPlotHsitogram.BackColor = System.Drawing.Color.White;
            this.formsPlotHsitogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlotHsitogram.Location = new System.Drawing.Point(2, 2);
            this.formsPlotHsitogram.Margin = new System.Windows.Forms.Padding(2);
            this.formsPlotHsitogram.Name = "formsPlotHsitogram";
            this.formsPlotHsitogram.Size = new System.Drawing.Size(896, 523);
            this.formsPlotHsitogram.TabIndex = 0;
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "Summary.png");
            this.imageListIcon.Images.SetKeyName(1, "Scatter.png");
            this.imageListIcon.Images.SetKeyName(2, "Histogram.png");
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
            this.Head,
            this.Site,
            this.TestNum,
            this.TestName,
            this.Unit,
            this.LowLimit,
            this.HighLimit,
            this.Cpk,
            this.Mean,
            this.StdDev,
            this.Min,
            this.Max});
            this.dataGridViewStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStats.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStats.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStats.Name = "dataGridViewStats";
            this.dataGridViewStats.RowHeadersVisible = false;
            this.dataGridViewStats.RowTemplate.Height = 23;
            this.dataGridViewStats.Size = new System.Drawing.Size(908, 99);
            this.dataGridViewStats.TabIndex = 1;
            this.dataGridViewStats.Tag = "";
            // 
            // Head
            // 
            this.Head.HeaderText = "Head";
            this.Head.Name = "Head";
            this.Head.Width = 64;
            // 
            // Site
            // 
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            this.Site.Width = 54;
            // 
            // TestNum
            // 
            this.TestNum.HeaderText = "Test Num";
            this.TestNum.Name = "TestNum";
            this.TestNum.Width = 89;
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.Width = 96;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 56;
            // 
            // LowLimit
            // 
            this.LowLimit.HeaderText = "Low Limit";
            this.LowLimit.Name = "LowLimit";
            this.LowLimit.Width = 87;
            // 
            // HighLimit
            // 
            this.HighLimit.HeaderText = "High Limit";
            this.HighLimit.Name = "HighLimit";
            this.HighLimit.Width = 91;
            // 
            // Cpk
            // 
            this.Cpk.HeaderText = "Cpk";
            this.Cpk.Name = "Cpk";
            this.Cpk.Width = 56;
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.Name = "Mean";
            this.Mean.Width = 66;
            // 
            // StdDev
            // 
            this.StdDev.HeaderText = "StdDev";
            this.StdDev.Name = "StdDev";
            this.StdDev.Width = 74;
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            this.Min.Width = 55;
            // 
            // Max
            // 
            this.Max.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 708);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Stdf Parser";
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
            this.groupBoxHead.ResumeLayout(false);
            this.groupBoxHead.PerformLayout();
            this.groupBoxSite.ResumeLayout(false);
            this.groupBoxSite.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControlChart.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.tabPageSummary.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ExportDataToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonSite3;
        private System.Windows.Forms.RadioButton radioButtonSite2;
        private System.Windows.Forms.RadioButton radioButtonSite1;
        private System.Windows.Forms.RadioButton radioButtonSite0;
        private System.Windows.Forms.DataGridView dataGridViewStats;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNums;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNames;
        private System.Windows.Forms.GroupBox groupBoxSite;
        private System.Windows.Forms.GroupBox groupBoxHead;
        private System.Windows.Forms.RadioButton radioButtonHead1;
        private System.Windows.Forms.RadioButton radioButtonHead0;
        private System.Windows.Forms.RadioButton radioButtonHead3;
        private System.Windows.Forms.RadioButton radioButtonHead2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Head;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem scatterShowLimitLinesToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListIcon;
    }
}

