import { Injectable } from '@angular/core';
import { Ingredient } from './ingredient.model';

@Injectable()
export class Recipe{
public name: String;
public ingredients: Ingredient[];
public description: string;
}