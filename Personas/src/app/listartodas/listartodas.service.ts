import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ListartodasService {
  private apiUrl = 'https://localhost:7160/api/personas'; // Reemplaza tuPuerto y tuRuta con los valores correctos

  constructor(private http: HttpClient) { }

  obtenerPersonas() {
    return this.http.get(this.apiUrl);
  }
}
