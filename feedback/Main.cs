﻿using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Streaming
{
    public partial class Main : Form
    {
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

            // Verificar las credenciales en la base de datos
            if (VerificarCredenciales(username, password))
            {
                // Credenciales válidas, el inicio de sesión es exitoso
                MessageBox.Show("Inicio de sesión exitoso");
                // Abre la siguiente ventana o realiza las acciones necesarias después del inicio de sesión exitoso
                lblRegister.ForeColor = System.Drawing.Color.FromArgb(196, 110, 56);
                openForms(new InicioCliente());
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

                    return count > 0;
                }
            }
        }

    }
}
