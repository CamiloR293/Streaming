using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class producto
    {
        Datos dt = new Datos();
        public DataSet consultarProducto()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from producto";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
    }
}
