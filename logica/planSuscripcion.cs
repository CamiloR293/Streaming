using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class plansuscripcion
    {
        Datos dt = new Datos();

        public int ingresarplansuscripcion(int codigo, string nombre, int precio, string duracion)
        {
            int resultado;
            string consulta;
            consulta = "insert into plansuscripcion values(" + codigo + ", '" + nombre + "', " + precio + ", '" + duracion + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
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
