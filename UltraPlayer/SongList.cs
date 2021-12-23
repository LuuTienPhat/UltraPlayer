using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraPlayer
{
    internal class SongList : List<FileInfo>
    {
        public SongList()
        {
        }

        public FileInfo getSongByFullname(string fullname)
        {
            foreach (var song in this)
            {
                if (song.FullName.Equals(fullname)) return song;
            }
            return null;
        }

        public FileInfo getSongByName(string name)
        {
            foreach (var song in this)
            {
                if (song.FullName.Equals(name)) return song;
            }
            return null;
        }
    }
}
