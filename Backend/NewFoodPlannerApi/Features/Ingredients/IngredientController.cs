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

        public IngredientController(IAddIngredientHandler addIngredientHandler)
        {
            this.addIngredientHandler = addIngredientHandler;
        }


        [HttpPost]
        public void AddIngredient([FromBody] AddIngredientRequest addIngredientRequest)
        {
            addIngredientHandler.Handle(addIngredientRequest);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
        {
            return await Task.FromResult(new List<Ingredient>());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredient(int id)
        {
            return await Task.FromResult(new Ingredient());
        }
        [HttpDelete("{id}")]
        public void DeleteIngredient(int id)
        {

        }


    }
}
