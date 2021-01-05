import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class IngredientDetailsGuardService implements CanActivate{

  constructor() { }

  canActivate(): boolean {

    // so far I have no idea what condition could I use, later on, when the 
    // authorization will be implemented i'll probalby use that :) 04.01.21 /dd.mm.yy
    return true;
  }
}
