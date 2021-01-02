using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Sql.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Kcal { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }

        public List<IngredientInRecipe> IngredientInRecipes { get; set; } = new List<IngredientInRecipe>();
    }
}
