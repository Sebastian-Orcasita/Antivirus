namespace Antivirus
{
    partial class VentanaAntivirus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAntivirus));
            buttonBuscar = new Button();
            label1 = new Label();
            textBoxRuta = new TextBox();
            textBoxBytes = new TextBox();
            buttonAnalizar = new Button();
            labelVirus = new Label();
            label2 = new Label();
            textBoxResultado = new TextBox();
            textBoxEstado = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(1075, 103);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(181, 34);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(549, 42);
            label1.Name = "label1";
            label1.Size = new Size(172, 45);
            label1.TabIndex = 1;
            label1.Text = "Mikubytes";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(89, 103);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(980, 31);
            textBoxRuta.TabIndex = 2;
            // 
            // textBoxBytes
            // 
            textBoxBytes.Location = new Point(686, 170);
            textBoxBytes.Multiline = true;
            textBoxBytes.Name = "textBoxBytes";
            textBoxBytes.ReadOnly = true;
            textBoxBytes.ScrollBars = ScrollBars.Vertical;
            textBoxBytes.Size = new Size(371, 497);
            textBoxBytes.TabIndex = 3;
            // 
            // buttonAnalizar
            // 
            buttonAnalizar.Location = new Point(1075, 170);
            buttonAnalizar.Name = "buttonAnalizar";
            buttonAnalizar.Size = new Size(181, 65);
            buttonAnalizar.TabIndex = 4;
            buttonAnalizar.Text = "Analizar";
            buttonAnalizar.UseVisualStyleBackColor = true;
            buttonAnalizar.Click += buttonAnalizar_Click;
            // 
            // labelVirus
            // 
            labelVirus.AutoSize = true;
            labelVirus.BackColor = Color.Silver;
            labelVirus.ForeColor = SystemColors.ActiveCaptionText;
            labelVirus.Location = new Point(1075, 250);
            labelVirus.Name = "labelVirus";
            labelVirus.Size = new Size(51, 25);
            labelVirus.TabIndex = 5;
            labelVirus.Text = "Virus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1075, 548);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 6;
            label2.Text = "Estado de parada";
            // 
            // textBoxResultado
            // 
            textBoxResultado.BackColor = Color.Silver;
            textBoxResultado.Location = new Point(1075, 278);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(182, 257);
            textBoxResultado.TabIndex = 7;
            // 
            // textBoxEstado
            // 
            textBoxEstado.BackColor = Color.FromArgb(192, 192, 255);
            textBoxEstado.ForeColor = Color.Blue;
            textBoxEstado.Location = new Point(1075, 586);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.ReadOnly = true;
            textBoxEstado.Size = new Size(182, 31);
            textBoxEstado.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 603);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 64);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VentanaAntivirus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1347, 695);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxResultado);
            Controls.Add(label2);
            Controls.Add(labelVirus);
            Controls.Add(buttonAnalizar);
            Controls.Add(textBoxBytes);
            Controls.Add(textBoxRuta);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Name = "VentanaAntivirus";
            Text = "My Antivirus";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscar;
        private Label label1;
        private TextBox textBoxRuta;
        private TextBox textBoxBytes;
        private Button buttonAnalizar;
        private Label labelVirus;
        private Label label2;
        private TextBox textBoxResultado;
        private TextBox textBoxEstado;
        private PictureBox pictureBox1;
    }
}
