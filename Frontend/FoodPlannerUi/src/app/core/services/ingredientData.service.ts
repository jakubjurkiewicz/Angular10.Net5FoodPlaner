import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Ingredient } from '../../model/ingredient.model';
import { Observable, throwError } from "rxjs";
import { map, tap, catchError } from "rxjs/operators";
import { ErrorTracker } from '../../model/ErrorTracker';

@Injectable({
  providedIn: 'root'
})
export class IngredientDataService {

  constructor(private http: HttpClient) {

  }


  getAllIngredients(): Observable<Ingredient[] | ErrorTracker> {
    const jsonHeader = new HttpHeaders().set('Content-Type', 'application/json; charset=utf-8');
    return this.http.get<Ingredient[]>("http://localhost:5000/api/ingredient", { headers: jsonHeader }).
    pipe(
      catchError(err => this.handleHttpError(err))
    );
  }

  private handleHttpError(error: HttpErrorResponse): Observable<ErrorTracker>{
    let dataError = new ErrorTracker();
    dataError.message = error.statusText;
    return throwError(dataError);
  }

  getIngredient(id: number): Observable<Ingredient> {
    return this.http.get<Ingredient>(`http://localhost:5000/api/ingredient/${id}`, {
      headers: new HttpHeaders({
        'Accept': 'application/json',
        'Authorization': 'my-token'
      })
    })
  }

  addIngredient(newIngredient: Ingredient): Observable<Ingredient>{
    console.log(newIngredient, 'ingredientDataservice');
    return this.http.post<Ingredient>(`http://localhost:5000/api/ingredient`, newIngredient);
  }
  updateIngredient(updateIngredient: Ingredient): Observable<void>{
    return this.http.put<void>(`http://localhost:5000/api/ingredient/${updateIngredient.id}`, updateIngredient);
  }
  deleteIngredient(IngredientId: Number): Observable<void>{
   return this.http.delete<void>(`http://localhost:5000/api/ingredient/${IngredientId}`);
  }

}

