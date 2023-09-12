import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ListarfiltroService {
  private apiUrl = 'https://localhost:7160/api/personas/ultimos10'; // Reemplaza tuPuerto y tuRuta con los valores correctos

  constructor(private http: HttpClient) { }

  obtenerPersonasFiltro() {
    return this.http.get(this.apiUrl);
  }
}
