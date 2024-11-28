namespace Game
{
    partial class frmJuego
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuego));
            pictureBoxPlayer = new PictureBox();
            pictureBoxEnemy1 = new PictureBox();
            pictureBoxEnemy2 = new PictureBox();
            pictureBoxEnemy3 = new PictureBox();
            lblScore = new Label();
            btnRestart = new Button();
            fallingObjectsTimer = new System.Windows.Forms.Timer(components);
            scoreTimer = new System.Windows.Forms.Timer(components);
            pictureBoxEnemy4 = new PictureBox();
            pictureBoxEnemy5 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.BackColor = SystemColors.HighlightText;
            pictureBoxPlayer.Image = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.PjStatic;
            pictureBoxPlayer.Location = new Point(702, 375);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(100, 300);
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayer.TabIndex = 0;
            pictureBoxPlayer.TabStop = false;
            pictureBoxPlayer.Tag = "";
            pictureBoxPlayer.Click += pictureBoxPlayer_Click;
            // 
            // pictureBoxEnemy1
            // 
            pictureBoxEnemy1.Image = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Mandarina;
            pictureBoxEnemy1.Location = new Point(1458, 894);
            pictureBoxEnemy1.Name = "pictureBoxEnemy1";
            pictureBoxEnemy1.Size = new Size(45, 43);
            pictureBoxEnemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEnemy1.TabIndex = 1;
            pictureBoxEnemy1.TabStop = false;
            pictureBoxEnemy1.Tag = "fallingObject";
            // 
            // pictureBoxEnemy2
            // 
            pictureBoxEnemy2.Image = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Pan;
            pictureBoxEnemy2.Location = new Point(1338, 867);
            pictureBoxEnemy2.Name = "pictureBoxEnemy2";
            pictureBoxEnemy2.Size = new Size(45, 71);
            pictureBoxEnemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEnemy2.TabIndex = 2;
            pictureBoxEnemy2.TabStop = false;
            pictureBoxEnemy2.Tag = "fallingObject";
            // 
            // pictureBoxEnemy3
            // 
            pictureBoxEnemy3.Image = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Pera;
            pictureBoxEnemy3.Location = new Point(1458, 975);
            pictureBoxEnemy3.Name = "pictureBoxEnemy3";
            pictureBoxEnemy3.Size = new Size(45, 75);
            pictureBoxEnemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEnemy3.TabIndex = 3;
            pictureBoxEnemy3.TabStop = false;
            pictureBoxEnemy3.Tag = "fallingObject";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Tan;
            lblScore.Font = new Font("Segoe UI Black", 19F);
            lblScore.Location = new Point(36, 33);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(190, 36);
            lblScore.TabIndex = 4;
            lblScore.Text = "Puntuacion: 0";
            // 
            // btnRestart
            // 
            btnRestart.Anchor = AnchorStyles.None;
            btnRestart.AutoSize = true;
            btnRestart.BackColor = SystemColors.GrayText;
            btnRestart.Font = new Font("Segoe UI Black", 30F);
            btnRestart.ForeColor = Color.Firebrick;
            btnRestart.Location = new Point(540, 405);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(380, 100);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Jugar de nuevo\r\n";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // fallingObjectsTimer
            // 
            fallingObjectsTimer.Enabled = true;
            fallingObjectsTimer.Interval = 25;
            fallingObjectsTimer.Tick += fallingObjectsTimer_Tick;
            // 
            // scoreTimer
            // 
            scoreTimer.Enabled = true;
            scoreTimer.Tick += scoreTimer_Tick;
            // 
            // pictureBoxEnemy4
            // 
            pictureBoxEnemy4.Image = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Manzana;
            pictureBoxEnemy4.Location = new Point(1458, 826);
            pictureBoxEnemy4.Name = "pictureBoxEnemy4";
            pictureBoxEnemy4.Size = new Size(45, 50);
            pictureBoxEnemy4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEnemy4.TabIndex = 6;
            pictureBoxEnemy4.TabStop = false;
            pictureBoxEnemy4.Tag = "fallingObject";
            // 
            // pictureBoxEnemy5
            // 
            pictureBoxEnemy5.Image = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Banana;
            pictureBoxEnemy5.Location = new Point(1338, 975);
            pictureBoxEnemy5.Name = "pictureBoxEnemy5";
            pictureBoxEnemy5.Size = new Size(45, 75);
            pictureBoxEnemy5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEnemy5.TabIndex = 7;
            pictureBoxEnemy5.TabStop = false;
            pictureBoxEnemy5.Tag = "fallingObject";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.Piano;
            pictureBox1.Location = new Point(-10, 718);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1396, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1380, 861);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxEnemy5);
            Controls.Add(pictureBoxEnemy4);
            Controls.Add(btnRestart);
            Controls.Add(lblScore);
            Controls.Add(pictureBoxEnemy3);
            Controls.Add(pictureBoxEnemy2);
            Controls.Add(pictureBoxEnemy1);
            Controls.Add(pictureBoxPlayer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmJuego";
            Text = "Sylvia ou La Nymphe de Diane";
            Load += frmJuego_Load;
            KeyDown += frmJuego_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEnemy5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPlayer;
        private PictureBox pictureBoxEnemy1;
        private PictureBox pictureBoxEnemy2;
        private PictureBox pictureBoxEnemy3;
        private Label lblScore;
        private Button btnRestart;
        private System.Windows.Forms.Timer fallingObjectsTimer;
        private System.Windows.Forms.Timer scoreTimer;
        private PictureBox pictureBoxEnemy4;
        private PictureBox pictureBoxEnemy5;
        private PictureBox pictureBox1;
    }
}
