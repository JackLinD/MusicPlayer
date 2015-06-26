using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Windows.Forms;

namespace JackLin_MusicPlayer
{
    class Lrc
    {
        string exc = @"[a-zA-z]+://[^\s]*[a-zA-z]";//用于匹配歌词连接的正则表达式
        string HTML;//保存网页源码
        string LrcText;//歌词信息
        string lrcAPI = "http://geci.me/api/lyric/";//取歌词文件的API
        string fileName;//保存歌词路径
        /// <summary>
        /// 下载歌词文件
        /// </summary>
        /// <param name="mp3Name">歌曲文件名</param>
        /// <returns>返回歌词连接 0为找不到歌词</returns>
        public string getLrc(string mp3Name)
        {
            lrcAPI = "http://geci.me/api/lyric/";//初始化
            //此处做本地歌词判断 如果存在 就不需要下载 不存在 就下载
            if (File.Exists(string.Format(".\\Lrc\\{0}.Lrc", mp3Name)) == true)
            {
                fileName = mp3Name;
                return "正在解析歌词...";
            }
            else
            {
                lrcAPI = lrcAPI + mp3Name;
                WebClient wc = new WebClient();
                wc.Credentials = CredentialCache.DefaultCredentials; // 获取或设置用于对向 Internet 资源的请求进行身份验证的网络凭据。
                Encoding enc = Encoding.GetEncoding("UTF-8"); // 如果是乱码就改成 utf-8 / GB2312
                //try
                //{   // 从资源下载数据并返回字节数组。
                //try
                //{
                Byte[] pageData = wc.DownloadData(lrcAPI);
                HTML = enc.GetString(pageData);
                MatchCollection matchs = Regex.Matches(HTML, exc);//开始对歌词进行匹配
                if (matchs.Count == 0)
                {
                    return "没有找到对应的歌词！";
                }
                else
                {
                    DownloadLrc(matchs[0].Value, mp3Name);
                    return "歌词找到并下载成功！";
                }
                //}
                //catch (Exception)
                //{

                //   return "网络连接失败！";
                //}
            }

        }
        /// <summary>
        /// 下载歌词
        /// </summary>
        /// <param name="url">歌词连接</param>
        public void DownloadLrc(string url, string FileName)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials; // 获取或设置用于对向 Internet 资源的请求进行身份验证的网络凭据。
            Encoding enc = Encoding.GetEncoding("UTF-8"); // 如果是乱码就改成 utf-8 / GB2312
            try
            {
                Byte[] pageData = wc.DownloadData(url);
                // 从资源下载数据并返回字节数组。
                LrcText = enc.GetString(pageData);
                if (Directory.Exists(".\\Lrc") == false)
                {
                    Directory.CreateDirectory(".\\Lrc");
                }
                StreamWriter sw = new StreamWriter(String.Format(".\\Lrc\\{0}.Lrc", FileName), false, Encoding.UTF8);
                sw.Write(LrcText);
                sw.Flush();
                sw.Close();
                fileName = FileName;
            }
            catch (Exception)
            {

            }

        }

        //返回歌词路径方法
        public string returnPath()
        {
            return fileName;
        }
    }
}
