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
            buttonAutomata = new Button();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(752, 62);
            buttonBuscar.Margin = new Padding(2, 2, 2, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(127, 20);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 1;
            label1.Text = "Mikubytes";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(62, 62);
            textBoxRuta.Margin = new Padding(2, 2, 2, 2);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(687, 23);
            textBoxRuta.TabIndex = 2;
            // 
            // textBoxBytes
            // 
            textBoxBytes.Location = new Point(480, 99);
            textBoxBytes.Margin = new Padding(2, 2, 2, 2);
            textBoxBytes.Multiline = true;
            textBoxBytes.Name = "textBoxBytes";
            textBoxBytes.ReadOnly = true;
            textBoxBytes.ScrollBars = ScrollBars.Vertical;
            textBoxBytes.Size = new Size(261, 300);
            textBoxBytes.TabIndex = 3;
            // 
            // buttonAnalizar
            // 
            buttonAnalizar.Location = new Point(752, 99);
            buttonAnalizar.Margin = new Padding(2, 2, 2, 2);
            buttonAnalizar.Name = "buttonAnalizar";
            buttonAnalizar.Size = new Size(127, 39);
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
            labelVirus.Location = new Point(752, 148);
            labelVirus.Margin = new Padding(2, 0, 2, 0);
            labelVirus.Name = "labelVirus";
            labelVirus.Size = new Size(33, 15);
            labelVirus.TabIndex = 5;
            labelVirus.Text = "Virus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(752, 328);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 6;
            label2.Text = "Estado de parada";
            label2.Click += label2_Click;
            // 
            // textBoxResultado
            // 
            textBoxResultado.BackColor = Color.Silver;
            textBoxResultado.Location = new Point(752, 166);
            textBoxResultado.Margin = new Padding(2, 2, 2, 2);
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(129, 156);
            textBoxResultado.TabIndex = 7;
            // 
            // textBoxEstado
            // 
            textBoxEstado.BackColor = Color.FromArgb(192, 192, 255);
            textBoxEstado.ForeColor = Color.Blue;
            textBoxEstado.Location = new Point(752, 346);
            textBoxEstado.Margin = new Padding(2, 2, 2, 2);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.ReadOnly = true;
            textBoxEstado.Size = new Size(129, 23);
            textBoxEstado.TabIndex = 8;
            // 
            // buttonAutomata
            // 
            buttonAutomata.Location = new Point(752, 373);
            buttonAutomata.Margin = new Padding(2, 2, 2, 2);
            buttonAutomata.Name = "buttonAutomata";
            buttonAutomata.Size = new Size(127, 39);
            buttonAutomata.TabIndex = 10;
            buttonAutomata.Text = "Ver diagrama del Automata";
            buttonAutomata.UseVisualStyleBackColor = true;
            buttonAutomata.Click += buttonAutomata_Click;
            // 
            // VentanaAntivirus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(943, 417);
            Controls.Add(buttonAutomata);
            Controls.Add(textBoxEstado);
            Controls.Add(textBoxResultado);
            Controls.Add(label2);
            Controls.Add(labelVirus);
            Controls.Add(buttonAnalizar);
            Controls.Add(textBoxBytes);
            Controls.Add(textBoxRuta);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "VentanaAntivirus";
            Text = "My Antivirus";
            Load += Form1_Load;
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
        private Button buttonAutomata;
    }
}
