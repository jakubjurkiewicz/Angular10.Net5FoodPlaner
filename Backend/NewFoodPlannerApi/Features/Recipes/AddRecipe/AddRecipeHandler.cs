using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            //var recipe = addRecipeRequest.Recipe;

            var recipe = new Recipe {
            Name= addRecipeRequest.Name
            };
            var ingredients = addRecipeRequest.IngredientsWithQuantities;

            foreach (var ingredient in ingredients)
            {
                recipe.IngredientInRecipes.Add(new Domain.IngredientInRecipe { IngredientId = ingredient.IngredientId });
            }

            _foodRepository.CreateRecipe(recipe);
        }

    }
}
