using NewFoodPlannerApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Recipes
{
    public interface IRecipeHandler
    {
        public List<Recipe> GetAllRecipes();
    }
}
