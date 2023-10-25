namespace __Front___Sistema_GYM_Genie
{
    partial class FrmHijaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHijaCliente));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            BtnModCliente = new Button();
            BtnBajaCliente = new Button();
            BtnAltaCliente = new Button();
            LblTituloCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.Gimnasio4;
            pictureBox1.Location = new Point(40, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(392, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(324, 375);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(748, 165);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(324, 375);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BtnModCliente);
            panel1.Controls.Add(BtnAltaCliente);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnBajaCliente);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 738);
            panel1.TabIndex = 3;
            // 
            // BtnModCliente
            // 
            BtnModCliente.Anchor = AnchorStyles.None;
            BtnModCliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnModCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnModCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnModCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnModCliente.Font = new Font("Impact", 30F, FontStyle.Italic, GraphicsUnit.Point);
            BtnModCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnModCliente.Location = new Point(748, 474);
            BtnModCliente.Name = "BtnModCliente";
            BtnModCliente.Size = new Size(324, 66);
            BtnModCliente.TabIndex = 11;
            BtnModCliente.Text = "MODIFICACIÓN";
            BtnModCliente.UseVisualStyleBackColor = false;
            // 
            // BtnBajaCliente
            // 
            BtnBajaCliente.Anchor = AnchorStyles.None;
            BtnBajaCliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnBajaCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnBajaCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBajaCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBajaCliente.Font = new Font("Impact", 30F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBajaCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBajaCliente.Location = new Point(392, 474);
            BtnBajaCliente.Name = "BtnBajaCliente";
            BtnBajaCliente.Size = new Size(324, 66);
            BtnBajaCliente.TabIndex = 10;
            BtnBajaCliente.Text = "BAJA";
            BtnBajaCliente.UseVisualStyleBackColor = false;
            // 
            // BtnAltaCliente
            // 
            BtnAltaCliente.Anchor = AnchorStyles.None;
            BtnAltaCliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnAltaCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnAltaCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnAltaCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnAltaCliente.Font = new Font("Impact", 30F, FontStyle.Italic, GraphicsUnit.Point);
            BtnAltaCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnAltaCliente.Location = new Point(40, 474);
            BtnAltaCliente.Name = "BtnAltaCliente";
            BtnAltaCliente.Size = new Size(324, 66);
            BtnAltaCliente.TabIndex = 9;
            BtnAltaCliente.Text = "ALTA";
            BtnAltaCliente.UseVisualStyleBackColor = false;
            // 
            // LblTituloCliente
            // 
            LblTituloCliente.Anchor = AnchorStyles.Top;
            LblTituloCliente.BorderStyle = BorderStyle.Fixed3D;
            LblTituloCliente.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            LblTituloCliente.ForeColor = Color.FromArgb(0, 205, 255);
            LblTituloCliente.Location = new Point(444, 29);
            LblTituloCliente.Name = "LblTituloCliente";
            LblTituloCliente.Size = new Size(223, 66);
            LblTituloCliente.TabIndex = 7;
            LblTituloCliente.Text = "CLIENTE";
            LblTituloCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmHijaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1116, 738);
            Controls.Add(LblTituloCliente);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(20, 20, 20);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHijaCliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label LblTituloCliente;
        private Button BtnModCliente;
        private Button BtnBajaCliente;
        private Button BtnAltaCliente;
    }
}