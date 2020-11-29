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


           return new AddIngredientResponse();
        }
    }
}
