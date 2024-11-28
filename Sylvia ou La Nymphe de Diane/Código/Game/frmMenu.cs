using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Game
{
    public partial class frmMenu : Form
    {
        private SoundPlayer musica;

        public frmMenu()
        {
            InitializeComponent();
            IniciarMusica();
        }

        private void IniciarMusica()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string musicPath = Path.Combine(basePath, "Resources", "BandaSonora.wav");

            if (File.Exists(musicPath))
            {
                SoundPlayer musica = new SoundPlayer(musicPath);
                musica.PlayLooping();
            }
            else
            {
                MessageBox.Show("Archivo no encontrado: " + musicPath);
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (musica != null)
            {
                musica.Stop();
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            frmJuego juegoForm = new frmJuego();
            juegoForm.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
