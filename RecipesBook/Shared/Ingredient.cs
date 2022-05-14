namespace RecipesBook.Shared
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Ingredient(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }
    }
}