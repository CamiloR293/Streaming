using Oracle.ManagedDataAccess.Client;
using Streaming.connection;
using System;
using System.Data;

namespace Streaming.logica
{
    internal class plansuscripcion
    {
        Datos dt = new Datos();

        public int ingresarplansuscripcion(int codigo, string nombre, int precio, string duracion)
        {
            int resultado;
            string consulta;
            consulta = "insert into plansuscripcion values(" + codigo + ", '" + nombre + "', " + precio + ", '" + duracion + "')";
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public int consultarSuscripcion(int codigo)
        {
            DateTime fechaVencimiento=this.ObtenerFechaVencimientoClientePlan(codigo);
            int resultado;
            string consulta;
            consulta = "update plansuscripcion set fecha_vencimiento=to_Date('"+fechaVencimiento+ "','dd-mm-yyyy')" + "WHERE codigo_cliente="+ codigo;
            resultado = dt.ejecutarDML(consulta);
            return resultado;
        }
        public DateTime ObtenerFechaVencimientoClientePlan(int codigoCliente)
        {
            DateTime fechaVencimiento = DateTime.MinValue;

            string consulta = "SELECT FECHA_VENCIMIENTO FROM CLIENTE_PLAN WHERE CODIGO_CLIENTE = :CodigoCliente";

            using (OracleConnection conexion = new OracleConnection(dt.getCadenaConexion()))
            {
                OracleCommand comando = new OracleCommand(consulta, conexion);
                comando.Parameters.Add(new OracleParameter(":CodigoCliente", OracleDbType.Int32)).Value = codigoCliente;

                conexion.Open();

                object resultado = comando.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    fechaVencimiento = Convert.ToDateTime(resultado);
                }

                conexion.Close();
            }

            return fechaVencimiento;
        }

    }
}
