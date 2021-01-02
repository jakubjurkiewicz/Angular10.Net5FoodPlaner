using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Repository;
using System.Collections.Generic;
using System.Linq;

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
         return  _foodRepository.GetAllRecipes().ToList();

        }
    }


}
