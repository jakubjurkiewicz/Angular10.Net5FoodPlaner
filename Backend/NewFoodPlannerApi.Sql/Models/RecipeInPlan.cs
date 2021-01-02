using System;

namespace NewFoodPlannerApi.Sql.Models
{
    public class RecipeInPlan
    {
        public int PlanId { get; set; }
        public int RecipeId { get; set; }
        public Plan Plan { get; set; }
        public Recipe Recipe { get; set; }
        public double PortionsQuantity { get; set; }
    }
}
