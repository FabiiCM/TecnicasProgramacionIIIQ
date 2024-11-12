

namespace Controller.DataHandler
{

    /// <summary>
    //coctato para elementos que manejan datos
    /// </summary>
    public interface IDataHandler
    {
        /// <summary>
        //Lee los archivos 
        /// </summary>
        public void ReadData();

        /// <summary>
        //escribe los archivos
        /// </summary>
        public void WriteData();

    }
}
