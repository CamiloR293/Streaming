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
            int resultado = admin.ingresarRegistro(25, txtUsuario.Text.ToString(), txtPNombre.Text.ToString(), txtPApellido.Text.ToString(),
                txtSNombre.Text.ToString(), txtSApellido.Text.ToString(), txtPassword.Text.ToString(), txtFechaNacimiento.Text.ToString(), txtTelefono.Text.ToString()
                , txtCorreo.Text.ToString(), 2, "12/06/2023");
        }
    }
}
