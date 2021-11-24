using Microsoft.AspNetCore.Http;
using MusicRecommendation.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

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
        public async Task<Music> CreateSelectedSongs(Music postBody)
        {
            Console.WriteLine("I am about to make the API post call");

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.PostAsJsonAsync("https://localhost:5001/api/SelectedSongs", postBody);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("I successfully made the POST call");

            }
            else
            {
                Console.WriteLine("There was an error");

            }
            return null;

        }

        public async Task<IEnumerable<Music>> GetSelectedSongs()
        {
            Console.WriteLine("I am about to make the API get Selected Songs");

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.GetAsync("https://localhost:5001/api/SelectedSongs");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("I successfully made the GET all selected music call");
                var responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                var selectedSongs = JsonSerializer.Deserialize<List<Music>>(responseBody);

                return selectedSongs;
            }
            else
            {
                Console.WriteLine("There was an error");

            }
            return null;

        }

        public async Task<bool> DeleteSelectedSongs()
        {
            Console.WriteLine("I am about to make the API call delete Selected Songs");

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.DeleteAsync("https://localhost:5001/api/SelectedSongs/List");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("I successfully made the delete all selected music call");
                return true;

            }
            else
            {
                Console.WriteLine("There was an error");

            }
            return false;
        }

        public Task<string> GetRecommendations()
        {
            throw new NotImplementedException();
        }

        public async Task<string> CreateRecommendationsRequest(Music entry)
        {
            Console.WriteLine("I am about to make the POST API call to my flask application");
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.PostAsJsonAsync("http://127.0.0.1:9999/recommendation", entry);

            if(httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("I successfully made the POST API call to my flask application");
                var responseBody = httpResponseMessage.Content.ReadAsStringAsync();
                return responseBody.Result;
            }

                Console.WriteLine("There was an error");
            return null;
        }
    }
}
