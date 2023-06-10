using Streaming.connection;
using System.Data;


namespace Streaming.logica
{
    internal class Cliente
    {
        Datos dt = new Datos();
        public static int codigo;
        public Cliente()
        {
            ++codigo;//identificador unico para cada nuevo objeto de la clase cliente
        }
        public int ingresarRegistro(string usuario, string primernombre, string segundonombre, string primerapellido,
                                    string segundoapellido, string contrasenia, string fechanac, string telefono, string correo,
                                    int tipoaaceso, string fechaultinicio)
        {
            int resultado;
            string consulta;
            //consulta = "insert into cliente values(" + codigo + "," + "'"+usuario+"'" + ", '"+ primernombre+"' , '" + segundonombre+"', '"+ 
            //                                        primerapellido+"','"+segundoapellido+"',"+ "to_Date('" + fechanac + "','dd-mm-yyyy'), '" + contrasenia 
            //                                        + "',"+ "to_Date(sysdate,'dd-mm-yyyy'),' " +telefono+"','"+ correo +"','"+tipoaaceso+"'," + 
            //                                        "to_Date('" + fechaultinicio + "','dd-mm-yyyy'))";

            consulta = "insert into cliente values(" + codigo + ", '" + usuario + "', '" + primernombre + "', '" + segundonombre +
                                                       "', '" + primerapellido + "', '" + segundoapellido + "', '" + fechanac +
                                                       "', '" + contrasenia + "', '" + fechaultinicio + "', '" + telefono +
                                                       "', '" + correo + "', " + tipoaaceso + ");";
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
                "on R.nitBanco=B.nitBanco where B.nitBanco =" + nitBanco + "AND fecIngreso= to_Date('" + fechaIngreso + "', 'dd-mm-yyyy');";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }

    }
}
