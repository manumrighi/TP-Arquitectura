import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Contact } from 'src/app/interfaces/contact';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-ver-contacto',
  templateUrl: './ver-contacto.component.html',
  styleUrls: ['./ver-contacto.component.scss']
})
export class VerContactoComponent implements OnInit {
  id: number;
  contact: any;

  constructor(private aRoute: ActivatedRoute, 
              private _contactService: ContactService) { 
    this.aRoute.snapshot.paramMap.get('id');
    this.id = +this.aRoute.snapshot.paramMap.get('id')!;
  }

  ngOnInit(): void {
    this.getContact();
  }

  getContact() {
    this._contactService.getContact(this.id).subscribe(data => {
      this.contact = data;
    })
  }

}
