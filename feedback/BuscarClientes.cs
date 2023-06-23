using Streaming.connection;
using Streaming.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streaming.feedback
{
    public partial class BuscarClientes : Form
    {
        Datos d= new Datos();
        Cliente cliente;
        public BuscarClientes()
        {
            InitializeComponent();
            lblSegundoApellido.Visible = false;
            lblPrimerNombre.Visible = false;
            lblNombreUsuario.Visible = false;
            lblSegundoNombre.Visible = false;
            lblPrimerApellido.Visible = false;
            lblFechaNacimiento.Visible = false;
            lblCorreo.Visible = false;
            lblTelefono.Visible = false;
            lblCodigo.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            txtBusqueda.Visible = false;
            btnConsulta.Visible = false;
            lblClientes.Text = d.ObtenerCantidadClientes().ToString();
            llenarDatos();

        }
        private void llenarDatos()
        {
            if(rbBusquedaCodigo.Checked)
            {
                rbCodigo.Visible=false;
                labelCodigo.Text="Ingrese el nombre de usuario";
                txtBusqueda.Visible = true;
                btnConsulta.Visible = true;

            }
            if (rbCodigo.Checked)
            {
                rbBusquedaCodigo.Visible = false;
                labelCodigo.Text = "Ingrese el codigo de cliente";
                txtBusqueda.Visible = true;
                btnConsulta.Visible = true;

            }
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {

        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (txtBusqueda != null && !txtBusqueda.Text.Equals(""))
            {
                Datos dt = new Datos();
                if (rbBusquedaCodigo.Checked)
                {
                    string busqueda = txtBusqueda.Text;
                    cliente = dt.BuscarClientePorNombreUsuario(busqueda);
                    setInfoClient();

                }
                if (rbCodigo.Checked)
                {
                    int busqueda = int.Parse(txtBusqueda.Text);

                    cliente = dt.BuscarClientePorCodigo(busqueda);
                    setInfoClient();

                }

            }
        }

        private void setInfoClient()
        {
            lblSegundoApellido.Visible = true;
            lblPrimerNombre.Visible = true;
            lblNombreUsuario.Visible = true;
            lblSegundoNombre.Visible = true;
            lblPrimerApellido.Visible = true;
            lblFechaNacimiento.Visible = true;
            lblCorreo.Visible = true;
            lblTelefono.Visible = true;
            lblCodigo.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label18.Visible = true;
            label19.Visible = true;

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
    

    private void rbBusquedaCodigo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDatos();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            llenarDatos();
        }
    }
}
