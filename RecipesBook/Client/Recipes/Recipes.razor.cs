using Microsoft.AspNetCore.Components;
using RecipesBook.Client.Services;
using RecipesBook.Shared;
using System.Linq;
using System.Net.Http;

namespace RecipesBook.Client.Recipes
{
    public partial class Recipes
    {
        private string selectedRecipeName = string.Empty;

        [Parameter]
        public Recipe SelectedRecipe { get; set; }

        [Inject]
        public IRecipeService recipeService { get; set; }

        [Inject]
        public HttpClient httpClient { get; set; }

        private async void OnRecipeItemSelected(string recipeName)
        {
            this.selectedRecipeName = recipeName;
            string absoluteUri = httpClient.BaseAddress.AbsoluteUri;
            var recipeListItems = await recipeService.GetRecipes(absoluteUri);
            SelectedRecipe = recipeListItems.FirstOrDefault(x => x.Name == recipeName);
            StateHasChanged();
        }
    }
}