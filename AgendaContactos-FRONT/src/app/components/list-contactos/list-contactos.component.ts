import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/interfaces/contact';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-list-contactos',
  templateUrl: './list-contactos.component.html',
  styleUrls: ['./list-contactos.component.scss']
})
export class ListContactosComponent implements OnInit {

  listContactos: Contact[] = [];

  constructor(private _contactService:ContactService ) { }

  ngOnInit(): void {
    this.getContacts();
  }

  getContacts() {
    this._contactService.getListContacts().subscribe(data => { 
      this.listContactos = data;
    }, error => {
      console.log(error);
    })
  }

  eliminarContact(id: any){
    console.log(id);
    this._contactService.deleteContact(id).subscribe(data => {
      this.getContacts();
    }, error => {
      console.log(error);
    })
  }

}
