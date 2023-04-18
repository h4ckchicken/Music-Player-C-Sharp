using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Diagnostics;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;
using System.IO;

namespace MuzikCalar
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();
        }

        private void Downloader_Load(object sender, EventArgs e)
        {
        }

        private void DownloadVideoButton2_Click(object sender, EventArgs e)
        {
            SearchButton2.Enabled = false;
            DownloadVideoButton2.Enabled = true;
            var youtube = new YoutubeClient();
            DownloadVideo2(youtube, SearchBox2.Text); ;
            DownloadVideoButton2.Enabled = false;
            SearchButton2.Enabled = false;
        }

        private async void DownloadVideo2(YoutubeClient youtube, string url)
        {
            try
            {
                info.Text = "İndirme Başladı...";
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                var video = await youtube.Videos.GetAsync(url);
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                var audioStreamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();
                var streamInfos = new IStreamInfo[] { audioStreamInfo };
                String videoName = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\" + video.Title + ".mp3";
                await youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder(videoName).Build());
                new ToastContentBuilder().AddText("Müzik Başarıyla İndirildi!").AddAppLogoOverride(new Uri("file:///" + Path.GetFullPath(@"icon.ico"), UriKind.Absolute), ToastGenericAppLogoCrop.Circle); Show();
                SearchButton2.Enabled = true;
                DownloadVideoButton2.Enabled = true;
                SearchButton2.Enabled = true;
                if (check2.Checked == true)
                {
                    Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
                }
                else
                {
                    //bişe yapma!
                }
            }
            catch (Exception ex)
            {
                new ToastContentBuilder().AddText(ex.Message); Show();
                SearchButton2.Enabled = true;
                info.Text = "";
            }

            info.Text = "İndirme Tamamlandı!";
        }

        private void OpenFileButton2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }

        private async void SearchButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SearchButton2.Enabled = false;
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(Clipboard.GetText());
                SearchBox2.Text = Clipboard.GetText();
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(SearchBox2.Text);
                VideoTitle2.Text = video.Title.ToString();
                VideoAuthor2.Text = video.Author.ChannelTitle;
                VideoDuration2.Text = video.Duration.ToString();
                VideoUrl2.Text = video.Url.ToString();
                ThumbnailBox2.ImageLocation = "https://img.youtube.com/vi/" + video.Id + "/hqdefault.jpg";
                DownloadVideoButton2.Enabled = true;
                SearchButton2.Enabled = true;
                check2.Enabled = true;
                button1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lütfen Linki Kontrol Edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchButton2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoTitle2.Text = null;
            VideoAuthor2.Text = null;
            VideoDuration2.Text = null;
            VideoUrl2.Text = null;
            ThumbnailBox2.ImageLocation = null;
            DownloadVideoButton2.Enabled = false;
            SearchBox2.Text = null;
            check2.Enabled = false;
            check2.Checked = false;
            button1.Enabled = false;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            VideoTitle.Text = null;
            VideoAuthor.Text = null;
            VideoDuration.Text = null;
            VideoUrl.Text = null;
            ThumbnailBox.ImageLocation = null;
            DownloadVideoButton.Enabled = false;
            SearchBox.Text = null;
            check1.Enabled = false;
            check1.Checked = false;
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            clearbutton.Enabled = false;
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SearchButton.Enabled = false;
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(Clipboard.GetText());
                SearchBox.Text = Clipboard.GetText();
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(SearchBox.Text);
                VideoTitle.Text = video.Title.ToString();
                VideoAuthor.Text = video.Author.ChannelTitle;
                VideoDuration.Text = video.Duration.ToString();
                VideoUrl.Text = video.Url.ToString();
                DownloadVideoButton.Enabled = true;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("144p");
                comboBox1.Items.Add("240p");
                comboBox1.Items.Add("360p");
                comboBox1.Items.Add("720p");
                ThumbnailBox.ImageLocation = "https://img.youtube.com/vi/" + video.Id + "/hqdefault.jpg";
                SearchButton.Enabled = true;
                check1.Enabled = true;
                clearbutton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lütfen Linki Kontrol Edin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchButton.Enabled = true;
            }
        }

        private void DownloadVideoButton_Click(object sender, EventArgs e)
        {
            SearchButton.Enabled = false;
            DownloadVideoButton.Enabled = true;
            var youtube = new YoutubeClient();
            DownloadVideo(youtube, SearchBox.Text);
            DownloadVideoButton.Enabled = false;
            SearchButton.Enabled = false;
        }

        private async void DownloadVideo(YoutubeClient youtube, string url)
        {
            try
            {
                info2.Text = "İndirme Başladı...";
                DateTime bugun = DateTime.Now;
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                var video = await youtube.Videos.GetAsync(url);
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                var audioStreamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();
                var videoStreamInfo = streamManifest.GetVideoStreams().First(s => s.VideoQuality.Label == comboBox1.SelectedItem.ToString());
                var streamInfos = new IStreamInfo[] { audioStreamInfo, videoStreamInfo };
                String videoName = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) + "\\" + video.Title + ".mp4";
                await youtube.Videos.DownloadAsync(streamInfos, new ConversionRequestBuilder(videoName).Build());
                new ToastContentBuilder().AddText("Video Başarıyla İndirildi!").AddAppLogoOverride(new Uri("file:///" + Path.GetFullPath(@"icon.ico"), UriKind.Absolute), ToastGenericAppLogoCrop.Circle); Show();
                SearchButton.Enabled = true;
                DownloadVideoButton.Enabled = true;
                if (check1.Checked == true)
                {
                    Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
                }
                else
                {
                    //bişe yapma!
                }
                info2.Text = "İndirme Tamamlandı!";
            }
            catch (Exception ex)
            {
                new ToastContentBuilder().AddText(ex.Message); Show();
                MessageBox.Show("Lütfen Linki Kontrol Edin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SearchButton.Enabled = true;
                DownloadVideoButton.Enabled = true;
                info2.Text = "";
            }


        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }
    }
}
