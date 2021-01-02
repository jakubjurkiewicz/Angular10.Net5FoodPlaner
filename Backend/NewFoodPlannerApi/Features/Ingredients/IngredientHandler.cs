using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Ingredients
{
    public class IngredientHandler : IIngredientHandler
    {
        private readonly IFoodRepository _foodRepository;

        public IngredientHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _foodRepository.GetAllIngredients().ToList();
        }

        public Ingredient GetIngredient(int id)
        {
            return _foodRepository.GetIngredient(id);
        }
    }
}
