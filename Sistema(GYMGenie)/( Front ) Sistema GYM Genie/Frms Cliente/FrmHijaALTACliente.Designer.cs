namespace __Front___Sistema_GYM_Genie.Frms_Cliente
{
    partial class FrmHijaALTACliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHijaALTACliente));
            PnlALTACliente = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            LblTituloCliente = new Label();
            label1 = new Label();
            LblDNI = new Label();
            TxtDNI = new TextBox();
            TxtNombre = new TextBox();
            LblNombre = new Label();
            TxtApellido = new TextBox();
            LblApellido = new Label();
            PnlALTACliente.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PnlALTACliente
            // 
            PnlALTACliente.BackColor = Color.FromArgb(20, 20, 20);
            PnlALTACliente.Controls.Add(panel1);
            PnlALTACliente.Controls.Add(LblTituloCliente);
            PnlALTACliente.Location = new Point(-1, 1);
            PnlALTACliente.Name = "PnlALTACliente";
            PnlALTACliente.Size = new Size(1105, 738);
            PnlALTACliente.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtApellido);
            panel1.Controls.Add(LblApellido);
            panel1.Controls.Add(TxtNombre);
            panel1.Controls.Add(LblNombre);
            panel1.Controls.Add(TxtDNI);
            panel1.Controls.Add(LblDNI);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 738);
            panel1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1365, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(167, 833);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.Gimnasio4;
            pictureBox1.Location = new Point(1365, 506);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 833);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1289, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 833);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // LblTituloCliente
            // 
            LblTituloCliente.Anchor = AnchorStyles.Top;
            LblTituloCliente.BorderStyle = BorderStyle.Fixed3D;
            LblTituloCliente.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            LblTituloCliente.ForeColor = Color.FromArgb(0, 205, 255);
            LblTituloCliente.Location = new Point(444, 29);
            LblTituloCliente.Name = "LblTituloCliente";
            LblTituloCliente.Size = new Size(281, 66);
            LblTituloCliente.TabIndex = 9;
            LblTituloCliente.Text = "BAJA CLIENTE";
            LblTituloCliente.TextAlign = ContentAlignment.MiddleCenter;
            LblTituloCliente.Click += LblTituloCliente_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 205, 255);
            label1.Location = new Point(420, 29);
            label1.Name = "label1";
            label1.Size = new Size(281, 66);
            label1.TabIndex = 8;
            label1.Text = "ALTA CLIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDNI
            // 
            LblDNI.AutoSize = true;
            LblDNI.BackColor = Color.White;
            LblDNI.Location = new Point(65, 160);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(27, 15);
            LblDNI.TabIndex = 9;
            LblDNI.Text = "DNI";
            // 
            // TxtDNI
            // 
            TxtDNI.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDNI.Location = new Point(132, 158);
            TxtDNI.Name = "TxtDNI";
            TxtDNI.Size = new Size(317, 21);
            TxtDNI.TabIndex = 10;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombre.Location = new Point(132, 201);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(317, 21);
            TxtNombre.TabIndex = 12;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.BackColor = Color.White;
            LblNombre.Location = new Point(65, 203);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(56, 15);
            LblNombre.TabIndex = 11;
            LblNombre.Text = "NOMBRE";
            // 
            // TxtApellido
            // 
            TxtApellido.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtApellido.Location = new Point(132, 244);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(317, 21);
            TxtApellido.TabIndex = 14;
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.BackColor = Color.White;
            LblApellido.Location = new Point(65, 246);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(60, 15);
            LblApellido.TabIndex = 13;
            LblApellido.Text = "APELLIDO";
            // 
            // FrmHijaALTACliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(PnlALTACliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHijaALTACliente";
            Text = "FrmHijaALTACliente";
            PnlALTACliente.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlALTACliente;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label LblTituloCliente;
        private Label LblDNI;
        private Label label1;
        private TextBox TxtApellido;
        private Label LblApellido;
        private TextBox TxtNombre;
        private Label LblNombre;
        private TextBox TxtDNI;
    }
}