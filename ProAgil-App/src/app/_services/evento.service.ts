import { Injectable } from '@angular/core';
import { HttpClient } from '@Angular/common/http';
import { Observable } from 'rxjs';
import { Evento } from '../_models/Evento';

@Injectable()
export class EventoService {

  baseURL = 'http://localhost:5000/api/evento';

constructor(private http: HttpClient) { }

 getAllEventos(): Observable<Evento[]> {
  return this.http.get<Evento[]>(this.baseURL);
 }
 getEventoById(id: number): Observable<Evento[]> {
  return this.http.get<Evento[]>(`${this.baseURL}/getById/${id}`);
 }
 getEventoByTema(tema: string): Observable<Evento[]> {
  return this.http.get<Evento[]>(`${this.baseURL}/${tema}`);
 }
}
