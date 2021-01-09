using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Repository;
using System.Collections.Generic;
using System.Linq;

namespace NewFoodPlannerApi.Features.Ingredients
{
    public class IngredientHandler : IIngredientHandler
    {
        private readonly IFoodRepository _foodRepository;

        public IngredientHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _foodRepository.GetAllIngredients().ToList();
        }

        public Ingredient GetIngredient(int id)
        {
            if(id == 0)
            {
                return new Ingredient();
            }
            return _foodRepository.GetIngredient(id);
        }
    }
}
