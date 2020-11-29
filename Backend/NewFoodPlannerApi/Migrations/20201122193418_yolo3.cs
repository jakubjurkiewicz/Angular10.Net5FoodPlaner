using Microsoft.EntityFrameworkCore.Migrations;

namespace NewFoodPlannerApi.Migrations
{
    public partial class yolo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ingredientInRecipes_Ingredients_IngredientId",
                table: "ingredientInRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_ingredientInRecipes_Recipes_RecipeId",
                table: "ingredientInRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_recipeInPlans_Plans_PlanId",
                table: "recipeInPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_recipeInPlans_Recipes_RecipeId",
                table: "recipeInPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_recipeInPlans",
                table: "recipeInPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ingredientInRecipes",
                table: "ingredientInRecipes");

            migrationBuilder.RenameTable(
                name: "recipeInPlans",
                newName: "RecipeInPlan");

            migrationBuilder.RenameTable(
                name: "ingredientInRecipes",
                newName: "IngredientInRecipe");

            migrationBuilder.RenameIndex(
                name: "IX_recipeInPlans_RecipeId",
                table: "RecipeInPlan",
                newName: "IX_RecipeInPlan_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_recipeInPlans_PlanId",
                table: "RecipeInPlan",
                newName: "IX_RecipeInPlan_PlanId");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientInRecipes_RecipeId",
                table: "IngredientInRecipe",
                newName: "IX_IngredientInRecipe_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_ingredientInRecipes_IngredientId",
                table: "IngredientInRecipe",
                newName: "IX_IngredientInRecipe_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeInPlan",
                table: "RecipeInPlan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientInRecipe",
                table: "IngredientInRecipe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientInRecipe_Ingredients_IngredientId",
                table: "IngredientInRecipe",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientInRecipe_Recipes_RecipeId",
                table: "IngredientInRecipe",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeInPlan_Plans_PlanId",
                table: "RecipeInPlan",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeInPlan_Recipes_RecipeId",
                table: "RecipeInPlan",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientInRecipe_Ingredients_IngredientId",
                table: "IngredientInRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientInRecipe_Recipes_RecipeId",
                table: "IngredientInRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeInPlan_Plans_PlanId",
                table: "RecipeInPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeInPlan_Recipes_RecipeId",
                table: "RecipeInPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeInPlan",
                table: "RecipeInPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientInRecipe",
                table: "IngredientInRecipe");

            migrationBuilder.RenameTable(
                name: "RecipeInPlan",
                newName: "recipeInPlans");

            migrationBuilder.RenameTable(
                name: "IngredientInRecipe",
                newName: "ingredientInRecipes");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeInPlan_RecipeId",
                table: "recipeInPlans",
                newName: "IX_recipeInPlans_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeInPlan_PlanId",
                table: "recipeInPlans",
                newName: "IX_recipeInPlans_PlanId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientInRecipe_RecipeId",
                table: "ingredientInRecipes",
                newName: "IX_ingredientInRecipes_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientInRecipe_IngredientId",
                table: "ingredientInRecipes",
                newName: "IX_ingredientInRecipes_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_recipeInPlans",
                table: "recipeInPlans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ingredientInRecipes",
                table: "ingredientInRecipes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientInRecipes_Ingredients_IngredientId",
                table: "ingredientInRecipes",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ingredientInRecipes_Recipes_RecipeId",
                table: "ingredientInRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipeInPlans_Plans_PlanId",
                table: "recipeInPlans",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipeInPlans_Recipes_RecipeId",
                table: "recipeInPlans",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
