import { Injectable } from '@angular/core';

@Injectable()
export class Ingredient {
   public id: Number;
   public name: String;
   public protein: Number;
   public carb: Number;
   public fat: Number;
}