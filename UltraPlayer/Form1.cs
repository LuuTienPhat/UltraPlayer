using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using TagLib;
using NAudio;
using NAudio.Wave;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace UltraPlayer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<FileInfo> files = new List<FileInfo>();
        WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
        int playerState = 0;
        Thread playMusic = null;
        

        public Form1()
        {
            InitializeComponent();
            songArtists.Text = "";
            songTitle.Text = "";
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sidePanel2_Click(object sender, EventArgs e)
        {


        }

        private void fileList_Click(object sender, EventArgs e)
        {
            if (fileList.Items.Count != 0) return;

            openFilesDialog.FileName = "";
            openFilesDialog.Multiselect = true;

            if (openFilesDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFilesDialog.FileNames)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    files.Add(fileInfo);
                    fileList.Items.Add(fileInfo.Name);
                }
            }
        }

        private void fileList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int i = fileList.SelectedIndex;
            FileInfo file = files[i];

            myplayer.URL = file.FullName;
            myplayer.controls.play();
            playerState = 1;

            TagLib.File tagFile = TagLib.File.Create(file.FullName);
            string artist = tagFile.Tag.FirstPerformer;
            string album = tagFile.Tag.Album;
            string title = tagFile.Tag.Title;

            songTitle.Text = title;
            songArtists.Text = artist;

            AudioFileReader fileReader = new AudioFileReader(file.FullName);
            
            

            DateTime dateTime = DateTime.ParseExact(fileReader.TotalTime.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
            lbNow.Text = fileReader.CurrentTime.ToString();
            lbDuration.Text = dateTime.ToString("mm:ss");

            
            var mStream = new MemoryStream();
            var firstPicture = tagFile.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                songCover.Image = bm;
            }
            else
            {
                // set "no cover" image
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (playerState == 1)
            {
                myplayer.controls.pause();
                playerState = 0;
            }
            else
            {
                myplayer.controls.play();
                playerState = 1;
            }

        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                myplayer.close();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            myplayer.close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedIndex = fileList.SelectedIndex;
            if (selectedIndex == fileList.Items.Count - 1) return;

            int nextIndex = selectedIndex + 1;
            fileList.SelectedIndex = nextIndex;
            FileInfo file = files[nextIndex];
            myplayer.controls.stop();
            myplayer.URL = file.FullName;
            myplayer.controls.play();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int selectedIndex = fileList.SelectedIndex;
            if (selectedIndex == 0) return;

            int nextIndex = selectedIndex - 1;
            fileList.SelectedIndex = nextIndex;
            FileInfo file = files[nextIndex];
            myplayer.controls.stop();
            myplayer.URL = file.FullName;
            myplayer.controls.play();
        }
    }
}
