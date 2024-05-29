
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
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
            //Method to calulate number of calories i the recipe

            int totalCalories = CalculateTotalCalories();
            Console.WriteLine($"\nTotal Calories: {totalCalories}");
            if (totalCalories > 300)
            {
                OnHighCalories?.Invoke("Warning: This recipe exceeds 300 calories.");
            }
        }

        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Scale(factor);
            }
        }
    }
}

/*https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-8.0
 */
