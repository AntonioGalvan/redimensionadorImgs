using System.Collections.Generic;

namespace RendimensionImagenes
{
    //Clase para alternar entre versiones
    /// Autor: Antonio Galván Uriza
    /// Fecha: 06-10-21
    /// Versión: 1.0.0.0
    /// Modificación: 06-10-21
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

        //Método para iniciar sesión
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.0.0
        /// Modificación: 06-10-21
        /// <param name="pUser">Contiene el usuario</param>
        /// <param name="pPassword">Contiene la contraseña</param>
        public bool iniciarSesion(string pUser, string pPassword)
        {
            return sesion.Inicio(pUser,pPassword);
        }

        //Método para comprimir
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.0.0
        /// Modificación: 06-10-21
        /// <param name="pOrigen">Contiene el origen</param>
        /// <param name="pDestino">Contiene el destino</param>
        /// <param name="pOpcion">Contiene la opcion de compresión</param>
        /// <param name="pResolucion">Contiene la resolución</param>
        public bool comprimir(string pOrigen, string pDestino, int pOpcion, int pResolucion)
        {
            return sesion.Peticion(pOrigen, pDestino, pOpcion, pResolucion);
        }

        //Método para comprimir varios archivos
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.0.0
        /// Modificación: 06-10-21
        /// <param name="pOrigen">Contiene los orígenes</param>
        /// <param name="pDestino">Contiene el destino</param>
        /// <param name="pOpcion">Contiene la opcion de compresión</param>
        /// <param name="pResolucion">Contiene la resolución</param>
        public bool comprimir(List<string> pArchivos, string pDestino, int pOpcion, int pResolucion)
        {
            return sesion.Peticion(pArchivos, pDestino, pOpcion, pResolucion);
        }
    }
}
