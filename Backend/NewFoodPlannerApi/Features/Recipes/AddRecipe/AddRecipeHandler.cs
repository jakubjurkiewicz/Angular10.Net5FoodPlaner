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
            Name= addRecipeRequest.Name,
            Description = addRecipeRequest.Description,
            MealType = addRecipeRequest.MealType,
            PhotoUrl = addRecipeRequest.PhotoUrl
            };

            foreach (var idAndQuantity in addRecipeRequest.IngredientsWithQuantities)
            {
                recipe.IngredientsAndQuantities.Add(new IngredientWithQuantity {
                Quantity = idAndQuantity.Quantity,
                Ingredient= new Ingredient { Id = idAndQuantity.IngredientId}
                });
            }
            _foodRepository.CreateRecipe(recipe);
        }

    }
}
