import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { IngredientDataService } from 'src/app/core/services/ingredient-data.service';
import { Ingredient } from 'src/app/model/ingredient.model';


function isBiggerThanZeroValidator(c: AbstractControl): { [key: string]: boolean } | null {
  if (c.value !== null && (isNaN(c.value) || c.value < 0)) {
    return { 'subZero': true }
  }
  return null;
}

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './ingredient-add.component.html',
  styleUrls: ['./ingredient-add.component.scss']
})
export class AddIngredientComponent implements OnInit {

  ingredientForm: FormGroup;
  constructor(private dataService: IngredientDataService, private router: Router, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.ingredientForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      kcal: ['', isBiggerThanZeroValidator],
      protein: '',
      carbs: '',
      fat: ''
    });
  }

  saveIngredient(): void {
    const newIngredient: Ingredient = this.ingredientForm.value as Ingredient;

    this.dataService.addIngredient(newIngredient)
      .subscribe((data: Ingredient) => {
        this.router.navigate(['ingredients']);
      },
        err => console.log(err));

  }

}
