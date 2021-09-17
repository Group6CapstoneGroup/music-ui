using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneMusic.Shared
{
   public class Playlist
    {
        public string Name { get; set; }
        public string User { get; set; }
        public int SongCount { get; set; }
        public int PlaylistDuration { get; set; }
        public enum Type
        {
            Personal,
            Shared
        }
    }
}
