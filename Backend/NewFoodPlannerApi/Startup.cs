using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NewFoodPlannerApi.Features.Ingredients;
using NewFoodPlannerApi.Features.Ingredients.AddIngredient;
using NewFoodPlannerApi.Features.Recipes;
using NewFoodPlannerApi.Features.Recipes.AddRecipe;
using NewFoodPlannerApi.Infrastructure.Database;
using NewFoodPlannerApi.Repository;

namespace NewFoodPlannerApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "NewFoodPlannerApi", Version = "v1" }); });
            services.AddDbContext<FoodPlannerContext>(opt =>
             opt.UseSqlServer(Configuration.GetConnectionString("FoodPlannerConnectionString")).EnableSensitiveDataLogging()
            );
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IAddIngredientHandler, AddIngredientHandler>();
            services.AddScoped<IIngredientHandler, IngredientHandler>();
            services.AddScoped<IAddRecipeHandler, AddRecipeHandler>();
            services.AddScoped<IRecipeHandler, RecipeHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NewFoodPlannerApi v1"));
            }

            app.UseRouting();
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
