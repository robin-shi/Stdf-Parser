
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
            this.toolStripStatusFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarFileOpen = new System.Windows.Forms.ToolStripProgressBar();
            this.textBoxFilte = new System.Windows.Forms.TextBox();
            this.labelFilte = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(1081, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 21);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenStdfFileDialog);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridViewTestItems
            // 
            this.dataGridViewTestItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestNum,
            this.TestItem});
            this.dataGridViewTestItems.Location = new System.Drawing.Point(0, 69);
            this.dataGridViewTestItems.Name = "dataGridViewTestItems";
            this.dataGridViewTestItems.ReadOnly = true;
            this.dataGridViewTestItems.RowTemplate.Height = 23;
            this.dataGridViewTestItems.Size = new System.Drawing.Size(282, 594);
            this.dataGridViewTestItems.TabIndex = 1;
            // 
            // TestNum
            // 
            this.TestNum.Frozen = true;
            this.TestNum.HeaderText = "TestNum";
            this.TestNum.Name = "TestNum";
            this.TestNum.ReadOnly = true;
            // 
            // TestItem
            // 
            this.TestItem.Frozen = true;
            this.TestItem.HeaderText = "TestItem";
            this.TestItem.Name = "TestItem";
            this.TestItem.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarFileOpen,
            this.toolStripStatusFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusFileName
            // 
            this.toolStripStatusFileName.Name = "toolStripStatusFileName";
            this.toolStripStatusFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBarFileOpen
            // 
            this.toolStripProgressBarFileOpen.Name = "toolStripProgressBarFileOpen";
            this.toolStripProgressBarFileOpen.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBarFileOpen.Step = 100;
            this.toolStripProgressBarFileOpen.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // textBoxFilte
            // 
            this.textBoxFilte.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFilte.Location = new System.Drawing.Point(74, 37);
            this.textBoxFilte.Name = "textBoxFilte";
            this.textBoxFilte.Size = new System.Drawing.Size(208, 26);
            this.textBoxFilte.TabIndex = 3;
            // 
            // labelFilte
            // 
            this.labelFilte.AutoSize = true;
            this.labelFilte.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFilte.Location = new System.Drawing.Point(12, 42);
            this.labelFilte.Name = "labelFilte";
            this.labelFilte.Size = new System.Drawing.Size(56, 16);
            this.labelFilte.TabIndex = 4;
            this.labelFilte.Text = "Filte:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 688);
            this.Controls.Add(this.labelFilte);
            this.Controls.Add(this.textBoxFilte);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewTestItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFileName;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarFileOpen;
        private System.Windows.Forms.TextBox textBoxFilte;
        private System.Windows.Forms.Label labelFilte;
    }
}

