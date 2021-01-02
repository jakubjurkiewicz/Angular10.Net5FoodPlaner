using System;
using System.Collections.Generic;
using System.Text;

namespace NewFoodPlannerApi.Domain
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Kcal { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }

            }
}
