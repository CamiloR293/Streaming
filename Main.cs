using System;
using System.Windows.Forms;

namespace Streaming
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void txtUserName_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Equals("Correo o nombre de usuario")) txtUserName.Clear();


        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Contraseña"))
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Clear();
            }
        }
        private Form activeForm = null;
        private void lblRegister_Click(object sender, EventArgs e)
        {
            lblRegister.ForeColor = System.Drawing.Color.FromArgb(196, 110, 56);
            openForms(new RegistroCliente(pnlDesktop));
        }
        
        private void openForms(Form newForm)
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
    }
}
