using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class plansuscripcion
    {
        Datos dt = new Datos();
        public DataSet consultarSuscripcion()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from planSuscripcion";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
    }
}
