using System;
using System.Collections.Generic;

namespace NewFoodPlannerApi.Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<IngredientInRecipe> IngredientInRecipes { get; set; } = new List<IngredientInRecipe>();
        public List<RecipeInPlan> RecipeInPlans { get; set; } = new List<RecipeInPlan>();
    }
}
