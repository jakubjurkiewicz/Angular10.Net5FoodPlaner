import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ErrorTracker } from 'src/app/model/ErrorTracker';
import { Ingredient } from 'src/app/model/ingredient.model';
import { Recipe } from 'src/app/model/recipe.model';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.scss']
})
export class AddRecipeComponent implements OnInit {

  recipeForm: FormGroup;
  ingredientsInRecipe:  FormArray;
  ingredients: Ingredient[];

  constructor( private route: ActivatedRoute, private http: HttpClient) { }

  ngOnInit(): void {
    let resolvedData: Ingredient[] | ErrorTracker = this.route.snapshot.data['resolvedIngredientsForNewRecipe'];
    if(resolvedData instanceof ErrorTracker){
      console.log(`error tracker : ${resolvedData.message}`);
    }
    else{
      this.ingredients = resolvedData;
    }


    this.ingredientsInRecipe= new FormArray([])

    this.recipeForm = new FormGroup({
      name: new FormControl(),
      description: new FormControl(),
      servings: new FormControl(),
      ingredientsWithQuantities: this.ingredientsInRecipe,
   
    });
  }

  addIngredient(): void {
    let ingredient = new FormGroup({
      ingredientId: new FormControl(),
      quantity: new FormControl()
    });
    this.ingredientsInRecipe.push(ingredient);
    console.log('LOL', this.ingredientsInRecipe);
  }

  saveRecipe(): void {
    let newRecipe: Recipe = <Recipe>this.recipeForm.value;
    console.log(newRecipe, 'new recipe');
     this.http.post<Ingredient>(`http://localhost:5000/api/recipe`, newRecipe).subscribe( response =>{
       console.log('add recipe response: ', response);
     }); 
    // this.dataService.addRecipe(newRecipe)
    //   .subscribe((data: Recipe) => {
    //     this.router.navigate(['recipes']);
    //   },
    //     err => console.log(err));

  }
}
