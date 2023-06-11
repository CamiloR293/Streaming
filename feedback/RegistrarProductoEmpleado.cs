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
    public partial class RegistrarProductoEmpleado : Form
    {
        private string usuario;
        public RegistrarProductoEmpleado(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Gestionar el registro de la pelicula
            administrador miAdmin = new administrador();
            producto miProducto= new producto();
            int idUser = miAdmin.retornarAdmin(usuario);
            int estado = 0;
            if (cBoxEstado.Text.ToString().Equals("Activo"))
            {
                estado = 1;
            }
         
            int resultado=miProducto.ingresarproducto(idUser, txtNombre.Text, txtDescripcion.Text, txtEstreno.Text
                , txtDuracion.Text, cBoxGenero.Text.ToString(), cBoxTipo.Text.ToString(), estado,0);
            if(resultado > 0) {
                MessageBox.Show("Pelicula insertada con exito");
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtEstreno.Text = "";
                txtDuracion.Text = "";
            }
            
        }
    }
}
