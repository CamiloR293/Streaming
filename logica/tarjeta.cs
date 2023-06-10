using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class tarjeta
    {
        Datos dt = new Datos();
        public int ingresartarjeta(int cliente, int codigo, string numerotarjeta,
         string fechaexp, string nombretarjeta, string cvv, string tipotarjeta)
        {
            int resultado;
            string consulta;
            consulta = "insert into tarjeta values(" + cliente + "," + codigo + ", '" + numerotarjeta + "', '" + fechaexp + "', '" + nombretarjeta + "', '" + cvv + "', '" + tipotarjeta + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
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
