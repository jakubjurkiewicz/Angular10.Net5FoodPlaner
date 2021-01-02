using Microsoft.AspNetCore.Mvc;
using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Features.Recipes.AddRecipe;
using System.Collections.Generic;

namespace NewFoodPlannerApi.Features.Recipes
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private readonly IAddRecipeHandler _addRecipeHandler;
        private readonly IRecipeHandler _recipeHandler;

        public RecipeController(IAddRecipeHandler addRecipeHandler, IRecipeHandler recipeHandler)
        {
            _addRecipeHandler = addRecipeHandler;
            _recipeHandler = recipeHandler;
        }

        [HttpPost]
        public void AddRecipe([FromBody] AddRecipeRequest addRecipeRequest)
        {

            _addRecipeHandler.Handle(addRecipeRequest);
        }

        [HttpGet]
        public List<Recipe> GetIngredients()
        {
            return _recipeHandler.GetAllRecipes();
        }

    }
}
