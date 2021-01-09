import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatModule } from './material-module';


@NgModule({
  imports: [
    CommonModule,
  ],
  declarations: [],

  exports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MatModule,
    FlexLayoutModule,
  ]
})
export class SharedModule {

  constructor() {
  }

}
