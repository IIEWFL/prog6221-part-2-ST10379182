
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
/*https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/
https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-8.0
 */