using ProbandoNetMauiBlazor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProbandoNetMauiBlazor.Models
{
    internal class RickAndMortyService : IRickAndMortyService
    {
        const string URL = "https://rickandmortyapi.com/api/character";

        public async Task<RickAndMorty> Get()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var rickAndMorty = JsonSerializer.Deserialize<RickAndMorty>(content);
            return rickAndMorty;
        }
    }
}
