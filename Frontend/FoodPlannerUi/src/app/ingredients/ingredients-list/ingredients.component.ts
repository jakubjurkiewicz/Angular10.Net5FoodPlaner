import { Component, OnInit } from '@angular/core';
import { Ingredient } from '../../model/ingredient.model';
import { IngredientDataService } from '../../core/services/ingredient-data.service';
import { ErrorTracker } from '../../model/ErrorTracker';
import { ActivatedRoute } from '@angular/router';
import { MatTableDataSource } from '@angular/material/table';
import { EmitEvent, EventBusService, Events } from 'src/app/core/services/event-bus.service';

@Component({
  selector: 'app-ingredients',
  templateUrl: './ingredients.component.html',
  styleUrls: ['./ingredients.component.scss']
})
export class IngredientsComponent implements OnInit {

  ingredients: Ingredient[];
  ingredient: Ingredient;
  dataSource = new MatTableDataSource<any>();
  displayedColumns: string[] = ['name', 'kcal', 'protein', 'carbs', 'fat'];


  constructor(private dataService: IngredientDataService, private route: ActivatedRoute, private eventBus: EventBusService) { }

  ngOnInit(): void {
    const resolvedData: Ingredient[] | ErrorTracker = this.route.snapshot.data.resolvedIngredients;
    if (resolvedData instanceof ErrorTracker){
      console.log(`error tracker : ${resolvedData.message}`);
    }
    else{
      this.ingredients = resolvedData;
      this.dataSource.data = this.ingredients;
    }

    this.getById();
  }


  getById(): void {
    // 1 tj Id. TODO: sparametryzowac jak zrobie backend
    this.dataService.getIngredient(1)
      .subscribe(data => this.ingredient = data,
        err => console.log(err));
  }

  selectIngredient(ingredient: Ingredient){
    this.eventBus.emit(new EmitEvent(Events.IngredientSelected , ingredient));
  }

  deleteIngredient(id: number): void {
    this.dataService.deleteIngredient(id).subscribe((data: void) => {
      const index: number = this.ingredients.findIndex(ingrdnt => ingrdnt.id === id);
      this.ingredients.splice(index, 1);
    },
      err => console.log(err));
  }
}

