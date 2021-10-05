using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendimensionImagenes
{
    interface IBridge
    {
        bool Inicio(string pUser, string pPassword);
        bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion);
        bool Peticion(List<string> pOrigen, string pDestino, int pOpcion, int pResolucion);
    }
}
