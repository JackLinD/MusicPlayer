using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Data;
using System.Threading;

namespace JackLin_MusicPlayer
{
    public partial class JackLin_MusicPlayer : Form
    {
        delegate void set_Text(string s);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        protected static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);
        public const Int32 AW_BLEND = 0x00080000;
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_ACTIVATE = 0x00020000;
        public const Int32 AW_HIDE = 0x00010000;
        public const Int32 AW_SLIDE = 0x00040000;
        public JackLin_MusicPlayer()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void JackLin_MusicPlayer_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 500, AW_BLEND | AW_CENTER | AW_ACTIVATE);
            GetMusicList();
            getNum();
            setMusicList(1);
            try
            {
                this.axWindowsMediaPlayer1.settings.volume = 35;
                play(names[musicNum]);
                isplay = true;
                song_page.Text = "1";
            }
            catch (Exception)
            {
                isplay = false;
            }
            //for (; musicNum < names.Length; musicNum++)
            //    transparentListBox1.Items.Add(names[musicNum]);
        }
        private void JackLin_MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 500, AW_CENTER | AW_BLEND | AW_HIDE); 
        }

        #region 窗体边框阴影效果变量申明

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        #endregion

        #region 窗体
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void JackLin_MusicPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Skin_panel.Visible = false;
            skins = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 皮肤
        Boolean skins = false;
        private void Skin_Click(object sender, EventArgs e)
        {
            if (skins == false)
            {
                Skin_panel.Visible = true;
                skins = true;
            }
            else
            {
                Skin_panel.Visible = false;
                skins = false;
            }
        }

        private void Skin1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0001;
        }

        private void Skin2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0002;
        }

        private void Skin3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0003;
        }

        private void Skin4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0004;
        }

        private void Skin5_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0005;
        }
        string picfile;//保存copy源
        string picName;
        private void Skin6_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0006;       
        }
        private void Skin7_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0007;
        }

        private void Skin8_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._0008;
        }
        private void Skin9_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(".\\Background") == false)
            {
                Directory.CreateDirectory(".\\Background");
                OpenFileDialog of1 = new OpenFileDialog();
                of1.InitialDirectory = "c:\\";
                of1.Filter = "png|*.png|jpg|*.jpg|bmp|*.bmp";
                of1.RestoreDirectory = true;
                of1.FilterIndex = 1;
                if (of1.ShowDialog() == DialogResult.OK)
                {
                    picfile = of1.FileName;
                    picName = of1.SafeFileName;
                    try
                    {
                        File.Copy(picfile, string.Format("Background\\{0}", picName, true));
                    }
                    catch (Exception)
                    {

                        //
                    }
                    this.BackgroundImage = Image.FromFile(string.Format("Background\\{0}", picName));
                }
            }
            else
            {
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = "c:\\";
                of.Filter = "png|*.png|jpg|*.jpg|bmp|*.bmp";
                of.RestoreDirectory = true;
                of.FilterIndex = 1;
                if (of.ShowDialog() == DialogResult.OK)
                {
                    picfile = of.FileName;
                    picName = of.SafeFileName;
                    try
                    {
                        File.Copy(picfile, string.Format("Background\\{0}", picName, true));
                    }
                    catch (Exception)
                    {

                        //
                    }
                    this.BackgroundImage = Image.FromFile(string.Format("Background\\{0}", picName));
                }
            }
        }
        #endregion     

        #region 颜色变化
        private void Skin_MouseLeave(object sender, EventArgs e)
        {
            Skin.Image = Properties.Resources.皮肤;
        }

        private void Skin_MouseMove(object sender, MouseEventArgs e)
        {
            Skin.Image = Properties.Resources.皮肤高亮;
        }
        private void window_minisize_MouseLeave(object sender, EventArgs e)
        {
            window_minisize.Image = Properties.Resources.最小;
        }

        private void window_minisize_MouseMove(object sender, MouseEventArgs e)
        {
            window_minisize.Image = Properties.Resources.最小鼠标移入;
        }

        private void window_close_MouseLeave(object sender, EventArgs e)
        {
            window_close.Image = Properties.Resources.关闭1;
        }

        private void window_close_MouseMove(object sender, MouseEventArgs e)
        {
            window_close.Image = Properties.Resources.关闭鼠标移入1;
        }

        private void song_add_MouseLeave(object sender, EventArgs e)
        {
            song_add.BackgroundImage = Properties.Resources.添加;
        }

        private void song_add_MouseMove(object sender, MouseEventArgs e)
        {
            song_add.BackgroundImage = Properties.Resources.添加高光;
        }

        private void song_control_MouseLeave(object sender, EventArgs e)
        {
            if (plays == false)
                song_control.BackgroundImage = Properties.Resources.播放;
            else
                song_control.BackgroundImage = Properties.Resources.暂停;

        }

        private void song_control_MouseEnter(object sender, EventArgs e)
        {
            if (plays == false)
                song_control.BackgroundImage = Properties.Resources.播放鼠标移入;
            else
                song_control.BackgroundImage = Properties.Resources.暂停鼠标移入;

        }

        private void song_next_MouseMove(object sender, MouseEventArgs e)
        {
            song_next.BackgroundImage = Properties.Resources.下一首鼠标移入;
        }

        private void song_next_MouseLeave(object sender, EventArgs e)
        {
            song_next.BackgroundImage = Properties.Resources.下一首;
        }

        private void song_preview_MouseMove(object sender, MouseEventArgs e)
        {
            song_preview.BackgroundImage = Properties.Resources.上一首鼠标移入;
        }

        private void song_preview_MouseLeave(object sender, EventArgs e)
        {
            song_preview.BackgroundImage = Properties.Resources.上一首;
        }

        private void song_favourite_MouseMove(object sender, MouseEventArgs e)
        {
            song_favourite.BackgroundImage = Properties.Resources.喜欢高亮;
        }

        private void song_favourite_MouseLeave(object sender, EventArgs e)
        {
            song_favourite.BackgroundImage = Properties.Resources.喜欢;
        }

        private void Skin1_MouseLeave(object sender, EventArgs e)
        {
            Skin1.BackgroundImage = Properties.Resources._0001;
        }

        private void Skin1_MouseMove(object sender, MouseEventArgs e)
        {
            Skin1.BackgroundImage = Properties.Resources._00011;
        }

        private void Skin2_MouseLeave(object sender, EventArgs e)
        {
            Skin2.BackgroundImage = Properties.Resources._0002;
        }

        private void Skin2_MouseMove(object sender, MouseEventArgs e)
        {
            Skin2.BackgroundImage = Properties.Resources._00022;
        }

        private void Skin3_MouseLeave(object sender, EventArgs e)
        {
            Skin3.BackgroundImage = Properties.Resources._0003;
        }

        private void Skin3_MouseMove(object sender, MouseEventArgs e)
        {
            Skin3.BackgroundImage = Properties.Resources._00033;
        }
        private void Skin4_MouseLeave(object sender, EventArgs e)
        {
            Skin4.BackgroundImage = Properties.Resources._0004;
        }

        private void Skin4_MouseMove(object sender, MouseEventArgs e)
        {
            Skin4.BackgroundImage = Properties.Resources._00044;
        }
        private void Skin5_MouseLeave(object sender, EventArgs e)
        {
            Skin5.BackgroundImage = Properties.Resources._0005;
        }

        private void Skin5_MouseMove(object sender, MouseEventArgs e)
        {
            Skin5.BackgroundImage = Properties.Resources._00055;
        }
        private void Skin6_MouseLeave(object sender, EventArgs e)
        {
            Skin6.BackgroundImage = Properties.Resources._0006;
        }

        private void Skin6_MouseMove(object sender, MouseEventArgs e)
        {
            Skin6.BackgroundImage = Properties.Resources._00066;
        }
        private void Skin7_MouseLeave(object sender, EventArgs e)
        {
            Skin7.BackgroundImage = Properties.Resources._0007;
        }

        private void Skin7_MouseMove(object sender, MouseEventArgs e)
        {
            Skin7.BackgroundImage = Properties.Resources._00077;
        }
        private void Skin8_MouseLeave(object sender, EventArgs e)
        {
            Skin8.BackgroundImage = Properties.Resources._0008;
        }

        private void Skin8_MouseMove(object sender, MouseEventArgs e)
        {
            Skin8.BackgroundImage = Properties.Resources._00088;
        }
        private void Skin9_MouseLeave(object sender, EventArgs e)
        {
            Skin9.BackgroundImage = Properties.Resources._;
        }

        private void Skin9_MouseMove(object sender, MouseEventArgs e)
        {
            Skin9.BackgroundImage = Properties.Resources.__;
        }
        #endregion

        #region 播放
        string[] names;//获取歌曲路径集合
        List<string> list;
        int musicNum = 0;
        Boolean plays = false;      
        string[] lists = new string[100];
        int old;
        private void song_add_Click(object sender, EventArgs e)
        {
            list = new List<string>();
            string[] oldFile;
            string[] newFile;
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "F:\\音乐\\MP3";
            of.Filter = "mp3|*.mp3|wav|*.wav";
            of.RestoreDirectory = true;
            of.FilterIndex = 1;
            of.Multiselect = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                int k = 0;
                int same = 0;
                if (names == null)
                {
                    oldFile = new string[of.FileNames.Length];
                    foreach (var i in of.FileNames)
                    {
                        oldFile[k] = i;
                        k++;
                    }
                }
                else
                {
                    old = names.Length;
                    oldFile = new string[of.FileNames.Length + names.Length];
                    for (int y = 0; y < names.Length; y++)
                    {
                        oldFile[k] = names[y];
                        k++;
                    }
                    foreach (var i in of.FileNames)
                    {
                        oldFile[k] = i;
                        k++;

                    }
                }
                for (int i = 0; i < oldFile.Length; i++)
                {
                    for (int j = i + 1; j < oldFile.Length; j++)
                    {
                        if (oldFile[i] == oldFile[j])
                        {
                            same++;
                        }
                    }
                }
                for (int i = 0; i < oldFile.Length; i++)
                {
                    for (int j = i + 1; j < oldFile.Length; j++)
                    {
                        if (oldFile[i] == oldFile[j])
                        {
                            oldFile[i] = "null";
                        }
                    }
                }
                //消除重复歌曲
                int w = 0;
                newFile = new string[oldFile.Length - same];
                for (int i = 0; i < oldFile.Length; i++)
                {
                    if (oldFile[i] != "null")
                    {
                        newFile[w] = oldFile[i];
                        w++;
                    }
                }

                names = newFile;
                for (int i = 0; i < names.Length; i++)
                {
                    list.Add(names[i]);
                }
                SaveMusicList();
            }
            setMusicList(1);

        }
        public void SaveMusicList()
        {
            if (File.Exists(".\\Music.lst") == true)
            {
                File.Delete(".\\Music.lst");
            }
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "Music.lst";
            sf.RestoreDirectory = true;
            sf.FilterIndex = 1;
            FileStream fs = new FileStream(string.Format("{0}", sf.FileName), FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();
            song_all.Text = (names.Length).ToString();
            musicNum = old;
            play(names[musicNum]);
            //if (isplay == false)
            //    song_control.BackgroundImage = Properties.Resources.播放;
        }
        public void play(string namepath)
        {
            this.axWindowsMediaPlayer1.URL = namepath;
            song_name.Text = this.axWindowsMediaPlayer1.currentMedia.name;
            isplay = true;
            plays = true;
            timer3.Enabled = true;
            getmusicTime();
            getNum();
            song_control.BackgroundImage = Properties.Resources.暂停;             
        }
        bool isplay = false;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isplay == true)
            {
                getmusicTime();
                this.song_firsttime.Text = this.axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                this.song_lasttime.Text = this.axWindowsMediaPlayer1.currentMedia.durationString;
                if (this.axWindowsMediaPlayer1.playState.ToString() == "wmppsStopped")
                {
                    timer1.Enabled = false;
                    song_firsttime.Text = "00:00";
                    musicNum++;
                        if (musicNum <= names.Length - 1)
                        {
                            play(names[musicNum]);
                        }
                        else
                        {
                            musicNum = 0;
                            play(names[musicNum]);
                        }
                }
            }
            else
            {
            }

        }
        private void song_control_Click(object sender, EventArgs e)
        {
            if (plays == false)
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
                song_control.BackgroundImage = Properties.Resources.暂停鼠标移入;
                plays = true;
            }
            else
            {
                song_control.BackgroundImage = Properties.Resources.播放鼠标移入;
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();
                plays = false;
            }
        }
        private void song_preview_Click(object sender, EventArgs e)
        {
            musicNum--;
            //try
            //{
            //    play(names[musicNum]);
            //}
            //catch (Exception)
            //{

            //    musicNum += 1;
            //}
            if (musicNum >= 0)
            {
                play(names[musicNum]);
            }
            else { 
                musicNum = names.Length-1;
            play(names[musicNum]);}
        }
        private void song_next_Click(object sender, EventArgs e)
        {
            musicNum++;
            //try
            //{
            //    play(names[musicNum]);
            //}
            //catch (Exception)
            //{

            //    musicNum -= 1;
            //}
            if (musicNum <= names.Length-1)
            {
                play(names[musicNum]);
            }
            else
            {
                musicNum = 0;
                play(names[musicNum]);
            }
        }
        public void GetMusicList()
        {
            string[] musicFile;
            if (File.Exists(".\\Music.lst") == false)
            {
            }
            else
            {
                OpenFileDialog of = new OpenFileDialog();
                of.FileName = "Music.lst";
                of.RestoreDirectory = true;
                of.FilterIndex = 1;
                FileStream fs = new FileStream(string.Format("{0}", of.FileName), FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                this.list = ((List<string>)bf.Deserialize(fs));
                fs.Close();
                musicFile = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    musicFile[i] = list[i];
                }
                names = musicFile;
            }
            song_all.Text = names.Length.ToString();
        }
        int index = 0;//下标
        int pages = 1;
        int noMusic;//取摸剩下的没有的歌曲
        private void setMusicList(int page)
        {
            if (names!=null) {
                label1.Text = null;
                label2.Text = null;
                label3.Text = null;
                label4.Text = null;
                label5.Text = null;
                label6.Text = null;
                pages = (int)names.Length / 6;
                index = (page - 1) * 6;
                noMusic = names.Length % 6;
                
                try
                {
                    label1.Text = System.IO.Path.GetFileNameWithoutExtension(names[index + 0]);
                    label2.Text = System.IO.Path.GetFileNameWithoutExtension(names[index + 1]);
                    label3.Text = System.IO.Path.GetFileNameWithoutExtension(names[index + 2]);
                    label4.Text = System.IO.Path.GetFileNameWithoutExtension(names[index + 3]);
                    label5.Text = System.IO.Path.GetFileNameWithoutExtension(names[index + 4]);
                    label6.Text = System.IO.Path.GetFileNameWithoutExtension(names[index + 5]);
                }
                catch (Exception)
                {
                    
                   
                }
            }
        }
        #endregion
        
        #region 进度条
        private void song_time_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(song_time, song_firsttime.Text);
        }

        private void song_time_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void song_time_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        int panleX;
        private void song_time_MouseDown(object sender, MouseEventArgs e)
        {
            song_time1.Size = new Size(e.Location.X, 3);
            panleX = e.Location.X;
            changeTime(332, panleX);
        }
        double Alltime;
        double thisTime;
        Double b;
        public void changeTime(double all, double thisp)
        {
            try
            {
                b = thisp / all;
                Alltime = this.axWindowsMediaPlayer1.currentMedia.duration;
                thisTime = Alltime * b;
                this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = thisTime;
            }
            catch (Exception)
            {

                //
            }
        }

        private void song_time1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void song_time1_MouseDown(object sender, MouseEventArgs e)
        {
            song_time1.Size = new Size(e.Location.X, 3);
            panleX = e.Location.X;
            changeTime(332, panleX);
        }

        private void song_time1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(song_time1, song_firsttime.Text);
        }

        private void song_time1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        double alltime;//全部时间
        double thistime;//当前时间
        double bfb;//百分比
        double thisX;
        //改变进度条长度
        public void getmusicTime()
        {
            thistime = this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            alltime = this.axWindowsMediaPlayer1.currentMedia.duration;
            bfb = thistime / alltime;
            thisX = 332 * bfb;
            song_time1.Size = new Size((int)thisX, 3);
        }
        
        #endregion

        #region 歌名
        int y = 0;
        int bb;
        int rx;
        int lx;
        int bl;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lx >= 0)
            {
                song_name.Location = new Point(bl - 1, y);
                bl--;
                lx--;
            }
            else
            {

                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lx < (song_name.Size.Width - 300))
            {
                song_name.Location = new Point(bl + 1, y);
                bl++;
                lx++;
            }
            else
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }
        public void getNum()
        {
            bl = 0;
            rx = 0;
            lx = 0;

            if (song_name.Size.Width > 300)
            {
                song_name.Location = new Point(0, 0);
                bb = rx = lx = song_name.Size.Width - 300;
                y = song_name.Location.Y;
                timer1.Enabled = true;
            }
            else
            {
                song_name.Location = new Point((300 - song_name.Size.Width) / 2, 0);
                timer1.Enabled = false;
            }
        }
        #endregion

        #region 声音

        int voice;//声音
        public void setVoice(int voice)
        {
            this.axWindowsMediaPlayer1.settings.volume = voice;
        }
        private void sound_MouseDown(object sender, MouseEventArgs e)
        {
            voice = e.Location.X;
            setVoice(voice);
            sound1.Size = new Size(e.Location.X, 3);
        }

        private void sound_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void sound_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void sound1_MouseDown(object sender, MouseEventArgs e)
        {
            voice = e.Location.X;
            sound1.Size = new Size(e.Location.X, 3);
            setVoice(voice);
        }

        private void sound1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void sound1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        #endregion     

        #region 手贱
        private void MusicPlayer_Click(object sender, EventArgs e)
        {

        }

        private void song_time_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Skin_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void song_lasttime_Click(object sender, EventArgs e)
        {

        }

        private void song_namepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion      

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.Image = Properties.Resources.s;
        }
        private void lable_MouseLeava(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.Image = null;
        }
        private void lable_DoubleClick(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            try
            {
                play(names[(mpage - 1) * 6 + Convert.ToInt32(lb.Tag)]);
                musicNum = (mpage - 1) * 6 + Convert.ToInt32(lb.Tag);
            }
            catch (Exception)
            {

            }
        }
        int mpage = 1;
        private void page_next_Click(object sender, EventArgs e)
        {
            if (mpage < (int)names.Length / 6 + 1)
            {
                setMusicList(mpage + 1);
                mpage++;
                song_page.Text = mpage.ToString();
            }
        }

        private void page_preview_Click(object sender, EventArgs e)
        {
            if (mpage > 1)
            {
                setMusicList(mpage - 1);
                mpage--;
                song_page.Text = mpage.ToString();
            }
        }
    }

    //public class TransparentListBox : ListBox
    //{

    //    public TransparentListBox()
    //    {
    //        SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
    //        this.BackColor = Color.Transparent;
    //    }

    //}

    
}
