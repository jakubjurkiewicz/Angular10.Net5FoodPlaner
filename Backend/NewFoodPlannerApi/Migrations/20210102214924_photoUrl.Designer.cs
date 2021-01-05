﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewFoodPlannerApi.Infrastructure.Database;

namespace NewFoodPlannerApi.Migrations
{
    [DbContext(typeof(FoodPlannerContext))]
    [Migration("20210102214924_photoUrl")]
    partial class photoUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("Carbs")
                        .HasColumnType("real");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<float>("Kcal")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.IngredientInRecipe", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<float>("IngredientQuantity")
                        .HasColumnType("real");

                    b.HasKey("IngredientId", "RecipeId");

                    b.HasIndex("RecipeId");

                    b.ToTable("IngredientInRecipe");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.RecipeInPlan", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<double>("PortionsQuantity")
                        .HasColumnType("float");

                    b.HasKey("RecipeId", "PlanId");

                    b.HasIndex("PlanId");

                    b.ToTable("RecipeInPlan");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.IngredientInRecipe", b =>
                {
                    b.HasOne("NewFoodPlannerApi.Sql.Models.Ingredient", "Ingredient")
                        .WithMany("IngredientInRecipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewFoodPlannerApi.Sql.Models.Recipe", "Recipe")
                        .WithMany("IngredientInRecipes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.RecipeInPlan", b =>
                {
                    b.HasOne("NewFoodPlannerApi.Sql.Models.Plan", "Plan")
                        .WithMany("RecipeInPlans")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NewFoodPlannerApi.Sql.Models.Recipe", "Recipe")
                        .WithMany("RecipeInPlans")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.Ingredient", b =>
                {
                    b.Navigation("IngredientInRecipes");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.Plan", b =>
                {
                    b.Navigation("RecipeInPlans");
                });

            modelBuilder.Entity("NewFoodPlannerApi.Sql.Models.Recipe", b =>
                {
                    b.Navigation("IngredientInRecipes");

                    b.Navigation("RecipeInPlans");
                });
#pragma warning restore 612, 618
        }
    }
}