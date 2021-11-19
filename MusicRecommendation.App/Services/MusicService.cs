using MusicRecommendation.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Services
{
    public class MusicService : IMusicService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public MusicService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        public async Task<IEnumerable<Music>> GetSongs()
        {
            Console.WriteLine("I am about to make the API call");

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.GetAsync("https://localhost:5001/api/Music");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("I successfully made the GET all music call");
                var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

                var songs = JsonSerializer.Deserialize<List<Music>>(responseBody);

                return songs;

            }
            else
            {
                Console.WriteLine("There was an error");
                
            }
            return null;
        }

    }
}
