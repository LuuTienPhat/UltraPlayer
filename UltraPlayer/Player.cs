using NAudio.Wave;
using System.IO;


namespace UltraPlayer
{
    internal class Player
    {
        private WaveOutEvent outputDevice { get; set; }
        private AudioFileReader audioFile { get; set; }
        private FileInfo fileInfo { get; set; }

        public Player(FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(fileInfo.FullName);
            outputDevice.Init(audioFile);
        }

        public void Play()
        {
            outputDevice.Play();
        }

        public void Stop()
        {
            outputDevice.Stop();
        }

        public void Pause()
        {
            outputDevice.Pause();
        }

        public void setVolumn(int volumn)
        {
            outputDevice.Volume = volumn / 100f;
        }

        public PlaybackState getState()
        {
            return outputDevice.PlaybackState;
        }
    }
}
