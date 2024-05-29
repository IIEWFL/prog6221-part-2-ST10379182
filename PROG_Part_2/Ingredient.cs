using System;

namespace RecipeApp
{
    //Ingredient Class
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, double quantity, string unit, int calories, string foodGroup)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            Calories = calories;
            FoodGroup = foodGroup;
        }
        //Method to scale ingredients
        public void Scale(double factor)
        {
            Quantity *= factor;
        }

        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name} ({Calories} calories, {FoodGroup})";
        }
    }
}
/*https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
https://learn.microsoft.com/en-us/dotnet/csharp/
https://learn.microsoft.com/en-us/dotnet/api/system.console?view=net-8.0
*/