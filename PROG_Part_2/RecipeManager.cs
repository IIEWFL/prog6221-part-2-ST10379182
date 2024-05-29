
using System;
using System.Collections.Generic;

namespace RecipeApp
{
    //RecipeManager Class
    public static class RecipeManager
    {
        private static List<Recipe> recipes = new List<Recipe>();

        //Add a new recipe
        public static void AddRecipe()
        {
            Console.Write("Enter the name of the recipe: ");
            string name = Console.ReadLine();

            Recipe recipe = new Recipe(name);
            recipe.OnHighCalories += ShowCalorieWarning;

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                string ingredientName = Console.ReadLine();

                Console.Write($"Enter the quantity of {ingredientName}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of {ingredientName}: ");
                string unit = Console.ReadLine();

                Console.Write($"Enter the number of calories in {ingredientName}: ");
                int calories = int.Parse(Console.ReadLine());

                Console.Write($"Enter the food group of {ingredientName}: ");
                string foodGroup = Console.ReadLine();

                recipe.Ingredients.Add(new Ingredient(ingredientName, quantity, unit, calories, foodGroup));
            }

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Enter the description for step {i + 1}: ");
                recipe.Steps.Add(Console.ReadLine());
            }

            recipes.Add(recipe);
        }

        public static void ListRecipes()
        {
            recipes.Sort((x, y) => x.Name.CompareTo(y.Name));
            Console.WriteLine("\nRecipes:");
            foreach (var recipe in recipes)
            {
                Console.WriteLine(recipe.Name);
            }
        }

        public static void SelectAndDisplayRecipe()
        {
            ListRecipes();
            Console.Write("\nEnter the name of the recipe to display: ");
            string name = Console.ReadLine();

            Recipe selectedRecipe = recipes.Find(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (selectedRecipe != null)
            {
                selectedRecipe.Display();
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }

        private static void ShowCalorieWarning(string message)
        {
            Console.WriteLine(message);
        }
    }
}
