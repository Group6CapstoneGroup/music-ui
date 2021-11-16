using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Models
{
    public partial class Music
    {
        public Guid RecordId { get; set; }
        public long RecordNumber { get; set; }
        public string Track { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Playlist { get; set; }
    }
}
