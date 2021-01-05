import { NgModule } from '@angular/core';
import { IngredientsComponent } from './ingredients-list/ingredients.component';
import { AddIngredientComponent } from './ingredient-add/ingredient-add.component';
import { IngredientDetailsComponent } from './ingredient-details/ingredient-details.component';
import { SharedModule } from '../core/shared.module';
import { IngredientRoutingModule } from './ingredient-routing.module';
import { IngredientEditComponent } from './ingredient-edit/ingredient-edit.component';



@NgModule({
  declarations: [
    IngredientsComponent,
    AddIngredientComponent,
    IngredientDetailsComponent,
    IngredientEditComponent
  ],
  imports: [
    SharedModule,
    IngredientRoutingModule,

  ]
})
export class IngredientModule { }
