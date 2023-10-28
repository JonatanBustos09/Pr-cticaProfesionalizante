namespace __Front___Sistema_GYM_Genie
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            PnlLogo = new Panel();
            BtnCerrar = new PictureBox();
            pictureBox1 = new PictureBox();
            PnlContenedor = new Panel();
            LblContrasena = new Label();
            LblUsuario = new Label();
            TxtContrasena = new TextBox();
            TxtUsuario = new TextBox();
            BtnIngresar = new Button();
            LblLogin = new Label();
            PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLogo
            // 
            PnlLogo.BackColor = Color.FromArgb(0, 205, 255);
            PnlLogo.BorderStyle = BorderStyle.Fixed3D;
            PnlLogo.Controls.Add(BtnCerrar);
            PnlLogo.Controls.Add(pictureBox1);
            PnlLogo.Dock = DockStyle.Left;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.Size = new Size(275, 330);
            PnlLogo.TabIndex = 0;
            // 
            // BtnCerrar
            // 
            BtnCerrar.BackColor = Color.FromArgb(7, 29, 49);
            BtnCerrar.Image = Properties.Resources.Apagar;
            BtnCerrar.Location = new Point(5, 273);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(51, 50);
            BtnCerrar.TabIndex = 1;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(-2, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PnlContenedor
            // 
            PnlContenedor.BackColor = Color.FromArgb(7, 29, 49);
            PnlContenedor.BorderStyle = BorderStyle.Fixed3D;
            PnlContenedor.Controls.Add(LblContrasena);
            PnlContenedor.Controls.Add(LblUsuario);
            PnlContenedor.Controls.Add(TxtContrasena);
            PnlContenedor.Controls.Add(TxtUsuario);
            PnlContenedor.Controls.Add(BtnIngresar);
            PnlContenedor.Controls.Add(LblLogin);
            PnlContenedor.Dock = DockStyle.Fill;
            PnlContenedor.Location = new Point(275, 0);
            PnlContenedor.Name = "PnlContenedor";
            PnlContenedor.Size = new Size(505, 330);
            PnlContenedor.TabIndex = 1;
            PnlContenedor.MouseDown += PnlContenedor_MouseDown;
            // 
            // LblContrasena
            // 
            LblContrasena.BackColor = Color.White;
            LblContrasena.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblContrasena.Location = new Point(87, 178);
            LblContrasena.Name = "LblContrasena";
            LblContrasena.Size = new Size(317, 23);
            LblContrasena.TabIndex = 6;
            LblContrasena.Text = "CONTRASEÑA";
            LblContrasena.TextAlign = ContentAlignment.MiddleLeft;
            LblContrasena.Click += LblContrasena_Click;
            // 
            // LblUsuario
            // 
            LblUsuario.BackColor = Color.White;
            LblUsuario.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblUsuario.Location = new Point(87, 129);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(317, 23);
            LblUsuario.TabIndex = 5;
            LblUsuario.Text = "USUARIO";
            LblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            LblUsuario.Click += LblUsuario_Click;
            // 
            // TxtContrasena
            // 
            TxtContrasena.ForeColor = Color.FromArgb(7, 29, 49);
            TxtContrasena.Location = new Point(87, 178);
            TxtContrasena.Name = "TxtContrasena";
            TxtContrasena.Size = new Size(317, 23);
            TxtContrasena.TabIndex = 2;
            TxtContrasena.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUsuario.Location = new Point(87, 133);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(317, 21);
            TxtUsuario.TabIndex = 1;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIngresar.ForeColor = Color.FromArgb(7, 29, 49);
            BtnIngresar.Location = new Point(189, 234);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(113, 29);
            BtnIngresar.TabIndex = 1;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click_1;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Impact", 24F, FontStyle.Italic, GraphicsUnit.Point);
            LblLogin.ForeColor = Color.FromArgb(0, 205, 255);
            LblLogin.Location = new Point(194, 53);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(87, 39);
            LblLogin.TabIndex = 0;
            LblLogin.Text = "Login";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 330);
            Controls.Add(PnlContenedor);
            Controls.Add(PnlLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Opacity = 0.8D;
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Formulario Login";
            PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PnlContenedor.ResumeLayout(false);
            PnlContenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlLogo;
        private Panel PnlContenedor;
        private PictureBox BtnCerrar;
        private PictureBox pictureBox1;
        private Button BtnIngresar;
        private Label LblLogin;
        private Label LblUsuario;
        private TextBox TxtContrasena;
        private TextBox TxtUsuario;
        private Label LblContrasena;
    }
}