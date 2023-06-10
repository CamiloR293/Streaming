using Streaming.connection;
using System.Data;


namespace Streaming.logica
{
    internal class cliente
    {
        Datos dt = new Datos();

        public int ingresarRegistro(string usuario, string primernombre, string segundonombre, string primerapellido,
            string segundoapellido, string contrasenia, string fechanac, string telefono, string correo)
        {
            int resultado;
            string consulta;
            consulta = "insert into cliente (CODIGO, NOMBRE_USUARIO_CLIENTE, PRIMERNOMBRE, SEGUNDONOMBRE, PRIMERAPELLIDO, SEGUNDOAPELLIDO, FECHANACIMIENTO, CONTRASENIA, TELEFONO, CORREO)" +
                " values((select max(codigo + 1) as codigo from CLIENTE)," + "'" + usuario + "'" + ", '" + primernombre + "' , '" + segundonombre + "', '" +
                primerapellido + "','" + segundoapellido + "'," + "to_Date('" + fechanac + "','dd-mm-yyyy'), '" + contrasenia + "','" + telefono + "','" + correo + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultarRegistro()
        {
            string consulta;
            consulta = "select * from Registro";
            DataSet miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
        public DataSet consultarInfo(int nitBanco, string fechaIngreso)
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select B.nombanco, C.clienteid, C.clinombre, C.cliapellido,r.fecretiro " +
                "from Registro R inner join Cliente C " +
                "on C.ClienteID=R.ClienteID inner join Banco B " +
                "on R.nitBanco=B.nitBanco where B.nitBanco =" + nitBanco + "AND fecIngreso= to_Date('" + fechaIngreso + "', 'dd-mm-yyyy')";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }

    }
}
