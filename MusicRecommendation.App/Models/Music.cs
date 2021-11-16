using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Models
{
    public partial class Music
    {
        public Guid RecordId { get; set; }
        public long RecordNumber { get; set; }
        [JsonPropertyName("track")]
        public string Track { get; set; }
        [JsonPropertyName("artist")]
        public string Artist { get; set; }
        [JsonPropertyName("album")]
        public string Album { get; set; }
        [JsonPropertyName("playlist")]
        public string Playlist { get; set; }
    }
}
