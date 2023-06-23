using Streaming.connection;
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
    public partial class Admin : Form
    {
        Cliente cliente=new Cliente();
        public Admin()
        {
            InitializeComponent();
            llenarComboBox();        
        }

        private void btnActualizarDatosPersonales_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem != null)
            {

                Form actualizar = new ActualizarDatosCliente(cliente, "2");
                actualizar.ShowDialog();
                //volver a hacer el set de la informacion, no se como funciona el cliente aqui
                //pero es volver a resetear las etiquetas con la info nueva
                setInfoClient();
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun cliente");
            }

        }
        public void llenarComboBox()
        {
            Datos dt=new Datos();
            dt.LlenarComboBoxConCursor(cmbClientes);
        }

        private void setInfoClient()
        {
            if (cmbClientes.SelectedItem!=null) {
                string[] partes = cmbClientes.SelectedItem.ToString().Split(',');

                // Obtener el código y el nombre
                string codigo = partes[0].Trim();
                string usuario = partes[1].Trim();
                cliente = cliente.ObtenerClientePorUsuario(usuario);
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
        }


        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            setInfoClient();
        }
    }
}
