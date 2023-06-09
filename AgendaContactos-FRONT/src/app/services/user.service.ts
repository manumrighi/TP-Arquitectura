import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IUser } from '../interfaces/user.interface';


@Injectable({
  providedIn: 'root'
})
export class UserService{
  private myAppUrl = 'https://localhost:7014/';
  private  myApiUrl = 'api/User/';


  constructor(private http: HttpClient) { }

  //addUser(user: IUser): Observable<any> {
    //return this.http.post(this.myAppUrl + this.myApiUrl, user);
  //}

  async save(user: IUser) {
    const res= await fetch(this.myAppUrl + this.myApiUrl, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(user),
    }).then()  ;
    console.log(res)
  }

}
