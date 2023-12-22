import { Component, OnInit } from '@angular/core';
import { LoginDTO } from 'src/app/models/loginDTO';
import { HttpService } from 'src/app/services/http.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginDTO : LoginDTO = new LoginDTO("", "");

  constructor(public httpService : HttpService) { }

  ngOnInit() {
  }

}
