using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System;
using System.IO;

namespace Game
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
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
        int score = 0;
        Random random = new Random();
        Image[] fallingImages = new Image[]
{
        Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Mandarina,
        Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Manzana,
        Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Pan,
        Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Banana,
        Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Pera,
};
        private void frmJuego_Load(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            this.KeyPreview = true;
            pictureBoxPlayer.Size = new Size(80, 240);
            pictureBoxPlayer.BackColor = Color.Transparent;
            pictureBoxPlayer.Location = new Point(this.ClientSize.Width / 2 - pictureBoxPlayer.Width / 2, this.ClientSize.Height - pictureBoxPlayer.Height - 145);

            fallingObjectsTimer.Start();
            scoreTimer.Interval = 1000;
            scoreTimer.Tick += scoreTimer_Tick;
            scoreTimer.Start();

            int numObjects = 10; // CANT.Enemigos
            for (int i = 0; i < numObjects; i++)
            {
                PictureBox fallingObject = new PictureBox
                {
                    Size = new Size(70,70),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                    Image = fallingImages[random.Next(fallingImages.Length)], 
                    Top = random.Next(-500, 0),
                    Left = random.Next(0, this.ClientSize.Width - 30), 
                    Tag = "fallingObject"  
                };

                this.Controls.Add(fallingObject);  
            }
        }

        private void EndGame()
        {
            fallingObjectsTimer.Stop();
            scoreTimer.Stop();
            btnRestart.Visible = true;
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string musicPath = Path.Combine(basePath, "Resources", "BandaSonora.wav");

            if (File.Exists(musicPath))
            {
                SoundPlayer musica = new SoundPlayer(musicPath);
                musica.Stop();
            }
            else
            {
                MessageBox.Show("Archivo no encontrado: " + musicPath);
            }
            MessageBox.Show($"¡Perdiste! Tu puntuación fue {score}. Presiona en 'Jugar de vuelta' volverlo a intentarlo.",
                    "Fin del Juego",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            score = 0;
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
            lblScore.Text = "Puntuación: 0";
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "fallingObject")
                {
                    control.Top = random.Next(-200, -50);
                    control.Left = random.Next(0, this.ClientSize.Width - control.Width);
                }
            }

            btnRestart.Visible = false;
            fallingObjectsTimer.Start();
            scoreTimer.Start();
        }

        private void fallingObjectsTimer_Tick(object sender, EventArgs e)
        {
            List<Control> enemiesToRemove = new List<Control>(); 

            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "fallingObject")
                {
                    control.Top += 8;
                    if (control.Top > this.ClientSize.Height)
                    {
                        control.Top = random.Next(-500, 0);
                        control.Left = random.Next(0, this.ClientSize.Width - control.Width);
                    }
                    if (control.Bounds.IntersectsWith(pictureBoxPlayer.Bounds))
                    {
                        EndGame();
                    }
                }
            }
        }


        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            int moveAmount = 10;
            if (e.KeyCode == Keys.A && pictureBoxPlayer.Left > 0)
            {
                pictureBoxPlayer.Left -= moveAmount;
            }
            else if (e.KeyCode == Keys.D && pictureBoxPlayer.Right < this.ClientSize.Width)
            {
                pictureBoxPlayer.Left += moveAmount;
            }

        }

        private void pictureBoxPlayer_Click(object sender, EventArgs e)
        {

        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            score += 10;
            lblScore.Text = "Puntuación: " + score;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}