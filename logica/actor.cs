using Streaming.connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming.logica
{
    internal class actor
    {
        Datos dt = new Datos();
        public int ingresaractor(int codigo, string primernombre, string segundonombre,
            string primerapellido, string segundoapellido, string fechanacimiento)
        {
            int resultado;
            string consulta = "insert into actor values(" + codigo + ",'" + primernombre + "', '" + segundonombre + "', '"
                + primerapellido + "', '" + segundoapellido + "', '" + "to_Date('" + fechanacimiento + "','dd/mm/yyyy'))";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DataSet consultaActor()
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from actor";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
    }
}

