import { NgModule } from '@angular/core';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';
import { IngredientResolverService } from './core/resolvers/ingredient-resolver.service';
import { PlansComponent } from './plans/plans.component';
import { RecipesComponent } from './recipes/recipes.component';
import { AddRecipeComponent } from './recipes/add-recipe/add-recipe.component';
import { PageNotFoundComponent } from './core/components/page-not-found/page-not-found.component';
import { AuthGuard } from './core/guards/auth.guard';

const routes: Routes = [
  {path: 'ingredients', canLoad: [AuthGuard] ,loadChildren: () => import('./ingredients/ingredient.module').then(m=>m.IngredientModule)},
  { path: 'recipes', component: RecipesComponent },
  { path: 'recipes/add', component: AddRecipeComponent, resolve: { resolvedIngredientsForNewRecipe: IngredientResolverService } },

  { path: 'plans', component: PlansComponent },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {preloadingStrategy: PreloadAllModules})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
