using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MusicRecommendation.App.Models;
using MusicRecommendation.App.Services;
using System.Linq;

namespace MusicRecommendation.App.Components
{
    public class GridMusicBase : ComponentBase
    {
        [Inject]
        public IMusicService MusicService { get; set; }
        public IEnumerable<Music> Songs { get; set; }
    }
}
