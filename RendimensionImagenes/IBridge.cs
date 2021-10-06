using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendimensionImagenes
{
    //Método para comprimir
    /// Autor: Antonio Galván Uriza
    /// Fecha: 06-10-21
    /// Versión: 1.0.0.0
    /// Modificación: 06-10-21
    /// <param name="pOrigen">Contiene el origne</param>
    /// <param name="pDestino">Contiene el destino</param>
    /// <param name="pOpcion">Contiene la opcion de compresión</param>
    /// <param name="pResolucion">Contiene la resolución</param>
    interface IBridge
    {
        bool Inicio(string pUser, string pPassword);
        bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion);
        bool Peticion(List<string> pOrigen, string pDestino, int pOpcion, int pResolucion);
    }
}
