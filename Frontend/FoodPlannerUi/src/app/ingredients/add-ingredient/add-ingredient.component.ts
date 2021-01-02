import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IngredientDataService } from 'src/app/core/services/ingredientData.service';
import { Ingredient } from 'src/app/model/ingredient.model';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.scss']
})
export class AddIngredientComponent implements OnInit {

ingredientForm: FormGroup;
  constructor(private dataService: IngredientDataService, private router: Router ) { }

  ngOnInit(): void {
    this.ingredientForm = new FormGroup({
      name: new FormControl(),
      kcal: new FormControl(),
      protein: new FormControl(),
      carbs: new FormControl(),
      fat: new FormControl()
    });
  }

  saveIngredient(): void {
    let newIngredient: Ingredient = <Ingredient>this.ingredientForm.value;
    console.log(newIngredient);
    
    this.dataService.addIngredient(newIngredient)
      .subscribe((data: Ingredient) => {
        this.router.navigate(['ingredients']);
      },
        err => console.log(err));

  }

}
