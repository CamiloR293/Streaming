using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streaming
{
    public partial class AgregarTarjeta : Form
    {
        Panel panelContainer = new Panel();
        Form registerClient = null;
        public AgregarTarjeta(Panel panelContainer,Form register)
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
    }
}
