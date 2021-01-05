import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { PlansComponent } from './plans/plans.component';
import { HttpClientModule } from '@angular/common/http';
import { FlexLayoutModule } from "@angular/flex-layout";
import { IngredientModule } from './ingredients/ingredient.module';
import { RecipeModule } from './recipes/recipe.module';
import { SharedModule } from './core/shared.module';


@NgModule({
  declarations: [
    AppComponent,
    PlansComponent,  
    
  ],
  imports: [
    SharedModule,
    BrowserModule,
    NoopAnimationsModule,
    HttpClientModule,
    FlexLayoutModule,
    IngredientModule,
    RecipeModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
