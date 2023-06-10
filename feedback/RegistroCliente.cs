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
            cliente miCLiente = new cliente();
            // contador para originar codigo de cliente
            int contador = 40;
            //creación de variable para capturar la fecha actual
            DateTime fechaActual = DateTime.Now.Date;
            // enviar datos de caja de texto para agregar nuevo usuario
            int resultado = miCLiente.ingresarRegistro(txtUsuario.Text.ToString(), txtPNombre.Text.ToString(),
                                                    txtSNombre.Text.ToString(), txtPApellido.Text.ToString(),
                                                    txtSApellido.Text.ToString(), txtFechaNacimiento.Text.ToString(), 
                                                    txtPassword.Text.ToString() , txtTelefono.Text.ToString(),
                                                    txtCorreo.Text.ToString(), 2 );
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
            //sumar contador
            contador++;
        }
    }
}
