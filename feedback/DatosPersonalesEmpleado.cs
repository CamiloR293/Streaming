using Streaming.feedback;
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
    public partial class DatosPersonalesEmpleado : Form
    {
        administrador cliente= new administrador();
        public DatosPersonalesEmpleado(administrador admin)
        {
            InitializeComponent();
            this.cliente=admin;
            lblPrimerNombre.Text = cliente.PName;
            lblNombreUsuario.Text = cliente.User;
            lblSegundoNombre.Text = cliente.SName;
            lblPrimerApellido.Text = cliente.PApellido;
            lblFechaNacimiento.Text = cliente.FNacimiento;
            lblCorreo.Text = cliente.Correo;
            lblTelefono.Text = cliente.Telefono;
            lblCodigo.Text = cliente.Codigo.ToString();
            lblIdAdmin.Text=cliente.IdAdmin.ToString();
        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            Form actualizar = new ActualizarDatosCliente();
            actualizar.ShowDialog();
            // hacer el reset de datos empleado
        }
    }
}
