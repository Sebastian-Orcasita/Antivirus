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

        private void button1_Click(object sender, EventArgs e)
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Analizador myAnalizador = new Analizador(bytes);
            textBoxEstado.Text = myAnalizador.buscarVirus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
