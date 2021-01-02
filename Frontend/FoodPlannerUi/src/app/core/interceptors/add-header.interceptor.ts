import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest } from "@angular/common/http";
import { Observable } from "rxjs";
import { Injectable } from "@angular/core";

@Injectable()
export class AddHeaderInterceptor implements HttpInterceptor {


    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        let jsonReq: HttpRequest<any> = req.clone({
            setHeaders: { 'Content-Type': 'application/json' }
        });
        return next.handle(jsonReq);
    }
}