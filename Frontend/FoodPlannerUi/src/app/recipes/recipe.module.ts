import { NgModule } from '@angular/core';
import { RecipesComponent } from './recipes.component';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { SharedModule } from '../core/shared.module';
import { RouterModule } from '@angular/router';
import { RecipeRoutingModule } from './recipe-routing.module';


@NgModule({
  declarations: [
    RecipesComponent,
    AddRecipeComponent
  ],
  imports: [
    RouterModule,
    SharedModule,
    RecipeRoutingModule,
  ]
})
export class RecipeModule { }
