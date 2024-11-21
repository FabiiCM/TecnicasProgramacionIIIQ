

namespace Controller.DataHandler
{

    /// <summary>
    //contato para elementos que manejan datos
    /// </summary>
    public interface IDataHandler
    {
        /// <summary>
        /// Lee datos de un archivo.
        /// </summary>
        /// <param name="filePath">Ruta del archivo.</param>
        /// <returns>Lista de cadenas con los datos.</returns>
        List<string> ReadData(string filePath);

        /// <summary>
        /// Escribe datos en un archivo.
        /// </summary>
        /// <param name="filePath">Ruta del archivo.</param>
        /// <param name="data">Datos a escribir.</param>
        void WriteData(string filePath, List<string> data);
    }
}
