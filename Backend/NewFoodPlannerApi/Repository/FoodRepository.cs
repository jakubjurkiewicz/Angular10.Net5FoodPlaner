using Microsoft.EntityFrameworkCore;
using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewFoodPlannerApi.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly FoodPlannerContext _context;

        public FoodRepository(FoodPlannerContext context)
        {
            _context = context;
        }

        public void CreateIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
        }
        public void CreateRecipe(Recipe recipe)
        {
            var ingredientsInRecipes = new List<IngredientInRecipe>();
            foreach (var ingredientInRecipe in recipe.IngredientInRecipes)
            {

            }
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void CreatePlan(Plan plan)
        {
            _context.Plans.Add(plan);
            _context.SaveChanges();
        }
        public Ingredient GetIngredient(int ingredientId)
        {
            return _context.Ingredients.AsNoTracking().FirstOrDefault(x => x.Id == ingredientId);
        }

        public Recipe GetRecipe(int recipeId)
        {
            return _context.Recipes.AsNoTracking().FirstOrDefault(x => x.Id == recipeId);
        }

        public Plan GetPlan(int planId)
        {
            return _context.Plans.AsNoTracking().FirstOrDefault(x => x.Id == planId);
        }
        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _context.Ingredients.ToList();
        }
        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _context.Recipes.Include(r => r.IngredientInRecipes).ThenInclude(ir=> ir.Ingredient).ToList();
        }
        public IEnumerable<Plan> GetAllPlans()
        {
            return _context.Plans.Include(p => p.RecipeInPlans).ThenInclude(rp=>rp.Recipe).ToList();
        }
        public void UpdateIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void UpdateRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void UpdatePlan(Plan plan)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(int ingredientId)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(int recipeId)
        {
            throw new NotImplementedException();
        }

        public void DeletePlan(int planId)
        {
            throw new NotImplementedException();
        }


    }
}
