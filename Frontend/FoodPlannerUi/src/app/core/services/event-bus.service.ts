import { Injectable } from '@angular/core';
import { Subject, Subscription, Observable } from "rxjs";
import { filter, map } from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class EventBusService {

  private subject = new Subject<any>();  // Do not expose any kind of subject directly! If needed go with: .asObservable() !

  constructor() { }  // TODO: add event source to know what component triggered the emit ; Implement unsubscribe

on(event: Events, action: any): Subscription {
  return this.subject.pipe(
    filter((e: EmitEvent)=> {
      return e.name === event;
    }),
    map((event: EmitEvent) => {
      return event.value;
    })
  )
  .subscribe(action);
}
emit(event: EmitEvent){
  this.subject.next(event);
}

}

export class EmitEvent {

  constructor(public name: Events, public value?: any){}
}

export enum Events {
  IngredientSelected,
}