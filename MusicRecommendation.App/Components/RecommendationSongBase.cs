using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MusicRecommendation.App.Models;
using MusicRecommendation.App.Services;

namespace MusicRecommendation.App.Components
{
    public class RecommendationSongBase : ComponentBase
    {
        [Inject]
        public IEnumerable<Music> RecommendationResponseData { get; set; }


    }
}
