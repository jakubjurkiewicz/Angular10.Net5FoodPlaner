import { Component, OnInit } from '@angular/core';
import { IngredientDataService } from 'src/app/core/services/ingredientData.service';

@Component({
  selector: 'app-update-ingredient',
  templateUrl: './update-ingredient.component.html',
  styleUrls: ['./update-ingredient.component.scss']
})
export class UpdateIngredientComponent implements OnInit {

  constructor(private dataService: IngredientDataService) { }

  ngOnInit(): void {
  }
}
