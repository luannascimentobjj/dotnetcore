import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any = [
    {
      EventoId: 1,
      Tema: 'Angular',
      Local: 'Niterói'
    },
    {
      EventoId: 1,
      Tema: '.NET Core',
      Local: 'Niterói'
    },
    {
      EventoId: 1,
      Tema: '.NET Core e Angular',
      Local: 'Niterói'
    }
  ];

  constructor() { }

  ngOnInit() {
  }

}
