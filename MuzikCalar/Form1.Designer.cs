namespace MuzikCalar
{//https://mustafabukulmez.com/2019/01/09/c-mp3-calar-uygulamasi-mcisendstring/
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list_Muzik_Liste = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.downloadtoolbtn = new System.Windows.Forms.Button();
            this.btn_Muzik_sec = new System.Windows.Forms.Button();
            this.btn_liste_temizle = new System.Windows.Forms.Button();
            this.tck_sol_ses = new System.Windows.Forms.TrackBar();
            this.tck_bas = new System.Windows.Forms.TrackBar();
            this.lbl_sol_ses = new System.Windows.Forms.Label();
            this.tck_ana_ses = new System.Windows.Forms.TrackBar();
            this.tck_sag_ses = new System.Windows.Forms.TrackBar();
            this.lbl_sag_ses = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ana_ses = new System.Windows.Forms.Label();
            this.tck_tiz = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_toplam_sn = new System.Windows.Forms.Label();
            this.lbl_pozisyon_sn = new System.Windows.Forms.Label();
            this.btn_muzik_durdur1 = new System.Windows.Forms.Button();
            this.btn_duraklat = new System.Windows.Forms.Button();
            this.btn_rastgele1 = new System.Windows.Forms.Button();
            this.btn_onceki1 = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_muzik_oynat1 = new System.Windows.Forms.Button();
            this.chk_tekrarla = new System.Windows.Forms.CheckBox();
            this.chk_karistir = new System.Windows.Forms.CheckBox();
            this.grp_muziksss = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tck_muzik_durum = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_muziksss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).BeginInit();
            this.SuspendLayout();
            // 
            // list_Muzik_Liste
            // 
            this.list_Muzik_Liste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.list_Muzik_Liste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_Muzik_Liste.ContextMenuStrip = this.contextMenuStrip1;
            this.list_Muzik_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Muzik_Liste.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.list_Muzik_Liste.ForeColor = System.Drawing.SystemColors.Control;
            this.list_Muzik_Liste.FormattingEnabled = true;
            this.list_Muzik_Liste.ItemHeight = 17;
            this.list_Muzik_Liste.Location = new System.Drawing.Point(0, 61);
            this.list_Muzik_Liste.Margin = new System.Windows.Forms.Padding(2);
            this.list_Muzik_Liste.Name = "list_Muzik_Liste";
            this.list_Muzik_Liste.Size = new System.Drawing.Size(703, 332);
            this.list_Muzik_Liste.TabIndex = 5;
            this.list_Muzik_Liste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.list_Muzik_Liste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            this.list_Muzik_Liste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Musik_Liste_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.list_Muzik_Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tck_sol_ses);
            this.splitContainer1.Panel2.Controls.Add(this.tck_bas);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_sol_ses);
            this.splitContainer1.Panel2.Controls.Add(this.tck_ana_ses);
            this.splitContainer1.Panel2.Controls.Add(this.tck_sag_ses);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_sag_ses);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_ana_ses);
            this.splitContainer1.Panel2.Controls.Add(this.tck_tiz);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(1063, 393);
            this.splitContainer1.SplitterDistance = 703;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.downloadtoolbtn);
            this.panel2.Controls.Add(this.btn_Muzik_sec);
            this.panel2.Controls.Add(this.btn_liste_temizle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 61);
            this.panel2.TabIndex = 6;
            // 
            // downloadtoolbtn
            // 
            this.downloadtoolbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.downloadtoolbtn.FlatAppearance.BorderSize = 0;
            this.downloadtoolbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadtoolbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.downloadtoolbtn.Image = ((System.Drawing.Image)(resources.GetObject("downloadtoolbtn.Image")));
            this.downloadtoolbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downloadtoolbtn.Location = new System.Drawing.Point(521, -1);
            this.downloadtoolbtn.Margin = new System.Windows.Forms.Padding(2);
            this.downloadtoolbtn.Name = "downloadtoolbtn";
            this.downloadtoolbtn.Size = new System.Drawing.Size(182, 61);
            this.downloadtoolbtn.TabIndex = 4;
            this.downloadtoolbtn.Text = "MP3/MP4 İndir";
            this.downloadtoolbtn.UseVisualStyleBackColor = false;
            this.downloadtoolbtn.Click += new System.EventHandler(this.downloadtoolbtn_Click);
            // 
            // btn_Muzik_sec
            // 
            this.btn_Muzik_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Muzik_sec.FlatAppearance.BorderSize = 0;
            this.btn_Muzik_sec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Muzik_sec.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Muzik_sec.Image = ((System.Drawing.Image)(resources.GetObject("btn_Muzik_sec.Image")));
            this.btn_Muzik_sec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Muzik_sec.Location = new System.Drawing.Point(0, -1);
            this.btn_Muzik_sec.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Muzik_sec.Name = "btn_Muzik_sec";
            this.btn_Muzik_sec.Size = new System.Drawing.Size(319, 61);
            this.btn_Muzik_sec.TabIndex = 2;
            this.btn_Muzik_sec.Text = "Müzik Ekle";
            this.btn_Muzik_sec.UseVisualStyleBackColor = false;
            this.btn_Muzik_sec.Click += new System.EventHandler(this.btn_Muzik_sec_Click);
            // 
            // btn_liste_temizle
            // 
            this.btn_liste_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_liste_temizle.FlatAppearance.BorderSize = 0;
            this.btn_liste_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_liste_temizle.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_liste_temizle.Image = ((System.Drawing.Image)(resources.GetObject("btn_liste_temizle.Image")));
            this.btn_liste_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_liste_temizle.Location = new System.Drawing.Point(321, -2);
            this.btn_liste_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_liste_temizle.Name = "btn_liste_temizle";
            this.btn_liste_temizle.Size = new System.Drawing.Size(198, 63);
            this.btn_liste_temizle.TabIndex = 3;
            this.btn_liste_temizle.Text = "Listeyi Temizle";
            this.btn_liste_temizle.UseVisualStyleBackColor = false;
            this.btn_liste_temizle.Click += new System.EventHandler(this.btn_liste_temizle_Click);
            // 
            // tck_sol_ses
            // 
            this.tck_sol_ses.Location = new System.Drawing.Point(16, 25);
            this.tck_sol_ses.Margin = new System.Windows.Forms.Padding(2);
            this.tck_sol_ses.Maximum = 100;
            this.tck_sol_ses.Name = "tck_sol_ses";
            this.tck_sol_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sol_ses.Size = new System.Drawing.Size(45, 342);
            this.tck_sol_ses.TabIndex = 15;
            this.tck_sol_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sol_ses.Value = 100;
            this.tck_sol_ses.Scroll += new System.EventHandler(this.tck_sol_ses_Scroll);
            // 
            // tck_bas
            // 
            this.tck_bas.Location = new System.Drawing.Point(226, 25);
            this.tck_bas.Margin = new System.Windows.Forms.Padding(2);
            this.tck_bas.Maximum = 100;
            this.tck_bas.Name = "tck_bas";
            this.tck_bas.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_bas.Size = new System.Drawing.Size(45, 342);
            this.tck_bas.TabIndex = 21;
            this.tck_bas.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_bas.Value = 100;
            this.tck_bas.Scroll += new System.EventHandler(this.tck_bas_Scroll);
            // 
            // lbl_sol_ses
            // 
            this.lbl_sol_ses.AutoSize = true;
            this.lbl_sol_ses.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.lbl_sol_ses.Location = new System.Drawing.Point(22, 366);
            this.lbl_sol_ses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sol_ses.Name = "lbl_sol_ses";
            this.lbl_sol_ses.Size = new System.Drawing.Size(29, 19);
            this.lbl_sol_ses.TabIndex = 17;
            this.lbl_sol_ses.Text = "Sol";
            // 
            // tck_ana_ses
            // 
            this.tck_ana_ses.Location = new System.Drawing.Point(157, 25);
            this.tck_ana_ses.Margin = new System.Windows.Forms.Padding(2);
            this.tck_ana_ses.Maximum = 100;
            this.tck_ana_ses.Name = "tck_ana_ses";
            this.tck_ana_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_ana_ses.Size = new System.Drawing.Size(45, 342);
            this.tck_ana_ses.TabIndex = 12;
            this.tck_ana_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_ana_ses.Value = 100;
            this.tck_ana_ses.Scroll += new System.EventHandler(this.tck_ana_ses_Scroll);
            // 
            // tck_sag_ses
            // 
            this.tck_sag_ses.Location = new System.Drawing.Point(86, 25);
            this.tck_sag_ses.Margin = new System.Windows.Forms.Padding(2);
            this.tck_sag_ses.Maximum = 100;
            this.tck_sag_ses.Name = "tck_sag_ses";
            this.tck_sag_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sag_ses.Size = new System.Drawing.Size(45, 342);
            this.tck_sag_ses.TabIndex = 18;
            this.tck_sag_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sag_ses.Value = 100;
            this.tck_sag_ses.Scroll += new System.EventHandler(this.tck_sag_ses_Scroll);
            // 
            // lbl_sag_ses
            // 
            this.lbl_sag_ses.AutoSize = true;
            this.lbl_sag_ses.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.lbl_sag_ses.Location = new System.Drawing.Point(93, 366);
            this.lbl_sag_ses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sag_ses.Name = "lbl_sag_ses";
            this.lbl_sag_ses.Size = new System.Drawing.Size(32, 19);
            this.lbl_sag_ses.TabIndex = 20;
            this.lbl_sag_ses.Text = "Sağ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(232, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_ana_ses
            // 
            this.lbl_ana_ses.AutoSize = true;
            this.lbl_ana_ses.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ana_ses.Location = new System.Drawing.Point(150, 365);
            this.lbl_ana_ses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ana_ses.Name = "lbl_ana_ses";
            this.lbl_ana_ses.Size = new System.Drawing.Size(58, 19);
            this.lbl_ana_ses.TabIndex = 14;
            this.lbl_ana_ses.Text = "Ana Ses";
            // 
            // tck_tiz
            // 
            this.tck_tiz.Location = new System.Drawing.Point(290, 25);
            this.tck_tiz.Margin = new System.Windows.Forms.Padding(2);
            this.tck_tiz.Maximum = 100;
            this.tck_tiz.Name = "tck_tiz";
            this.tck_tiz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_tiz.Size = new System.Drawing.Size(45, 342);
            this.tck_tiz.TabIndex = 24;
            this.tck_tiz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_tiz.Value = 100;
            this.tck_tiz.Scroll += new System.EventHandler(this.tck_tiz_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(297, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tiz";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_toplam_sn);
            this.panel1.Controls.Add(this.lbl_pozisyon_sn);
            this.panel1.Controls.Add(this.btn_muzik_durdur1);
            this.panel1.Controls.Add(this.btn_duraklat);
            this.panel1.Controls.Add(this.btn_rastgele1);
            this.panel1.Controls.Add(this.btn_onceki1);
            this.panel1.Controls.Add(this.btn_sonraki);
            this.panel1.Controls.Add(this.btn_muzik_oynat1);
            this.panel1.Controls.Add(this.chk_tekrarla);
            this.panel1.Controls.Add(this.chk_karistir);
            this.panel1.Controls.Add(this.grp_muziksss);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 145);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(245, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tam Süre :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(232, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Geçen Süre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MuzikCalar.Properties.Resources.high;
            this.pictureBox1.Location = new System.Drawing.Point(17, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_toplam_sn
            // 
            this.lbl_toplam_sn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_toplam_sn.AutoSize = true;
            this.lbl_toplam_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toplam_sn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.lbl_toplam_sn.Location = new System.Drawing.Point(320, 113);
            this.lbl_toplam_sn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam_sn.Name = "lbl_toplam_sn";
            this.lbl_toplam_sn.Size = new System.Drawing.Size(63, 19);
            this.lbl_toplam_sn.TabIndex = 31;
            this.lbl_toplam_sn.Text = "00:00:00";
            this.lbl_toplam_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pozisyon_sn
            // 
            this.lbl_pozisyon_sn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pozisyon_sn.AutoSize = true;
            this.lbl_pozisyon_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pozisyon_sn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.lbl_pozisyon_sn.Location = new System.Drawing.Point(320, 84);
            this.lbl_pozisyon_sn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pozisyon_sn.Name = "lbl_pozisyon_sn";
            this.lbl_pozisyon_sn.Size = new System.Drawing.Size(63, 19);
            this.lbl_pozisyon_sn.TabIndex = 30;
            this.lbl_pozisyon_sn.Text = "00:00:00";
            this.lbl_pozisyon_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_muzik_durdur1
            // 
            this.btn_muzik_durdur1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_muzik_durdur1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_muzik_durdur1.Enabled = false;
            this.btn_muzik_durdur1.FlatAppearance.BorderSize = 0;
            this.btn_muzik_durdur1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_durdur1.Image = ((System.Drawing.Image)(resources.GetObject("btn_muzik_durdur1.Image")));
            this.btn_muzik_durdur1.Location = new System.Drawing.Point(707, 86);
            this.btn_muzik_durdur1.Name = "btn_muzik_durdur1";
            this.btn_muzik_durdur1.Size = new System.Drawing.Size(47, 47);
            this.btn_muzik_durdur1.TabIndex = 43;
            this.btn_muzik_durdur1.UseVisualStyleBackColor = false;
            this.btn_muzik_durdur1.Click += new System.EventHandler(this.btn_muzik_durdur1_Click);
            // 
            // btn_duraklat
            // 
            this.btn_duraklat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_duraklat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_duraklat.Enabled = false;
            this.btn_duraklat.FlatAppearance.BorderSize = 0;
            this.btn_duraklat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duraklat.Image = ((System.Drawing.Image)(resources.GetObject("btn_duraklat.Image")));
            this.btn_duraklat.Location = new System.Drawing.Point(599, 87);
            this.btn_duraklat.Name = "btn_duraklat";
            this.btn_duraklat.Size = new System.Drawing.Size(47, 47);
            this.btn_duraklat.TabIndex = 42;
            this.btn_duraklat.UseVisualStyleBackColor = false;
            this.btn_duraklat.Click += new System.EventHandler(this.btn_duraklat1_Click);
            // 
            // btn_rastgele1
            // 
            this.btn_rastgele1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rastgele1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_rastgele1.Enabled = false;
            this.btn_rastgele1.FlatAppearance.BorderSize = 0;
            this.btn_rastgele1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rastgele1.Image = ((System.Drawing.Image)(resources.GetObject("btn_rastgele1.Image")));
            this.btn_rastgele1.Location = new System.Drawing.Point(440, 87);
            this.btn_rastgele1.Name = "btn_rastgele1";
            this.btn_rastgele1.Size = new System.Drawing.Size(47, 47);
            this.btn_rastgele1.TabIndex = 41;
            this.btn_rastgele1.UseVisualStyleBackColor = false;
            this.btn_rastgele1.Click += new System.EventHandler(this.btn_rastgele1_Click);
            // 
            // btn_onceki1
            // 
            this.btn_onceki1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_onceki1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_onceki1.Enabled = false;
            this.btn_onceki1.FlatAppearance.BorderSize = 0;
            this.btn_onceki1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onceki1.Image = ((System.Drawing.Image)(resources.GetObject("btn_onceki1.Image")));
            this.btn_onceki1.Location = new System.Drawing.Point(493, 87);
            this.btn_onceki1.Name = "btn_onceki1";
            this.btn_onceki1.Size = new System.Drawing.Size(47, 47);
            this.btn_onceki1.TabIndex = 40;
            this.btn_onceki1.UseVisualStyleBackColor = false;
            this.btn_onceki1.Click += new System.EventHandler(this.btn_onceki1_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sonraki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_sonraki.Enabled = false;
            this.btn_sonraki.FlatAppearance.BorderSize = 0;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Image = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.Image")));
            this.btn_sonraki.Location = new System.Drawing.Point(654, 87);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(47, 47);
            this.btn_sonraki.TabIndex = 39;
            this.btn_sonraki.UseVisualStyleBackColor = false;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki1_Click);
            // 
            // btn_muzik_oynat1
            // 
            this.btn_muzik_oynat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_muzik_oynat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_muzik_oynat1.Enabled = false;
            this.btn_muzik_oynat1.FlatAppearance.BorderSize = 0;
            this.btn_muzik_oynat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_oynat1.Image = ((System.Drawing.Image)(resources.GetObject("btn_muzik_oynat1.Image")));
            this.btn_muzik_oynat1.Location = new System.Drawing.Point(546, 87);
            this.btn_muzik_oynat1.Name = "btn_muzik_oynat1";
            this.btn_muzik_oynat1.Size = new System.Drawing.Size(47, 47);
            this.btn_muzik_oynat1.TabIndex = 38;
            this.btn_muzik_oynat1.UseVisualStyleBackColor = false;
            this.btn_muzik_oynat1.Click += new System.EventHandler(this.btn_muzik_oynat1_Click);
            // 
            // chk_tekrarla
            // 
            this.chk_tekrarla.AutoSize = true;
            this.chk_tekrarla.Location = new System.Drawing.Point(105, 113);
            this.chk_tekrarla.Margin = new System.Windows.Forms.Padding(2);
            this.chk_tekrarla.Name = "chk_tekrarla";
            this.chk_tekrarla.Size = new System.Drawing.Size(99, 17);
            this.chk_tekrarla.TabIndex = 37;
            this.chk_tekrarla.Text = "Şarkıyı Tekrarla";
            this.chk_tekrarla.UseVisualStyleBackColor = true;
            // 
            // chk_karistir
            // 
            this.chk_karistir.AutoSize = true;
            this.chk_karistir.Location = new System.Drawing.Point(105, 91);
            this.chk_karistir.Margin = new System.Windows.Forms.Padding(2);
            this.chk_karistir.Name = "chk_karistir";
            this.chk_karistir.Size = new System.Drawing.Size(57, 17);
            this.chk_karistir.TabIndex = 36;
            this.chk_karistir.Text = "Karıştır";
            this.chk_karistir.UseVisualStyleBackColor = true;
            // 
            // grp_muziksss
            // 
            this.grp_muziksss.Controls.Add(this.label1);
            this.grp_muziksss.Controls.Add(this.tck_muzik_durum);
            this.grp_muziksss.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_muziksss.Location = new System.Drawing.Point(0, 0);
            this.grp_muziksss.Margin = new System.Windows.Forms.Padding(2);
            this.grp_muziksss.Name = "grp_muziksss";
            this.grp_muziksss.Padding = new System.Windows.Forms.Padding(2);
            this.grp_muziksss.Size = new System.Drawing.Size(1063, 72);
            this.grp_muziksss.TabIndex = 34;
            this.grp_muziksss.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Çalan Müzik :";
            // 
            // tck_muzik_durum
            // 
            this.tck_muzik_durum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tck_muzik_durum.Location = new System.Drawing.Point(4, 10);
            this.tck_muzik_durum.Margin = new System.Windows.Forms.Padding(2);
            this.tck_muzik_durum.Maximum = 500;
            this.tck_muzik_durum.Name = "tck_muzik_durum";
            this.tck_muzik_durum.Size = new System.Drawing.Size(1038, 45);
            this.tck_muzik_durum.TabIndex = 4;
            this.tck_muzik_durum.Scroll += new System.EventHandler(this.tck_muzik_durum_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1063, 538);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1079, 577);
            this.MinimumSize = new System.Drawing.Size(1079, 577);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müzik Çalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_muziksss.ResumeLayout(false);
            this.grp_muziksss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Muzik_sec;
        private System.Windows.Forms.ListBox list_Muzik_Liste;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar tck_ana_ses;
        private System.Windows.Forms.Label lbl_ana_ses;
        private System.Windows.Forms.Label lbl_sol_ses;
        private System.Windows.Forms.TrackBar tck_sol_ses;
        private System.Windows.Forms.Label lbl_sag_ses;
        private System.Windows.Forms.TrackBar tck_sag_ses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tck_tiz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tck_bas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_liste_temizle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_tekrarla;
        private System.Windows.Forms.CheckBox chk_karistir;
        private System.Windows.Forms.Button btn_muzik_oynat1;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_onceki1;
        private System.Windows.Forms.Button btn_rastgele1;
        private System.Windows.Forms.Button btn_duraklat;
        private System.Windows.Forms.Button btn_muzik_durdur1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grp_muziksss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_toplam_sn;
        private System.Windows.Forms.Label lbl_pozisyon_sn;
        private System.Windows.Forms.TrackBar tck_muzik_durum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button downloadtoolbtn;
    }
}

//https://mustafabukulmez.com/2019/01/09/c-mp3-calar-uygulamasi-mcisendstring/