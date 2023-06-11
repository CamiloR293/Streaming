using Streaming.logica;
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
    public partial class PlanSuscripcionCliente : Form
    {
        Cliente cliente;
        Panel panelContainer = new Panel();
        public PlanSuscripcionCliente(Panel panelContainer, Form activeForm, Cliente cliente)
        {
            this.cliente= cliente;
            InitializeComponent();
            this.panelContainer = panelContainer;
            this.activeForm = activeForm;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente_plan miRelacionClientePlan = new cliente_plan();
            MessageBox.Show("¡Haz hecho clic en Plan mensual!");
            int resultado = miRelacionClientePlan.ingresarRelacionClientePlan("sysdate+30");
            if (resultado > 0)
            {
                MessageBox.Show("¡Compra exitosa!");
                openForms(new InicioCliente(cliente));

            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            cliente_plan miRelacionClientePlan = new cliente_plan();
            MessageBox.Show("¡Haz hecho clic en Plan anual!");
            int resultado = miRelacionClientePlan.ingresarRelacionClientePlan("sysdate+365");
            if (resultado > 0)
            {
                MessageBox.Show("¡Compra exitosa!");
                openForms(new InicioCliente());

            }

        }
    }
}
