using Streaming.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming.logica
{
    internal class producto
    {
        Datos dt = new Datos();
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
