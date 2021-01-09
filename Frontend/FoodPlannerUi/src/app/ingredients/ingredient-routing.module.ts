import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IngredientsComponent } from './ingredients-list/ingredients.component';
import { IngredientResolverService } from '../core/resolvers/ingredient-resolver.service';
import { AddIngredientComponent } from './ingredient-add/ingredient-add.component';
import { IngredientDetailsComponent } from './ingredient-details/ingredient-details.component';
import { IngredientDetailsGuardService } from '../core/guards/ingredient-details-guard.service';
import { IngredientDetailsResolverService } from '../core/resolvers/ingredient-details-resolver.service';
import { IngredientEditComponent } from './ingredient-edit/ingredient-edit.component';
import { IngredientEditInfoComponent } from './ingredient-edit/ingredient-edit-info/ingredient-edit-info.component';
import { IngredientEditTagsComponent } from "./ingredient-edit/ingredient-edit-tags/ingredient-edit-tags.component";

const routes: Routes = [

  { path: '', component: IngredientsComponent, resolve: { resolvedIngredients: IngredientResolverService } },
  { path: 'add', component: AddIngredientComponent },
  {
    path: ':id', component: IngredientDetailsComponent, canActivate: [IngredientDetailsGuardService]
    , resolve: { resolvedIngredientDetails: IngredientDetailsResolverService }
  },
  {
    path: ':id/edit', component: IngredientEditComponent, children: [
      { path: '', redirectTo: 'info', pathMatch: 'full' },
      { path: 'info', component: IngredientEditInfoComponent },
      { path: 'tags', component: IngredientEditTagsComponent }
    ]
  }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class IngredientRoutingModule {
  static components =[
    IngredientsComponent,
    AddIngredientComponent,
    IngredientDetailsComponent,
    IngredientEditComponent,
    IngredientEditInfoComponent,
    IngredientEditTagsComponent
  ];
 }



