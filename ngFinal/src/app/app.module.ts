import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { TweetsComponent } from './tweets/tweets.component';
import { FormsModule } from '@angular/forms';
import { AuthenticationInterceptor } from './authentication.interceptor';

@NgModule({
  declarations: [				
    AppComponent,
      RegisterComponent,
      LoginComponent,
      TweetsComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    {provide:HTTP_INTERCEPTORS, useClass: AuthenticationInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
