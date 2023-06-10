using Streaming.logica;
using System;
using System.Windows.Forms;

namespace Streaming
{
    public partial class RegistroCliente : Form
    {
        Panel panelContainer = new Panel();
        public RegistroCliente(Panel panelContainer)
        {
            InitializeComponent();
            this.panelContainer = panelContainer;
        }

        private void picBoxReturnTo_Click(object sender, EventArgs e)
        {
            openForms(new Main());
        }
        private Form activeForm = null;
        private void openForms(Form newForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = newForm;

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(newForm);
            panelContainer.Tag = newForm;

            newForm.BringToFront();
            newForm.Show();
        }

        private void btnAgregarTarjeta_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals("") || txtPNombre.Text.Equals("") || txtPApellido.Text.Equals("") ||
                txtSNombre.Text.Equals("") || txtSApellido.Text.Equals("") || txtPassword.Text.Equals("") || txtFechaNacimiento.Text.Equals("") || txtTelefono.Text.Equals("")
                || txtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Algunos campos estan incorrectos o vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                openForms(new AgregarTarjeta(panelContainer, this, txtUsuario.Text, txtPNombre.Text, txtPApellido.Text,
                    txtSNombre.Text, txtSApellido.Text, txtPassword.Text, txtFechaNacimiento.Text, txtTelefono.Text
                    , txtCorreo.Text));
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente miCLiente = new cliente();
            // contador para originar codigo de cliente
            int contador = 40;
            //creación de variable para capturar la fecha actual
            // enviar datos de caja de texto para agregar nuevo usuario
            Console.WriteLine(txtUsuario.Text);
            int resultado = miCLiente.ingresarRegistro(txtUsuario.Text, txtPNombre.Text, txtPApellido.Text,
                txtSNombre.Text, txtSApellido.Text,txtPassword.Text, txtFechaNacimiento.Text, txtTelefono.Text
                , txtCorreo.Text);
            //validacion
            if (resultado > 0 & txtPassword.Text.Equals(txtRepPassword.Text))
                MessageBox.Show("Usuario registrado", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Usuario NO registrado", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //limpiar cajas de texto
            txtRepPassword.Clear();
            txtPassword.Clear();
            txtUsuario.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtFechaNacimiento.Clear();
            txtSApellido.Clear();
            txtPApellido.Clear();
            txtSNombre.Clear();
            txtPNombre.Clear();
            contador++;
        }
    }
}
