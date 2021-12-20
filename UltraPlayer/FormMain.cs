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
using TagLib;
using NAudio;
using NAudio.Wave;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using NAudio.WaveFormRenderer;

namespace UltraPlayer
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        List<FileInfo> files = new List<FileInfo>();
        int playerState = 0;
        Thread playMusic = null;
        

        public FormMain()
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
            playerState = 1;

            TagLib.File tagFile = TagLib.File.Create(file.FullName);
            string artist = tagFile.Tag.FirstPerformer;
            string album = tagFile.Tag.Album;
            string title = tagFile.Tag.Title;

            songTitle.Text = title;
            songArtists.Text = artist;

            AudioFileReader audioFileReader = new AudioFileReader(file.FullName);

            // Calculate new position
            long newPos = audioFileReader.Position + (long)(audioFileReader.WaveFormat.AverageBytesPerSecond * 2.5);
            // Force it to align to a block boundary
            if ((newPos % audioFileReader.WaveFormat.BlockAlign) != 0)
                newPos -= newPos % audioFileReader.WaveFormat.BlockAlign;
            // Force new position into valid range
            newPos = Math.Max(0, Math.Min(audioFileReader.Length, newPos));
            // set position
            audioFileReader.Position = newPos;

            Console.WriteLine(newPos);
            
            


            DateTime dateTime = DateTime.ParseExact(audioFileReader.TotalTime.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
            lbNow.Text = audioFileReader.CurrentTime.ToString();
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


            IWavePlayer wavePlayer = new WaveOut();
            wavePlayer.Init(audioFileReader);   
            wavePlayer.Play();


            //var maxPeakProvider = new MaxPeakProvider();
            //var rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            //var samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            //var averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

            musicProgressBar.EditValue = 30;
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
                
                playerState = 0;
            }
            else
            {
                
                playerState = 1;
            }

        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedIndex = fileList.SelectedIndex;
            if (selectedIndex == fileList.Items.Count - 1) return;

            int nextIndex = selectedIndex + 1;
            fileList.SelectedIndex = nextIndex;
            FileInfo file = files[nextIndex];
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int selectedIndex = fileList.SelectedIndex;
            if (selectedIndex == 0) return;

            int nextIndex = selectedIndex - 1;
            fileList.SelectedIndex = nextIndex;
            FileInfo file = files[nextIndex];
           
        }

        private void musicProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
