namespace Game
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            btnJugar = new Button();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnJugar.BackColor = Color.Gray;
            btnJugar.Font = new Font("Verdana", 70F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugar.ForeColor = Color.Firebrick;
            btnJugar.Location = new Point(161, 369);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(1068, 147);
            btnJugar.TabIndex = 2;
            btnJugar.Text = "Videojugar";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Sylvia_ou_La_Nymphe_de_Diane.Properties.Resources.portada;
            ClientSize = new Size(1380, 861);
            Controls.Add(btnJugar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMenu";
            Text = "Sylvia ou La Nymphe de Diane";
            Load += frmMenu_Load;
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnJugar;
    }
}