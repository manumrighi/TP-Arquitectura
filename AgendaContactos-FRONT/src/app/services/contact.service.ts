import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Contact } from '../interfaces/contact';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  private myAppUrl = 'https://localhost:7014/';
  private myApiUrl = 'api/Contact/';

  constructor(private http: HttpClient) { }

  getListContacts(): Observable<any> {
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }

  deleteContact(id: number): Observable<any> {
     return this.http.delete(this.myAppUrl + this.myApiUrl + id);
  }

  getContact(id: number): Observable<any> {
    return this.http.get(this.myAppUrl + this.myApiUrl + id);
  }

  saveContact(contact: Contact): Observable<any> {
    return this.http.post(this.myAppUrl + this.myApiUrl, contact);
  }

  updateContact(id: number, contact: Contact): Observable<any> {
    return this.http.put(this.myAppUrl + this.myApiUrl + id, contact);
  }

}
