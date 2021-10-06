using System.Collections.Generic;

namespace RendimensionImagenes
{
    //Interfaz para bridge
    /// Autor: Antonio Galván Uriza
    /// Fecha: 06-10-21
    /// Versión: 1.0.0.0
    /// Modificación: 06-10-21
    interface IBridge
    {
        bool Inicio(string pUser, string pPassword);
        bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion);
        bool Peticion(List<string> pOrigen, string pDestino, int pOpcion, int pResolucion);
    }
}
