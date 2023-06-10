using Streaming.connection;
using System.Data;

namespace Streaming.logica
{
    internal class producto
    {
        Datos dt = new Datos();
        public int ingresarproducto(int codigo, int codigo_admin, string nombre, string descripcion,
            string fechaestreno, string duracion, string genero, string tipo_producto)
        {
            int resultado;
            string consulta;
            consulta = "insert into producto values(" + codigo + "," + codigo_admin + ", '" + nombre + "', '"
                + descripcion + "', " + "to_Date('" + fechaestreno + "','dd/mm/yyyy'), '" + duracion + "', '" + genero + "', '" + tipo_producto + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
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
