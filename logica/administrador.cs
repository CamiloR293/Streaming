using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class administrador
    {


        Datos dt = new Datos();
        public administrador()
        {
        }

        public DataSet consultarAdmin()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from Administrador";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
    }
}
