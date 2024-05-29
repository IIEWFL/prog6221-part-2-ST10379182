using System;

namespace RecipeApp
{
    //Main Program Class
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. List all recipes");
                Console.WriteLine("3. Select a recipe to display");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                 switch (option)
                {
                    case 1:
                        RecipeManager.AddRecipe();
                        break;
