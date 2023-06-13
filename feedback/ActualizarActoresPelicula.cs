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
    public partial class ActualizarActoresPelicula : Form
    {
        public ActualizarActoresPelicula()
        {
            InitializeComponent();
            llenarCmbBoxPeliculas();
        }
        private void llenarCmbBoxPeliculas()
        {
            cmbBoxPelicula.Items.Clear();
            //cmbBoxPelicula.Items.Add(); //Ciclo que llene todas las peliculas para seleccionar
        }
        private void llenarCmbBoxActores(int idPelicula)
        {
            cmbBoxActor.Items.Clear();
            //cmbBoxActor.Items.Add(); //Ciclo que llene todos los actores de una pelicula seleccionada
        }

        private void cmbBoxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCmbBoxActores(0); //Cuando se seleccione una pelicula llenar el combo box de actores
        }

        private void cmbBoxActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se ejecuta cuando se seleccione un actor, los campos de texto se llenan automaticamente para
            //ser actualizados
            //txtPrimerNombre.Text = "NombreActor";
            //txtPrimerApellido.Text = "ApellidoActor";
            //txtSegundoNombre.Text = "NombreActor";
            //txtSegundoApellido.Text = "ApellidoActor";
            //txtFechaNacimiento.Text = "fech";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Actualiza la informacion en la base de datos
            actor miActor = new actor();
            Datos misDatos = new Datos();
            int resultado = miActor.actualizarActor(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text,
                                                    txtSegundoApellido.Text, txtFechaNacimiento.Text, misDatos.ObtenerCodigoActor(txtPrimerNombre.Text, txtPrimerApellido.Text));
            if(resultado > 0)
            {
                MessageBox.Show("Actor actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrimerNombre.Clear();
                txtPrimerNombre.Clear();
                txtSegundoNombre.Clear();
                txtFechaNacimiento.Clear();
                txtPrimerApellido.Clear();
            }
            else
            {
                MessageBox.Show("actor no se ha actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
