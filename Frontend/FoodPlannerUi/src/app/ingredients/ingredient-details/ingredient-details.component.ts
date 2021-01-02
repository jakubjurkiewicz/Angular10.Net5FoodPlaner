import { Component, OnInit } from '@angular/core';
import { IngredientDataService } from 'src/app/core/services/ingredientData.service';

@Component({
  selector: 'app-ingredient-details',
  templateUrl: './ingredient-details.component.html',
  styleUrls: ['./ingredient-details.component.scss']
})
export class IngredientDetailsComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}
