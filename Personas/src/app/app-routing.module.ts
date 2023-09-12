import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ListarfiltroComponent } from './listarfiltro/listarfiltro.component';

const routes: Routes = [
  { path: "home", component: HomeComponent },
  { path: "lista", component: ListarfiltroComponent },
  // { path: "editar", component: PostsComponent },
  { path: "**", redirectTo: "home" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
