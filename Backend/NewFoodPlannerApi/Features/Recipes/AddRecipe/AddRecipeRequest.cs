using NewFoodPlannerApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Recipes.AddRecipe
{
    public class AddRecipeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MealType { get; set; }
        public string PhotoUrl { get; set; }
        public List<IngredienIdAndQuantity> IngredientsWithQuantities { get; set; }
    }

    public class IngredienIdAndQuantity
    {
        public int IngredientId { get; set; }
        public float Quantity { get; set; }
    }
}
