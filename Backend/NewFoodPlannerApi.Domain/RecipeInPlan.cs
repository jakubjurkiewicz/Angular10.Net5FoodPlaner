using System;

namespace NewFoodPlannerApi.Domain
{
    public class RecipeInPlan
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int RecipeId { get; set; }
        public Plan Plan { get; set; }
        public Recipe Recipe { get; set; }
        public double PortionsQuantity { get; set; }
    }
}
