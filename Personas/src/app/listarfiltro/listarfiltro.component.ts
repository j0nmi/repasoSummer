import { Component, OnInit, OnDestroy } from '@angular/core';
import { ListarfiltroService } from './listarfiltro.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-listarfiltro',
  templateUrl: './listarfiltro.component.html',
  styleUrls: ['./listarfiltro.component.css']
})
export class ListarfiltroComponent implements OnInit, OnDestroy {
  personasFiltro: any[] = [];
  errorMessage: string = '';
  subscription!: Subscription;
  mostrarTabla: boolean = true;

  mostrarTablaOnClick() {
    this.mostrarTabla = true;
  }

  ocultarTablaOnClick() {
    this.mostrarTabla = false;
  }
  
  constructor(private listarfiltroService: ListarfiltroService) { }

  ngOnInit() {
    this.subscription = this.listarfiltroService.obtenerPersonasFiltro().subscribe(
      (data: any) => {
        this.personasFiltro = data;
      },
      (error) => {
        this.errorMessage = 'Error al obtener datos: ' + error;
      }
    );
  }

  ngOnDestroy(): void {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }
}
