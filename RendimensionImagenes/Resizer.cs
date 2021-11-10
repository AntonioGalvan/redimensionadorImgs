using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RendimensionImagenes
{
    //Clase de interfaz de app principal
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 2.0.0.3
    /// Modificación: 09-11-21
    public partial class Resizer : Form
    {
        private List<string> archivos = new List<string>();
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
        /// Versión: 1.0.0.2
        /// Modificación: 06-10-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pbxOrigen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                archivos.Add(openFileDialog1.FileName);
                if(archivos.Count <= 1)
                {
                    origen = archivos[0];
                    txtOrigen.Text = origen;
                }
                else
                {
                    txtOrigen.Text = $"Archivos [{archivos.Count}]";
                }
                pbxTrash.Visible = true;
            }
        }

        //Método para ingresar ruta de imagen de destino
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.2
        /// Modificación: 06-10-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pbxDestino_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destino = folderBrowserDialog1.SelectedPath;
                txtDestino.Text = destino;
            }


        }

        //Método para comprimir imagen
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.1.6
        /// Modificación: 06-10-21
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

                    if(archivos.Count > 1)
                    {
                        if (frmLogin.bridge.comprimir(archivos, destino, opcion, resolucion))
                        {
                            btnComprimir.Visible = false;
                            btnNuevaImagen.Visible = true;
                            lblExito.Visible = true;
                            txtOrigen.Text = "";
                            txtDestino.Text = "";
                            origen = "";
                            destino = "";
                            resolucion = 0;
                            archivos.Clear();
                            pbxTrash.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error, es posible que debas utilizar la versión 2.0");
                        }
                    }
                    else
                    {
                        if (frmLogin.bridge.comprimir(origen, destino, opcion, resolucion))
                        {
                            btnComprimir.Visible = false;
                            btnNuevaImagen.Visible = true;
                            lblExito.Visible = true;
                            txtOrigen.Text = "";
                            txtDestino.Text = "";
                            origen = "";
                            destino = "";
                            resolucion = 0;
                            archivos.Clear();
                            pbxTrash.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error");
                        }
                    }
                    //Hacemos la petición de un servicio de la app
                    

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

        //Método para realizar drag and drop (fallido)
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.0.0
        /// Modificación: 06-10-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtOrigen_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        //Método para realizar drag and drop (fallido)
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.0.0
        /// Modificación: 06-10-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtOrigen_DragDrop(object sender, DragEventArgs e)
        {
            List<string> archivos = new List<string>();
            archivos = (List<string>)e.Data.GetData(DataFormats.FileDrop, false);
            txtOrigen.Text = "Archivos varios";
        }

        //Método para realizar drag and drop (fallido)
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.0.0
        /// Modificación: 06-10-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void Resizer_Load(object sender, EventArgs e)
        {
            txtOrigen.AllowDrop = true;
            
        }

        //Método para realizar drag and drop (fallido)
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.0.0
        /// Modificación: 06-10-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void txtOrigen_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this.txtOrigen.ToString(), DragDropEffects.Copy);
        }

        //Método para vaciar la lista de imágenes
        /// Autor: Antonio Galván Uriza
        /// Fecha: 09-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 09-11-21
        /// <param name="sender">Objeto que disparó el evento</param>
        /// <param name="e"> Informacíón del evento</param>
        private void pbxTrash_Click(object sender, EventArgs e)
        {
            archivos.Clear();
            pbxTrash.Visible = false;
            origen = "";
            txtOrigen.Text = origen;
        }
    }
}
