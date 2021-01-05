import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AddHeaderInterceptor } from './interceptors/add-header.interceptor';
import { LogResponseInterceptor } from './interceptors/log-response.interceptor';
import { CacheInterceptor } from './interceptors/cache.interceptor';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatModule } from '../material-module';


@NgModule({
  imports: [
    CommonModule,
  ],
  declarations: [PageNotFoundComponent],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AddHeaderInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: LogResponseInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: CacheInterceptor, multi: true }
  ],
  exports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MatModule,
  ]
})
export class SharedModule {

  constructor() {
  }

}
