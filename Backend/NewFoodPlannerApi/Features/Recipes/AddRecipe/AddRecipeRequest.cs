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
        public int Servings { get; set; }
        public List<IngredientWithQuantity> IngredientsWithQuantities { get; set; }
    }
}
