
using System;
using System.Collections.Generic;

namespace RecipeApp
{

    private static List<Recipe> recipes = new List<Recipe>();

    //Add a new recipe
    public static void AddRecipe()
    {
        Console.Write("Enter the name of the recipe: ");
        string name = Console.ReadLine();