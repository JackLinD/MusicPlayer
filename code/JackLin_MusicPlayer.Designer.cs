namespace JackLin_MusicPlayer
{
    
    partial class JackLin_MusicPlayer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JackLin_MusicPlayer));
            this.MusicPlayer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.song_time = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.song_firsttime = new System.Windows.Forms.Label();
            this.song_lasttime = new System.Windows.Forms.Label();
            this.song_time1 = new System.Windows.Forms.Panel();
            this.sound = new System.Windows.Forms.Panel();
            this.sound1 = new System.Windows.Forms.Panel();
            this.song_name = new System.Windows.Forms.Label();
            this.song_namepanel = new System.Windows.Forms.Panel();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.共有歌曲 = new System.Windows.Forms.Label();
            this.song_all = new System.Windows.Forms.Label();
            this.Skin_panel = new System.Windows.Forms.Panel();
            this.Skin9 = new System.Windows.Forms.PictureBox();
            this.Skin8 = new System.Windows.Forms.PictureBox();
            this.Skin7 = new System.Windows.Forms.PictureBox();
            this.Skin6 = new System.Windows.Forms.PictureBox();
            this.Skin5 = new System.Windows.Forms.PictureBox();
            this.Skin4 = new System.Windows.Forms.PictureBox();
            this.Skin3 = new System.Windows.Forms.PictureBox();
            this.Skin2 = new System.Windows.Forms.PictureBox();
            this.Skin1 = new System.Windows.Forms.PictureBox();
            this.song_panel = new System.Windows.Forms.Panel();
            this.song_page = new System.Windows.Forms.Label();
            this.page_next = new System.Windows.Forms.Label();
            this.page_preview = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.song_favourite = new System.Windows.Forms.PictureBox();
            this.Skin = new System.Windows.Forms.Label();
            this.song_preview = new System.Windows.Forms.PictureBox();
            this.song_next = new System.Windows.Forms.PictureBox();
            this.song_control = new System.Windows.Forms.PictureBox();
            this.song_add = new System.Windows.Forms.PictureBox();
            this.window_close = new System.Windows.Forms.Label();
            this.window_minisize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.sound.SuspendLayout();
            this.song_namepanel.SuspendLayout();
            this.Skin_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Skin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin1)).BeginInit();
            this.song_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.song_favourite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_add)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.AutoSize = true;
            this.MusicPlayer.BackColor = System.Drawing.Color.Transparent;
            this.MusicPlayer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicPlayer.ForeColor = System.Drawing.Color.White;
            this.MusicPlayer.Location = new System.Drawing.Point(12, 11);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.Size = new System.Drawing.Size(141, 17);
            this.MusicPlayer.TabIndex = 4;
            this.MusicPlayer.Text = "JackLin\'s MusicPlayer";
            this.MusicPlayer.Click += new System.EventHandler(this.MusicPlayer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(9, 28);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 13);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // song_time
            // 
            this.song_time.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.song_time.Location = new System.Drawing.Point(60, 65);
            this.song_time.Name = "song_time";
            this.song_time.Size = new System.Drawing.Size(332, 3);
            this.song_time.TabIndex = 11;
            this.song_time.Paint += new System.Windows.Forms.PaintEventHandler(this.song_time_Paint);
            this.song_time.MouseDown += new System.Windows.Forms.MouseEventHandler(this.song_time_MouseDown);
            this.song_time.MouseEnter += new System.EventHandler(this.song_time_MouseEnter);
            this.song_time.MouseLeave += new System.EventHandler(this.song_time_MouseLeave);
            this.song_time.MouseHover += new System.EventHandler(this.song_time_MouseHover);
            // 
            // song_firsttime
            // 
            this.song_firsttime.AutoSize = true;
            this.song_firsttime.BackColor = System.Drawing.Color.Transparent;
            this.song_firsttime.ForeColor = System.Drawing.Color.White;
            this.song_firsttime.Location = new System.Drawing.Point(54, 74);
            this.song_firsttime.Name = "song_firsttime";
            this.song_firsttime.Size = new System.Drawing.Size(35, 12);
            this.song_firsttime.TabIndex = 12;
            this.song_firsttime.Text = "00:00";
            // 
            // song_lasttime
            // 
            this.song_lasttime.AutoSize = true;
            this.song_lasttime.BackColor = System.Drawing.Color.Transparent;
            this.song_lasttime.ForeColor = System.Drawing.Color.White;
            this.song_lasttime.Location = new System.Drawing.Point(360, 74);
            this.song_lasttime.Name = "song_lasttime";
            this.song_lasttime.Size = new System.Drawing.Size(35, 12);
            this.song_lasttime.TabIndex = 13;
            this.song_lasttime.Text = "00:00";
            this.song_lasttime.Click += new System.EventHandler(this.song_lasttime_Click);
            // 
            // song_time1
            // 
            this.song_time1.BackColor = System.Drawing.Color.White;
            this.song_time1.Location = new System.Drawing.Point(60, 65);
            this.song_time1.Name = "song_time1";
            this.song_time1.Size = new System.Drawing.Size(0, 3);
            this.song_time1.TabIndex = 12;
            this.song_time1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.song_time1_MouseDown);
            this.song_time1.MouseEnter += new System.EventHandler(this.song_time1_MouseEnter);
            this.song_time1.MouseLeave += new System.EventHandler(this.song_time1_MouseLeave);
            this.song_time1.MouseHover += new System.EventHandler(this.song_time1_MouseHover);
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sound.Controls.Add(this.sound1);
            this.sound.Location = new System.Drawing.Point(296, 145);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(120, 3);
            this.sound.TabIndex = 12;
            this.sound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sound_MouseDown);
            this.sound.MouseEnter += new System.EventHandler(this.sound_MouseEnter);
            this.sound.MouseLeave += new System.EventHandler(this.sound_MouseLeave);
            // 
            // sound1
            // 
            this.sound1.BackColor = System.Drawing.Color.White;
            this.sound1.Location = new System.Drawing.Point(0, 0);
            this.sound1.Name = "sound1";
            this.sound1.Size = new System.Drawing.Size(50, 3);
            this.sound1.TabIndex = 13;
            this.sound1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sound1_MouseDown);
            this.sound1.MouseEnter += new System.EventHandler(this.sound1_MouseEnter);
            this.sound1.MouseLeave += new System.EventHandler(this.sound1_MouseLeave);
            // 
            // song_name
            // 
            this.song_name.AutoSize = true;
            this.song_name.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.song_name.ForeColor = System.Drawing.Color.White;
            this.song_name.Location = new System.Drawing.Point(28, 0);
            this.song_name.Name = "song_name";
            this.song_name.Size = new System.Drawing.Size(244, 22);
            this.song_name.TabIndex = 1;
            this.song_name.Text = "欢迎使用Jacklin\'s MusicPlayer";
            this.song_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // song_namepanel
            // 
            this.song_namepanel.BackColor = System.Drawing.Color.Transparent;
            this.song_namepanel.Controls.Add(this.song_name);
            this.song_namepanel.Location = new System.Drawing.Point(79, 34);
            this.song_namepanel.Name = "song_namepanel";
            this.song_namepanel.Size = new System.Drawing.Size(300, 34);
            this.song_namepanel.TabIndex = 16;
            this.song_namepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.song_namepanel_Paint);
            // 
            // 共有歌曲
            // 
            this.共有歌曲.AutoSize = true;
            this.共有歌曲.BackColor = System.Drawing.Color.Transparent;
            this.共有歌曲.ForeColor = System.Drawing.Color.White;
            this.共有歌曲.Location = new System.Drawing.Point(36, 136);
            this.共有歌曲.Name = "共有歌曲";
            this.共有歌曲.Size = new System.Drawing.Size(53, 12);
            this.共有歌曲.TabIndex = 17;
            this.共有歌曲.Text = "共有歌曲";
            // 
            // song_all
            // 
            this.song_all.AutoSize = true;
            this.song_all.BackColor = System.Drawing.Color.Transparent;
            this.song_all.ForeColor = System.Drawing.Color.White;
            this.song_all.Location = new System.Drawing.Point(97, 136);
            this.song_all.Name = "song_all";
            this.song_all.Size = new System.Drawing.Size(11, 12);
            this.song_all.TabIndex = 18;
            this.song_all.Text = "0";
            // 
            // Skin_panel
            // 
            this.Skin_panel.BackColor = System.Drawing.Color.Transparent;
            this.Skin_panel.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources.panel6_Backgroun;
            this.Skin_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin_panel.Controls.Add(this.Skin9);
            this.Skin_panel.Controls.Add(this.Skin8);
            this.Skin_panel.Controls.Add(this.Skin7);
            this.Skin_panel.Controls.Add(this.Skin6);
            this.Skin_panel.Controls.Add(this.Skin5);
            this.Skin_panel.Controls.Add(this.Skin4);
            this.Skin_panel.Controls.Add(this.Skin3);
            this.Skin_panel.Controls.Add(this.Skin2);
            this.Skin_panel.Controls.Add(this.Skin1);
            this.Skin_panel.ForeColor = System.Drawing.Color.Transparent;
            this.Skin_panel.Location = new System.Drawing.Point(190, 30);
            this.Skin_panel.Name = "Skin_panel";
            this.Skin_panel.Size = new System.Drawing.Size(199, 190);
            this.Skin_panel.TabIndex = 3;
            this.Skin_panel.Visible = false;
            this.Skin_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Skin_panel_Paint);
            // 
            // Skin9
            // 
            this.Skin9.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._;
            this.Skin9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin9.Location = new System.Drawing.Point(137, 128);
            this.Skin9.Name = "Skin9";
            this.Skin9.Size = new System.Drawing.Size(50, 50);
            this.Skin9.TabIndex = 8;
            this.Skin9.TabStop = false;
            this.Skin9.Click += new System.EventHandler(this.Skin9_Click);
            this.Skin9.MouseLeave += new System.EventHandler(this.Skin9_MouseLeave);
            this.Skin9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin9_MouseMove);
            // 
            // Skin8
            // 
            this.Skin8.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0008;
            this.Skin8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin8.Location = new System.Drawing.Point(77, 128);
            this.Skin8.Name = "Skin8";
            this.Skin8.Size = new System.Drawing.Size(50, 50);
            this.Skin8.TabIndex = 7;
            this.Skin8.TabStop = false;
            this.Skin8.Click += new System.EventHandler(this.Skin8_Click);
            this.Skin8.MouseLeave += new System.EventHandler(this.Skin8_MouseLeave);
            this.Skin8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin8_MouseMove);
            // 
            // Skin7
            // 
            this.Skin7.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0007;
            this.Skin7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin7.Location = new System.Drawing.Point(12, 128);
            this.Skin7.Name = "Skin7";
            this.Skin7.Size = new System.Drawing.Size(50, 50);
            this.Skin7.TabIndex = 6;
            this.Skin7.TabStop = false;
            this.Skin7.Click += new System.EventHandler(this.Skin7_Click);
            this.Skin7.MouseLeave += new System.EventHandler(this.Skin7_MouseLeave);
            this.Skin7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin7_MouseMove);
            // 
            // Skin6
            // 
            this.Skin6.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0006;
            this.Skin6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin6.Location = new System.Drawing.Point(137, 71);
            this.Skin6.Name = "Skin6";
            this.Skin6.Size = new System.Drawing.Size(50, 50);
            this.Skin6.TabIndex = 5;
            this.Skin6.TabStop = false;
            this.Skin6.Click += new System.EventHandler(this.Skin6_Click);
            this.Skin6.MouseLeave += new System.EventHandler(this.Skin6_MouseLeave);
            this.Skin6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin6_MouseMove);
            // 
            // Skin5
            // 
            this.Skin5.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0005;
            this.Skin5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin5.Location = new System.Drawing.Point(76, 71);
            this.Skin5.Name = "Skin5";
            this.Skin5.Size = new System.Drawing.Size(50, 50);
            this.Skin5.TabIndex = 4;
            this.Skin5.TabStop = false;
            this.Skin5.Click += new System.EventHandler(this.Skin5_Click);
            this.Skin5.MouseLeave += new System.EventHandler(this.Skin5_MouseLeave);
            this.Skin5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin5_MouseMove);
            // 
            // Skin4
            // 
            this.Skin4.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0004;
            this.Skin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin4.Location = new System.Drawing.Point(12, 71);
            this.Skin4.Name = "Skin4";
            this.Skin4.Size = new System.Drawing.Size(50, 50);
            this.Skin4.TabIndex = 3;
            this.Skin4.TabStop = false;
            this.Skin4.Click += new System.EventHandler(this.Skin4_Click);
            this.Skin4.MouseLeave += new System.EventHandler(this.Skin4_MouseLeave);
            this.Skin4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin4_MouseMove);
            // 
            // Skin3
            // 
            this.Skin3.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0003;
            this.Skin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin3.Location = new System.Drawing.Point(137, 12);
            this.Skin3.Name = "Skin3";
            this.Skin3.Size = new System.Drawing.Size(50, 50);
            this.Skin3.TabIndex = 2;
            this.Skin3.TabStop = false;
            this.Skin3.Click += new System.EventHandler(this.Skin3_Click);
            this.Skin3.MouseLeave += new System.EventHandler(this.Skin3_MouseLeave);
            this.Skin3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin3_MouseMove);
            // 
            // Skin2
            // 
            this.Skin2.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0002;
            this.Skin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin2.Location = new System.Drawing.Point(76, 12);
            this.Skin2.Name = "Skin2";
            this.Skin2.Size = new System.Drawing.Size(50, 50);
            this.Skin2.TabIndex = 1;
            this.Skin2.TabStop = false;
            this.Skin2.Click += new System.EventHandler(this.Skin2_Click);
            this.Skin2.MouseLeave += new System.EventHandler(this.Skin2_MouseLeave);
            this.Skin2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin2_MouseMove);
            // 
            // Skin1
            // 
            this.Skin1.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources._0001;
            this.Skin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Skin1.Location = new System.Drawing.Point(12, 12);
            this.Skin1.Name = "Skin1";
            this.Skin1.Size = new System.Drawing.Size(50, 50);
            this.Skin1.TabIndex = 0;
            this.Skin1.TabStop = false;
            this.Skin1.Click += new System.EventHandler(this.Skin1_Click);
            this.Skin1.MouseLeave += new System.EventHandler(this.Skin1_MouseLeave);
            this.Skin1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin1_MouseMove);
            // 
            // song_panel
            // 
            this.song_panel.BackColor = System.Drawing.Color.Transparent;
            this.song_panel.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources.panel6_BackgroundImage;
            this.song_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.song_panel.Controls.Add(this.song_page);
            this.song_panel.Controls.Add(this.page_next);
            this.song_panel.Controls.Add(this.page_preview);
            this.song_panel.Controls.Add(this.label6);
            this.song_panel.Controls.Add(this.label5);
            this.song_panel.Controls.Add(this.label4);
            this.song_panel.Controls.Add(this.label3);
            this.song_panel.Controls.Add(this.label2);
            this.song_panel.Controls.Add(this.label1);
            this.song_panel.Location = new System.Drawing.Point(15, 165);
            this.song_panel.Name = "song_panel";
            this.song_panel.Size = new System.Drawing.Size(420, 196);
            this.song_panel.TabIndex = 15;
            // 
            // song_page
            // 
            this.song_page.AutoSize = true;
            this.song_page.BackColor = System.Drawing.Color.Transparent;
            this.song_page.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.song_page.ForeColor = System.Drawing.Color.Black;
            this.song_page.Location = new System.Drawing.Point(204, 172);
            this.song_page.Name = "song_page";
            this.song_page.Size = new System.Drawing.Size(15, 14);
            this.song_page.TabIndex = 19;
            this.song_page.Text = "0";
            // 
            // page_next
            // 
            this.page_next.BackColor = System.Drawing.Color.Transparent;
            this.page_next.ForeColor = System.Drawing.Color.White;
            this.page_next.Image = global::JackLin_MusicPlayer.Properties.Resources.pictureBox12_Image;
            this.page_next.Location = new System.Drawing.Point(270, 172);
            this.page_next.Name = "page_next";
            this.page_next.Size = new System.Drawing.Size(30, 12);
            this.page_next.TabIndex = 20;
            this.page_next.Text = "    ";
            this.page_next.Click += new System.EventHandler(this.page_next_Click);
            // 
            // page_preview
            // 
            this.page_preview.BackColor = System.Drawing.Color.Transparent;
            this.page_preview.ForeColor = System.Drawing.Color.White;
            this.page_preview.Image = global::JackLin_MusicPlayer.Properties.Resources.pictureBox13_Image;
            this.page_preview.Location = new System.Drawing.Point(120, 172);
            this.page_preview.Name = "page_preview";
            this.page_preview.Size = new System.Drawing.Size(30, 12);
            this.page_preview.TabIndex = 19;
            this.page_preview.Text = "    ";
            this.page_preview.Click += new System.EventHandler(this.page_preview_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(40, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 27);
            this.label6.TabIndex = 5;
            this.label6.Tag = "5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
            this.label6.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.lable_MouseLeava);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(40, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 27);
            this.label5.TabIndex = 4;
            this.label5.Tag = "4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
            this.label5.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.lable_MouseLeava);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(40, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 27);
            this.label4.TabIndex = 3;
            this.label4.Tag = "3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
            this.label4.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.lable_MouseLeava);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 27);
            this.label3.TabIndex = 2;
            this.label3.Tag = "2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
            this.label3.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.lable_MouseLeava);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 27);
            this.label2.TabIndex = 1;
            this.label2.Tag = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
            this.label2.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.lable_MouseLeava);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 30);
            this.label1.TabIndex = 0;
            this.label1.Tag = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DoubleClick += new System.EventHandler(this.lable_DoubleClick);
            this.label1.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.lable_MouseLeava);
            // 
            // song_favourite
            // 
            this.song_favourite.BackColor = System.Drawing.Color.Transparent;
            this.song_favourite.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources.喜欢;
            this.song_favourite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.song_favourite.Location = new System.Drawing.Point(290, 96);
            this.song_favourite.Name = "song_favourite";
            this.song_favourite.Size = new System.Drawing.Size(30, 29);
            this.song_favourite.TabIndex = 14;
            this.song_favourite.TabStop = false;
            this.song_favourite.MouseLeave += new System.EventHandler(this.song_favourite_MouseLeave);
            this.song_favourite.MouseMove += new System.Windows.Forms.MouseEventHandler(this.song_favourite_MouseMove);
            // 
            // Skin
            // 
            this.Skin.AutoSize = true;
            this.Skin.BackColor = System.Drawing.Color.Transparent;
            this.Skin.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Skin.ForeColor = System.Drawing.Color.White;
            this.Skin.Image = global::JackLin_MusicPlayer.Properties.Resources.皮肤;
            this.Skin.Location = new System.Drawing.Point(369, 13);
            this.Skin.Name = "Skin";
            this.Skin.Size = new System.Drawing.Size(22, 14);
            this.Skin.TabIndex = 2;
            this.Skin.Text = "     ";
            this.Skin.Click += new System.EventHandler(this.Skin_Click);
            this.Skin.MouseLeave += new System.EventHandler(this.Skin_MouseLeave);
            this.Skin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Skin_MouseMove);
            // 
            // song_preview
            // 
            this.song_preview.BackColor = System.Drawing.Color.Transparent;
            this.song_preview.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources.上一首;
            this.song_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.song_preview.Location = new System.Drawing.Point(50, 96);
            this.song_preview.Name = "song_preview";
            this.song_preview.Size = new System.Drawing.Size(30, 29);
            this.song_preview.TabIndex = 10;
            this.song_preview.TabStop = false;
            this.song_preview.Click += new System.EventHandler(this.song_preview_Click);
            this.song_preview.MouseLeave += new System.EventHandler(this.song_preview_MouseLeave);
            this.song_preview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.song_preview_MouseMove);
            // 
            // song_next
            // 
            this.song_next.BackColor = System.Drawing.Color.Transparent;
            this.song_next.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources.下一首;
            this.song_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.song_next.Location = new System.Drawing.Point(210, 96);
            this.song_next.Name = "song_next";
            this.song_next.Size = new System.Drawing.Size(30, 29);
            this.song_next.TabIndex = 9;
            this.song_next.TabStop = false;
            this.song_next.Click += new System.EventHandler(this.song_next_Click);
            this.song_next.MouseLeave += new System.EventHandler(this.song_next_MouseLeave);
            this.song_next.MouseMove += new System.Windows.Forms.MouseEventHandler(this.song_next_MouseMove);
            // 
            // song_control
            // 
            this.song_control.BackColor = System.Drawing.Color.Transparent;
            this.song_control.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources.播放;
            this.song_control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.song_control.Location = new System.Drawing.Point(130, 96);
            this.song_control.Name = "song_control";
            this.song_control.Size = new System.Drawing.Size(30, 29);
            this.song_control.TabIndex = 8;
            this.song_control.TabStop = false;
            this.song_control.Click += new System.EventHandler(this.song_control_Click);
            this.song_control.MouseEnter += new System.EventHandler(this.song_control_MouseEnter);
            this.song_control.MouseLeave += new System.EventHandler(this.song_control_MouseLeave);
            // 
            // song_add
            // 
            this.song_add.BackColor = System.Drawing.Color.Transparent;
            this.song_add.BackgroundImage = global::JackLin_MusicPlayer.Properties.Resources.添加;
            this.song_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.song_add.Location = new System.Drawing.Point(370, 96);
            this.song_add.Name = "song_add";
            this.song_add.Size = new System.Drawing.Size(30, 29);
            this.song_add.TabIndex = 5;
            this.song_add.TabStop = false;
            this.song_add.Click += new System.EventHandler(this.song_add_Click);
            this.song_add.MouseLeave += new System.EventHandler(this.song_add_MouseLeave);
            this.song_add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.song_add_MouseMove);
            // 
            // window_close
            // 
            this.window_close.AutoSize = true;
            this.window_close.BackColor = System.Drawing.Color.Transparent;
            this.window_close.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.window_close.ForeColor = System.Drawing.Color.White;
            this.window_close.Image = global::JackLin_MusicPlayer.Properties.Resources.关闭1;
            this.window_close.Location = new System.Drawing.Point(422, 11);
            this.window_close.Name = "window_close";
            this.window_close.Size = new System.Drawing.Size(13, 20);
            this.window_close.TabIndex = 1;
            this.window_close.Text = " ";
            this.window_close.Click += new System.EventHandler(this.label2_Click);
            this.window_close.MouseLeave += new System.EventHandler(this.window_close_MouseLeave);
            this.window_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_close_MouseMove);
            // 
            // window_minisize
            // 
            this.window_minisize.AutoSize = true;
            this.window_minisize.BackColor = System.Drawing.Color.Transparent;
            this.window_minisize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.window_minisize.ForeColor = System.Drawing.Color.White;
            this.window_minisize.Image = global::JackLin_MusicPlayer.Properties.Resources.最小;
            this.window_minisize.Location = new System.Drawing.Point(393, 11);
            this.window_minisize.Name = "window_minisize";
            this.window_minisize.Size = new System.Drawing.Size(24, 17);
            this.window_minisize.TabIndex = 0;
            this.window_minisize.Text = "    ";
            this.window_minisize.Click += new System.EventHandler(this.label1_Click);
            this.window_minisize.MouseLeave += new System.EventHandler(this.window_minisize_MouseLeave);
            this.window_minisize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.window_minisize_MouseMove);
            // 
            // JackLin_MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 375);
            this.Controls.Add(this.Skin_panel);
            this.Controls.Add(this.song_all);
            this.Controls.Add(this.共有歌曲);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.song_panel);
            this.Controls.Add(this.song_favourite);
            this.Controls.Add(this.MusicPlayer);
            this.Controls.Add(this.Skin);
            this.Controls.Add(this.song_time1);
            this.Controls.Add(this.song_lasttime);
            this.Controls.Add(this.song_firsttime);
            this.Controls.Add(this.song_time);
            this.Controls.Add(this.song_preview);
            this.Controls.Add(this.song_next);
            this.Controls.Add(this.song_control);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.song_add);
            this.Controls.Add(this.window_close);
            this.Controls.Add(this.window_minisize);
            this.Controls.Add(this.song_namepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JackLin_MusicPlayer";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JackLin_MusicPlayer_FormClosing);
            this.Load += new System.EventHandler(this.JackLin_MusicPlayer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JackLin_MusicPlayer_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.sound.ResumeLayout(false);
            this.song_namepanel.ResumeLayout(false);
            this.song_namepanel.PerformLayout();
            this.Skin_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Skin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin1)).EndInit();
            this.song_panel.ResumeLayout(false);
            this.song_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.song_favourite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label window_minisize;
        private System.Windows.Forms.Label window_close;
        private System.Windows.Forms.Label Skin;
        private System.Windows.Forms.Panel Skin_panel;
        private System.Windows.Forms.PictureBox Skin1;
        private System.Windows.Forms.PictureBox Skin6;
        private System.Windows.Forms.PictureBox Skin5;
        private System.Windows.Forms.PictureBox Skin4;
        private System.Windows.Forms.PictureBox Skin3;
        private System.Windows.Forms.PictureBox Skin2;
        private System.Windows.Forms.Label MusicPlayer;
        private System.Windows.Forms.PictureBox song_add;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox song_control;
        private System.Windows.Forms.PictureBox song_next;
        private System.Windows.Forms.PictureBox song_preview;
        private System.Windows.Forms.Panel song_time;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label song_firsttime;
        private System.Windows.Forms.Label song_lasttime;
        private System.Windows.Forms.Panel song_time1;
        private System.Windows.Forms.PictureBox song_favourite;
        private System.Windows.Forms.Panel song_panel;
        private System.Windows.Forms.Panel sound;
        private System.Windows.Forms.Panel sound1;
        private System.Windows.Forms.PictureBox Skin9;
        private System.Windows.Forms.PictureBox Skin8;
        private System.Windows.Forms.PictureBox Skin7;
        private System.Windows.Forms.Label song_name;
        private System.Windows.Forms.Panel song_namepanel;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label 共有歌曲;
        private System.Windows.Forms.Label song_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label page_preview;
        private System.Windows.Forms.Label page_next;
        private System.Windows.Forms.Label song_page;
    }
}

