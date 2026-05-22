using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TSVFile
{

    public partial class frmTSVFile : Form
    {
        /// <summary>
        /// 關於視窗
        /// </summary>
        frmAbout about = new frmAbout();

        /// <summary>
        /// 單字清單
        /// </summary>
        WordCollection _WordList = new WordCollection();

        string currentFilePath = "";

        public frmTSVFile()
        {
            InitializeComponent();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            // 顯示關於視窗
            about.ShowDialog(this);
        }

        /// <summary>
        /// 更新 ListView 的內容
        /// </summary>
        private void UpdateListView()
        {
            lvwWord.BeginUpdate();
            lvwWord.Items.Clear();

            foreach (WordItem item in _WordList)
            {
                ListViewItem lvi = new ListViewItem(item.Word);
                lvi.SubItems.Add(item.Phonogram);
                lvi.SubItems.Add(item.SoundPath);
                lvi.SubItems.Add(item.Explain.Replace(Environment.NewLine, " "));
                lvi.Checked = item.IsMemorized;

                lvwWord.Items.Add(lvi);
            }
            lvwWord.EndUpdate();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TSV files (*.tsv)|*.tsv|Text files (*.txt)|*.txt|All files (*.*)|*.*"; ofd.Title = "開啟檔案";
            ofd.FilterIndex = 2;
            // 設定初始目錄為程式所在目錄
            ofd.InitialDirectory = Application.StartupPath;
            DialogResult dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                currentFilePath = ofd.FileName;
                // 讀取檔案並且將每一行的資料放入字串陣列
                string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                // 將字串陣列的資料載入到 WordCollection 物件中
                _WordList.LoadFromStringArray(lines);
                // 將 WordCollection 物件中的資料載入到 ListView 中
                UpdateListView();
                this.tsslMessage.Text = $"{_WordList.Count} 單字已成功載入";
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTSVFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要離開嗎?", "離開",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true; // 取消關閉
            }
        }

        private void frmTSVFile_Load(object sender, EventArgs e)
        {
            tsslMessage.Text = "請開啟檔案";
            // 強制設定欄寬 (索引從0開始，2 是音檔路徑，3 是解釋)
            // 數值可以依據你的螢幕大小自由調整
            lvwWord.Columns[0].Width = 90;
            lvwWord.Columns[2].Width = 150;
            lvwWord.Columns[3].Width = 500;
        }

        private void lvwWord_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // 確保有選中項目，且檔案路徑不是空的
            if (e.Item.Index >= 0 && e.Item.Index < _WordList.Count && currentFilePath != "")
            {
                // 1. 更新記憶體裡的打勾狀態
                _WordList[e.Item.Index].IsMemorized = e.Item.Checked;

                // 2. 呼叫剛剛寫好的存檔功能，直接覆蓋原本的檔案！
                _WordList.SaveToFile(currentFilePath);
            }
        }

        private void frmTSVFile_KeyDown(object sender, KeyEventArgs e)
        {
            // 判斷使用者按下了什麼鍵
            switch (e.KeyCode)
            {
                case Keys.Up:
                    // 快速切換到「上一個」單字
                    if (lvwWord.SelectedItems.Count > 0 && lvwWord.SelectedItems[0].Index > 0)
                    {
                        int prevIdx = lvwWord.SelectedItems[0].Index - 1;
                        // 清除所有選取，改選上一個
                        lvwWord.SelectedItems.Clear();
                        lvwWord.Items[prevIdx].Selected = true;
                        lvwWord.Items[prevIdx].Focused = true;

                        //強制 ListView 向上滾動，確保該項目可見
                        lvwWord.Items[prevIdx].EnsureVisible();
                    }
                    e.Handled = true;
                    break;

                case Keys.Down:
                    //快速切換到「下一個」單字
                    if (lvwWord.SelectedItems.Count > 0 && lvwWord.SelectedItems[0].Index < lvwWord.Items.Count - 1)
                    {
                        int nextIdx = lvwWord.SelectedItems[0].Index + 1;
                        // 清除所有選取，改選下一個
                        lvwWord.SelectedItems.Clear();
                        lvwWord.Items[nextIdx].Selected = true;
                        lvwWord.Items[nextIdx].Focused = true;

                        //關鍵新增：強制 ListView 向下滾動，確保該項目可見
                        lvwWord.Items[nextIdx].EnsureVisible();
                    }
                    else if (lvwWord.SelectedItems.Count == 0 && lvwWord.Items.Count > 0)
                    {
                        // 如果目前都沒選任何東西，按下鍵就預設選第一個
                        lvwWord.Items[0].Selected = true;
                        lvwWord.Items[0].Focused = true;
                        lvwWord.Items[0].EnsureVisible();
                    }
                    e.Handled = true;
                    break;
            }
        }
         
    }
}
