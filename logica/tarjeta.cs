using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class Tarjeta
    {
        Datos dt = new Datos();
        private static int codigo;
        public Tarjeta()
        {
            ++codigo;//identificador unico para cada objeto de la clase Tarjeta
        }
        public DataSet consultarTarjeta()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from tarjeta";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
        //funcion para agregar tarjeta de credito o debito
        public int registrarTarjeta(int cliente, string numeroTarjeta, string fechaExp, string nombreTarjeta,
                                    string tipoTarjeta)
        {
            int resultado;
            string consulta;
            consulta = "insert into tarjeta values (" + cliente + ", " + codigo + ", '" + numeroTarjeta +
                                                    "', '" + fechaExp + "', '" + nombreTarjeta + "', '" +
                                                    tipoTarjeta + "');";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        //por si no se quire colocar el id del cliente
        public int registrarTarjeta(string numeroTarjeta, string fechaExp, string nombreTarjeta,
                                    string tipoTarjeta)
        {
            int resultado;
            string consulta;
            consulta = "insert into tarjeta values (" + codigo + ", '" + numeroTarjeta +
                                                    "', '" + fechaExp + "', '" + nombreTarjeta + "', '" +
                                                    tipoTarjeta + "');";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}
