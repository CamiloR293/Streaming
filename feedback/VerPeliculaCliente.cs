using System;
using System.Collections.Generic;
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
    public partial class VerPeliculaCliente : Form
    {
        Panel main = new Panel();
        public VerPeliculaCliente()
        {
            InitializeComponent();
            
        }

        private void btnVerAhora_Click(object sender, EventArgs e)
        {
            ViendoPelicula pelicula = new ViendoPelicula();
            pelicula.ShowDialog();
            //openForms(new ViendoPelicula());
            this.Close();
        }
        
        public void informacion(DataSet dsResultado)
        {
            lblTituloPelicula.Text = dsResultado.Tables[0].Rows[0]["nombre"].ToString();
            lblDescripcion.Text = dsResultado.Tables[0].Rows[0]["descripcion"].ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}