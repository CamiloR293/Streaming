using Streaming.logica;
using System;
using System.Windows.Forms;

namespace Streaming
{
    public partial class AgregarTarjeta : Form
    {
        Panel panelContainer = new Panel();
        Form registerClient = null;
        public AgregarTarjeta(Panel panelContainer, Form register)
        {
            InitializeComponent();
            this.panelContainer = panelContainer;
            this.registerClient = register;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picBoxReturnTo_Click(object sender, EventArgs e)
        {
            openForms(registerClient);
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

        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Tarjeta mitarjeta = new Tarjeta();
            int codigo = 1;
            int resultado = mitarjeta.registrarTarjeta(codigo, txtNumero.Text, txtFechaExpedicion.Text, 
                                                       txtNombre.Text, cmbBoxTipoTarjeta.SelectedItem.ToString());
            //validacion
            if (resultado > 0)
                MessageBox.Show("Tarjeta registrada", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Tarjeta NO registrado", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //limpiar cajas de texto
            txtCVV.Clear();
            txtFechaExpedicion.Clear();
            txtNombre.Clear();
            txtNumero.Clear();
            txtPassword.Clear();
        }
    }
}
