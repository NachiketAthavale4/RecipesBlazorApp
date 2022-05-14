using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using RecipesBook.Client.Services;
using RecipesBook.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RecipesBook.Client.Recipes
{
    public partial class RecipeList
    {
        private IEnumerable<Recipe> recipeList = null;

        [Inject]
        public IRecipeService recipeService { get; set; }

        [Inject]
        public HttpClient httpClient { get; set; }

        [Parameter]
        public EventCallback<string> OnRecipeSelected { get; set; }

        private async Task RecipeSelected(string name)
        {
            await OnRecipeSelected.InvokeAsync(name);
        }

        public RecipeList()
        {
            this.recipeList = new List<Recipe> { };
        }

        protected override async Task OnInitializedAsync()
        {
            string absoluteUri = httpClient.BaseAddress.AbsoluteUri;
            this.recipeList = await recipeService.GetRecipes(absoluteUri);
        }
    }
}