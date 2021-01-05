using System;
using System.Collections.Generic;

namespace NewFoodPlannerApi.Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MealType { get; set; }
        public string PhotoUrl { get; set; }

        public List<IngredientWithQuantity> IngredientsAndQuantities { get; set; } = new List<IngredientWithQuantity>();

       
    }
}
