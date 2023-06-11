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
            llenarcmbBoxTarjeta();
        }

        private void llenarcmbBoxTarjeta()
        {
            cmbBoxTarjeta.Items.Clear();
            //llenar todas las tarjetas relacionadas al cliente actual
            //cmbBoxTarjeta.Items.Add();
        }
        private void cmbBoxTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //llenar todas las etiquetas correspondientes a la info de la tarjeta seleccionada
        }

    }
}
