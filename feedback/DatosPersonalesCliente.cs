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
    public partial class DatosPersonalesCliente : Form
    {

        private Cliente cliente;
        Main iniciosesion = new Main();
        public DatosPersonalesCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            lblSegundoApellido.Text = cliente.SApellido;
            lblPrimerNombre.Text = cliente.PName;
            lblNombreUsuario.Text = cliente.User;
            lblSegundoNombre.Text = cliente.SName;
            lblPrimerApellido.Text = cliente.PApellido;
            lblFechaNacimiento.Text = cliente.FNacimiento;
            lblCorreo.Text = cliente.Correo;
            lblTelefono.Text = cliente.Telefono;
            lblCodigo.Text = cliente.Codigo.ToString();
        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
