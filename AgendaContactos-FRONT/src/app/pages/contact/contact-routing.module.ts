import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgregarEditarContactoComponent } from 'src/app/components/agregar-editar-contacto/agregar-editar-contacto.component';
import { ListContactosComponent } from 'src/app/components/list-contactos/list-contactos.component';
import { VerContactoComponent } from 'src/app/components/ver-contacto/ver-contacto.component';

const routes: Routes = [
  {
    path: '', 
    component: ListContactosComponent
  },
  { 
    path: 'agregar', 
    component: AgregarEditarContactoComponent
  },
  {
    path: 'editar/:id', 
    component: AgregarEditarContactoComponent
  },
  {
    path: 'ver/:id',
    component: VerContactoComponent
  },
  {
    path: '**', redirectTo: '', pathMatch: 'full'
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContactRoutingModule { }
