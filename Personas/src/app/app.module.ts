import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListartodasComponent } from './listartodas/listartodas.component';
import { ListarfiltroComponent } from './listarfiltro/listarfiltro.component';


@NgModule({
  declarations: [
    AppComponent,
    ListartodasComponent,
    ListarfiltroComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
