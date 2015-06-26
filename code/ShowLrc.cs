using TXTClass;
using System.Text.RegularExpressions;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Data;
using System.Text;
using System.IO;

namespace JackLin_MusicPlayer
{
    class ShowLrc
    {
        txtclass txt = new txtclass();
        string excTime = @"(?<=\[).*?(?=\])";//匹配时间的正则
        string excText = @"(?<=\])(?!\[).*";//匹配歌词的正则
        string[] lrcTime = new string[200];//保存歌曲时间
        string[] lrcText = new string[200];//保存歌词文字
        int t1 = 0;
        int t2 = 0;
        string zj;//中间变量

        /// <summary>
        /// 解析lrc文件
        /// </summary>
        /// <param name="FileName">文件路径</param>
        public void getLrc(string FileName)
        {
            t1 = 0;
            t2 = 0;
            lrcTime = new string[200];
            lrcText = new string[200];
            string[] strs = System.IO.File.ReadAllLines(FileName);
            int hasline = strs.Length;
            MatchCollection match1;
            MatchCollection match2;
            for (int i = 0; i <= hasline; i++)
            {
                match1 = Regex.Matches(txt.txtRead(FileName, i), excTime);
                match2 = Regex.Matches(txt.txtRead(FileName, i), excText);
                foreach (var v in match1)
                {
                    StringBuilder sb = new StringBuilder(v.ToString());
                    sb.Replace(".", ":");
                    zj = sb.ToString();
                    try
                    {
                        zj = zj.Substring(0, 5) + ":00";
                        //try
                        //{
                        System.DateTime.Parse(zj);
                        lrcTime[t1] = zj;
                        foreach (var t in match2)
                        {
                            lrcText[t2] = t.ToString();
                        }
                        t1++;
                        t2++;
                        //}
                        //catch (System.Exception)
                        //{


                        //}
                    }
                    catch (Exception)
                    {

                        //
                    }

                }

            }
        }

        //返回数组
        public string[] returnTime()
        {
            return this.lrcTime;
        }

        public string[] returnText()
        {
            return this.lrcText;
        }
    }
}
