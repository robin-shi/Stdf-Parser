
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTestItems = new System.Windows.Forms.DataGridView();
            this.TestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarFileOpen = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxFilte = new System.Windows.Forms.TextBox();
            this.labelFilte = new System.Windows.Forms.Label();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
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
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 25);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenStdfFileDialog);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridViewTestItems
            // 
            this.dataGridViewTestItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTestItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTestItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestNum,
            this.TestItem});
            this.dataGridViewTestItems.Location = new System.Drawing.Point(0, 106);
            this.dataGridViewTestItems.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewTestItems.MultiSelect = false;
            this.dataGridViewTestItems.Name = "dataGridViewTestItems";
            this.dataGridViewTestItems.ReadOnly = true;
            this.dataGridViewTestItems.RowHeadersVisible = false;
            this.dataGridViewTestItems.RowHeadersWidth = 200;
            this.dataGridViewTestItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTestItems.RowTemplate.Height = 23;
            this.dataGridViewTestItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTestItems.Size = new System.Drawing.Size(263, 580);
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
            this.textBoxFilte.Location = new System.Drawing.Point(69, 38);
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
            this.labelFilte.Location = new System.Drawing.Point(13, 41);
            this.labelFilte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFilte.Name = "labelFilte";
            this.labelFilte.Size = new System.Drawing.Size(52, 21);
            this.labelFilte.TabIndex = 4;
            this.labelFilte.Text = "Filter:";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(355, 132);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(651, 455);
            this.formsPlot1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 725);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.labelFilte);
            this.Controls.Add(this.textBoxFilte);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewTestItems);
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
        private ScottPlot.FormsPlot formsPlot1;
    }
}

