
using System;
using System.Collections.Generic;

namespace RecipeApp
{
    //Recipe Class
    public delegate void CalorieNotification(string message);

    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public event CalorieNotification OnHighCalories;

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }
        //Method to display Recipe details
        public void Display()
        {
            Console.WriteLine($"\nRecipe: {Name}");
            Console.WriteLine("\nIngredients:");


/*https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-8.0
 */