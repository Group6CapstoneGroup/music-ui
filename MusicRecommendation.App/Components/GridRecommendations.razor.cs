using Microsoft.AspNetCore.Components;
using MusicRecommendation.App.Models;
using MusicRecommendation.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Components
{
    public partial class GridRecommendations
    {
        [Inject]
        public IMusicService MusicService { get; set; }
    }
}
