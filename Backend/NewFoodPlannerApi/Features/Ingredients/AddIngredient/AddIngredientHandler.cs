using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Repository;
using System;

namespace NewFoodPlannerApi.Features.Ingredients.AddIngredient
{
    public class AddIngredientHandler : IAddIngredientHandler
    {
        private readonly IFoodRepository _foodCommandRepository;

        public AddIngredientHandler(IFoodRepository foodCommandRepository)
        {
            _foodCommandRepository = foodCommandRepository;
        }

        public AddIngredientResponse Handle(AddIngredientRequest request)
        {
            var ingredient = new Ingredient
            {
                Name = request.Name,
                Carbs = request.Carbs,
                Fat = request.Fat,
                Protein = request.Protein,
                Kcal = request.Kcal
            };
            _foodCommandRepository.CreateIngredient(ingredient);

           return new AddIngredientResponse();
        }
    }
}
