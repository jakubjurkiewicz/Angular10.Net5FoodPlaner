import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router, Event, NavigationStart, NavigationEnd, NavigationError, NavigationCancel } from "@angular/router";
import { Subscription } from 'rxjs';
import { EventBusService, Events } from './core/services/event-bus.service';
import { Ingredient } from './model/ingredient.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'FoodPlannerUi';
  loading = true;
  eventBusSubscription: Subscription;
  ingredient: Ingredient;

  constructor(private router: Router, private eventBus: EventBusService) {
    router.events.subscribe((routerEvent: Event) => {
      this.checkRouterEvent(routerEvent);
    })
  }

  ngOnInit() {
    this.eventBusSubscription = this.eventBus.on(Events.IngredientSelected, (ingredient => this.ingredient = ingredient))
  }
  ngOnDestroy(): void {
    if (this.eventBusSubscription) {
      this.eventBusSubscription.unsubscribe();
    }
  }

  checkRouterEvent(routerEvent: Event): void {  // this functionality could be placed in core module components as it is one of the 'single use scenario'
    if (routerEvent instanceof NavigationStart) {
      this.loading = true;
    }
    if (routerEvent instanceof NavigationEnd || routerEvent instanceof NavigationCancel || routerEvent instanceof NavigationError) {
      this.loading = false
    }
  }
}
