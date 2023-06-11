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
        public AgregarActoresPelicula()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string primerNombre = txtPrimerNombre.Text;
            string segundoNombre = txtSegundoNombre.Text;
            string primerApellido = txtPrimerApellido.Text;
            string segundoApellido = txtSegundoApellido.Text;
            string fechaNacimiento = txtFechaNacimiento.Text;

            //Realizar insert de actor

            string nombrePelicula = cmbBoxPelicula.Text;

            //Ejecutar la insercion de un actor a la pelicula
        }

        private void cmbBoxPapel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbBoxPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
