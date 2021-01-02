using NewFoodPlannerApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Repository
{
   public interface IFoodRepository
    {
        public void CreateIngredient(Ingredient ingredient);
        public void CreateRecipe(Recipe recipe);

        public Ingredient GetIngredient(int ingredientId);
        public Recipe GetRecipe(int recipeId);
        public  IEnumerable<Ingredient> GetAllIngredients();
        public IEnumerable<Recipe> GetAllRecipes();

        public void DeleteIngredient(int ingredientId);
        public void DeleteRecipe(int recipeId);

        public void UpdateIngredient(Ingredient ingredient);
        public void UpdateRecipe(Recipe recipe);



    }
}
