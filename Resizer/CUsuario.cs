using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizer
{
    //Clase para usuarios
    /// Autor: Antonio Galván Uriza
    /// Fecha: 01-12-21
    /// Versión: 1.0.0.0
    /// Modificación: 01-12-21
    [Serializable]
    class CUsuario
    {
        private string nombre;
        private string usuario;
        private string password;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

    }
}
