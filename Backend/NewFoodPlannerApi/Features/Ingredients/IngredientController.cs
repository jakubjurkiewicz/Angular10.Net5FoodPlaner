using Microsoft.AspNetCore.Mvc;
using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Features.Ingredients.AddIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewFoodPlannerApi.Features.Ingredients
{
    [Route("api/[controller]")]
    public class IngredientController : Controller
    {
        private readonly IAddIngredientHandler addIngredientHandler;
        private readonly IIngredientHandler _ingredientHandler;

        public IngredientController(IAddIngredientHandler addIngredientHandler, IIngredientHandler ingredientHandler)
        {
            this.addIngredientHandler = addIngredientHandler;
            _ingredientHandler = ingredientHandler;
        }


        [HttpPost]
        public void AddIngredient([FromBody] AddIngredientRequest addIngredientRequest)
        {
            addIngredientHandler.Handle(addIngredientRequest);
        }
        [HttpGet]
        public IEnumerable<Ingredient> GetIngredients()
        {
            return  _ingredientHandler.GetAllIngredients();
        }

        [HttpGet("{id}")]
        public  Ingredient GetIngredient(int id)
        {
            return _ingredientHandler.GetIngredient(id);
        }
        [HttpDelete("{id}")]
        public void DeleteIngredient(int id)
        {

        }


    }
}
