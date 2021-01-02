import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Ingredient } from '../../model/ingredient.model';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { IngredientDataService } from '../../core/services/ingredientData.service';
import { ErrorTracker } from '../../model/ErrorTracker';
import { ActivatedRoute } from "@angular/router";
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-ingredients',
  templateUrl: './ingredients.component.html',
  styleUrls: ['./ingredients.component.scss']
})
export class IngredientsComponent implements OnInit {

  ingredients: Ingredient[];
  ingredient: Ingredient;
  dataSource = new MatTableDataSource<any>();
  displayedColumns : string[] = ['name','kcal','protein','carbs','fat'];


  constructor(private dataService: IngredientDataService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    let resolvedData: Ingredient[] | ErrorTracker = this.route.snapshot.data['resolvedIngredients'];
    if(resolvedData instanceof ErrorTracker){
      console.log(`error tracker : ${resolvedData.message}`);
    }
    else{
      this.ingredients = resolvedData;
      this.dataSource.data = this.ingredients;
    }

    this.getById();
  }


  getById() {
    // 1 tj Id. TODO: sparametryzowac jak zrobie backend 
    this.dataService.getIngredient(1)
      .subscribe(data => this.ingredient = data,
        err => console.log(err));
  }


  deleteIngredient(id: number) {
    this.dataService.deleteIngredient(id).subscribe((data: void) => {
      let index: number = this.ingredients.findIndex(ingrdnt => ingrdnt.id === id);
      this.ingredients.splice(index, 1);
    },
      err => console.log(err));
  }
}

