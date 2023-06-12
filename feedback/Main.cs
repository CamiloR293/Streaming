using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Streaming.logica;

namespace Streaming
{
    public partial class Main : Form
    {
        Panel panel = new Panel();

        public Cliente ClienteGlobal;
        private string cadenaConexion = "Data Source=localhost;User ID=admin;Password=admin123";

        public Main()
        {
            InitializeComponent();
        }

        #region txtUserName
        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Correo o nombre de usuario")) txtUserName.Clear();


        }
        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("")) txtUserName.Text = "Correo o nombre de usuario";
        }
        #endregion
        #region txtPassword
        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Contraseña"))
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Clear();
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Contraseña";
            }
        }
        #endregion
        #region OpenForm
        private Form activeForm = null;
        private Panel panelContainer;

        public void openForms(Form newForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = newForm;

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Add(newForm);
            pnlDesktop.Tag = newForm;

            newForm.BringToFront();
            newForm.Show();
        }
        #endregion
        private void lblRegister_Click(object sender, EventArgs e)
        {
            lblRegister.ForeColor = System.Drawing.Color.FromArgb(196, 110, 56);
            openForms(new RegistroCliente(pnlDesktop));
        }

        private void lblEmployeeAccount_Click(object sender, EventArgs e)
        {
            lblRegister.ForeColor = System.Drawing.Color.FromArgb(196, 110, 56);
            openForms(new MainEmpleado());

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            Cliente micliente = new Cliente();

            // Verificar las credenciales en la base de datos
            if (VerificarCredenciales(username, password))
            {
                // Credenciales válidas, el inicio de sesión es exitoso


                plansuscripcion miPlan = new plansuscripcion();

                lblRegister.ForeColor = System.Drawing.Color.FromArgb(196, 110, 56);
                ClienteGlobal = micliente.ObtenerClientePorUsuario(username);
                MessageBox.Show(ClienteGlobal.Codigo.ToString());
                int resultado = miPlan.consultarSuscripcion(ClienteGlobal.Codigo);
                if (resultado == 20001)
                {
                    // La suscripción ha vencido, mostrar mensaje y suspender acceso al contenido
                    MessageBox.Show("La suscripción ha vencido. Por favor renovar para disfrutar del contenido :)");
                    openForms(new PlanSuscripcionCliente(pnlDesktop, ClienteGlobal));

                }
                else
                {
                    if (resultado > 0)
                    {
                        openForms(new InicioCliente(ClienteGlobal));
                    }
                    else
                    {

                        // Ocurrió otra excepción, muestra un mensaje genérico o realiza las acciones correspondientes
                        MessageBox.Show("Error en el inicio de sesión");
                    }
                }

            }
            else
            {
                // Credenciales inválidas, muestra un mensaje de error o realiza las acciones correspondientes
                MessageBox.Show("Credenciales inválidas");
            }
        }



        private bool VerificarCredenciales(string username, string password)
        {
            using (OracleConnection miConexion = new OracleConnection(cadenaConexion))
            {
                miConexion.Open();

                string consulta = "SELECT COUNT(*) FROM CLIENTE WHERE NOMBRE_USUARIO_CLIENTE = :username AND CONTRASENIA = :password";

                using (OracleCommand comando = new OracleCommand(consulta, miConexion))
                {
                    comando.Parameters.Add(":username", OracleDbType.Varchar2).Value = username;
                    comando.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    miConexion.Close();
                    return count > 0;
                }

            }
        }

    }
}