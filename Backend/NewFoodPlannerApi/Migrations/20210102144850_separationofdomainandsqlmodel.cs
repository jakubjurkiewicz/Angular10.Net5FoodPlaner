using Microsoft.EntityFrameworkCore.Migrations;

namespace NewFoodPlannerApi.Migrations
{
    public partial class separationofdomainandsqlmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "IngredientQuantity",
                table: "IngredientInRecipe",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Recipes");

            migrationBuilder.AlterColumn<decimal>(
                name: "IngredientQuantity",
                table: "IngredientInRecipe",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
