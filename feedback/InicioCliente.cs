using Streaming.logica;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Streaming
{
    public partial class InicioCliente : Form
    {
        public Cliente cliente;
        private Color colorNaranjaPredeterminado = Color.FromArgb(255, 144, 76);
        private Color colorNaranjaSeleccionado = Color.FromArgb(192, 108, 56);


        public InicioCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente=cliente;
            openForms(new MenuPrincipalCliente());
        }

        public InicioCliente()
        {
            InitializeComponent();
            openForms(new MenuPrincipalCliente());
        }

        public void InicioCliente_Load(object sender, System.EventArgs e)
        {
            btnMenuPrincipal_Click(sender, e);
        }
        #region OpenForm

        private Form activeForm = null;
        public void openForms(Form newForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = newForm;

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Add(newForm);
            pnlDesktop.Tag = newForm;

            newForm.BringToFront();
            newForm.Show();
        }
        #endregion
        
        private void btnMenuPrincipal_Click(object sender, System.EventArgs e)
        {
            btnMenuPrincipal.BackColor = colorNaranjaSeleccionado;
            btnAddMetodosPago.BackColor = colorNaranjaPredeterminado;
            btnDatosPersonales.BackColor = colorNaranjaPredeterminado;

            openForms(new MenuPrincipalCliente());
        }

        private void btnDatosPersonales_Click(object sender, System.EventArgs e)
        {
            btnMenuPrincipal.BackColor = colorNaranjaPredeterminado;
            btnAddMetodosPago.BackColor = colorNaranjaPredeterminado;
            btnDatosPersonales.BackColor = colorNaranjaSeleccionado;
            openForms(new DatosPersonalesCliente(cliente));
        }

        private void btnAddMetodosPago_Click(object sender, System.EventArgs e)
        {
            btnMenuPrincipal.BackColor = colorNaranjaPredeterminado;
            btnAddMetodosPago.BackColor = colorNaranjaSeleccionado;
            btnDatosPersonales.BackColor = colorNaranjaPredeterminado;
            openForms(new AgregarTarjeta());
        }

        private void btnCerrarSesion_Click(object sender, System.EventArgs e)
        {
            //Poner una notificacion
            DialogResult result = MessageBox.Show("¿Desea cerrar sesion?","Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes.Equals(result))
            {
                this.Close();
            }  
                
            

        }
    }
}
