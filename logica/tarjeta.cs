using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class tarjeta
    {
        Datos dt = new Datos();
        public int ingresartarjeta(string numerotarjeta,
         string fechaexp, string nombretarjeta, string cvv, string tipotarjeta)
        {
            int resultado;
            string consulta;
            consulta = "insert into tarjeta values((select max(codigo) from CLIENTE),(select max(codigo + 1) from TARJETA), '" + numerotarjeta + "', '" + fechaexp + "', '" + nombretarjeta + "', '" + cvv + "', '" + tipotarjeta + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public int ingresartarjetaLogin(int idCliente,  string numerotarjeta,
            string fechaexp, string nombretarjeta, string cvv, string tipotarjeta)
        {
            int resultado;
            string consulta;
            consulta = "insert into tarjeta values("+idCliente+",(select max(codigo + 1) from TARJETA), '" + numerotarjeta + "', '" + fechaexp + "', '" + nombretarjeta + "', '" + cvv + "', '" + tipotarjeta + "')";
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
