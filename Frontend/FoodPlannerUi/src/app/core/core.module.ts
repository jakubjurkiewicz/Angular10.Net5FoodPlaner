import { NgModule, Optional, SkipSelf, ErrorHandler } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IngredientDataService } from "./services/ingredientData.service";
import { HTTP_INTERCEPTORS } from "@angular/common/http";
import { AddHeaderInterceptor } from "./interceptors/add-header.interceptor";
import { LogResponseInterceptor } from './interceptors/log-response.interceptor';
import { CacheInterceptor } from "./interceptors/cache.interceptor";


@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers: [
    IngredientDataService,
    { provide: HTTP_INTERCEPTORS, useClass: AddHeaderInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: LogResponseInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: CacheInterceptor, multi: true }
  ]
})
export class CoreModule {

  constructor() {
  }

}
