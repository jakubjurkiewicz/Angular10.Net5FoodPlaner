import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-ingredient-details',
  templateUrl: './ingredient-details.component.html',
  styleUrls: ['./ingredient-details.component.scss']
})
export class IngredientDetailsComponent implements OnInit {

  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
   
    this.route.data.subscribe(data => { 
      const resolvedData = data['resolvedDataZRouteraKtoraJeszczeNieMaNazwy'];              // TODO: <-- ogarnąć ten parametr
    })
  }

}

