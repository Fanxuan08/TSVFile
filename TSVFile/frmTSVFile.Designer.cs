namespace TSVFile
{
    partial class frmTSVFile
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsWord = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwWord = new System.Windows.Forms.ListView();
            this.chWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhonogram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoundPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ssrWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsWord.SuspendLayout();
            this.ssrWord.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsWord
            // 
            this.mnsWord.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsWord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.mnsWord.Location = new System.Drawing.Point(0, 0);
            this.mnsWord.Name = "mnsWord";
            this.mnsWord.Size = new System.Drawing.Size(1173, 31);
            this.mnsWord.TabIndex = 0;
            this.mnsWord.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(55, 27);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(157, 34);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(157, 34);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(66, 27);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(162, 34);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // lvwWord
            // 
            this.lvwWord.CheckBoxes = true;
            this.lvwWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWord,
            this.chPhonogram,
            this.chSoundPath,
            this.chExplain});
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.FullRowSelect = true;
            this.lvwWord.HideSelection = false;
            this.lvwWord.Location = new System.Drawing.Point(0, 31);
            this.lvwWord.Name = "lvwWord";
            this.lvwWord.Size = new System.Drawing.Size(1173, 594);
            this.lvwWord.TabIndex = 1;
            this.lvwWord.UseCompatibleStateImageBehavior = false;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            this.lvwWord.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwWord_ItemChecked);
            // 
            // chWord
            // 
            this.chWord.Text = "單字";
            // 
            // chPhonogram
            // 
            this.chPhonogram.Text = "音標";
            // 
            // chSoundPath
            // 
            this.chSoundPath.Text = "音檔路徑";
            // 
            // chExplain
            // 
            this.chExplain.Text = "解釋";
            // 
            // ssrWord
            // 
            this.ssrWord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssrWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssrWord.Location = new System.Drawing.Point(0, 595);
            this.ssrWord.Name = "ssrWord";
            this.ssrWord.Size = new System.Drawing.Size(1173, 30);
            this.ssrWord.TabIndex = 3;
            this.ssrWord.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(84, 23);
            this.tsslMessage.Text = "Message";
            // 
            // frmTSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 625);
            this.Controls.Add(this.ssrWord);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.mnsWord);
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnsWord;
            this.Name = "frmTSVFile";
            this.Text = "TSV資料檔讀取";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTSVFile_FormClosing);
            this.Load += new System.EventHandler(this.frmTSVFile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTSVFile_KeyDown);
            this.mnsWord.ResumeLayout(false);
            this.mnsWord.PerformLayout();
            this.ssrWord.ResumeLayout(false);
            this.ssrWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsWord;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ListView lvwWord;
        private System.Windows.Forms.StatusStrip ssrWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ColumnHeader chWord;
        private System.Windows.Forms.ColumnHeader chPhonogram;
        private System.Windows.Forms.ColumnHeader chSoundPath;
        private System.Windows.Forms.ColumnHeader chExplain;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

