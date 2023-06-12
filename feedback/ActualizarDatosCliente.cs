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
        administrador admin = new administrador();
        String estado;
        public ActualizarDatosCliente(Cliente cliente, string estado)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.meterInformacionCliente(cliente);
            this.estado= estado;
        }
        public ActualizarDatosCliente(administrador admin, string estado)
        {
            InitializeComponent();
            this.admin = admin;
            this.meterInformacionAdmin(admin);
            this.estado = estado;
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
        private void meterInformacionAdmin(administrador cliente)
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
            if (estado.Equals("2")){
                cliente.PName = txtPrimerNombre.Text;
                cliente.SName = txtSegundoNombre.Text;
                cliente.PApellido = txtPrimerApellido.Text;
                cliente.SApellido = txtSegundoApellido.Text;
                cliente.User = txtNombreUsuario.Text;
                cliente.Password = txtPassword.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.FNacimiento = fechaTruncada.ToString("dd-MM-yyyy");
                cliente.Telefono = txtTelefono.Text;
                cliente.updateRegistro(cliente);
            }
            else
            {
                admin.PName = txtPrimerNombre.Text;
                admin.SName = txtSegundoNombre.Text;
                admin.PApellido = txtPrimerApellido.Text;
                admin.SApellido = txtSegundoApellido.Text;
                admin.User = txtNombreUsuario.Text;
                admin.Password = txtPassword.Text;
                admin.Correo = txtCorreo.Text;
                admin.FNacimiento = fechaTruncada.ToString("dd-MM-yyyy");
                admin.Telefono = txtTelefono.Text;
                admin.updateRegistro(admin);
            }

        }
    }
}
