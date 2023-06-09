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
            openForms(new AgregarTarjeta(panelContainer, this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente admin = new cliente();
            // contador para originar codigo de cliente
            int contador = 0;
            contador = contador + 1;
            //creación de variable para capturar la fecha actual
            DateTime fechaActual = DateTime.Now.Date;
            // enviar datos de caja de texto para agregar nuevo usuario
            int resultado = admin.ingresarRegistro( contador, txtUsuario.Text, txtPNombre.Text,
                                                    txtSNombre.Text, txtPApellido.Text,
                                                    txtSApellido.Text, txtPassword.Text,
                                                    txtFechaNacimiento.Text, txtTelefono.Text,
                                                    txtCorreo.Text, 2, fechaActual.ToString("dd/MM/yyyy") );
            //validacion
            if (resultado > 0 & txtPassword.Text.Equals(txtRepPassword.Text))
                MessageBox.Show("Usuario registrado", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Usuario NO registrado", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
