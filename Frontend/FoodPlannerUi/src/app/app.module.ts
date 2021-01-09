import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { PlansComponent } from './plans/plans.component';
import { HttpClientModule } from '@angular/common/http';
import { RecipeModule } from './recipes/recipe.module';
import { SharedModule } from './shared/shared.module';
import { UserModule } from './user/user.module';
import { CoreModule } from './core/core.module';


@NgModule({
  declarations: [
    AppComponent,
    PlansComponent,
    

  ],
  imports: [
    SharedModule,
    CoreModule,
    BrowserModule,
    NoopAnimationsModule,
    HttpClientModule,
    UserModule,
    RecipeModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
