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
            button1 = new Button();
            label1 = new Label();
            textBoxRuta = new TextBox();
            textBoxBytes = new TextBox();
            button2 = new Button();
            labelVirus = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(466, 100);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 35);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 1;
            label1.Text = "Malwerbytes";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Location = new Point(89, 103);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.Size = new Size(371, 31);
            textBoxRuta.TabIndex = 2;
            // 
            // textBoxBytes
            // 
            textBoxBytes.Location = new Point(89, 170);
            textBoxBytes.Multiline = true;
            textBoxBytes.Name = "textBoxBytes";
            textBoxBytes.Size = new Size(371, 246);
            textBoxBytes.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(466, 170);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Analizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelVirus
            // 
            labelVirus.AutoSize = true;
            labelVirus.Location = new Point(507, 222);
            labelVirus.Name = "labelVirus";
            labelVirus.Size = new Size(51, 25);
            labelVirus.TabIndex = 5;
            labelVirus.Text = "Virus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 324);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 6;
            label2.Text = "Estado de parada";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.Location = new Point(507, 250);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 46);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 255);
            textBox2.ForeColor = Color.FromArgb(192, 192, 255);
            textBox2.Location = new Point(508, 364);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // VentanaAntivirus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
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
        private TextBox textBox2;
    }
}
