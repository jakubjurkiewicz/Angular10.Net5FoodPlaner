using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Recipes
{
    public class RecipeHandler : IRecipeHandler
    {
        private readonly IFoodRepository _foodRepository;

        public RecipeHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }
        public List<Recipe> GetAllRecipes()
        {
          var x=  _foodRepository.GetAllRecipes().ToList();
            return x;
        }
    }
}
