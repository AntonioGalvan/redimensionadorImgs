using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendimensionImagenes
{
    public class CAbstraccion
    {
        private IBridge sesion;
        public CAbstraccion(int pTipo)
        {
            if (pTipo == 1)
                sesion = new CProxy.CInicio();
            if (pTipo == 2)
                sesion = new CProxy.CInicio2();
        }

        public bool iniciarSesion(string pUser, string pPassword)
        {
            return sesion.Inicio(pUser,pPassword);
        }

        public bool comprimir(string pOrigen, string pDestino, int pOpcion, int pResolucion)
        {
            return sesion.Peticion(pOrigen, pDestino, pOpcion, pResolucion);
        }

        public bool comprimir(List<string> pArchivos, string pDestino, int pOpcion, int pResolucion)
        {
            return sesion.Peticion(pArchivos, pDestino, pOpcion, pResolucion);
        }
    }
}
