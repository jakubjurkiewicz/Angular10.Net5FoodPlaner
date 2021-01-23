import { Injectable } from '@angular/core';
import { Ingredient } from './ingredient.model';

export class Recipe{
public name: string;
public ingredients: Ingredient[];
public description: string;
public mealType: RecipeCategory;
public photoUrl: string;
}

export enum RecipeCategory {
    Śniadanie,
    Obiad,
    Kolacja,
    Przekąska,
    Napój
  }
