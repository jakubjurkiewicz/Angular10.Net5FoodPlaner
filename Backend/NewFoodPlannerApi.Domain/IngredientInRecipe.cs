﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Domain
{
    public class IngredientInRecipe
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public Ingredient Ingredient { get; set; }
        public Recipe Recipe { get; set; }

        public decimal IngredientQuantity { get; set; }
    }
}
