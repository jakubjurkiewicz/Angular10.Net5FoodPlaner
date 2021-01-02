namespace NewFoodPlannerApi.Features.Ingredients.AddIngredient
{
    public class AddIngredientRequest
    {
        public string Name { get; set; }
        public float Kcal { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }

    }
}