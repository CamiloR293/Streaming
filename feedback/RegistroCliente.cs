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

                openForms(new AgregarTarjeta(panelContainer, this, txtUsuario.Text, txtPNombre.Text, txtSNombre.Text, txtPApellido.Text
                    , txtSApellido.Text, txtPassword.Text, txtFechaNacimiento.Text, txtTelefono.Text
                    , txtCorreo.Text));
               
            }
        }

    }
}
