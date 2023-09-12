import { Guid } from "guid-typescript";

export interface IPersonas {
    id: Guid;
    nombre: string;
    apellido: string;
    fechaNacimiento: string;
    telefono: string;
    resumenPersona: string;
  }