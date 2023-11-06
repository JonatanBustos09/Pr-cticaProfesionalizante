namespace __Front___Sistema_GYM_Genie
{
    partial class FrmTableroInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableroInicio));
            PnlBarraTitulo = new Panel();
            BtnMinizar = new PictureBox();
            BtnCerrar = new PictureBox();
            BtnMaximizar = new PictureBox();
            BtnRestaurar = new PictureBox();
            PnlInicio = new Panel();
            BtnIndicador = new Button();
            BtnReserva = new Button();
            BtnSalir = new PictureBox();
            BtnClase = new Button();
            BtnProfesor = new Button();
            BtnCliente = new Button();
            BtnInicio = new PictureBox();
            PnlContenedorInicio = new Panel();
            PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            PnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnInicio).BeginInit();
            SuspendLayout();
            // 
            // PnlBarraTitulo
            // 
            PnlBarraTitulo.BackColor = SystemColors.ActiveBorder;
            PnlBarraTitulo.Controls.Add(BtnMinizar);
            PnlBarraTitulo.Controls.Add(BtnCerrar);
            PnlBarraTitulo.Controls.Add(BtnMaximizar);
            PnlBarraTitulo.Controls.Add(BtnRestaurar);
            PnlBarraTitulo.Dock = DockStyle.Top;
            PnlBarraTitulo.Location = new Point(0, 0);
            PnlBarraTitulo.Name = "PnlBarraTitulo";
            PnlBarraTitulo.Size = new Size(1366, 30);
            PnlBarraTitulo.TabIndex = 0;
            PnlBarraTitulo.MouseDown += PnlBarraTitulo_MouseDown;
            // 
            // BtnMinizar
            // 
            BtnMinizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMinizar.Image = (Image)resources.GetObject("BtnMinizar.Image");
            BtnMinizar.Location = new Point(1276, 3);
            BtnMinizar.Name = "BtnMinizar";
            BtnMinizar.Size = new Size(25, 25);
            BtnMinizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMinizar.TabIndex = 3;
            BtnMinizar.TabStop = false;
            BtnMinizar.Click += BtnMinizar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCerrar.Image = Properties.Resources.CerrarVentana;
            BtnCerrar.Location = new Point(1338, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(25, 25);
            BtnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnCerrar.TabIndex = 2;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // BtnMaximizar
            // 
            BtnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnMaximizar.Image = Properties.Resources.MaximizarVentana;
            BtnMaximizar.Location = new Point(1307, 3);
            BtnMaximizar.Name = "BtnMaximizar";
            BtnMaximizar.Size = new Size(25, 25);
            BtnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnMaximizar.TabIndex = 1;
            BtnMaximizar.TabStop = false;
            BtnMaximizar.Click += BtnMaximizar_Click;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.Image = Properties.Resources.RestaurarVentana;
            BtnRestaurar.Location = new Point(1307, 3);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(25, 25);
            BtnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            BtnRestaurar.TabIndex = 0;
            BtnRestaurar.TabStop = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // PnlInicio
            // 
            PnlInicio.BackColor = Color.FromArgb(20, 20, 20);
            PnlInicio.BackgroundImageLayout = ImageLayout.None;
            PnlInicio.BorderStyle = BorderStyle.Fixed3D;
            PnlInicio.Controls.Add(BtnIndicador);
            PnlInicio.Controls.Add(BtnReserva);
            PnlInicio.Controls.Add(BtnSalir);
            PnlInicio.Controls.Add(BtnClase);
            PnlInicio.Controls.Add(BtnProfesor);
            PnlInicio.Controls.Add(BtnCliente);
            PnlInicio.Controls.Add(BtnInicio);
            PnlInicio.Dock = DockStyle.Left;
            PnlInicio.Location = new Point(0, 30);
            PnlInicio.Name = "PnlInicio";
            PnlInicio.Size = new Size(250, 738);
            PnlInicio.TabIndex = 1;
            // 
            // BtnIndicador
            // 
            BtnIndicador.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnIndicador.BackColor = Color.FromArgb(20, 20, 20);
            BtnIndicador.FlatAppearance.BorderColor = Color.Gray;
            BtnIndicador.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnIndicador.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnIndicador.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIndicador.ForeColor = Color.FromArgb(0, 205, 255);
            BtnIndicador.Location = new Point(12, 416);
            BtnIndicador.Name = "BtnIndicador";
            BtnIndicador.Size = new Size(219, 36);
            BtnIndicador.TabIndex = 10;
            BtnIndicador.Text = "INSCRIPCION";
            BtnIndicador.UseVisualStyleBackColor = false;
            BtnIndicador.Click += BtnIndicador_Click;
            // 
            // BtnReserva
            // 
            BtnReserva.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnReserva.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            BtnReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnReserva.Location = new Point(12, 332);
            BtnReserva.Name = "BtnReserva";
            BtnReserva.Size = new Size(219, 36);
            BtnReserva.TabIndex = 9;
            BtnReserva.Text = "RESERVA";
            BtnReserva.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnSalir.BackColor = Color.FromArgb(7, 29, 49);
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(12, 672);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(51, 50);
            BtnSalir.SizeMode = PictureBoxSizeMode.Zoom;
            BtnSalir.TabIndex = 8;
            BtnSalir.TabStop = false;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnClase
            // 
            BtnClase.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnClase.BackColor = Color.FromArgb(20, 20, 20);
            BtnClase.FlatAppearance.BorderColor = Color.Gray;
            BtnClase.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnClase.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnClase.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            BtnClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnClase.Location = new Point(12, 374);
            BtnClase.Name = "BtnClase";
            BtnClase.Size = new Size(219, 36);
            BtnClase.TabIndex = 7;
            BtnClase.Text = "CLASE";
            BtnClase.UseVisualStyleBackColor = false;
            BtnClase.Click += BtnClase_Click;
            // 
            // BtnProfesor
            // 
            BtnProfesor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnProfesor.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            BtnProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnProfesor.Location = new Point(12, 290);
            BtnProfesor.Name = "BtnProfesor";
            BtnProfesor.Size = new Size(219, 36);
            BtnProfesor.TabIndex = 6;
            BtnProfesor.Text = "PROFESOR";
            BtnProfesor.UseVisualStyleBackColor = false;
            BtnProfesor.Click += BtnProfesor_Click;
            // 
            // BtnCliente
            // 
            BtnCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnCliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnCliente.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            BtnCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnCliente.Location = new Point(12, 248);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(219, 36);
            BtnCliente.TabIndex = 5;
            BtnCliente.Text = "CLIENTE";
            BtnCliente.UseVisualStyleBackColor = false;
            BtnCliente.Click += BtnCliente_Click;
            // 
            // BtnInicio
            // 
            BtnInicio.Image = Properties.Resources.Logo;
            BtnInicio.Location = new Point(0, 13);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(248, 215);
            BtnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            BtnInicio.TabIndex = 0;
            BtnInicio.TabStop = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // PnlContenedorInicio
            // 
            PnlContenedorInicio.BackColor = Color.FromArgb(7, 29, 49);
            PnlContenedorInicio.BorderStyle = BorderStyle.Fixed3D;
            PnlContenedorInicio.Dock = DockStyle.Fill;
            PnlContenedorInicio.Location = new Point(250, 30);
            PnlContenedorInicio.Name = "PnlContenedorInicio";
            PnlContenedorInicio.Size = new Size(1116, 738);
            PnlContenedorInicio.TabIndex = 2;
            // 
            // FrmTableroInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1366, 768);
            Controls.Add(PnlContenedorInicio);
            Controls.Add(PnlInicio);
            Controls.Add(PnlBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTableroInicio";
            Text = "FrmInicio";
            Activated += FrmTableroInicio_Activated;
            Load += FrmTableroInicio_Load;
            PnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnMinizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).EndInit();
            PnlInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlBarraTitulo;
        private PictureBox BtnMinizar;
        private PictureBox BtnCerrar;
        private PictureBox BtnMaximizar;
        private PictureBox BtnRestaurar;
        private Panel PnlInicio;
        private Panel PnlContenedorInicio;
        private PictureBox BtnInicio;
        private Button BtnCliente;
        private Button BtnClase;
        private Button BtnProfesor;
        private PictureBox BtnSalir;
        private Button BtnReserva;
        private Button BtnIndicador;
    }
}