import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Recipe } from '../model/recipe.model';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.scss']
})
export class RecipesComponent implements OnInit {

  recipes: Recipe[];
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getAllRecipes();
  }

  getAllRecipes(){
    this.http.get<Recipe[]>("http://localhost:5000/api/recipe").subscribe(response => {
      console.log('response', response);
    this.recipes = response;
    });
  }
}


// getAllIngredients(): Observable<Ingredient[] | ErrorTracker> {
//   const jsonHeader = new HttpHeaders().set('Content-Type', 'application/json; charset=utf-8');
//   return this.http.get<Ingredient[]>("http://localhost:5000/api/ingredient", { headers: jsonHeader }).
//   pipe(
//     catchError(err => this.handleHttpError(err))
//   );
// }