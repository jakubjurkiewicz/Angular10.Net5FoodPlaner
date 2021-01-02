using Microsoft.EntityFrameworkCore;
using NewFoodPlannerApi.Domain;

namespace NewFoodPlannerApi.Infrastructure.Database
{
    public class FoodPlannerContext : DbContext
    {
        public FoodPlannerContext()
        {

        }

        public FoodPlannerContext(DbContextOptions<FoodPlannerContext> options): base(options)
        {}

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Plan> Plans { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
             .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =  NewFoodPlannerAppData");
            }          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredientInRecipe>()
                .HasKey(i =>new { i.IngredientId, i.RecipeId});
            modelBuilder.Entity<RecipeInPlan>()
                .HasKey(r => new { r.RecipeId, r.PlanId });
        }

    }
}
