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
            button1 = new Button();
            label1 = new Label();
            textBoxRuta = new TextBox();
            textBoxBytes = new TextBox();
            button2 = new Button();
            labelVirus = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBoxEstado = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1075, 103);
            button1.Name = "button1";
            button1.Size = new Size(200, 34);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(549, 42);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 1;
            label1.Text = "Malwerbytes";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(89, 103);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.Size = new Size(980, 31);
            textBoxRuta.TabIndex = 2;
            // 
            // textBoxBytes
            // 
            textBoxBytes.Location = new Point(89, 170);
            textBoxBytes.Multiline = true;
            textBoxBytes.Name = "textBoxBytes";
            textBoxBytes.ReadOnly = true;
            textBoxBytes.ScrollBars = ScrollBars.Vertical;
            textBoxBytes.Size = new Size(371, 497);
            textBoxBytes.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(508, 170);
            button2.Name = "button2";
            button2.Size = new Size(181, 65);
            button2.TabIndex = 4;
            button2.Text = "Analizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelVirus
            // 
            labelVirus.AutoSize = true;
            labelVirus.Location = new Point(508, 249);
            labelVirus.Name = "labelVirus";
            labelVirus.Size = new Size(51, 25);
            labelVirus.TabIndex = 5;
            labelVirus.Text = "Virus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 428);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 6;
            label2.Text = "Estado de parada";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Location = new Point(507, 306);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(182, 73);
            textBox1.TabIndex = 7;
            // 
            // textBoxEstado
            // 
            textBoxEstado.BackColor = Color.FromArgb(255, 192, 255);
            textBoxEstado.ForeColor = Color.Blue;
            textBoxEstado.Location = new Point(507, 488);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.ReadOnly = true;
            textBoxEstado.Size = new Size(182, 31);
            textBoxEstado.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(725, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 470);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // VentanaAntivirus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 695);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxEstado);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(labelVirus);
            Controls.Add(button2);
            Controls.Add(textBoxBytes);
            Controls.Add(textBoxRuta);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "VentanaAntivirus";
            Text = "My Antivirus";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxRuta;
        private TextBox textBoxBytes;
        private Button button2;
        private Label labelVirus;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBoxEstado;
        private PictureBox pictureBox1;
    }
}
