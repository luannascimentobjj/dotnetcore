import { RedeSocial } from './RedeSocial';
import { Evento } from './Evento';


export interface Palestrante {


    id: number;
    nome: string;
    miniCurriculo: number;
    imagemUrl: string;
    telefone: string;
    email: string;
    redeSociais: RedeSocial[];
    PalestranteEventos: Evento[];

}
