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

        private void buttonBuscar_Click(object sender, EventArgs e)
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

            else {

                MessageBox.Show("Tienes que seleccionar un archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
