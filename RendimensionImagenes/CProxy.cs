using System;
using System.Drawing;
using System.Drawing.Imaging;
using ImageMagick;

namespace RendimensionImagenes
{
    //Clase Proxy
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.2.1
    /// Modificación: 07-09-21
    class CProxy
    {

        //Clase CInicio que contiene los métodos de acceso y las clases principales
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.2.1
        /// Modificación: 07-09-21
        public class CInicio : ISujeto
        {
            private IComprimir resizer;
            private static bool isAuthenticated = false;
            public static bool IsAuthenticated { get => isAuthenticated; private set => isAuthenticated = value; }

            //Método para iniciar sesión en la aplicación
            /// Autor: Antonio Galván Uriza
            /// Fecha: 05-09-21
            /// Versión: 1.0.0.3
            /// Modificación: 07-09-21
            /// <param name="pUser">Usuario</param>
            /// <param name="pPassword">Contrasñeña del usuario</param>
            public bool Inicio(string pUser, string pPassword)
            {
                //Autenticación básica
                if (pUser == "admin" && pPassword == "admin123")
                {
                    IsAuthenticated = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Método de petición para usar los servicios del app
            /// Autor: Antonio Galván Uriza
            /// Fecha: 05-09-21
            /// Versión: 1.0.1.5
            /// Modificación: 07-09-21
            /// <param name="pOrigen">Ruta de origen de la imagen</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pOpcion">Opción del compresor que se usará</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion)
            {
                //Verifica si el usuario está autenticado
                if(IsAuthenticated == true)
                {
                    if (pOpcion == 1)
                        resizer = new CClasico();
                    if (pOpcion == 2)
                        resizer = new CMagick();

                    //Trata de realizar la compresión
                    try
                    {
                        resizer.comprimir(pOrigen, pDestino, pResolucion);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    } 
                }
                else
                {
                    return false;
                }
                
            }
        }

        //Clase de compresor CMagick (Privada)
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.0.3
        /// Modificación: 06-09-21
        private class CMagick:IComprimir
        {
            //Método para comprimir con CMagick (framework)
            /// Autor: Antonio Galván Uriza
            /// Fecha: 05-09-21
            /// Versión: 1.0.0.3
            /// Modificación: 06-09-21
            /// <param name="pOrigen">Ruta de origen de la imagen</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public void comprimir(string pOrigen, string pDestino, int pResolucion)
            {
                pOrigen = @""+pOrigen;
                pDestino = @""+pDestino;
                    
                using(MagickImage oMagickImage = new MagickImage(pOrigen))
                {
                    oMagickImage.Resize(pResolucion, 0);

                    oMagickImage.Write(pDestino);
                }
            }
        }

        //Clase de compresor clásico (privada)
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.2.1
        /// Modificación: 07-09-21
        private class CClasico:IComprimir
        {
            //Método para comprimir Encoder
            /// Autor: Antonio Galván Uriza
            /// Fecha: 05-09-21
            /// Versión: 1.0.2.1
            /// Modificación: 07-09-21
            /// <param name="pOrigen">Ruta de origen de la imagen</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public void comprimir(string pOrigen, string pDestino, int pResolucion)
            {
                pOrigen = @"" + pOrigen;
                pDestino = @"" + pDestino;

                using (Bitmap mybitmab = new Bitmap(pOrigen))
                {
                    ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                    //ERROR: La idea original era pasar el parámetro con el valor de la resolución, sin embar
                    EncoderParameters myEncoderParameters = new EncoderParameters(1);
                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
                    myEncoderParameters.Param[0] = myEncoderParameter;
                    mybitmab.Save(pDestino, myImageCodecInfo, myEncoderParameters);
                }
            }

            //Método para comprimir con CMagick (framework)
            /// Autor: Antonio Galván Uriza
            /// Fecha: 07-09-21
            /// Versión: 1.0.0.0
            /// Modificación: 07-09-21
            /// <param name="mimeType">Tipo de imagen</param>
            private static ImageCodecInfo GetEncoderInfo(String mimeType)
            {
                int j;
                ImageCodecInfo[] encoders;
                encoders = ImageCodecInfo.GetImageEncoders();
                for (j = 0; j < encoders.Length; ++j)
                {
                    if (encoders[j].MimeType == mimeType)
                        return encoders[j];
                }
                return null;
            }

        }
    }
}
