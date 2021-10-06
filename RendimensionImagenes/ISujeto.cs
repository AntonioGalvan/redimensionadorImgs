using System.Collections.Generic;

namespace RendimensionImagenes
{
    //Interfaz de patrón proxy
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.0.3
    /// Modificación: 06-10-21
    public interface ISujeto
    {
        bool Inicio(string pUser, string pPassword);
        bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion);

    }
}
