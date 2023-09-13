import { Component } from '@angular/core';
import { IPersonas } from './personas';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { AltaService } from './alta.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-alta',
  templateUrl: './alta.component.html',
  styleUrls: ['./alta.component.css']
})

export class AltaComponent{
  persona: any = {}; 
  resultAlta: string = "";

  //Para Rellenar
  nombre: string = "";
  apellido: string = "";
  fechaNacimiento: string = "";
  telefono: string = "";
  myForm: FormGroup;
  sub!: Subscription;

  // Agrega una propiedad 'id' y genera un GUID en el constructor
  constructor(private altaService: AltaService, public fb: FormBuilder, public router: Router) {
    this.myForm = this.fb.group({
      nombre: ['', [Validators.required,Validators.maxLength(50)]],
      apellido: ['', [Validators.required,Validators.maxLength(50)]],
      telefono: ['', [Validators.required,Validators.maxLength(25)]],
      fechaNacimiento: ['', [Validators.required,Validators.max(new Date(new Date().getFullYear() - 16).getTime())]],
    });
  }

  rellenarAlta(myForm : FormGroup): void {
    const altaDTO: IPersonas = {
      nombre: myForm.value.nombre,
      apellido: myForm.value.apellido,
      fechaNacimiento: myForm.value.fechaNacimiento,
      telefono: myForm.value.telefono
    };
    this.postAlta(altaDTO);
    console.log(altaDTO);
  }
  
 // Realiza el POST enviando el registro rellenado
 postAlta(altaDTO: IPersonas): void {
  this.altaService.postRealizarAlta(altaDTO).subscribe({
    next: (alta) => {
      this.resultAlta = alta;
      console.log(alta);
    },
  });
}
}
