using Microsoft.EntityFrameworkCore.Migrations;

namespace NewFoodPlannerApi.Migrations
{
    public partial class recipeEnrichment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MealType",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MealType",
                table: "Recipes");
        }
    }
}
