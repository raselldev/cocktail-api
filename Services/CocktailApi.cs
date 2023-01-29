using System;
using System.Text.Json;
using cocktail_api.Data;
using cocktail_api.Models;

namespace cocktail_api.Services
{
    public class CocktailApi : ICocktailAPI
    {
        private readonly HttpClient _httpClient;

        public CocktailApi(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<Cocktail> GetCocktails()
        {
            var response = await _httpClient.GetAsync("https://thecocktaildb.com/api/json/v1/1/random.php");
            response.EnsureSuccessStatusCode();

            var responseAsString = await response.Content.ReadAsStringAsync();

            var results = JsonSerializer.Deserialize<Cocktail>(responseAsString);

            return results!;
        }
    }
}

