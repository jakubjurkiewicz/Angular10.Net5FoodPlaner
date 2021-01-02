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
        public void CreatePlan(Plan plan);

        public Ingredient GetIngredient(int ingredientId);
        public Recipe GetRecipe(int recipeId);
        public Plan GetPlan(int planId);

        public  IEnumerable<Ingredient> GetAllIngredients();
        public IEnumerable<Recipe> GetAllRecipes();
        public IEnumerable<Plan> GetAllPlans();

        public void DeleteIngredient(int ingredientId);
        public void DeleteRecipe(int recipeId);
        public void DeletePlan(int planId);

        public void UpdateIngredient(Ingredient ingredient);
        public void UpdateRecipe(Recipe recipe);
        public void UpdatePlan(Plan plan);



    }
}
