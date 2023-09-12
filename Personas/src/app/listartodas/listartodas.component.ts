import { Component, OnInit, OnDestroy } from '@angular/core';
import { ListartodasService } from './listartodas.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-listartodas',
  templateUrl: './listartodas.component.html',
  styleUrls: ['./listartodas.component.css']
})
export class ListartodasComponent implements OnInit, OnDestroy {
  personas: any[] = [];
  errorMessage: string = '';
  subscription!: Subscription;
  mostrarTabla: boolean = true;

  mostrarTablaOnClick() {
    this.mostrarTabla = true;
  }

  ocultarTablaOnClick() {
    this.mostrarTabla = false;
  }
  
  constructor(private listartodasService: ListartodasService) { }

  ngOnInit() {
    this.subscription = this.listartodasService.obtenerPersonas().subscribe(
      (data: any) => {
        this.personas = data;
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
