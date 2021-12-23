using NAudio.Wave;
using System.IO;
using System.Threading;

namespace UltraPlayer
{
    internal class Player
    {
        private WaveOutEvent outputDevice;

        private AudioFileReader audioFile;
        public AudioFileReader AudioFile { get { return audioFile; } }

        private FileInfo fileInfo;
        public FileInfo FileInfo { get { return fileInfo; } }

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
