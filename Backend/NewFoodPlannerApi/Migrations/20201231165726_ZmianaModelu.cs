using Microsoft.EntityFrameworkCore.Migrations;

namespace NewFoodPlannerApi.Migrations
{
    public partial class ZmianaModelu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeInPlan",
                table: "RecipeInPlan");

            migrationBuilder.DropIndex(
                name: "IX_RecipeInPlan_RecipeId",
                table: "RecipeInPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientInRecipe",
                table: "IngredientInRecipe");

            migrationBuilder.DropIndex(
                name: "IX_IngredientInRecipe_IngredientId",
                table: "IngredientInRecipe");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RecipeInPlan");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IngredientInRecipe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeInPlan",
                table: "RecipeInPlan",
                columns: new[] { "RecipeId", "PlanId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientInRecipe",
                table: "IngredientInRecipe",
                columns: new[] { "IngredientId", "RecipeId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeInPlan",
                table: "RecipeInPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientInRecipe",
                table: "IngredientInRecipe");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RecipeInPlan",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "IngredientInRecipe",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeInPlan",
                table: "RecipeInPlan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientInRecipe",
                table: "IngredientInRecipe",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeInPlan_RecipeId",
                table: "RecipeInPlan",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientInRecipe_IngredientId",
                table: "IngredientInRecipe",
                column: "IngredientId");
        }
    }
}
