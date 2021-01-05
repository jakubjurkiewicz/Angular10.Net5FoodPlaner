using NewFoodPlannerApi.Domain;
using System.Collections.Generic;
using System.Linq;

namespace NewFoodPlannerApi.Extensions
{
    public static class RecipeExtensions
    {

        public static Sql.Models.Recipe ConvertToSqlRecipe(this Recipe recipe)
        {
            var sqlRecipe = new Sql.Models.Recipe
            {
                Id = recipe.Id,
                Name = recipe.Name,
                Description = recipe.Description,
                MealType = recipe.MealType,
                PhotoUrl = recipe.PhotoUrl
            };
            sqlRecipe.IngredientInRecipes = new List<Sql.Models.IngredientInRecipe>();

            foreach (var ingredientAndQuantity in recipe.IngredientsAndQuantities)
            {
                sqlRecipe.IngredientInRecipes.Add(new Sql.Models.IngredientInRecipe
                {
                    IngredientQuantity = ingredientAndQuantity.Quantity,
                    IngredientId = ingredientAndQuantity.Ingredient.Id
                });
            }
            return sqlRecipe;
        }
        public static Recipe ConvertToDomainRecipe(this Sql.Models.Recipe recipe)
        {
            var domainRecipe = new Recipe {
            Description = recipe.Description,
            Id= recipe.Id,
            Name = recipe.Name,
            MealType = recipe.MealType,
            PhotoUrl = recipe.PhotoUrl
            };
            domainRecipe.IngredientsAndQuantities = new List<IngredientWithQuantity>();
            foreach (var ingredientInRecipe in recipe.IngredientInRecipes)
            {
                domainRecipe.IngredientsAndQuantities.Add(new IngredientWithQuantity {
                Ingredient = ingredientInRecipe.Ingredient.ConvertToDomainIngredient(),
                Quantity = ingredientInRecipe.IngredientQuantity
                });
            }

            return domainRecipe;
        }

        public static List<Recipe> ConvertToDomainRecipes(this List<Sql.Models.Recipe> recipes)
        {
            var domainRecipes = new List<Recipe>();

            foreach (var recipe in recipes)
            {
                domainRecipes.Add(recipe.ConvertToDomainRecipe());
            }
            return domainRecipes;

        }
    }
}
