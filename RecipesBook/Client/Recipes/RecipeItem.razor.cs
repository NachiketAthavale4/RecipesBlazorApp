using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using RecipesBook.Shared;
using System.Threading.Tasks;

namespace RecipesBook.Client.Recipes
{
    public partial class RecipeItem
    {
        [Parameter]
        public Recipe Recipe { get; set; }

        [Parameter]
        public EventCallback<string> SelectedRecipeCallback { get; set; }

        private async Task OnRecipeItemSelectedByUser(MouseEventArgs args, string name)
        {
            await SelectedRecipeCallback.InvokeAsync(name);
        }
    }
}