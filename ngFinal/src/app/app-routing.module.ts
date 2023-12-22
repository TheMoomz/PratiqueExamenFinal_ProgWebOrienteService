import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { TweetsComponent } from './tweets/tweets.component';

const routes: Routes = [
  {path:"", redirectTo:"tweets", pathMatch:"full"},
  {path:"login", component:LoginComponent},
  {path:"register", component:RegisterComponent},
  {path:"tweets", component:TweetsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
