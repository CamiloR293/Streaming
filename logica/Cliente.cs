using Streaming.connection;
using System.Data;
using System.Windows.Forms;

namespace Streaming.logica
{
    internal class cliente
    {


        public cliente(string user, string pName, string sName, string pApellido, string sapellido, string password, string fNacimiento, string telefono, string correo)
        {
            this.user = user;
            this.pName = pName;
            this.sName = sName;
            this.pApellido = pApellido;
            this.sapellido = sapellido;
            this.password = password;
            this.fNacimiento = fNacimiento;
            this.telefono = telefono;
            this.correo = correo;
        }


        Datos dt = new Datos();

        public int ingresarRegistro(string usuario, string primernombre, string segundonombre, string primerapellido,
            string segundoapellido, string contrasenia, string fechanac, string telefono, string correo)
        {
            int resultado;
            string consulta;
            consulta = "insert into cliente (CODIGO, NOMBRE_USUARIO_CLIENTE, PRIMERNOMBRE, SEGUNDONOMBRE, PRIMERAPELLIDO, SEGUNDOAPELLIDO, FECHANACIMIENTO, CONTRASENIA, TELEFONO, CORREO)" +
                " values((select max(codigo + 1) as codigo from CLIENTE)," + "'" + usuario + "'" + ", '" + primernombre + "' , '" + segundonombre + "', '" +
                primerapellido + "','" + segundoapellido + "'," + "to_Date('" + fechanac + "','dd-mm-yyyy'), '" + contrasenia + "','" + telefono + "','" + correo + "')";
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
                "on R.nitBanco=B.nitBanco where B.nitBanco =" + nitBanco + "AND fecIngreso= to_Date('" + fechaIngreso + "', 'dd-mm-yyyy')";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
        private string user;
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string pName;
        public string PName
        {
            get { return pName; }
            set { pName = value; }
        }

        private string sName;
        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }

        private string pApellido;
        public string PApellido
        {
            get { return pApellido; }
            set { pApellido = value; }
        }

        private string sapellido;
        public string SApellido
        {
            get { return sapellido; }
            set { sapellido = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string fNacimiento;
        public string FNacimiento
        {
            get { return fNacimiento; }
            set { fNacimiento = value; }
        }

        private string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


    }
}
