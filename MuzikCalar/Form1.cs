﻿using MuzikCalar.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Controls;

namespace MuzikCalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string kullaniciadi = Environment.UserName.ToString();
            this.Text = "Müzik Oynatıcı - Kullanıcı adı: " + kullaniciadi;
        }

        


        MP3Player pl = new MP3Player();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        bool muziklerYuklendi = false, muzik_Caliyor = false, Karistir = false, Tekrarla = false;
        List<string> OynatmaListesi = new List<string>();
        int MuzikDegisti = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tck_muzik_durum.MouseWheel += new MouseEventHandler(this.Tck_muzik_durum_MouseWheel);
        }
        private void Tck_muzik_durum_MouseWheel(object sender, MouseEventArgs e)
        {
            IleriGeriSar();
        }
        private void btn_Muzik_sec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3,*.mp4)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv;*.mp4";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Count(); i++)
                {
                    list_Muzik_Liste.Items.Add(openFileDialog1.SafeFileNames[i]);
                    OynatmaListesi.Add(openFileDialog1.FileNames[i]);
                }
                btn_muzik_oynat1.Enabled = true;
                btn_muzik_durdur1.Enabled = true;
                btn_duraklat.Enabled = true;
                muziklerYuklendi = true;
                btn_sonraki.Enabled = true;
                btn_onceki1.Enabled = true;
                btn_rastgele1.Enabled = true;
            }

        }
        private void btn_liste_temizle_Click(object sender, EventArgs e)
        {
            list_Muzik_Liste.Items.Clear();
            OynatmaListesi.Clear();
            pl.mp3_Kapat();
            btn_muzik_oynat1.Enabled = false;
            btn_muzik_durdur1.Enabled = false;
            btn_duraklat.Enabled = false;
            muziklerYuklendi = false;
            btn_sonraki.Enabled = false;
            btn_onceki1.Enabled = false;
            btn_rastgele1.Enabled = false;
            if (MessageBox.Show("Mecvut liste temzilendi. Yeni liste oluşturmak ister misiniz?", "Yeni Liste", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btn_Muzik_sec.PerformClick();
            }
        }
        private void btn_muzik_oynat_Click(object sender, EventArgs e)
        {
            try
            {
                muzikDegistirTemizle();

                if (pl.muzikDuraklatildi == true)
                {
                    pl.mp3_Oynat(Tekrarla);
                    pl.muzikDuraklatildi = false;
                }
                else
                {
                    if (muzik_Caliyor)
                    {
                        pl.mp3_Kapat();
                        muzik_Caliyor = false;
                    }
                    if (list_Muzik_Liste.SelectedIndex < 0)
                        list_Muzik_Liste.SelectedIndex = 0;



                    pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                    pl.mp3_Oynat(Tekrarla);
                    muzik_Caliyor = true;

                    label1.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                    pl.ToplamSure();
                    lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                    tck_muzik_durum.Maximum = pl._sn_ToplamSure;


                }
                MuzikDegisti = 0;
            }
            catch
            {

            }
        }
        private void btn_duraklat_Click(object sender, EventArgs e)
        {
            pl.mp3_Duraklat();
            pl.muzikDuraklatildi = true;
        }
        private void btn_muzik_durdur_Click(object sender, EventArgs e)
        {
            pl.mp3_Kapat();
            list_Muzik_Liste.SelectedIndex = 0;
            muzikDegistirTemizle();
        }
        private void btn_sonraki_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_onceki_Click(object sender, EventArgs e)
        {
           
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            muzikDegistirTemizle();
            try
            {
                label1.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                btn_muzik_oynat1.PerformClick();
            }
            catch (NullReferenceException)
            {
            }
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_Muzik_Liste.SelectedIndex >= 0)
                if (muziklerYuklendi)
                    if (pl.muzikDuraklatildi == true)
                    {
                        pl.mp3_Oynat(Tekrarla);
                        pl.muzikDuraklatildi = false;
                    }
                    else
                        btn_muzik_oynat1.PerformClick();
        }
        private void tck_ana_ses_Scroll(object sender, EventArgs e)
        {
            pl.AnaSes = tck_ana_ses.Value;
            if(tck_ana_ses.Value == 0)
            {
                pictureBox1.Image = Resources.icons8_mute_32;
            }
            else if (tck_ana_ses.Value == 100)
            {
                pictureBox1.Image = Resources.high;
            }
            else if (tck_ana_ses.Value >= 1 && tck_ana_ses.Value <= 50)
            {
                pictureBox1.Image = Resources.low;
            }
        }
        private void tck_sol_ses_Scroll(object sender, EventArgs e)
        {
            pl.SolSes = tck_sol_ses.Value;
        }
        private void tck_sag_ses_Scroll(object sender, EventArgs e)
        {
            pl.SagSes = tck_sag_ses.Value;
        }
        private void tck_bas_Scroll(object sender, EventArgs e)
        {
            pl.Bass = tck_bas.Value;
        }
        private void tck_tiz_Scroll(object sender, EventArgs e)
        {
            pl.Tiz = tck_tiz.Value;
        }
        private void tck_muzik_durum_Scroll(object sender, EventArgs e)
        {
            IleriGeriSar();
        }
        private void IleriGeriSar()
        {
            pl.mp3_Duraklat();
            double d = TimeSpan.FromSeconds(tck_muzik_durum.Value).TotalMilliseconds;
            pl.IleriGeriSar(d);
            pl.mp3_Oynat(Tekrarla);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chk_tekrarla.CheckState == CheckState.Checked)
                Tekrarla = true;
            else
                Tekrarla = false;

            if (chk_karistir.CheckState == CheckState.Checked)
                Karistir = true;
            else
                Karistir = false;




            if (muzik_Caliyor)
            {
                if (list_Muzik_Liste.Items.Count > 0)
                {
                    if (muziklerYuklendi & muzik_Caliyor)
                    {
                        pl.Pozisyon();
                        lbl_pozisyon_sn.Text = pl._st_Pozisyon.ToString();
                        tck_muzik_durum.Value = pl._sn_Pozisyon;
                        OtoMuzikDegistir();
                    }
                }
            }

        }
        private void OtoMuzikDegistir()
        {
            if (pl._sn_Pozisyon == pl._sn_ToplamSure & MuzikDegisti == 0 & Tekrarla == false)
            {
                try
                {
                    if (Karistir)
                    {
                        Karisik_Oynat();
                    }
                    else
                    {
                        list_Muzik_Liste.SelectedIndex += 1;
                    }
                    MuzikDegisti = 1;
                    btn_muzik_oynat1.PerformClick();
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }
        private void muzikDegistirTemizle()
        {
            label1.Text = "Çalan Müzik : ";
            lbl_pozisyon_sn.Text = "00:00:00";
            lbl_toplam_sn.Text = "00:00:00";
            tck_muzik_durum.Value = 0;
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i = list_Muzik_Liste.SelectedIndex;
                list_Muzik_Liste.Items.RemoveAt(i);
                OynatmaListesi.RemoveAt(i);
                list_Muzik_Liste.Refresh();
                if (muzik_Caliyor == true)
                {
                    pl.mp3_Kapat();

                    muzikDegistirTemizle();
                    muzik_Caliyor = false;
                }
            }
            catch
            {

            }
        }

        private void btn_muzik_oynat1_Click(object sender, EventArgs e)
        {
            try
            {
                muzikDegistirTemizle();

                if (pl.muzikDuraklatildi == true)
                {
                    pl.mp3_Oynat(Tekrarla);
                    pl.muzikDuraklatildi = false;
                }
                else
                {
                    if (muzik_Caliyor)
                    {
                        pl.mp3_Kapat();
                        muzik_Caliyor = false;
                        lbl_pozisyon_sn.Text = pl._st_Pozisyon.ToString();
                        tck_muzik_durum.Value = pl._sn_Pozisyon;
                    }
                    if (list_Muzik_Liste.SelectedIndex < 0)
                        list_Muzik_Liste.SelectedIndex = 0;



                    pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                    pl.mp3_Oynat(Tekrarla);
                    muzik_Caliyor = true;

                    label1.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                    pl.ToplamSure();
                    lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                    tck_muzik_durum.Maximum = pl._sn_ToplamSure;


                }
                MuzikDegisti = 0;
                lbl_pozisyon_sn.Text = pl._st_Pozisyon.ToString();
                tck_muzik_durum.Value = pl._sn_Pozisyon;
            }
            catch
            {

            }
        }

        private void btn_sonraki1_Click(object sender, EventArgs e)
        {
            muzikDegistirTemizle();
            pl.mp3_Kapat();
            if (Karistir)
            {
                Karisik_Oynat();
            }
            else
            {
                try
                {
                    list_Muzik_Liste.SelectedIndex += 1;
                    pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                    label1.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Müzik Listesinin Sonu");
                }
            }
            pl.mp3_Oynat(Tekrarla);
            pl.ToplamSure();
            lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
            tck_muzik_durum.Maximum = pl._sn_ToplamSure;
        }

        private void btn_onceki1_Click(object sender, EventArgs e)
        {
            muzikDegistirTemizle();
            pl.mp3_Kapat();

            if (Karistir)
            {
                Karisik_Oynat();
            }
            else
            {
                try
                {
                    list_Muzik_Liste.SelectedIndex -= 1;
                    pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                    label1.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Müzik Listesinin Başı");
                }
            }

            pl.mp3_Oynat(Tekrarla);
            pl.ToplamSure();
            lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
            tck_muzik_durum.Maximum = pl._sn_ToplamSure;
        }

        private void btn_rastgele1_Click(object sender, EventArgs e)
        {
            Karisik_Oynat();
        }

        private void btn_duraklat1_Click(object sender, EventArgs e)
        {
            pl.mp3_Duraklat();
            pl.muzikDuraklatildi = true;
            lbl_pozisyon_sn.Text = pl._st_Pozisyon.ToString();
            tck_muzik_durum.Value = pl._sn_Pozisyon;
        }

        private void btn_muzik_durdur1_Click(object sender, EventArgs e)
        {
            pl.mp3_Kapat();
            list_Muzik_Liste.SelectedIndex = 0;
            muzikDegistirTemizle();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tck_ana_ses.Value != 0)
                {
                    tck_ana_ses.Value = 0;
                    pl.AnaSes = 0;
                    pictureBox1.Image = Resources.icons8_mute_32;
                }
                else
                {
                    tck_ana_ses.Value = 100;
                    pl.AnaSes = 100;
                    pictureBox1.Image = Resources.high;
                }
            }
            catch
            {

            }
        }

        private void downloadtoolbtn_Click(object sender, EventArgs e)
        {
            Downloader donwldr = new Downloader();
            donwldr.Show();
        }

        private void btn_rastgele_Click(object sender, EventArgs e)
        {
            Karisik_Oynat();
        }
        private void Karisik_Oynat()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, OynatmaListesi.Count() - 1);
            list_Muzik_Liste.SelectedIndex = i;
            btn_muzik_oynat1.PerformClick();
        }
        private void list_Musik_Liste_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                list_Muzik_Liste.SelectedIndex = list_Muzik_Liste.IndexFromPoint(e.X, e.Y);
            else { }
        }
    }
}
