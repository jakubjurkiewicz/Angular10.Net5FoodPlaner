using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Recipes.AddRecipe
{
    public interface IAddRecipeHandler
    {
        public void Handle(AddRecipeRequest addRecipeRequest);
    }
}
