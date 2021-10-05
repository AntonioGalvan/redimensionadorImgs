namespace RendimensionImagenes
{
    //Interfaz de patrón proxy
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.0.2
    /// Modificación: 07-09-21
    public interface ISujeto
    {
        bool Inicio(string pUser, string pPassword);
        bool Peticion(string pOrigen, string pDestino, int pOpcion, int pResolucion);

    }
}
