using Streaming.logica;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Streaming
{
    public partial class AgregarTarjeta : Form
    {
        Panel panelContainer = new Panel();
        Cliente cliente;
        Form registerClient = null;
        private String txtUsuario;
        private String txtPNombre;
        private String txtPApellido;
        private String txtSNombre;
        private String txtSApellido;
        private String txtPasswordRegistro;
        private String txtFechaNacimiento;
        private String txtTelefono;
        private String txtCorreo;
        public AgregarTarjeta(Panel panelContainer, Form register,String txtUsuario, String txtPNombre, String txtPApellido,
                String txtSNombre, String txtSApellido, String txtPasswordRegistro, String txtFechaNacimiento, String txtTelefono
                , String txtCorreo)
        {
            InitializeComponent();
            this.txtCorreo = txtCorreo;
            this.txtFechaNacimiento = txtFechaNacimiento;
            this.txtPApellido = txtPApellido;
            this.txtPNombre = txtPNombre;
            this.txtSApellido = txtSApellido;
            this.txtSNombre = txtSNombre;
            this.txtPasswordRegistro = txtPasswordRegistro;
            this.txtTelefono = txtTelefono;
            this.txtUsuario = txtUsuario;
            this.panelContainer = panelContainer;
            this.registerClient = register;
            btnRegistrar.Visible = false;
            btnRegistrarme.Visible = true;
            picBoxReturnTo.Visible = true;
        }
        public AgregarTarjeta (Cliente cliente)
        {
            this.cliente = cliente;

            InitializeComponent();
            btnRegistrar.Visible = true;
            btnRegistrarme.Visible = false;
            picBoxReturnTo.Visible = false;
        }
        public AgregarTarjeta()
        {
            InitializeComponent();
            btnRegistrar.Visible = true;
            btnRegistrarme.Visible = false;
            picBoxReturnTo.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picBoxReturnTo_Click(object sender, EventArgs e)
        {
            this.Close();
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




    }
}
