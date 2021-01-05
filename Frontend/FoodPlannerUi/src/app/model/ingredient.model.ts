import { Injectable } from '@angular/core';

@Injectable()
export class Ingredient {
   public id: number;
   public name: string;
   public protein: number;
   public carb: number;
   public fat: number;
}
