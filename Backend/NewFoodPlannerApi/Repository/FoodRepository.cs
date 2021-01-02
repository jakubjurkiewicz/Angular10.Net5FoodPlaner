using Microsoft.EntityFrameworkCore;
using NewFoodPlannerApi.Extensions;
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

        public void CreateIngredient(Domain.Ingredient ingredient)
        {
            var sqlIngredient = ingredient.ConvertToSqlIngredient();
            _context.Ingredients.Add(sqlIngredient);
            _context.SaveChanges();
        }
        public void CreateRecipe(Domain.Recipe recipe)
        {
            var sqlRecipe = recipe.ConvertToSqlRecipe();
            _context.Recipes.Add(sqlRecipe);
            _context.SaveChanges();
        }


        public Domain.Ingredient GetIngredient(int ingredientId)
        {
            return _context.Ingredients.AsNoTracking().FirstOrDefault(x => x.Id == ingredientId).ConvertToDomainIngredient();
        }

        public Domain.Recipe GetRecipe(int recipeId)
        {
            return _context.Recipes.AsNoTracking().FirstOrDefault(x => x.Id == recipeId).ConvertToDomainRecipe();
        }

        public IEnumerable<Domain.Ingredient> GetAllIngredients()
        {
            return _context.Ingredients.ToList().ConvertToDomainIngredients();
        }
        public IEnumerable<Domain.Recipe> GetAllRecipes()
        {
            return _context.Recipes.Include(r => r.IngredientInRecipes).ThenInclude(ir=> ir.Ingredient).ToList().ConvertToDomainRecipes();
        }
        public void UpdateIngredient(Domain.Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void UpdateRecipe(Domain.Recipe recipe)
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


    }
}
