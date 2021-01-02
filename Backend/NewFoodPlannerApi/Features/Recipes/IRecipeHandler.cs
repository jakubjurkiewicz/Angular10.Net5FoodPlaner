using NewFoodPlannerApi.Domain;
using System;
using System.Collections.Generic;

namespace NewFoodPlannerApi.Features.Recipes
{
    public interface IRecipeHandler
    {
        public List<Recipe> GetAllRecipes();
    }
}
