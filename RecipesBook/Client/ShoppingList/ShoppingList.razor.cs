using RecipesBook.Shared;
using System.Collections.Generic;

namespace RecipesBook.Client.ShoppingList
{
    public partial class ShoppingList
    {
        public List<Ingredient> Ingredients { get; set; }

        public ShoppingList()
        {
            this.Ingredients = new List<Ingredient> { new Ingredient("Apples", 5), new Ingredient("Tomatoes", 10) };
        }
    }
}