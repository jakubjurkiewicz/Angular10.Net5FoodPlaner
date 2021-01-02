using NewFoodPlannerApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Ingredients
{
   public interface IIngredientHandler
    {
        public IEnumerable<Ingredient> GetAllIngredients();
       public Ingredient GetIngredient(int id);
    }
}
