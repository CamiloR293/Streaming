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
        public int ingresaradministrador(int codigo, int adm_id, string nombre_usuario_admin, string primernombre, string segundonombre,
            string primerapellido, string segundoapellido, string fechanacimiento, string contrasenia, string telefono, string correo)
        {
            int resultado;
            string consulta;
            consulta = "insert into administrador values(" + codigo + "," + adm_id + ", '" + nombre_usuario_admin + "','" + primernombre + "', '" + segundonombre + "', '"
                + primerapellido + "', '" + segundoapellido + "', '" + "to_Date('" + fechanacimiento + "','dd/mm/yyyy'), '" + contrasenia + "', '" + telefono + "', '" + correo + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }

        public DataSet consultarAdmin()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from Administrador";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
        public int retornarAdmin(string usuario)
        {
            return dt.procedureIdAdmin(usuario);

        }
    }
}
