import { NgModule } from '@angular/core';
import { IngredientsComponent } from './ingredients-list/ingredients.component';
import { AddIngredientComponent } from './add-ingredient/add-ingredient.component';
import { IngredientDetailsComponent } from './ingredient-details/ingredient-details.component';
import { SharedModule } from '../core/shared.module';
import { IngredientRoutingModule } from './ingredient-routing.module';



@NgModule({
  declarations: [
    IngredientsComponent,
    AddIngredientComponent,
    IngredientDetailsComponent
  ],
  imports: [
    SharedModule,
    IngredientRoutingModule,

  ]
})
export class IngredientModule { }
