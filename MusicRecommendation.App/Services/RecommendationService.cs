using MusicRecommendation.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MusicRecommendation.App.Services
{
    public class RecommendationService : IRecommendationService
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public RecommendationService(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;

        public async Task<string> GetRecommendations()
        {
            Console.WriteLine("I am about to make the API call");

            var httpClient = _httpClientFactory.CreateClient();

            var httpResponseMessage = await httpClient.GetAsync("http://127.0.0.1:9999/");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("I successfully made the GET all music call");
                var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

                var recommendations = JsonSerializer.Deserialize<string>(responseBody);

                return recommendations;

            }
            else
            {
                Console.WriteLine("There was an error");

            }
            return null;
        }
    }
}
