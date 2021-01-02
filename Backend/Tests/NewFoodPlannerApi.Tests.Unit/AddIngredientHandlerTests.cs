using NewFoodPlannerApi.Features.Ingredients.AddIngredient;
using NewFoodPlannerApi.Repository;
using System;
using Xunit;

namespace NewFoodPlannerApi.Tests.Unit
{
    public class AddIngredientHandlerTests
    {
        public AddIngredientHandlerTests()
        {

        }
        [Fact]
        public void Test1()
        {

            var _foodCommandRepository = NSubstitute.Substitute.For<IFoodRepository>();
            var sut = new AddIngredientHandler(_foodCommandRepository);


            sut.Handle(new AddIngredientRequest { Name = "Test123" });
        }
    }
}
