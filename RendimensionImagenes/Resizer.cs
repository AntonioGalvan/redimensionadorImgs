using System;
using System.Windows.Forms;

namespace RendimensionImagenes
{
    //Clase de interfaz de app principal
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.1.4
    /// Modificación: 07-09-21
    public partial class Resizer : Form
    {
        private string origen = "";
        private string destino = "";
        private int resolucion = 0;
        private int opcion = 0;

        public Resizer()
        {
            InitializeComponent();
        }

        //Método para cerrar la aplicación
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 05-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pnlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para cerrar la aplicación
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 05-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pbxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para ingresar ruta de imagen de origen
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 05-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pbxOrigen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origen = openFileDialog1.FileName;
                txtOrigen.Text = origen;
            }
        }

        //Método para ingresar ruta de imagen de destino
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 05-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pbxDestino_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                destino = saveFileDialog1.FileName;
                txtDestino.Text = destino;
            }
        }

        //Método para comprimir imagen
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.1.4
        /// Modificación: 07-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void btnComprimir_Click(object sender, EventArgs e)
        {
            //Validamos que se ingrese origen y destino (rutas)
            if (origen != "" && destino != "")
            {
                //Validamos que se haya seleccionado resolución de img
                if (cbxResolucion.SelectedItem != null || cbxCalidad.SelectedItem != null)
                {
                    //Verificamos que compresor se utilizará
                    if (rdbClasico.Checked)
                    {
                        opcion = 1;
                        switch (cbxResolucion.SelectedIndex)
                        {
                            case 0:
                                resolucion = 25;
                                break;
                            case 1:
                                resolucion = 50;
                                break;
                            case 2:
                                resolucion = 80;
                                break;
                            case 3:
                                resolucion = 90;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        opcion = 2;
                        switch (cbxResolucion.SelectedIndex)
                        {
                            case 0:
                                resolucion = 1920;
                                break;
                            case 1:
                                resolucion = 1280;
                                break;
                            case 2:
                                resolucion = 960;
                                break;
                            case 3:
                                resolucion = 640;
                                break;
                            default:
                                break;
                        }
                    }

                    //Hacemos la petición de un servicio de la app
                    ISujeto ejecucion = new CProxy.CInicio();
                    if (ejecucion.Peticion(origen, destino, opcion, resolucion))
                    {
                        btnComprimir.Visible = false;
                        btnNuevaImagen.Visible = true;
                        lblExito.Visible = true;
                        txtOrigen.Text = "";
                        txtDestino.Text = "";
                        origen = "";
                        destino = "";
                        resolucion = 0;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }

                }
                else
                {
                    MessageBox.Show("Debes seleccionar una resolución");
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una imagen y su nueva ubicación");
            }
        }

        //Método cambiar elementos de interfaz según el compresor
        /// Autor: Antonio Galván Uriza
        /// Fecha: 07-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 07-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void rdbClasico_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbClasico.Checked)
            {
                lblCalidad.Visible = true;
                cbxCalidad.Visible = true;
                lblResolucion.Visible = false;
                cbxResolucion.Visible = false;
            }
            else
            {
                lblCalidad.Visible = false;
                cbxCalidad.Visible = false;
                lblResolucion.Visible = true;
                cbxResolucion.Visible = true;
            }
        }

        //Método para resetar controles despúes de comprimir una imagen
        /// Autor: Antonio Galván Uriza
        /// Fecha: 07-09-21
        /// Versión: 1.0.0.0
        /// Modificación: 07-09-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            btnNuevaImagen.Visible = false;
            lblExito.Visible = false;
            btnComprimir.Visible = true;
        }
    }
}
