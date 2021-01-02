import { Injectable } from "@angular/core";
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { Observable, of } from "rxjs";
import { ErrorTracker } from "../../model/ErrorTracker";
import { Ingredient } from "../../model/ingredient.model";
import { IngredientDataService } from "../services/ingredientData.service";
import { catchError } from "rxjs/operators";


@Injectable({
    providedIn: 'root'
})
export class IngredientResolverService implements Resolve<Ingredient[] | ErrorTracker>{
    
    constructor(private dataService: IngredientDataService) {}

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Ingredient[] | ErrorTracker> {
        console.log('state',state);
       return this.dataService.getAllIngredients()
       .pipe(
           catchError(err => of(err))
       ); 
    }

}