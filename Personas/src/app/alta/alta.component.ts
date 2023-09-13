import { Component } from '@angular/core';
import { IPersonas } from './personas';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { AltaService } from './alta.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Guid } from 'guid-typescript';

@Component({
  selector: 'app-alta',
  templateUrl: './alta.component.html',
  styleUrls: ['./alta.component.css']
})

export class AltaComponent{
  persona: any = {}; 
  resultAlta: string = "";

  //Para Rellenar
  fechaNacimientoF: string = "";
  nombreF: string = "";
  apellidoF: string = "";
  telefonoF: string = "";
  myForm: FormGroup;
  sub!: Subscription;

  // Agrega una propiedad 'id' y genera un GUID en el constructor
  constructor(private altaService: AltaService, public fb: FormBuilder, public router: Router) {
    this.myForm = this.fb.group({
      fechaNacimiento: ['', [Validators.required, Validators.max(new Date(new Date().getFullYear() - 16).getTime()), Validators.min(new Date(new Date().getFullYear() - 100).getTime())]],
      nombre: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
      apellido: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
      telefono: ['', [Validators.required, Validators.minLength(9), Validators.maxLength(25)]],
    });
  }

  rellenarAlta(): void {
    // Genera un GUID automáticamente
    const id = Guid.create().toString();
  
    const altaDTO: IPersonas = {
      id: id,
      fechaNacimiento: this.myForm.value.fechaNacimiento,
      nombre: this.myForm.value.nombre,
      apellido: this.myForm.value.apellido,
      telefono: this.myForm.value.telefono
    };
  
    this.postAlta(altaDTO);
    this.router.navigate(['/lista']);
  }
  
  // Realiza el POST enviando el registro rellenado
  postAlta(altaDTO: IPersonas): void {
    this.altaService.postRealizarAlta(altaDTO).subscribe({
      next: (alta) => {
        this.resultAlta = alta;
      }
    });
  }
}
