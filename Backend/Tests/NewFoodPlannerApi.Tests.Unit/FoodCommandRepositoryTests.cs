using Microsoft.EntityFrameworkCore;
using NewFoodPlannerApi.Domain;
using NewFoodPlannerApi.Infrastructure.Database;
using NewFoodPlannerApi.Repository;
using Xunit;

namespace NewFoodPlannerApi.Tests.Unit
{
    public class FoodCommandRepositoryTests
    {


        [Fact]
        public void test1()
        {
            var builder = new DbContextOptionsBuilder<FoodPlannerContext>();
            builder.UseInMemoryDatabase("InMemoryTestingMyFoodRepository");
            using (var context = new FoodPlannerContext(builder.Options))
            {
                var sut = new FoodRepository(context);
                var ingredient = new Ingredient()
                {
                    Name = "tost"
                };
             //  var counter = sut.CreateOrUpdate<Ingredient>(ingredient);
                //Assert.Equal(EntityState.Added,context.Entry(ingredient).State);
              //  Assert.NotEqual(0, counter);
            }
            // var sut = new FoodCommandRepository(_foodPlannerContext);
            // sut.CreateOrUpdate<Ingredient>(new Ingredient { Name = "Tomasz" });
        }
        [Fact]
        public async void CreateRecipeTest()
        {
            var builder = new DbContextOptionsBuilder<FoodPlannerContext>();
            builder.UseInMemoryDatabase("CreateRecipeTest");
            using(var context = new FoodPlannerContext(builder.Options))
            {
                var ingredient = new Ingredient()
                {
                    Name = "a"
                };
                var ingredientb = new Ingredient()
                {
                    Name = "b"
                };


                var recipe = new Recipe()
                {
                    Name = "spaghetti",
                };
                var ingInRecip = new IngredientInRecipe
                {
                    Ingredient = ingredient,
                };
                var ingInRecip2 = new IngredientInRecipe
                {
                    Ingredient = ingredientb,
                };

                recipe.IngredientInRecipes.Add(ingInRecip);
                recipe.IngredientInRecipes.Add(ingInRecip2);




                var sut = new FoodRepository(context);
                sut.CreateIngredient(ingredient);

                sut.CreateRecipe(recipe);

                var myszojelen = await context.Ingredients.ToListAsync();

                Assert.Equal( 3, myszojelen.Count);

            }

        }
    }
}
