import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { IngredientRoutingModule } from './ingredient-routing.module';



@NgModule({
  declarations: [
   IngredientRoutingModule.components
  ],
  imports: [
    SharedModule,
    IngredientRoutingModule,

  ]
})
export class IngredientModule { }
