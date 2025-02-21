using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antivirus
{
    // Definición de la clase ImagenForm, formulario de Windows Forms
    public partial class ImagenForm : Form
    {
        // Constructor de la clase ImagenForm, recibe la ruta de una imagen como parámetro
        public ImagenForm(string rutaImagen)
        {
            InitializeComponent();

            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill, 
                SizeMode = PictureBoxSizeMode.StretchImage, 
                Image = Image.FromFile(rutaImagen) 
            };

            this.Controls.Add(pictureBox);

        }
    }
}
