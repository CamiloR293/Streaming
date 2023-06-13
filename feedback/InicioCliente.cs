using Streaming.logica;
using System.Data;
using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using Streaming.feedback;

namespace Streaming
{
    public partial class InicioCliente : Form
    {
        public Cliente cliente = new Cliente();
        private Color colorNaranjaPredeterminado = Color.FromArgb(255, 144, 76);
        private Color colorNaranjaSeleccionado = Color.FromArgb(192, 108, 56);


        public InicioCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            openForms(new MenuPrincipalCliente(cliente));
        }

        public InicioCliente()
        {
            InitializeComponent();
            openForms(new MenuPrincipalCliente(cliente));
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
            cliente = cliente.ObtenerClientePorUsuario(cliente.User);
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
            openForms(new AgregarTarjeta(cliente));
        }
        /*
        private void cargarPeliculas()
        {
            producto peliculas = new producto();
            DataSet dsResultado = new DataSet();
            dsResultado = peliculas.consultarProducto();
            if (dsResultado.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < dsResultado.Tables[0].Rows.Count; i++)
                {
                    Button button = new Button();
                    Font myFont = new Font("Impact", 10);
                    button.Text = dsResultado.Tables[0].Rows[i]["nombre"].ToString() + "-" + dsResultado.Tables[0].Rows[i]["genero"].ToString();
                    button.Width = 150;
                    button.Height = 150;
                    button.BackgroundImageLayout = ImageLayout.Zoom;
                    button.ForeColor = Color.Red;
                    button.BackColor = Color.White;
                    button.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    button.Font = myFont;
                    button.Name = dsResultado.Tables[0].Rows[i]["codigo"].ToString();

                    //String direccion = "C:\\Users\\Usuario\\Documents\\GitHub\\Streaming\\CamiloR293\\Streaming\\Resources\\" + dsResultado.Tables[0].Rows[i]["nombre"].ToString() + ".png";
                    String direccion = "D:\\GitHub\\Streaming\\Resources\\" + dsResultado.Tables[0].Rows[i]["nombre"].ToString() + ".png";
                    if (dsResultado.Tables[0].Rows[i]["nombre"].ToString().Contains(":"))
                    {

                        String[] linea = dsResultado.Tables[0].Rows[i]["nombre"].ToString().Split(':');
                        //direccion = "C:\\Users\\Usuario\\Documents\\GitHub\\Streaming\\CamiloR293\\Streaming\\Resources\\" + linea[0] + ".png";
                        direccion = "D:\\GitHub\\Streaming\\Resources\\" + linea[0] + ".png";

                    }
                    button.BackgroundImage = Image.FromFile(direccion);
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    flowLayoutPanel1.Controls.Add(button);


                    button.Click += button_Click;


                }


            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            producto peliculas = new producto();
            DataSet dsResultado = new DataSet();
            dsResultado = peliculas.obtenerProducto(int.Parse(clickedButton.Name));

            VerPeliculaCliente form2 = new VerPeliculaCliente();
            form2.informacion(dsResultado);
            form2.ShowDialog();


        }
        */
        private void btnCerrarSesion_Click(object sender, System.EventArgs e)
        {
            //Poner una notificacion
            DialogResult result = MessageBox.Show("¿Desea cerrar sesion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes.Equals(result))
            {
                openForms(new Main());
                this.Close();

            }



        }
        private void txtBuscar_Click(object sender, System.EventArgs e)
        {
            if (txtBuscar.Text.Equals("Buscar")) txtBuscar.Clear();
        }
        private void txtBuscar_Leave(object sender, System.EventArgs e)
        {
            if (txtBuscar.Text.Equals("")) txtBuscar.Text = "Buscar";
        }

        private void picBoxBuscar_Click(object sender, System.EventArgs e)
        {
            //buscar segun txtBuscar
        }

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        public void hideControls()
        {
            pnlDesktop.Visible = false;
            banner.Visible = false;
            pnlLateral.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Recomendaciones fromRec = new Recomendaciones(this.cliente);
            fromRec.ShowDialog();
            
        }
    }
}