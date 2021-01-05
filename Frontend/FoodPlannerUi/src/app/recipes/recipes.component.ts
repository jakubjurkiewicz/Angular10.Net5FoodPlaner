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
  filteredRecipes: Recipe[];
  _listFilter: string;
  public get listFilter(): string {
    return this._listFilter;
  }
  public set listFilter(v: string) {
    this._listFilter = v;
    this.filteredRecipes = this.listFilter ? this.performFilter(this.listFilter) : this.recipes;
  }


  constructor(private http: HttpClient) {
    console.log('constructor');
  }

  ngOnInit(): void {
    console.log('ngoninit');
    this.getAllRecipes();
  }

  performFilter(filterBy: string): Recipe[]{
    filterBy = filterBy.toLocaleLowerCase();
    const x = this.recipes.filter((recipe) => recipe.name.toLocaleLowerCase().indexOf(filterBy) !== -1);
    return x;
  }

  getAllRecipes(): void{
    this.http.get<Recipe[]>('http://localhost:5000/api/recipe').subscribe(response => {
      this.recipes = response;
      this.filteredRecipes = this.recipes;
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
