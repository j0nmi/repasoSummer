import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListartodasComponent } from './listartodas/listartodas.component';
import { ListarfiltroComponent } from './listarfiltro/listarfiltro.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { RouterModule } from '@angular/router';
import { BotonTopComponent } from './boton-top/boton-top.component';
import { AltaComponent } from './alta/alta.component';


@NgModule({
  declarations: [
    AppComponent,
    ListartodasComponent,
    ListarfiltroComponent,
    NavbarComponent,
    HomeComponent,
    FooterComponent,
    BotonTopComponent,
    AltaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
