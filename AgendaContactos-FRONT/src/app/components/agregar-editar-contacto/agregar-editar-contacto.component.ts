import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Contact } from 'src/app/interfaces/contact';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-agregar-editar-contacto',
  templateUrl: './agregar-editar-contacto.component.html',
  styleUrls: ['./agregar-editar-contacto.component.scss']
})
export class AgregarEditarContactoComponent implements OnInit {
  agregarContact: FormGroup;
  accion = 'Agregar';
  id = 0;
  contact: Contact | undefined;

  constructor(private fb: FormBuilder,
    private _contactService: ContactService,
    private router: Router,
    private aRoute: ActivatedRoute) {
    this.agregarContact = this.fb.group({
      name: ['', Validators.required],
      celularNumber: ['', Validators.required],
      email: ['', Validators.required],
      favorite: ['', Validators.required],
    })
    this.id = +this.aRoute.snapshot.paramMap.get('id')!;
  }

  ngOnInit(): void {
    this.esEditar();
  }

  esEditar() {
    if (this.id !== 0) {
      this.accion = 'Editar'
      this._contactService.getContact(this.id).subscribe(data => {
        console.log(data);
        this.contact = data;
        this.agregarContact.patchValue({
          name: data.name,
          celularNumber: data.celularNumber,
          email: data.email,
          favorite: data.favorite,
        })
      }, error => {
        console.log(error);
      })
    }
  }


  agregarEditarContacto() {
    // Agregamos un nuevo contacto
    if (this.contact == undefined) {
      const contactos: Contact = {
        name: this.agregarContact.get('name')?.value,
        celularNumber: this.agregarContact.get('celularNumber')?.value,
        email: this.agregarContact.get('email')?.value,
        favorite: this.agregarContact.get('favorite')?.value,
      }
      this._contactService.saveContact(contactos).subscribe(data => {
        this.router.navigate(['/contact/']);
      }, error => {
        console.log(error);
      })
    } else {
      // Editamos contacto
      const contact: Contact = {
        id: this.contact.id,
        name: this.agregarContact.get('name')?.value,
        celularNumber: this.agregarContact.get('celularNumber')?.value,
        email: this.agregarContact.get('email')?.value,
        favorite: this.agregarContact.get('favorite')?.value,
      }
      this._contactService.updateContact(this.id, contact).subscribe(data => {
        this.router.navigate(['/contact/'])
      }, error => {
        console.log(error);
      })
    }
  }

}
