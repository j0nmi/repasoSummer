import { IPersonas } from './personas';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AltaService {
    altaUrl: string;
  private http: HttpClient;

  constructor(httpClient: HttpClient) {
    this.altaUrl = 'https://localhost:7160/api/personas';
    this.http = httpClient;
  }

  //Realiza el POST de registro
  postRealizarAlta(alta: IPersonas): Observable<any> {
    return this.http.post(this.altaUrl, alta);
  }
}
