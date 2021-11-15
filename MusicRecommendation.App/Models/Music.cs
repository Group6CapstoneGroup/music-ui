using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Models
{
    public class Music
    {
        public string Song { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public string Playlist { get; set; }


        public static Music ConvertToCSV(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Music newMusic = new Music();

            newMusic.Song = values[0];
            newMusic.Artist = values[1];
            newMusic.Album = values[2];
            newMusic.Playlist = values[3];

            return newMusic;
        }

    }
}
