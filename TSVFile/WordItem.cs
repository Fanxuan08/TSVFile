using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSVFile
{
    public class WordItem
    {
        public string Word { get; set; }
        public string Phonogram { get; set; }
        public string SoundPath { get; set; }
        public string Explain { get; set; }
        public bool IsMemorized { get; set; }
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name=“str”>單行的單字資料</param>
        public WordItem(string str)
        {
            string[] strLists = str.Split('\t');
            IsMemorized = false; // 預設為沒背過

            if (strLists.Length >= 3)
            {
                Word = strLists[0];
                Phonogram = strLists[1];
                SoundPath = strLists[2];

                // 判斷最後一欄是不是 True 或 False (用來相容舊版沒有打勾的檔案)
                string lastItem = strLists.Last();
                if (bool.TryParse(lastItem, out bool memorizedStatus))
                {
                    IsMemorized = memorizedStatus;
                    // 如果最後一欄是打勾狀態，那解釋的部分就是從索引 3 取到倒數第二個
                    var explainParts = strLists.Skip(3).Take(strLists.Length - 4);
                    Explain = string.Join(Environment.NewLine, explainParts);
                }
                else
                {
                    // 舊版檔案，沒有打勾狀態，剩下的全都是解釋
                    Explain = string.Join(Environment.NewLine, strLists.Skip(3));
                }
            }
        }

        public string ToLineString()
        {
            string strExplain = Explain.Replace(Environment.NewLine, "\t");
            // 👇 在最後面多加一個 \t 與打勾狀態 (IsMemorized) 寫入文字檔
            return $"{Word}\t{Phonogram}\t{SoundPath}\t{strExplain}\t{IsMemorized}";
        }

        /// <summary>
        /// 覆寫 ToString() 可將物件自動轉換為字串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Word;
        }


    }

}
