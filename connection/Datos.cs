using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace Streaming.connection
{
    class Datos
    {
        //Creo la cadena de conexion 
        string cadenaConexion = "Data Source = localhost; User ID = admin; Password=admin123";

        //Metodo para ejecutar una sentencia insert , update o delete
        public int ejecutarDML(string consulta)
        {

            int filasAfectadas;
            //paso 1: creo una conexion
            OracleConnection miConexion = new OracleConnection(cadenaConexion);

            //paso 2: creo un comando
            OracleCommand comando = new OracleCommand(consulta, miConexion);

            //paso 3: abrir la conexion
            try
            {
                miConexion.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show("Conexión fallida -->" + E.Message);

            }

            //Paso 4: ejecutar el comando, este me devuelve el 
            //Numero de filas que se afectaron ya sea con el insert,
            //update o delete que le llegaba a la consulta
            try
            {
                filasAfectadas = comando.ExecuteNonQuery();

                //cerrar la conexion
                miConexion.Close();
                return filasAfectadas;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return -1;
            }
        }
        public int procedureIdAdmin(string usuario)
        {
            int id = 0;
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            using (OracleCommand command = new OracleCommand("obtener_id_admin", miConexion))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("p_usuario", OracleDbType.Varchar2).Value = usuario;
                command.Parameters.Add("p_id", OracleDbType.Int32).Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                id = Convert.ToInt32(command.Parameters["p_id"].Value);
            }

            return id;
        }

        //Metodo para ejecutar sentencias select
        public DataSet ejecutarSELECT(string consulta)
        {
            //Paso 1: Creo un dataset vacio
            DataSet ds = new DataSet();

            //Paso 2: Creo un adaptador 
            OracleDataAdapter adaptador = new OracleDataAdapter(consulta, cadenaConexion);

            //Paso 3: LLeno el dataset ds a traves del adaptador
            adaptador.Fill(ds, "ResultadoDatos");
            return ds;
        }
    }
}
