using RecipesBook.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipesBook.Client.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetRecipes(string absoluteUri);
    }
}