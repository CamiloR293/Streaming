using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Streaming.connection;

namespace Streaming.logica
{
    internal class Registro
    {

        Datos dt = new Datos();
        public int ingresarRegistro(int idCliente, int idBanco, string fechaIngreso, string fechaSalida)
        {
            int resultado;
            string consulta;
            consulta = "insert into Registro(clienteid,nitBanco, fecIngreso, fecRetiro) values(" + idCliente + "," + idBanco + ", to_Date('" + fechaIngreso + "','dd-mm-yyyy'), to_Date('" + fechaSalida + "','dd-mm-yyyy'))";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultarRegistro()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from Registro";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
        public DataSet consultarInfo(int nitBanco, string fechaIngreso)
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select B.nombanco, C.clienteid, C.clinombre, C.cliapellido,r.fecretiro from Registro R inner join Cliente C on C.ClienteID=R.ClienteID inner join Banco B on R.nitBanco=B.nitBanco where B.nitBanco =" + nitBanco + "AND fecIngreso= to_Date('" + fechaIngreso + "', 'dd-mm-yyyy')";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs; 
        }


    }
}
