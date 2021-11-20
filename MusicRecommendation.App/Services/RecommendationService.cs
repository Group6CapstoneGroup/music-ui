using MusicRecommendation.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Services
{
    public class RecommendationService : IRecommendationService
    {
        public Task<IEnumerable<Music>> GetRecommendations()
        {
            throw new NotImplementedException();
        }
    }
}
