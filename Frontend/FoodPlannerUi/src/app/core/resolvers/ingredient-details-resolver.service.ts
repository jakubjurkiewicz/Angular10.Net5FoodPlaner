import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable, of } from 'rxjs';
import { ErrorTracker } from '../../model/ErrorTracker';
import { Ingredient } from '../../model/ingredient.model';
import { IngredientDataService } from '../services/ingredient-data.service';
import { catchError } from 'rxjs/operators';


@Injectable({
    providedIn: 'root'
})
export class IngredientDetailsResolverService implements Resolve<Ingredient | ErrorTracker>{

    constructor(private dataService: IngredientDataService) {}

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<Ingredient | ErrorTracker> {
        const id = +route.paramMap.get['id'];
        return this.dataService.getIngredient(id)
       .pipe(
           catchError(err => of(err))
       );
    }

}
