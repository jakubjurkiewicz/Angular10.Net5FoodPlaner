using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Ingredients.AddIngredient
{
    public interface IAddIngredientHandler
    {
        public AddIngredientResponse Handle(AddIngredientRequest request);
    }
}
