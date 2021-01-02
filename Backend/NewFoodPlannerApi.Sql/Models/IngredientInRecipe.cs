using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Sql.Models
{
    public class IngredientInRecipe
    {
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public float IngredientQuantity { get; set; }
    }
}
