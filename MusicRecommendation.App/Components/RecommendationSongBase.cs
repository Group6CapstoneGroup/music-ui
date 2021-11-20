using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MusicRecommendation.App.Models;

namespace MusicRecommendation.App.Components
{
    public class RecommendationSongBase : ComponentBase
    {
        public IEnumerable<Music> RecommendationData { get; set; }
    }
}
