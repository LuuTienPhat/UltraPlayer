using DevExpress.XtraEditors;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UltraPlayer
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        private List<FileInfo> files = new List<FileInfo>();
        private Player player;
        private TagLib.File tagFile;


        public FormMain()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            songArtists.Text = "";
            songTitle.Text = "";
            lbNumberOfSongs.Text = "";

            openFileDialog.FileName = "";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Music Files |*.flac; *.mp3; *.wav; *.wma; *.aac; *.m4a |All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
        }

        private void browseFiles()
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        files.Add(fileInfo);
                        fileList.Items.Add(fileInfo.Name);
                    }
                }

                displayNumberOfSongs();
                lbBrowseFiles.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fileList_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileList.Items.Count == 0)
                {
                    browseFiles();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (files.Count == 0) return;

            try
            {
                int i = fileList.SelectedIndex;
                FileInfo file = files[i];
                PlayMusic(file);

                //DateTime dateTime = DateTime.ParseExact(audioFileReader.TotalTime.ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);
                //lbNow.Text = audioFileReader.CurrentTime.ToString();
                //lbDuration.Text = dateTime.ToString("mm:ss");





                //IWavePlayer wavePlayer = new WaveOut();
                //wavePlayer.Init(audioFileReader);   
                //wavePlayer.Play();


                //var maxPeakProvider = new MaxPeakProvider();
                //var rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
                //var samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
                //var averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

                musicProgressBar.EditValue = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void displayNumberOfSongs()
        {
            if (files.Count == 1)
            {
                lbNumberOfSongs.Text = files.Count.ToString() + " song";
            }
            else
            {
                lbNumberOfSongs.Text = files.Count.ToString() + " songs";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (player == null)
                {
                    int selectedIndex = fileList.SelectedIndex;
                    player = new Player(files[selectedIndex]);
                    player.Play();
                    btnPlay.ImageOptions.SvgImage = svgImageCollection[1];
                }
                else
                {
                    if (player.getState() == PlaybackState.Stopped || player.getState() == PlaybackState.Paused)
                    {
                        player.Play();
                        btnPlay.ImageOptions.SvgImage = svgImageCollection[1];
                    }
                    else
                    {
                        player.Pause();
                        btnPlay.ImageOptions.SvgImage = svgImageCollection[0];
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = fileList.SelectedIndex;
                if (selectedIndex == fileList.Items.Count - 1) return;

                int nextIndex = selectedIndex + 1;
                fileList.SelectedIndex = nextIndex;
                FileInfo file = files[nextIndex];

                PlayMusic(file);
            }
            catch (Exception)
            {
                
            }


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = fileList.SelectedIndex;
                if (selectedIndex == 0) return;

                int previousIndex = selectedIndex - 1;
                fileList.SelectedIndex = previousIndex;
                FileInfo file = files[previousIndex];

                PlayMusic(file);

            }
            catch (Exception)
            {

            }
        }

        public void PlayMusic(FileInfo fileInfo)
        {
            try
            {
                if (player != null) player.Stop();
                btnPlay.ImageOptions.SvgImage = svgImageCollection[0];

                player = new Player(fileInfo);
                player.Play();
                btnPlay.ImageOptions.SvgImage = svgImageCollection[1];

                tagFile = TagLib.File.Create(fileInfo.FullName);
                string title = tagFile.Tag.Title;
                string artist = tagFile.Tag.FirstPerformer;


                songTitle.Text = title;
                songArtists.Text = artist;

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
                    songCover.Image = null;
                }
            }
            catch (Exception)
            {

            }
        }

        private void musicProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void setSongImage()
        {

        }

        private void btnDeleteFiles_Click(object sender, EventArgs e)
        {
            try
            {
                files.Clear();
                fileList.Items.Clear();
                lbBrowseFiles.Show();
                displayNumberOfSongs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            browseFiles();
        }

        private void lbBrowseFiles_Click(object sender, EventArgs e)
        {
            browseFiles();
        }

        private void listBoxControlToolTip_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            ListBoxControl listBoxControl = e.SelectedControl as ListBoxControl;
            if (listBoxControl == null)
                return;
            int index = listBoxControl.IndexFromPoint(e.ControlMousePosition);
            if (index != -1)
            {
                //string item = listBoxControl.GetItem(index) as string;
                //object obj = index.ToString() + item;
                //e.Info = new DevExpress.Utils.ToolTipControlInfo(obj, item);
                string item = files[index].FullName;
                e.Info = new DevExpress.Utils.ToolTipControlInfo(fileList.Items[index], item);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
