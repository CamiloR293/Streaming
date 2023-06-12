using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Types;

namespace Streaming.connection
{
    class Datos
    {
        //Creo la cadena de conexion 
        string cadenaConexion = "Data Source = localhost; User ID = admin; Password=admin123";
        public string getCadenaConexion()
        {
            return cadenaConexion;
        }

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
            catch (OracleException E)
            {
                MessageBox.Show(E.Message);
                if(E.Number == 20001)
                {
                    return E.Number;
                }
                return -1;
            }
        }
        public void procedureIdEstadoSuscripcion(int codigoC, int plan, String planDuracion)
        {
            using (OracleConnection connection = new OracleConnection(this.getCadenaConexion()))
            {
                try
                {
                    connection.Open();

                    // Insertar registro
                    OracleCommand insertCommand = new OracleCommand();
                    insertCommand.Connection = connection;
                    insertCommand.CommandText = "INSERT INTO CLIENTE_PLAN (CODIGO, CODIGO_CLIENTE, CODIGO_PLAN, FECHA_COMPRA, FECHA_VENCIMIENTO, ESTADO) VALUES ((select max(codigo)+1 FROM CLIENTE_PLAN), :codigoCliente, :codigoPlan, :fechaCompra, :fechaVencimiento, :estado)";
                    insertCommand.Parameters.Add(":codigoCliente", OracleDbType.Decimal).Value = codigoC; // Código de cliente
                    insertCommand.Parameters.Add(":codigoPlan", OracleDbType.Decimal).Value = plan; // Código de plan
                    insertCommand.Parameters.Add(":fechaCompra", OracleDbType.Date).Value = DateTime.Now; // Fecha de compra
                    if (planDuracion.Equals("Anual"))
                    {
                        insertCommand.Parameters.Add(":fechaVencimiento", OracleDbType.Date).Value = DateTime.Now.AddDays(366); // Fecha de vencimiento

                    }
                    else
                    {
                        insertCommand.Parameters.Add(":fechaVencimiento", OracleDbType.Date).Value = DateTime.Now.AddDays(31); // Fecha de vencimiento
                    }
                    insertCommand.Parameters.Add(":estado", OracleDbType.Varchar2).Value = "ACTIVO"; // Estado
                    insertCommand.ExecuteNonQuery();

                    // Ejecutar procedimiento
                    OracleCommand procedureCommand = new OracleCommand();
                    procedureCommand.Connection = connection;
                    procedureCommand.CommandText = "ACTUALIZAR_ESTADO_CLIENTE_PLAN";
                    procedureCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    procedureCommand.ExecuteNonQuery();

                    Console.WriteLine("Inserción y ejecución del procedimiento completadas correctamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al realizar la inserción y ejecutar el procedimiento: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public int procedureIdAdmin(string usuario)
        {
            int id = 0;
            OracleConnection miConexion = new OracleConnection(cadenaConexion);
            try
            {
                miConexion.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show("Conexión fallida -->" + E.Message);

            }
            using (OracleCommand command = new OracleCommand("obtener_id_admin", miConexion))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("p_usuario", OracleDbType.Varchar2).Value = usuario;
                command.Parameters.Add("p_id", OracleDbType.Int32).Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                OracleDecimal oracleDecimal = (OracleDecimal)command.Parameters["p_id"].Value;
                id = oracleDecimal.ToInt32();
            }

            return id;
        }
        public void ObtenerActoresProducto(int codigoProducto, OracleConnection connection)
        {
            try
            {
                using (OracleCommand command = new OracleCommand("lista_actores_producto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetro de entrada
                    command.Parameters.Add("v_idProducto", OracleDbType.Int32).Value = codigoProducto;

                    // Parámetros de salida
                    command.Parameters.Add("table_plan", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    command.Parameters.Add("v_genero", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    // Obtener los resultados
                    OracleDataReader reader = ((OracleRefCursor)command.Parameters["table_plan"].Value).GetDataReader();
                    string genero = command.Parameters["v_genero"].Value.ToString();

                    Console.WriteLine("ACTORES QUE PARTICIPAN EN LA PELÍCULA:");
                    Console.WriteLine("-------------------------------------");

                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                        int codigo = Convert.ToInt32(reader["CODIGO"]);
                        string primerNombre = reader["PRIMERNOMBRE"].ToString();
                        string segundoNombre = reader["SEGUNDONOMBRE"].ToString();
                        string primerApellido = reader["PRIMERAPELLIDO"].ToString();
                        string segundoApellido = reader["SEGUNDOAPELLIDO"].ToString();
                        DateTime fechaNacimiento = Convert.ToDateTime(reader["FECHANACIMIENTO"]);
                        string papel = reader["PAPEL"].ToString();

                        Console.WriteLine($"CÓDIGO: {codigo}");
                        Console.WriteLine($"NOMBRES: {primerNombre} {segundoNombre}");
                        Console.WriteLine($"APELLIDOS: {primerApellido} {segundoApellido}");
                        Console.WriteLine($"FECHA DE NACIMIENTO: {fechaNacimiento}");
                        Console.WriteLine($"PAPEL: {papel}");
                        Console.WriteLine("-------------------------------------");
                    }

                    Console.WriteLine($"En la película hay {count} actores");

                    if (count > 0)
                    {
                        Console.WriteLine("LOS ACTORES TAMBIÉN PARTICIPAN EN LAS SIGUIENTES PELÍCULAS:");
                        Console.WriteLine("-------------------------------------");

                        reader.NextResult();
                        while (reader.Read())
                        {
                            string nombrePelicula = reader["NOMBRE"].ToString();
                            Console.WriteLine($"NOMBRE: {nombrePelicula}");
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al obtener los actores del producto: " + ex.Message);
            }
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
