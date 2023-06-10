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
    public partial class MenuPrincipalCliente : Form
    {
        Panel panelContainer = new Panel();
        public MenuPrincipalCliente(Panel panelContainer)
        {
            InitializeComponent();
            AgregarPeliculas();
            this.panelContainer = panelContainer;
        } 
        /*dimensiones picture box 169; 97 */
        private void AgregarPeliculas()
        {
            //Se ejecuta la sentencia select count(*) para asignar el iterador
            int n = 12;
            for (int i = 0; i < n; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox" + i; /*asignar directamente el nombre con el select
                * no sé como funciona realmente pero si se hace
                *la consulta y se puede iterar con este ciclo, mucho
                *mejor*/
                
                pictureBox.Width = 169;
                pictureBox.Height = 97;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Image.FromFile("ruta_de_la_imagen.png"); // Ruta de la imagen que deseas asignar
                pictureBox.Click += PictureBox_Click;
                
                flowPanelCatalogo.Controls.Add(pictureBox);
                
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            //Hacemos el select comparando el nombre del picBox y guardamos el genero, titulo y descripcion.

            //openForms(new VerPeliculaCliente(String nombre, String genero, String descripcion));
            //Falta hacer el set text en el label de "VerPeliculaCliente"
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

            panelContainer.Controls.Add(newForm);
            panelContainer.Tag = newForm;

            newForm.BringToFront();
            newForm.Show();
        }
        #endregion
        //Las picture box deben generarse de acuerdo a la cantidad de peliculas de la base
        //de datos
    }
}
