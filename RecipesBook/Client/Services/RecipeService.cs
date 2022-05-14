using RecipesBook.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RecipesBook.Client.Services
{
    public class RecipeService : IRecipeService
    {
        public async Task<IEnumerable<Recipe>> GetRecipes(string absoluteUri)
        {
            using HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(absoluteUri);
            return await httpClient.GetFromJsonAsync<Recipe[]>("api/Recipe");
        }
    }
}