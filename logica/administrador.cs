using Streaming.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming.logica
{
    internal class administrador
    {


        Datos dt = new Datos();
        public administrador()
        {
        }

        public DataSet consultarAdmin()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from Administrador";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
    }
}
