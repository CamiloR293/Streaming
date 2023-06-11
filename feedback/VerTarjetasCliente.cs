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
    public partial class VerTarjetasCliente : Form
    {
        public VerTarjetasCliente()
        {
            InitializeComponent();
            llenarCmbBoxTarjetas();
        }

        private void VerTarjetasCliente_Load(object sender, EventArgs e)
        {

        }

        private void llenarCmbBoxTarjetas()
        {
            //Llenar tarjetas en cmbBox, una consulta y se pone solo el nombre
            cmbBoxTarjetas.Items.Clear();
            //cmbBoxTarjetas.Items.Add();
        }
        private void cmbBoxTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //rellenar las etiquetas correspondientes con los datos de las tarjetas
        }
    }
}
