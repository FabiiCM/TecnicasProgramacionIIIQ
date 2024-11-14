
namespace Controller.DataHandler
{

    /// <summary>
    /// Implementación de <see cref="IDataHandler"/> al usar archivos
    /// </summary>
    /// <see cref="Controller.DataHandler.IDataHandler"/>
    internal class FileDataHandler : IDataHandler
    {
        /// <summary>
        /// lee el dato de un file
        /// </summary>
        public void ReadData()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "clientes.xlx");
            var fileString = File.ReadAllText(path);


        }

        /// <summary>
        /// Escribe el dato de un file
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void WriteData()
        {
            throw new NotImplementedException();
        }
    }
}
