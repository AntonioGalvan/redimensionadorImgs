using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RendimensionImagenes
{
    //Clase para registrarse
    /// Autor: Antonio Galván Uriza
    /// Fecha: 30-11-21
    /// Versión: 2.0.0.3
    /// Modificación: 30-11-21
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        //Método para salir de la aplicación
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pbxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para salir de la aplicación
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pnlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para mostrar el inicio de sesión
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        //Método para placeholder de Nombre
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                this.txtNombre.ForeColor = Color.Black;
                this.txtNombre.Text = null;
            }
            
        }

        //Método para placeholder de Nombre
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                this.txtNombre.ForeColor = Color.Gray;
                this.txtNombre.Text = "Nombre";
            }
        }

        //Método para placeholder de usuario
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                this.txtUsuario.ForeColor = Color.Black;
                this.txtUsuario.Text = null;
            }
        }

        //Método para placeholder de Usuario
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                this.txtUsuario.ForeColor = Color.Gray;
                this.txtUsuario.Text = "Usuario";
            }
        }

        //Método para placeholder de Contraseña
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
            if (txtPassword.Text == "Contraseña")
            {
                this.txtPassword.ForeColor = Color.Black;
                this.txtPassword.Text = null;
                this.txtPassword.UseSystemPasswordChar = false;
            }
        }

        //Método para placeholder de Contraseña
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                this.txtPassword.ForeColor = Color.Gray;
                this.txtPassword.Text = "Contraseña";
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        //Método para placeholder de confirmar contraseña
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            if (txtPassword2.Text == "Confirmar contraseña")
            {
                this.txtPassword2.ForeColor = Color.Black;
                this.txtPassword2.Text = null;
                this.txtPassword2.UseSystemPasswordChar = false;
            }
        }

        //Método para placeholder de confirmar contraseña
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword2.Text))
            {
                this.txtPassword2.ForeColor = Color.Gray;
                this.txtPassword2.Text = "Confirmar contraseña";
                this.txtPassword2.UseSystemPasswordChar = true;
            }
        }

        //Método para desactivar los caracteres de contraseña
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword2.UseSystemPasswordChar = true;
        }

        //Método para realizar el registro
        /// Autor: Antonio Galván Uriza
        /// Fecha: 30-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 30-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre" || txtNombre.Text == null)
            {
                MessageBox.Show("Debes ingresar tu nombre");
            }
            else
            {
                if (txtUsuario.Text == "Usuario" || txtUsuario.Text == null)
                {
                    MessageBox.Show("Debes ingresar un usuario");
                }
                else
                {
                    if (txtPassword.Text == "Contraseña" || txtUsuario.Text == null)
                    {
                        MessageBox.Show("Debes ingresar una contraseña");
                    }
                    else
                    {
                        if (txtPassword.Text != txtPassword2.Text)
                        {
                            MessageBox.Show("Las contraseña deben coincidir");
                        }
                        else
                        {
                            MessageBox.Show("Enhorabuena");
                        }
                    }
                }
            }
        }
    }
}
