using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Repository;

namespace NewFoodPlannerApi.Features.Recipes.AddRecipe
{
    public class AddRecipeHandler : IAddRecipeHandler
    {
        public IFoodRepository _foodRepository { get; }
        public AddRecipeHandler(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }


        public void Handle(AddRecipeRequest addRecipeRequest)
        {
            var recipe = new Recipe {
            Name= addRecipeRequest.Name
            };
            var ingredientsAndQuantities = addRecipeRequest.IngredientsWithQuantities;

            foreach (var ingredientAndQuantity in ingredientsAndQuantities)
            {
                recipe.IngredientsAndQuantities.Add(ingredientAndQuantity);
            }
            _foodRepository.CreateRecipe(recipe);
        }

    }
}
