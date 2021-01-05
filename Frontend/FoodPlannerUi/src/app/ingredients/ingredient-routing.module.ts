import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IngredientsComponent } from './ingredients-list/ingredients.component';
import { IngredientResolverService } from '../core/resolvers/ingredient-resolver.service';
import { AddIngredientComponent } from './ingredient-add/ingredient-add.component';
import { IngredientDetailsComponent } from './ingredient-details/ingredient-details.component';
import { IngredientDetailsGuardService } from '../core/guards/ingredient-details-guard.service';
import { IngredientDetailsResolverService } from '../core/resolvers/ingredient-details-resolver.service';
import { IngredientEditComponent } from './ingredient-edit/ingredient-edit.component';

const routes: Routes = [
  { path: 'ingredients', component: IngredientsComponent, resolve: { resolvedIngredients: IngredientResolverService } },
  { path: 'ingredients/add', component: AddIngredientComponent },
  {
    path: 'ingredients/:id', component: IngredientDetailsComponent, canActivate: [IngredientDetailsGuardService]
    , resolve: { resolvedIngredientDetails: IngredientDetailsResolverService }
  },
  { path: 'ingredients/:id/edit', component: IngredientEditComponent}
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class IngredientRoutingModule { }



