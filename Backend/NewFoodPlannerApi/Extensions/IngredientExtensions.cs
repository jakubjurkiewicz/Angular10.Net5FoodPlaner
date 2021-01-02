using NewFoodPlannerApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Extensions
{
    public static class IngredientExtensions
    {
        public static Sql.Models.Ingredient ConvertToSqlIngredient(this Ingredient ingredient)
        {
            return new Sql.Models.Ingredient { 
            Carbs = ingredient.Carbs,
            Fat = ingredient.Fat,
            Id = ingredient.Id,
            Kcal = ingredient.Kcal,
            Name = ingredient.Name,
            Protein = ingredient.Protein
            };
        }

        public static Ingredient ConvertToDomainIngredient(this Sql.Models.Ingredient ingredient)
        {
            return new Ingredient
            {
                Carbs = ingredient.Carbs,
                Fat = ingredient.Fat,
                Id = ingredient.Id,
                Kcal = ingredient.Kcal,
                Name = ingredient.Name,
                Protein = ingredient.Protein
            };
        }
        public static List<Ingredient> ConvertToDomainIngredients(this List<Sql.Models.Ingredient> ingredients)
        {
            var domainIngredients = new List<Ingredient>();

            foreach (var ingredient in ingredients)
            {
                domainIngredients.Add(ingredient.ConvertToDomainIngredient());
            }
            return domainIngredients;

        }
    }
}
