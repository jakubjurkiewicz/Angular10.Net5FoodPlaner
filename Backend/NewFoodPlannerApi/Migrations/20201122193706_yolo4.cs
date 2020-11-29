using Microsoft.EntityFrameworkCore.Migrations;

namespace NewFoodPlannerApi.Migrations
{
    public partial class yolo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Portions",
                table: "RecipeInPlan");

            migrationBuilder.AddColumn<double>(
                name: "PortionsQuantity",
                table: "RecipeInPlan",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PortionsQuantity",
                table: "RecipeInPlan");

            migrationBuilder.AddColumn<decimal>(
                name: "Portions",
                table: "RecipeInPlan",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
