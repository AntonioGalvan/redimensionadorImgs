using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ImageMagick;

namespace Resizer
{

    //Clase para alternar entre versiones
    /// Autor: Antonio Galván Uriza
    /// Fecha: 06-10-21
    /// Versión: 2.0.0.3
    /// Modificación: 01-12-21
    public class CAbstraccion
    {
        //Propiedad para realizar instancia de Singleton
        private static CAbstraccion instancia;

        //Propiedad para utilizar patrón bridge
        private IBridge sesion;
        private CAbstraccion(int pTipo)
        {
            if (pTipo == 1)
                sesion = new CProxy.CInicio();
            if (pTipo == 2)
                sesion = new CProxy.CInicio2();
        }

        /// Método para instanciar la clase
        /// Autor: Antonio Galván Uriza
        /// Fecha: 09-11-21
        /// Versión: 1.0.0.0
        /// Modificación: 09-11-21
        /// <param name="pUser">Contiene el usuario</param>
        public static CAbstraccion inicial(int pTipo)
        {
            if (instancia == null)
            {
                instancia = new CAbstraccion(pTipo);
            }

            return instancia;
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
            return sesion.Inicio(pUser, pPassword);
        }

        //Método para registrar usuarios
        /// Autor: Antonio Galván Uriza
        /// Fecha: 01-12-21
        /// Versión: 1.0.0.0
        /// Modificación: 01-12-21
        /// <param name="pNombre">Contiene el usuario</param>
        /// <param name="pUsuario">Contiene el usuario</param>
        /// <param name="pPassword">Contiene la contraseña</param>
        public bool registrar(string pNombre, string pUsuario, string pPassword)
        {
            return sesion.Registro(pNombre, pUsuario, pPassword);
        }

        //Método para obtener datos de usuarios
        /// Autor: Antonio Galván Uriza
        /// Fecha: 01-12-21
        /// Versión: 1.0.0.0
        /// Modificación: 01-12-21
        public string obtenerDatos()
        {
            return sesion.obtenerNombre();
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
        /// <param name="pArchivos">Contiene los orígenes</param>
        /// <param name="pDestino">Contiene el destino</param>
        /// <param name="pOpcion">Contiene la opcion de compresión</param>
        /// <param name="pResolucion">Contiene la resolución</param>
        public bool comprimir(List<string> pArchivos, string pDestino, int pOpcion, int pResolucion)
        {
            return sesion.Peticion(pArchivos, pDestino, pOpcion, pResolucion);
        }
    }

    //Interfaz para bridge
    /// Autor: Antonio Galván Uriza
    /// Fecha: 06-10-21
    /// Versión: 1.0.0.1
    /// Modificación: 01-12-21
    public interface IBridge
    {
        bool Inicio(string pUser, string pPassword);
        bool Registro(string pNombre, string pUser, string pPassword);
        bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion);
        bool Peticion(List<string> pOrigen, string pDestino, int pOpcion, int pResolucion);
        string obtenerNombre();
    }

    //Interfaz de patrón estrategia
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.0.3
    /// Modificación: 05-09-21
    public interface IComprimir
    {
        void comprimir(string pOrigen, string pDestino, int pResolucion);
    }

