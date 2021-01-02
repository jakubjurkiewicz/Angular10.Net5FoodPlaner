import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IngredientDetailsResolverService } from './core/resolvers/ingredient-details-resolver.service';
import { IngredientResolverService } from './core/resolvers/ingredient-resolver.service';
import { IngredientDetailsComponent } from "./ingredients/ingredient-details/ingredient-details.component";
import { IngredientsComponent } from './ingredients/ingredients-list/ingredients.component';
import { PlansComponent } from './plans/plans.component';
import { RecipesComponent } from './recipes/recipes.component';
import { AddIngredientComponent } from "./ingredients/add-ingredient/add-ingredient.component";
import { AddRecipeComponent } from './recipes/add-recipe/add-recipe.component';

const routes: Routes = [
  {path: "ingredients", component: IngredientsComponent , resolve: {resolvedIngredients:  IngredientResolverService}},
  {path: "ingredients/add", component: AddIngredientComponent },
  {path: "ingredients/:id", component: IngredientDetailsComponent , resolve: {resolvedIngredientDetails:  IngredientDetailsResolverService}},
  
  {path: "recipes", component: RecipesComponent},
  {path: "recipes/add", component: AddRecipeComponent , resolve: {resolvedIngredientsForNewRecipe:  IngredientResolverService}},

  {path: "plans", component: PlansComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
