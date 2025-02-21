using System.Security.Cryptography;

namespace Antivirus
{
    public partial class VentanaAntivirus : Form
    {
        private byte[] bytes;
        public VentanaAntivirus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Este metodo permite al usuario buscar un archivo en su computador y hace que el programa le los bytes de este
        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog explorador = new OpenFileDialog();
                explorador.ShowDialog(this);

                AdminArchivos myAdmin = new AdminArchivos(explorador.FileName);
                bytes = myAdmin.leerBytes();

                //Cadena que almacena los bytes que se envian desde el administrador
                string contenidoBytes = "";

                for (int i = 0; i < bytes.Length; i++)
                {

                    contenidoBytes += " " + bytes[i];

                }

                textBoxBytes.Text = contenidoBytes;
                textBoxRuta.Text = explorador.FileName;

                textBoxResultado.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //Este metodo analiza todos los bytes de un archivo y los compara para ver si una cadena de estos coincide con un virus
        //y se lo muestra al usuario
        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
            if (bytes != null)
            {

                Analizador myAnalizador = new Analizador(bytes);
                textBoxEstado.Text = myAnalizador.buscarVirus();

                textBoxResultado.Text = "Usama: " + myAnalizador.getCountUsama() + Environment.NewLine +
                                        "Ébola: " + myAnalizador.getCountEBOLA() + Environment.NewLine +
                                        "AH1N1: " + myAnalizador.getCountAH1N1() + Environment.NewLine +
                                        "Amtrax: " + myAnalizador.getCountAMTRAX() + Environment.NewLine +
                                        "Covid: " + myAnalizador.getCountCOVID();

            }

            else
            {

                MessageBox.Show("Tienes que seleccionar un archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //Metodo que permite ver en una imagen el automata de los virus
        private void buttonAutomata_Click(object sender, EventArgs e)
        {

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string rutaImagen = Path.Combine(basePath, "Imagen", "AutomataAntivirys.jff.jpg");

            ImagenForm ventanaImagen = new ImagenForm(rutaImagen);
            ventanaImagen.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
