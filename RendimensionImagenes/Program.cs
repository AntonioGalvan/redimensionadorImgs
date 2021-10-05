using System;
using System.Windows.Forms;

namespace RendimensionImagenes
{
    //Clase principal program que contiene el main
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.0.0
    /// Modificación: 05-09-21
    static class Program
    {
        //Método de inicio
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 05-09-21
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
