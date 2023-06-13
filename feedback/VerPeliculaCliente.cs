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
using Streaming.logica;

namespace Streaming
{
    public partial class VerPeliculaCliente : Form
    {
        Panel main = new Panel();
        public VerPeliculaCliente()
        {
            InitializeComponent();
            AgregarPeliculas();
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

        private void AgregarPeliculas() //Lo llamo en el constructor, se necesita pasar el genero de la pelicula
                                        // se hace otro select? o se usa el texto del boton presionado
        {
            producto peliculas = new producto();
            DataSet dsResultado = new DataSet();
            string genero = "brayan homosexual";
            dsResultado = peliculas.extraerPeliculasPorGenero(genero);
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
                    //Modificar esta direccion para que funcione, es la direccion de donde se toman las fotos
                    String direccion = "C:\\Users\\Usuario\\Documents\\GitHub\\Streaming\\CamiloR293\\Streaming\\Resources\\" + dsResultado.Tables[0].Rows[i]["nombre"].ToString() + ".png";
                    //String direccion = "D:\\GitHub\\Streaming\\Resources\\" + dsResultado.Tables[0].Rows[i]["nombre"].ToString() + ".png";
                    if (dsResultado.Tables[0].Rows[i]["nombre"].ToString().Contains(":"))
                    {

                        String[] linea = dsResultado.Tables[0].Rows[i]["nombre"].ToString().Split(':');
                        //Esta tambien favor comentarlas y no borrarlas
                        direccion = "C:\\Users\\Usuario\\Documents\\GitHub\\Streaming\\CamiloR293\\Streaming\\Resources\\" + linea[0] + ".png";
                        //direccion = "D:\\GitHub\\Streaming\\Resources\\" + linea[0] + ".png";

                    }
                    button.BackgroundImage = Image.FromFile(direccion);
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    flowPanelPeliculasRelacionadas.Controls.Add(button);


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

            VerPeliculaCliente form = new VerPeliculaCliente();
            form.informacion(dsResultado);
            form.ShowDialog();



        }
    }
}