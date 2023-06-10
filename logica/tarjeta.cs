using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class tarjeta
    {
        Datos dt = new Datos();
        public DataSet consultarTarjeta()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from tarjeta";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
    }
}
