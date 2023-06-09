import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { iAuthRequest } from 'src/app/interfaces/auth';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  constructor(private router:Router) { }
  
    //Hecho usando NgModel
  // authData:iAuthRequest = {
  //   userName : "",
  //   password : ""
  // };


  async login(form:NgForm){
    //Valor del formulario para no usar NgModel
    console.log(form.value);
    this.router.navigate(['/contacts']);
  }

}
