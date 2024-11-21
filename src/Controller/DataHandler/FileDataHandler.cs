
namespace Controller.DataHandler
{

    /// <summary>
    /// Implementación de las interfaces para manejar los archivos CSV.
    /// </summary>
    public class FileDataHandler : IDataHandler, IClientDataHandler, ITrainerDataHandler
    {
        private readonly string clientesPath;
        private readonly string entrenadoresPath;

        /// <summary>
        /// Inicializa las rutas de los archivos.
        /// </summary>
        /// <param name="clientesPath">Ruta del archivo de clientes.</param>
        /// <param name="entrenadoresPath">Ruta del archivo de entrenadores.</param>
        public FileDataHandler(string clientesPath, string entrenadoresPath)
        {
            this.clientesPath = clientesPath;
            this.entrenadoresPath = entrenadoresPath;
        }

        /// <summary>
        /// Lee datos desde un archivo.
        /// </summary>
        public List<string> ReadData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"El archivo {filePath} no existe.");

            return new List<string>(File.ReadAllLines(filePath));
        }

        /// <summary>
        /// Escribe datos en un archivo.
        /// </summary>
        public void WriteData(string filePath, List<string> data)
        {
            File.WriteAllLines(filePath, data);
        }

        /// <summary>
        /// Obtiene los datos de clientes.
        /// </summary>
        public List<string> GetClientes()
        {
            return ReadData(clientesPath);
        }

        /// <summary>
        /// Obtiene los datos de entrenadores.
        /// </summary>
        public List<string> GetEntrenadores()
        {
            return ReadData(entrenadoresPath);
        }
    }
}
