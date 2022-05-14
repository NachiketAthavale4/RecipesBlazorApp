namespace RecipesBook.Shared
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public Recipe(string name, string description, string imagePath)
        {
            this.Name = name;
            this.Description = description;
            this.ImagePath = imagePath;
        }
    }
}