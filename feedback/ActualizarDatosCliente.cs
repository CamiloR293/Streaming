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

namespace Streaming.feedback
{
    public partial class ActualizarDatosCliente : Form
    {
        Cliente cliente = new Cliente();
        public ActualizarDatosCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.meterInformacionCliente(cliente);
        }
        private void meterInformacionCliente(Cliente cliente)
        {
            txtPrimerNombre.Text = cliente.PName;
            txtSegundoNombre.Text = cliente.SName;
            txtPrimerApellido.Text = cliente.PApellido;
            txtSegundoApellido.Text = cliente.SApellido;
            txtNombreUsuario.Text = cliente.User;
            txtPassword.Text = cliente.Password;
            txtCorreo.Text = cliente.Correo;
            txtFechaNacimiento.Text = cliente.FNacimiento;
            txtTelefono.Text = cliente.Telefono;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Actualziar datos en la BD
            DateTime fecha = DateTime.Parse(txtFechaNacimiento.Text);
            DateTime fechaTruncada = fecha.Date;
            cliente.PName=txtPrimerNombre.Text;
            cliente.SName=txtSegundoNombre.Text;
            cliente.PApellido=txtPrimerApellido.Text;
            cliente.SApellido = txtSegundoApellido.Text ;
            cliente.User= txtNombreUsuario.Text ;
            cliente.Password= txtPassword.Text;
            cliente.Correo= txtCorreo.Text;
            cliente.FNacimiento= fechaTruncada.ToString("dd-MM-yyyy");
            cliente.Telefono= txtTelefono.Text;
            cliente.updateRegistro(cliente);
        }
    }
}
