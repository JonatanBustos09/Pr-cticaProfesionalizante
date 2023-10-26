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
            PnlReserva = new Panel();
            BtnMODReserva = new Button();
            BtnALTAReserva = new Button();
            BtnBAJAReserva = new Button();
            PnlProfesor = new Panel();
            BtnMODProfesor = new Button();
            BtnALTAProfesor = new Button();
            BtnBAJAProfesor = new Button();
            PnlCliente = new Panel();
            BtnMODCliente = new Button();
            BtnALTACliente = new Button();
            BtnBAJACliente = new Button();
            PnlIndicador = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            BtnPago = new Button();
            PnlClase = new Panel();
            BtnMODClase = new Button();
            BtnALTAClase = new Button();
            BtnBAJAClase = new Button();
            PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            PnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnInicio).BeginInit();
            PnlContenedorInicio.SuspendLayout();
            PnlReserva.SuspendLayout();
            PnlProfesor.SuspendLayout();
            PnlCliente.SuspendLayout();
            PnlIndicador.SuspendLayout();
            PnlClase.SuspendLayout();
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
            BtnIndicador.Font = new Font("Impact", 32F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIndicador.ForeColor = Color.FromArgb(0, 205, 255);
            BtnIndicador.Location = new Point(12, 549);
            BtnIndicador.Name = "BtnIndicador";
            BtnIndicador.Size = new Size(219, 66);
            BtnIndicador.TabIndex = 10;
            BtnIndicador.Text = "INDICADOR";
            BtnIndicador.UseVisualStyleBackColor = false;
            // 
            // BtnReserva
            // 
            BtnReserva.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnReserva.Font = new Font("Impact", 32F, FontStyle.Italic, GraphicsUnit.Point);
            BtnReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnReserva.Location = new Point(12, 405);
            BtnReserva.Name = "BtnReserva";
            BtnReserva.Size = new Size(219, 66);
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
            BtnClase.Font = new Font("Impact", 32F, FontStyle.Italic, GraphicsUnit.Point);
            BtnClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnClase.Location = new Point(12, 477);
            BtnClase.Name = "BtnClase";
            BtnClase.Size = new Size(219, 66);
            BtnClase.TabIndex = 7;
            BtnClase.Text = "CLASE";
            BtnClase.UseVisualStyleBackColor = false;
            // 
            // BtnProfesor
            // 
            BtnProfesor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BtnProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnProfesor.Font = new Font("Impact", 32F, FontStyle.Italic, GraphicsUnit.Point);
            BtnProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnProfesor.Location = new Point(12, 333);
            BtnProfesor.Name = "BtnProfesor";
            BtnProfesor.Size = new Size(219, 66);
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
            BtnCliente.Font = new Font("Impact", 32F, FontStyle.Italic, GraphicsUnit.Point);
            BtnCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnCliente.Location = new Point(12, 261);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(219, 66);
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
            BtnInicio.Size = new Size(250, 226);
            BtnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            BtnInicio.TabIndex = 0;
            BtnInicio.TabStop = false;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // PnlContenedorInicio
            // 
            PnlContenedorInicio.BackColor = Color.FromArgb(7, 29, 49);
            PnlContenedorInicio.BorderStyle = BorderStyle.Fixed3D;
            PnlContenedorInicio.Controls.Add(PnlClase);
            PnlContenedorInicio.Controls.Add(PnlIndicador);
            PnlContenedorInicio.Controls.Add(PnlReserva);
            PnlContenedorInicio.Controls.Add(PnlProfesor);
            PnlContenedorInicio.Controls.Add(PnlCliente);
            PnlContenedorInicio.Dock = DockStyle.Fill;
            PnlContenedorInicio.Location = new Point(250, 30);
            PnlContenedorInicio.Name = "PnlContenedorInicio";
            PnlContenedorInicio.Size = new Size(1116, 738);
            PnlContenedorInicio.TabIndex = 2;
            // 
            // PnlReserva
            // 
            PnlReserva.Controls.Add(BtnMODReserva);
            PnlReserva.Controls.Add(BtnALTAReserva);
            PnlReserva.Controls.Add(BtnBAJAReserva);
            PnlReserva.Location = new Point(482, 14);
            PnlReserva.Name = "PnlReserva";
            PnlReserva.Size = new Size(203, 215);
            PnlReserva.TabIndex = 17;
            // 
            // BtnMODReserva
            // 
            BtnMODReserva.Anchor = AnchorStyles.None;
            BtnMODReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnMODReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODReserva.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODReserva.Location = new Point(0, 144);
            BtnMODReserva.Name = "BtnMODReserva";
            BtnMODReserva.Size = new Size(201, 66);
            BtnMODReserva.TabIndex = 15;
            BtnMODReserva.Text = "MODIFICACIÓN";
            BtnMODReserva.UseVisualStyleBackColor = false;
            // 
            // BtnALTAReserva
            // 
            BtnALTAReserva.Anchor = AnchorStyles.None;
            BtnALTAReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTAReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnALTAReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTAReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTAReserva.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTAReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTAReserva.Location = new Point(0, 1);
            BtnALTAReserva.Name = "BtnALTAReserva";
            BtnALTAReserva.Size = new Size(201, 66);
            BtnALTAReserva.TabIndex = 13;
            BtnALTAReserva.Text = "ALTA";
            BtnALTAReserva.UseVisualStyleBackColor = false;
            // 
            // BtnBAJAReserva
            // 
            BtnBAJAReserva.Anchor = AnchorStyles.None;
            BtnBAJAReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJAReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJAReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJAReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJAReserva.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJAReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJAReserva.Location = new Point(-1, 73);
            BtnBAJAReserva.Name = "BtnBAJAReserva";
            BtnBAJAReserva.Size = new Size(201, 66);
            BtnBAJAReserva.TabIndex = 14;
            BtnBAJAReserva.Text = "BAJA";
            BtnBAJAReserva.UseVisualStyleBackColor = false;
            // 
            // PnlProfesor
            // 
            PnlProfesor.Controls.Add(BtnMODProfesor);
            PnlProfesor.Controls.Add(BtnALTAProfesor);
            PnlProfesor.Controls.Add(BtnBAJAProfesor);
            PnlProfesor.Location = new Point(247, 13);
            PnlProfesor.Name = "PnlProfesor";
            PnlProfesor.Size = new Size(203, 215);
            PnlProfesor.TabIndex = 16;
            // 
            // BtnMODProfesor
            // 
            BtnMODProfesor.Anchor = AnchorStyles.None;
            BtnMODProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnMODProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODProfesor.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODProfesor.Location = new Point(1, 144);
            BtnMODProfesor.Name = "BtnMODProfesor";
            BtnMODProfesor.Size = new Size(201, 66);
            BtnMODProfesor.TabIndex = 15;
            BtnMODProfesor.Text = "MODIFICACIÓN";
            BtnMODProfesor.UseVisualStyleBackColor = false;
            // 
            // BtnALTAProfesor
            // 
            BtnALTAProfesor.Anchor = AnchorStyles.None;
            BtnALTAProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTAProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnALTAProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTAProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTAProfesor.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTAProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTAProfesor.Location = new Point(1, 1);
            BtnALTAProfesor.Name = "BtnALTAProfesor";
            BtnALTAProfesor.Size = new Size(201, 66);
            BtnALTAProfesor.TabIndex = 13;
            BtnALTAProfesor.Text = "ALTA";
            BtnALTAProfesor.UseVisualStyleBackColor = false;
            // 
            // BtnBAJAProfesor
            // 
            BtnBAJAProfesor.Anchor = AnchorStyles.None;
            BtnBAJAProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJAProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJAProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJAProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJAProfesor.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJAProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJAProfesor.Location = new Point(1, 72);
            BtnBAJAProfesor.Name = "BtnBAJAProfesor";
            BtnBAJAProfesor.Size = new Size(201, 66);
            BtnBAJAProfesor.TabIndex = 14;
            BtnBAJAProfesor.Text = "BAJA";
            BtnBAJAProfesor.UseVisualStyleBackColor = false;
            // 
            // PnlCliente
            // 
            PnlCliente.Controls.Add(BtnMODCliente);
            PnlCliente.Controls.Add(BtnALTACliente);
            PnlCliente.Controls.Add(BtnBAJACliente);
            PnlCliente.Location = new Point(17, 13);
            PnlCliente.Name = "PnlCliente";
            PnlCliente.Size = new Size(203, 215);
            PnlCliente.TabIndex = 0;
            // 
            // BtnMODCliente
            // 
            BtnMODCliente.Anchor = AnchorStyles.None;
            BtnMODCliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnMODCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODCliente.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODCliente.Location = new Point(2, 144);
            BtnMODCliente.Name = "BtnMODCliente";
            BtnMODCliente.Size = new Size(201, 66);
            BtnMODCliente.TabIndex = 15;
            BtnMODCliente.Text = "MODIFICACIÓN";
            BtnMODCliente.UseVisualStyleBackColor = false;
            // 
            // BtnALTACliente
            // 
            BtnALTACliente.Anchor = AnchorStyles.None;
            BtnALTACliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTACliente.FlatAppearance.BorderColor = Color.Gray;
            BtnALTACliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTACliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTACliente.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTACliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTACliente.Location = new Point(2, 0);
            BtnALTACliente.Name = "BtnALTACliente";
            BtnALTACliente.Size = new Size(201, 66);
            BtnALTACliente.TabIndex = 13;
            BtnALTACliente.Text = "ALTA";
            BtnALTACliente.UseVisualStyleBackColor = false;
            // 
            // BtnBAJACliente
            // 
            BtnBAJACliente.Anchor = AnchorStyles.None;
            BtnBAJACliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJACliente.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJACliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJACliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJACliente.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJACliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJACliente.Location = new Point(2, 72);
            BtnBAJACliente.Name = "BtnBAJACliente";
            BtnBAJACliente.Size = new Size(201, 66);
            BtnBAJACliente.TabIndex = 14;
            BtnBAJACliente.Text = "BAJA";
            BtnBAJACliente.UseVisualStyleBackColor = false;
            // 
            // PnlIndicador
            // 
            PnlIndicador.Controls.Add(BtnPago);
            PnlIndicador.Controls.Add(button1);
            PnlIndicador.Controls.Add(button2);
            PnlIndicador.Controls.Add(button3);
            PnlIndicador.Location = new Point(17, 256);
            PnlIndicador.Name = "PnlIndicador";
            PnlIndicador.Size = new Size(203, 287);
            PnlIndicador.TabIndex = 16;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 205, 255);
            button1.Location = new Point(2, 148);
            button1.Name = "button1";
            button1.Size = new Size(201, 66);
            button1.TabIndex = 15;
            button1.Text = "RESERVA";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 205, 255);
            button2.Location = new Point(2, 4);
            button2.Name = "button2";
            button2.Size = new Size(201, 66);
            button2.TabIndex = 13;
            button2.Text = "CLIENTE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 205, 255);
            button3.Location = new Point(2, 76);
            button3.Name = "button3";
            button3.Size = new Size(201, 66);
            button3.TabIndex = 14;
            button3.Text = "PROFESOR";
            button3.UseVisualStyleBackColor = false;
            // 
            // BtnPago
            // 
            BtnPago.Anchor = AnchorStyles.None;
            BtnPago.BackColor = Color.FromArgb(20, 20, 20);
            BtnPago.FlatAppearance.BorderColor = Color.Gray;
            BtnPago.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnPago.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPago.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnPago.ForeColor = Color.FromArgb(0, 205, 255);
            BtnPago.Location = new Point(2, 220);
            BtnPago.Name = "BtnPago";
            BtnPago.Size = new Size(201, 66);
            BtnPago.TabIndex = 16;
            BtnPago.Text = "PAGO";
            BtnPago.UseVisualStyleBackColor = false;
            // 
            // PnlClase
            // 
            PnlClase.Controls.Add(BtnMODClase);
            PnlClase.Controls.Add(BtnALTAClase);
            PnlClase.Controls.Add(BtnBAJAClase);
            PnlClase.Location = new Point(716, 13);
            PnlClase.Name = "PnlClase";
            PnlClase.Size = new Size(203, 215);
            PnlClase.TabIndex = 18;
            // 
            // BtnMODClase
            // 
            BtnMODClase.Anchor = AnchorStyles.None;
            BtnMODClase.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODClase.FlatAppearance.BorderColor = Color.Gray;
            BtnMODClase.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODClase.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODClase.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODClase.Location = new Point(2, 146);
            BtnMODClase.Name = "BtnMODClase";
            BtnMODClase.Size = new Size(201, 66);
            BtnMODClase.TabIndex = 15;
            BtnMODClase.Text = "MODIFICACIÓN";
            BtnMODClase.UseVisualStyleBackColor = false;
            // 
            // BtnALTAClase
            // 
            BtnALTAClase.Anchor = AnchorStyles.None;
            BtnALTAClase.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTAClase.FlatAppearance.BorderColor = Color.Gray;
            BtnALTAClase.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTAClase.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTAClase.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTAClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTAClase.Location = new Point(1, 2);
            BtnALTAClase.Name = "BtnALTAClase";
            BtnALTAClase.Size = new Size(201, 66);
            BtnALTAClase.TabIndex = 13;
            BtnALTAClase.Text = "ALTA";
            BtnALTAClase.UseVisualStyleBackColor = false;
            // 
            // BtnBAJAClase
            // 
            BtnBAJAClase.Anchor = AnchorStyles.None;
            BtnBAJAClase.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJAClase.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJAClase.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJAClase.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJAClase.Font = new Font("Impact", 22F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJAClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJAClase.Location = new Point(2, 74);
            BtnBAJAClase.Name = "BtnBAJAClase";
            BtnBAJAClase.Size = new Size(201, 66);
            BtnBAJAClase.TabIndex = 14;
            BtnBAJAClase.Text = "BAJA";
            BtnBAJAClase.UseVisualStyleBackColor = false;
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
            PnlContenedorInicio.ResumeLayout(false);
            PnlReserva.ResumeLayout(false);
            PnlProfesor.ResumeLayout(false);
            PnlCliente.ResumeLayout(false);
            PnlIndicador.ResumeLayout(false);
            PnlClase.ResumeLayout(false);
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
        private Panel PnlCliente;
        private Panel PnlReserva;
        private Button BtnMODReserva;
        private Button BtnALTAReserva;
        private Button BtnBAJAReserva;
        private Panel PnlProfesor;
        private Button BtnMODProfesor;
        private Button BtnALTAProfesor;
        private Button BtnBAJAProfesor;
        private Button BtnMODCliente;
        private Button BtnALTACliente;
        private Button BtnBAJACliente;
        private Panel PnlClase;
        private Button BtnMODClase;
        private Button BtnALTAClase;
        private Button BtnBAJAClase;
        private Panel PnlIndicador;
        private Button BtnPago;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}