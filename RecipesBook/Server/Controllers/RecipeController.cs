using Microsoft.AspNetCore.Mvc;
using RecipesBook.Shared;
using System.Collections.Generic;

namespace RecipesBook.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private static readonly IEnumerable<Recipe> recipes = new List<Recipe>
        {
            new Recipe("NeoPolitan Pizza", "This is simply a test", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg/330px-Eq_it-na_pizza-margherita_sep2005_sml.jpg"),
            new Recipe("Misal Pav", "This is simply a test", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Kolhapuri_Misal_Pav.jpg/1280px-Kolhapuri_Misal_Pav.jpg")
        };

        [HttpGet]
        public IEnumerable<Recipe> GetRecipes()
        {
            return recipes;
        }
    }
}