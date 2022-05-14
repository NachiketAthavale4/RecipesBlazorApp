using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using RecipesBook.Shared;

namespace RecipesBook.Client.Recipes
{
    public partial class RecipeDetail
    {
        [Parameter]
        public Recipe RecipeItem { get; set; }

        [Parameter]
        public EventCallback<Recipe> RecipeItemChanged { get; set; }

        private string DropDownClass = "btn-group mx-3";

        private bool IsDropDownSelected = false;

        private void OnDropDownClicked(MouseEventArgs args)
        {
            this.IsDropDownSelected = !this.IsDropDownSelected;
            if (this.IsDropDownSelected)
            {
                this.DropDownClass = "btn-group mx-3 open";
            }
            else
            {
                this.DropDownClass = "btn-group mx-3";
            }
        }
    }
}