    //Interfaz de patrón proxy
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.0.3
    /// Modificación: 06-10-21
    public interface ISujeto
    {
        bool Inicio(string pUser, string pPassword);
        bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion);

    }

    //Clase Proxy
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 2.0.1.1
    /// Modificación: 01-12-21
    public class CProxy
    {

        private static int numImg = 0;
        private static List<CUsuario> usuarios = new List<CUsuario>();


        //Clase CInicio que contiene los métodos de acceso y las clases principales
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.3.1
        /// Modificación: 01-12-21
        public class CInicio : ISujeto, IBridge
        {
            private IComprimir resizer;
            private static bool isAuthenticated = false;
            private static string nombre = "";

            public static string Nombre { get => nombre; }
            public static bool IsAuthenticated { get => isAuthenticated; private set => isAuthenticated = value; }

            //Método para iniciar sesión en la aplicación
            /// Autor: Antonio Galván Uriza
            /// Fecha: 05-09-21
            /// Versión: 1.0.0.3
            /// Modificación: 01-12-21
            /// <param name="pUser">Usuario</param>
            /// <param name="pPassword">Contraseña del usuario</param>
            public bool Inicio(string pUser, string pPassword)
            {
                //si el archivo existe lo deserializamos y obtenemos los usuarios
                if (File.Exists("usuario.rzr"))
                {
                    BinaryFormatter formateador = new BinaryFormatter();
                    Stream miStream;

                    miStream = new FileStream("usuario.rzr", FileMode.Open, FileAccess.Read, FileShare.None);
                    usuarios = (List<CUsuario>)formateador.Deserialize(miStream);
                    miStream.Close();
                }

                //Autenticación básica
                if (usuarios.Exists(x => x.Usuario == pUser && x.Password == pPassword))
                {
                    nombre = usuarios.Find(x => x.Usuario == pUser).Nombre;
                    IsAuthenticated = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Método para registrarse en la aplicación
            /// Autor: Antonio Galván Uriza
            /// Fecha: 01-12-21
            /// Versión: 1.0.0.0
            /// Modificación: 01-12-21
            /// <param name="pNombre">nombre</param>
            /// <param name="pUser">Usuario</param>
            /// <param name="pPassword">Contraseña del usuario</param>
            public bool Registro(string pNombre, string pUser, string pPassword)
            {
                try
                {
                    BinaryFormatter formateador = new BinaryFormatter();
                    Stream miStream;

                    //Obtenemos los usuarios registrados para ver si alguno ya existe
                    if (File.Exists("usuario.rzr"))
                    {
                        miStream = new FileStream("usuario.rzr", FileMode.Open, FileAccess.Read, FileShare.None);
                        usuarios = (List<CUsuario>)formateador.Deserialize(miStream);
                        miStream.Close();
                    }


                    CUsuario usuario = new CUsuario();

                    usuario.Nombre = pNombre;
                    usuario.Usuario = pUser;
                    usuario.Password = pPassword;

                    //Si el usuario no existe lo registramos y serializamos
                    if (!usuarios.Exists(x => x.Usuario == usuario.Usuario))
                    {
                        usuarios.Add(usuario);

                        miStream = new FileStream("usuario.rzr", FileMode.Create, FileAccess.Write, FileShare.None);
                        formateador.Serialize(miStream, usuarios);
                        miStream.Close();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    return false;
                }
            }

            //Método para obtener los datos del usuario
            /// Autor: Antonio Galván Uriza
            /// Fecha: 01-12-21
            /// Versión: 1.0.0.0
            /// Modificación: 01-12-21
            public string obtenerNombre()
            {
                return Nombre;
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
                if (IsAuthenticated == true)
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

            //Método de petición para usar los servicios del app
            /// Autor: Antonio Galván Uriza
            /// Fecha: 06-10-21
            /// Versión: 1.0.0.0
            /// Modificación: 06-10-21
            /// <param name="pOrigen">Lista de Rutas de origen de las imagenes</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pOpcion">Opción del compresor que se usará</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public bool Peticion(List<string> pOrigen, string pDestino, int pOpcion, int pResolucion)
            {
                return false;
            }
        }

        //Clase de inicio de la versión 2.0
        /// Autor: Antonio Galván Uriza
        /// Fecha: 06-10-21
        /// Versión: 1.0.1.0
        /// Modificación: 01-12-21
        public class CInicio2 : ISujeto, IBridge
        {
            private IComprimir resizer;
            private static bool isAuthenticated = false;
            private static string nombre = "";

            public static string Nombre { get => nombre; }
            public static bool IsAuthenticated { get => isAuthenticated; private set => isAuthenticated = value; }

            
            //Método para iniciar sesión en la aplicación
            /// Autor: Antonio Galván Uriza
            /// Fecha: 06-10-21
            /// Versión: 1.0.0.3
            /// Modificación: 01-12-21
            /// <param name="pUser">Usuario</param>
            /// <param name="pPassword">Contrasñeña del usuario</param>
            public bool Inicio(string pUser, string pPassword)
            {
                if (File.Exists("usuario.rzr"))
                {
                    BinaryFormatter formateador = new BinaryFormatter();
                    Stream miStream;

                    miStream = new FileStream("usuario.rzr", FileMode.Open, FileAccess.Read, FileShare.None);
                    usuarios = (List<CUsuario>)formateador.Deserialize(miStream);
                    miStream.Close();
                }

                //Autenticación básica
                if (usuarios.Exists(x => x.Usuario == pUser && x.Password == pPassword))
                {
                    nombre = usuarios.Find(x => x.Usuario == pUser).Nombre;
                    IsAuthenticated = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Método para registrar usuario en la aplicación
            /// Autor: Antonio Galván Uriza
            /// Fecha: 01-12-21
            /// Versión: 1.0.0.0
            /// Modificación: 01-12-21
            /// <param name="pNombre">Nombre</param>
            /// <param name="pUser">Usuario</param>
            /// <param name="pPassword">Contraseña del usuario</param>
            public bool Registro(string pNombre, string pUser, string pPassword)
            {
                try
                {
                    BinaryFormatter formateador = new BinaryFormatter();
                    Stream miStream;

                    if (File.Exists("usuario.rzr"))
                    {
                        miStream = new FileStream("usuario.rzr", FileMode.Open, FileAccess.Read, FileShare.None);
                        usuarios = (List<CUsuario>)formateador.Deserialize(miStream);
                        miStream.Close();
                    }


                    CUsuario usuario = new CUsuario();

                    usuario.Nombre = pNombre;
                    usuario.Usuario = pUser;
                    usuario.Password = pPassword;

                    if (!usuarios.Exists(x => x.Usuario == usuario.Usuario))
                    {
                        usuarios.Add(usuario);

                        miStream = new FileStream("usuario.rzr", FileMode.Create, FileAccess.Write, FileShare.None);
                        formateador.Serialize(miStream, usuarios);
                        miStream.Close();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception es)
                {

                    throw es;
                }
            }

            //Método para obtener los datos del usuario
            /// Autor: Antonio Galván Uriza
            /// Fecha: 01-12-21
            /// Versión: 1.0.0.0
            /// Modificación: 01-12-21
            public string obtenerNombre()
            {
                return Nombre;
            }

            //Método de petición para usar los servicios del app
            /// Autor: Antonio Galván Uriza
            /// Fecha: 06-10-21
            /// Versión: 1.0.0.0
            /// Modificación: 06-10-21
            /// <param name="pOrigen">Ruta de origen de la imagen</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pOpcion">Opción del compresor que se usará</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion)
            {
                //Verifica si el usuario está autenticado
                if (IsAuthenticated == true)
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

            //Método de petición para usar los servicios del app
            /// Autor: Antonio Galván Uriza
            /// Fecha: 06-10-21
            /// Versión: 1.0.0.0
            /// Modificación: 06-10-21
            /// <param name="pOrigen">Lista de Rutas de origen de las imagenes</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pOpcion">Opción del compresor que se usará</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public bool Peticion(List<string> pOrigen, string pDestino, int pOpcion, int pResolucion)
            {
                //Verifica si el usuario está autenticado
                if (IsAuthenticated == true)
                {
                    if (pOpcion == 1)
                        resizer = new CClasico();
                    if (pOpcion == 2)
                        resizer = new CMagick();

                    //Trata de realizar la compresión
                    try
                    {
                        foreach (string img in pOrigen)
                        {
                            resizer.comprimir(img, pDestino, pResolucion);
                        }
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
        private class CMagick : IComprimir
        {
            //Método para comprimir con CMagick (framework)
            /// Autor: Antonio Galván Uriza
            /// Fecha: 05-09-21
            /// Versión: 1.0.1.0
            /// Modificación: 10-11-21
            /// <param name="pOrigen">Ruta de origen de la imagen</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public void comprimir(string pOrigen, string pDestino, int pResolucion)
            {
                pOrigen = @"" + pOrigen;

                while (File.Exists(@"" + pDestino + "/img-min" + numImg + ".jpg"))
                {
                    numImg++;
                }

                pDestino = @"" + pDestino + "/img-min" + numImg + ".jpg";

                using (MagickImage oMagickImage = new MagickImage(pOrigen))
                {
                    oMagickImage.Resize(pResolucion, 0);

                    oMagickImage.Write(pDestino);
                }
                numImg++;
            }
        }

        //Clase de compresor clásico (privada)
        /// Autor: Antonio Galván Uriza
        /// Fecha: 05-09-21
        /// Versión: 1.0.2.1
        /// Modificación: 07-09-21
        private class CClasico : IComprimir
        {
            //Método para comprimir Encoder
            /// Autor: Antonio Galván Uriza
            /// Fecha: 05-09-21
            /// Versión: 1.0.3.3
            /// Modificación: 10-11-21
            /// <param name="pOrigen">Ruta de origen de la imagen</param>
            /// <param name="pDestino">Ruta en la que se colocará la imagen</param>
            /// <param name="pResolucion">Resolución de la nueva imagen</param>
            public void comprimir(string pOrigen, string pDestino, int pResolucion)
            {
                pOrigen = @"" + pOrigen;

                while (File.Exists(@"" + pDestino + "/img-min" + numImg + ".jpg"))
                {
                    numImg++;
                }

                pDestino = @"" + pDestino + "/img-min" + numImg + ".jpg";

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
                numImg++;
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
