import { Component } from '@angular/core';
import { Router, Event, NavigationStart, NavigationEnd, NavigationError,NavigationCancel } from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'FoodPlannerUi';
  loading = true;

  constructor(private router: Router){
    router.events.subscribe((routerEvent: Event) => {
      this.checkRouterEvent(routerEvent);
    })
  }
  checkRouterEvent(routerEvent: Event): void {  // this functionality could be placed in core module components as it is one of the 'single use scenario'
    if(routerEvent instanceof NavigationStart){
      this.loading = true;
    }
    if(routerEvent instanceof NavigationEnd || routerEvent instanceof NavigationCancel || routerEvent instanceof NavigationError){
      this.loading= false
    }
  }
}
