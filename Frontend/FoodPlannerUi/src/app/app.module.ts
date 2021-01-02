import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { IngredientsComponent } from './ingredients/ingredients-list/ingredients.component';
import { RecipesComponent } from './recipes/recipes.component';
import { PlansComponent } from './plans/plans.component';
import { HttpClientModule } from '@angular/common/http';

import { MatModule } from "./material-module";
import { CoreModule } from "./core/core.module";
import { AddIngredientComponent } from './ingredients/add-ingredient/add-ingredient.component';
import { UpdateIngredientComponent } from './ingredients/update-ingredient/update-ingredient.component';
import { IngredientDetailsComponent } from './ingredients/ingredient-details/ingredient-details.component';
import { ReactiveFormsModule } from "@angular/forms";
import {MatSelectModule} from '@angular/material/select';
import { AddRecipeComponent } from './recipes/add-recipe/add-recipe.component';

@NgModule({
  declarations: [
    AppComponent,
    IngredientsComponent,
    RecipesComponent,
    PlansComponent,
    AddIngredientComponent,
    UpdateIngredientComponent,
    IngredientDetailsComponent,
    AddRecipeComponent,
  ],
  imports: [
    BrowserModule,
    MatModule,
    AppRoutingModule,
    NoopAnimationsModule,
    HttpClientModule,
    CoreModule,
    ReactiveFormsModule,
    MatSelectModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
