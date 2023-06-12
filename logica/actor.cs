﻿using Streaming.connection;
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

        public int ingresarActor(string primernombre, string segundonombre,
            string primerapellido, string segundoapellido, string fechanacimiento)
        {
            int resultado;
            string consulta = "insert into actor values((select nvl(max(codigo) + 1, 1) as codigo from CLIENTE), '" + primernombre + "', '" + segundonombre + "', '"
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
        public int registrarProductoActor(string papel)
        {
            string consulta = "insert into actor_producto values (select max(codigo) from actor, select max(codigo) from producto, '" + 
                                papel + "');";
            int resultado;
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
    }
}

