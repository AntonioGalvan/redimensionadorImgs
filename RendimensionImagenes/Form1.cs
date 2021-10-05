using System;
using System.Windows.Forms;

namespace RendimensionImagenes
{
    //Clase del login
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.0.3
    /// Modificación: 07-09-21
    public partial class frmLogin : Form
    {
        public static CAbstraccion bridge;
        public frmLogin()
        {
            InitializeComponent();
        }

        //Método para iniciar sesión
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.3
        /// Modificación: 06-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Validamos credenciales dentro del proxy que nos dará acceso a funciones más adelante
            if (cbxVersion.SelectedIndex == 0)
                bridge = new CAbstraccion(1);
            else
                bridge = new CAbstraccion(2);
            if (bridge.iniciarSesion(txtUsuario.Text, txtContrasena.Text)){
                new Resizer().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos");
            }
        }

        //Método para cerrar la app
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 05-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbxVersion.SelectedIndex = 0;
        }
    }
}
