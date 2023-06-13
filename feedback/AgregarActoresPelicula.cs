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
    public partial class AgregarActoresPelicula : Form
    {
        Datos misDatos = new Datos();

        public AgregarActoresPelicula()
        {
            InitializeComponent();
            misDatos.obtenerPeliculas(cmbBoxPelicula);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //crear un objeto tipo actor
            actor miActor = new actor();
            //
            string primerNombre = txtPrimerNombre.Text;
            string segundoNombre = txtSegundoNombre.Text;
            string primerApellido = txtPrimerApellido.Text;
            string segundoApellido = txtSegundoApellido.Text;
            string fechaNacimiento = txtFechaNacimiento.Text;
            string papel = cmbBoxPapel.SelectedItem.ToString();
            //rellenar peliculas
            string nombrePelicula = cmbBoxPelicula.SelectedItem.ToString(); // guardar en una variable
            //Ejecutar la insercion de un actor a la pelicula
            int resultado = miActor.ingresarActor(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento);
            int resultado2 = miActor.registrarProductoActor(nombrePelicula, papel);
            if (resultado > 0 && resultado2 > 0)
            {
                MessageBox.Show("Actor y productos registrados con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //limpiar text box
                txtFechaNacimiento.Clear();
                txtPrimerApellido.Clear();
                txtPrimerNombre.Clear();
                txtSegundoApellido.Clear();
                txtSegundoNombre.Clear();
            }
            else
            {
                MessageBox.Show("Actor y productos registrados No se registraron", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
