import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class AuthenticationInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    if(request.url.match("https://localhost:5001/api/pictures/postpicture/[0-9]+")){
      request = request.clone({
        setHeaders : {
          "Authorization" : "Bearer " + localStorage.getItem("token")
        }
      });
    }
    else{
      request = request.clone({
        setHeaders : {
          "Authorization" : "Bearer " + localStorage.getItem("token")
        }
      });
    }
    return next.handle(request);
  }
}
