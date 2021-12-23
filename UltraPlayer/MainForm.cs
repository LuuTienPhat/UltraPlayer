using DevExpress.XtraEditors;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UltraPlayer
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        SongList songList = new SongList();
        private Player player;
        private TagLib.File tagFile;
        private System.Threading.Timer playingSong = null;


        public MainForm()
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
                        songList.Add(fileInfo);
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
            if (songList.Count == 0) return;

            try
            {
                int i = fileList.SelectedIndex;
                FileInfo file = songList[i];
                PlayMusic(file);

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
            if (songList.Count == 1)
            {
                lbNumberOfSongs.Text = songList.Count.ToString() + " song";
            }
            else
            {
                lbNumberOfSongs.Text = songList.Count.ToString() + " songs";
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (player == null)
                {
                    int selectedIndex = fileList.SelectedIndex;
                    FileInfo fileInfo = songList[selectedIndex];
                    PlayMusic(fileInfo);
                }
                else
                {
                    if (player.getState() == PlaybackState.Stopped || player.getState() == PlaybackState.Paused)
                    {
                        player.Play();
                        playingSong = new System.Threading.Timer((o) =>
                        {
                            System.TimeSpan currentTime = player.AudioFile.CurrentTime;
                            this.Invoke((MethodInvoker)delegate
                            {
                                lbNow.Text = new DateTime(currentTime.Ticks).ToString("mm:ss");
                                float calc = (float)player.AudioFile.Position / (float)player.AudioFile.Length * 100;
                                musicProgressBar.EditValue = calc;
                            });

                        }, null, 0, 1000);
                        playingSong.InitializeLifetimeService();
                        btnPlay.ImageOptions.SvgImage = svgImageCollection[0];
                    }
                    else
                    {
                        player.Pause();
                        playingSong.Dispose();
                        btnPlay.ImageOptions.SvgImage = svgImageCollection[1];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                FileInfo file = songList[nextIndex];

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
                FileInfo file = songList[previousIndex];

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
                StopMusic();

                player = new Player(fileInfo);
                player.Play();
                btnPlay.ImageOptions.SvgImage = svgImageCollection[0];

                System.TimeSpan totalTime = player.AudioFile.TotalTime;
                lbDuration.Text = new DateTime(totalTime.Ticks).ToString("mm:ss");

                playingSong = new System.Threading.Timer((o) =>
                {
                    System.TimeSpan currentTime = player.AudioFile.CurrentTime;
                    this.Invoke((MethodInvoker)delegate
                    {
                        lbNow.Text = new DateTime(currentTime.Ticks).ToString("mm:ss");
                        float calc = (float) player.AudioFile.Position / (float) player.AudioFile.Length * 100;
                        musicProgressBar.EditValue = calc;
                        Console.WriteLine(calc);
                    });

                }, null, 0, 1000);
                playingSong.InitializeLifetimeService();

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
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void StopMusic()
        {
            if (player != null) player.Stop();
            if (playingSong != null) playingSong.Dispose();
            btnPlay.ImageOptions.SvgImage = svgImageCollection[1];
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
                songList.Clear();
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
                string item = songList[index].FullName;
                e.Info = new DevExpress.Utils.ToolTipControlInfo(fileList.Items[index], item);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void musicProgressBar_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {

        }
    }
}
