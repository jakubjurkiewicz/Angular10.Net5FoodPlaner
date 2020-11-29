using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Domain
{
    public class Ingredient
    {
        public int   Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<IngredientInRecipe> IngredientInRecipes { get; set; }
    }
}
