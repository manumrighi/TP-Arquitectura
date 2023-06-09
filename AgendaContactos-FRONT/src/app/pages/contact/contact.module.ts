import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContactRoutingModule } from './contact-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

// Componentes
import { AgregarEditarContactoComponent } from 'src/app/components/agregar-editar-contacto/agregar-editar-contacto.component';
import { ListContactosComponent } from 'src/app/components/list-contactos/list-contactos.component';



@NgModule({
  declarations: [
    AgregarEditarContactoComponent,
    ListContactosComponent,
  ],
  imports: [
    CommonModule,
    ContactRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ]
})
export class ContactModule { }
