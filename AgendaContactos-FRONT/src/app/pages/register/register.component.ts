import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IUser } from 'src/app/interfaces/user.interface';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {


  constructor(private userService: UserService, private router: Router) {}

  error : boolean = false

  user: IUser = {
   name: "",
   lastName: "",
   userName: "",
   email: "",
   password: ""
  }

  ngOnInit(): void {
  }

    //Armamos el objeto
  register(registerForm: NgForm): void {
    if (registerForm.errors !== null) return
    const res = this.userService.save(registerForm.value)
    console.log(res)
    this.router.navigate(['/login']);


  }

  onSubmit(): void {
    console.log(this.user)
  }

}


