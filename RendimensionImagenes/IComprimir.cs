namespace RendimensionImagenes
{
    //Interfaz de patrón estrategia
    /// Autor: Antonio Galván Uriza
    /// Fecha: 05-09-21
    /// Versión: 1.0.0.3
    /// Modificación: 05-09-21
    interface IComprimir
    {
        void comprimir(string pOrigen, string pDestino, int pResolucion);
    }
}
