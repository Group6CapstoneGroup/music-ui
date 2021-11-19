using MusicRecommendation.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Services
{
    public interface IMusicService
    {
        Task<IEnumerable<Music>> GetSongs();
    }
}
