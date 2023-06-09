using Streaming.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming.logica
{
    internal class plansuscripcion
    {
        Datos dt = new Datos();
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
