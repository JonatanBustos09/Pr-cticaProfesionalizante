﻿namespace __Front___Sistema_GYM_Genie
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
            PnlCliente = new Panel();
            BtnMODCliente = new Button();
            BtnALTACliente = new Button();
            BtnBAJACliente = new Button();
            PnlProfesor = new Panel();
            BtnMODProfesor = new Button();
            BtnALTAProfesor = new Button();
            BtnBAJAProfesor = new Button();
            PnlReserva = new Panel();
            BtnMODReserva = new Button();
            BtnALTAReserva = new Button();
            BtnBAJAReserva = new Button();
            PnlClase = new Panel();
            BtnMODClase = new Button();
            BtnALTAClase = new Button();
            BtnBAJAClase = new Button();
            BtnIndicador = new Button();
            PnlIndicador = new Panel();
            BtnPago = new Button();
            BtnIndicadorReserva = new Button();
            BtnIndicadorCliente = new Button();
            BtnIndicadorProfesor = new Button();
            BtnReserva = new Button();
            BtnSalir = new PictureBox();
            BtnClase = new Button();
            BtnProfesor = new Button();
            BtnCliente = new Button();
            BtnInicio = new PictureBox();
            PnlContenedorInicio = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnMinizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnRestaurar).BeginInit();
            PnlInicio.SuspendLayout();
            PnlCliente.SuspendLayout();
            PnlProfesor.SuspendLayout();
            PnlReserva.SuspendLayout();
            PnlClase.SuspendLayout();
            PnlIndicador.SuspendLayout();
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
            PnlInicio.Controls.Add(PnlCliente);
            PnlInicio.Controls.Add(PnlProfesor);
            PnlInicio.Controls.Add(PnlReserva);
            PnlInicio.Controls.Add(PnlClase);
            PnlInicio.Controls.Add(BtnIndicador);
            PnlInicio.Controls.Add(PnlIndicador);
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
            // PnlCliente
            // 
            PnlCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PnlCliente.Controls.Add(button4);
            PnlCliente.Controls.Add(button3);
            PnlCliente.Controls.Add(BtnMODCliente);
            PnlCliente.Controls.Add(button2);
            PnlCliente.Controls.Add(BtnALTACliente);
            PnlCliente.Controls.Add(button1);
            PnlCliente.Controls.Add(BtnBAJACliente);
            PnlCliente.Location = new Point(12, 290);
            PnlCliente.Name = "PnlCliente";
            PnlCliente.Size = new Size(219, 240);
            PnlCliente.TabIndex = 0;
            PnlCliente.Visible = false;
            // 
            // BtnMODCliente
            // 
            BtnMODCliente.Anchor = AnchorStyles.None;
            BtnMODCliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnMODCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODCliente.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODCliente.Location = new Point(0, 88);
            BtnMODCliente.Name = "BtnMODCliente";
            BtnMODCliente.Size = new Size(219, 36);
            BtnMODCliente.TabIndex = 15;
            BtnMODCliente.Text = "MODIFICACIÓN";
            BtnMODCliente.UseVisualStyleBackColor = false;
            BtnMODCliente.Click += BtnMODCliente_Click;
            // 
            // BtnALTACliente
            // 
            BtnALTACliente.Anchor = AnchorStyles.None;
            BtnALTACliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTACliente.FlatAppearance.BorderColor = Color.Gray;
            BtnALTACliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTACliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTACliente.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTACliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTACliente.Location = new Point(0, 4);
            BtnALTACliente.Name = "BtnALTACliente";
            BtnALTACliente.Size = new Size(219, 36);
            BtnALTACliente.TabIndex = 13;
            BtnALTACliente.Text = "ALTA";
            BtnALTACliente.UseVisualStyleBackColor = false;
            BtnALTACliente.Click += BtnALTACliente_Click;
            // 
            // BtnBAJACliente
            // 
            BtnBAJACliente.Anchor = AnchorStyles.None;
            BtnBAJACliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJACliente.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJACliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJACliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJACliente.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJACliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJACliente.Location = new Point(0, 46);
            BtnBAJACliente.Name = "BtnBAJACliente";
            BtnBAJACliente.Size = new Size(219, 36);
            BtnBAJACliente.TabIndex = 14;
            BtnBAJACliente.Text = "BAJA";
            BtnBAJACliente.UseVisualStyleBackColor = false;
            BtnBAJACliente.Click += BtnBAJACliente_Click;
            // 
            // PnlProfesor
            // 
            PnlProfesor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PnlProfesor.Controls.Add(BtnMODProfesor);
            PnlProfesor.Controls.Add(BtnALTAProfesor);
            PnlProfesor.Controls.Add(BtnBAJAProfesor);
            PnlProfesor.Location = new Point(11, 332);
            PnlProfesor.Name = "PnlProfesor";
            PnlProfesor.Size = new Size(219, 240);
            PnlProfesor.TabIndex = 16;
            PnlProfesor.Visible = false;
            // 
            // BtnMODProfesor
            // 
            BtnMODProfesor.Anchor = AnchorStyles.None;
            BtnMODProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnMODProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODProfesor.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODProfesor.Location = new Point(1, 88);
            BtnMODProfesor.Name = "BtnMODProfesor";
            BtnMODProfesor.Size = new Size(219, 36);
            BtnMODProfesor.TabIndex = 15;
            BtnMODProfesor.Text = "MODIFICACIÓN";
            BtnMODProfesor.UseVisualStyleBackColor = false;
            BtnMODProfesor.Click += BtnMODProfesor_Click;
            // 
            // BtnALTAProfesor
            // 
            BtnALTAProfesor.Anchor = AnchorStyles.None;
            BtnALTAProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTAProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnALTAProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTAProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTAProfesor.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTAProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTAProfesor.Location = new Point(1, 4);
            BtnALTAProfesor.Name = "BtnALTAProfesor";
            BtnALTAProfesor.Size = new Size(219, 36);
            BtnALTAProfesor.TabIndex = 13;
            BtnALTAProfesor.Text = "ALTA";
            BtnALTAProfesor.UseVisualStyleBackColor = false;
            BtnALTAProfesor.Click += BtnALTAProfesor_Click;
            // 
            // BtnBAJAProfesor
            // 
            BtnBAJAProfesor.Anchor = AnchorStyles.None;
            BtnBAJAProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJAProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJAProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJAProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJAProfesor.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJAProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJAProfesor.Location = new Point(0, 46);
            BtnBAJAProfesor.Name = "BtnBAJAProfesor";
            BtnBAJAProfesor.Size = new Size(219, 36);
            BtnBAJAProfesor.TabIndex = 14;
            BtnBAJAProfesor.Text = "BAJA";
            BtnBAJAProfesor.UseVisualStyleBackColor = false;
            BtnBAJAProfesor.Click += BtnBAJAProfesor_Click;
            // 
            // PnlReserva
            // 
            PnlReserva.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PnlReserva.Controls.Add(BtnMODReserva);
            PnlReserva.Controls.Add(BtnALTAReserva);
            PnlReserva.Controls.Add(BtnBAJAReserva);
            PnlReserva.Location = new Point(12, 374);
            PnlReserva.Name = "PnlReserva";
            PnlReserva.Size = new Size(219, 240);
            PnlReserva.TabIndex = 17;
            PnlReserva.Visible = false;
            // 
            // BtnMODReserva
            // 
            BtnMODReserva.Anchor = AnchorStyles.None;
            BtnMODReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnMODReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODReserva.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODReserva.Location = new Point(0, 88);
            BtnMODReserva.Name = "BtnMODReserva";
            BtnMODReserva.Size = new Size(219, 36);
            BtnMODReserva.TabIndex = 15;
            BtnMODReserva.Text = "MODIFICACIÓN";
            BtnMODReserva.UseVisualStyleBackColor = false;
            BtnMODReserva.Click += BtnMODReserva_Click;
            // 
            // BtnALTAReserva
            // 
            BtnALTAReserva.Anchor = AnchorStyles.None;
            BtnALTAReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTAReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnALTAReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTAReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTAReserva.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTAReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTAReserva.Location = new Point(0, 4);
            BtnALTAReserva.Name = "BtnALTAReserva";
            BtnALTAReserva.Size = new Size(219, 36);
            BtnALTAReserva.TabIndex = 13;
            BtnALTAReserva.Text = "ALTA";
            BtnALTAReserva.UseVisualStyleBackColor = false;
            BtnALTAReserva.Click += BtnALTAReserva_Click;
            // 
            // BtnBAJAReserva
            // 
            BtnBAJAReserva.Anchor = AnchorStyles.None;
            BtnBAJAReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJAReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJAReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJAReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJAReserva.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJAReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJAReserva.Location = new Point(0, 46);
            BtnBAJAReserva.Name = "BtnBAJAReserva";
            BtnBAJAReserva.Size = new Size(219, 36);
            BtnBAJAReserva.TabIndex = 14;
            BtnBAJAReserva.Text = "BAJA";
            BtnBAJAReserva.UseVisualStyleBackColor = false;
            BtnBAJAReserva.Click += BtnBAJAReserva_Click;
            // 
            // PnlClase
            // 
            PnlClase.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PnlClase.Controls.Add(BtnMODClase);
            PnlClase.Controls.Add(BtnALTAClase);
            PnlClase.Controls.Add(BtnBAJAClase);
            PnlClase.Location = new Point(12, 416);
            PnlClase.Name = "PnlClase";
            PnlClase.Size = new Size(219, 215);
            PnlClase.TabIndex = 18;
            PnlClase.Visible = false;
            // 
            // BtnMODClase
            // 
            BtnMODClase.Anchor = AnchorStyles.None;
            BtnMODClase.BackColor = Color.FromArgb(20, 20, 20);
            BtnMODClase.FlatAppearance.BorderColor = Color.Gray;
            BtnMODClase.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODClase.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODClase.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODClase.Location = new Point(0, 87);
            BtnMODClase.Name = "BtnMODClase";
            BtnMODClase.Size = new Size(219, 36);
            BtnMODClase.TabIndex = 15;
            BtnMODClase.Text = "MODIFICACIÓN";
            BtnMODClase.UseVisualStyleBackColor = false;
            BtnMODClase.Click += BtnMODClase_Click;
            // 
            // BtnALTAClase
            // 
            BtnALTAClase.Anchor = AnchorStyles.None;
            BtnALTAClase.BackColor = Color.FromArgb(20, 20, 20);
            BtnALTAClase.FlatAppearance.BorderColor = Color.Gray;
            BtnALTAClase.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnALTAClase.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnALTAClase.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnALTAClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnALTAClase.Location = new Point(0, 3);
            BtnALTAClase.Name = "BtnALTAClase";
            BtnALTAClase.Size = new Size(219, 36);
            BtnALTAClase.TabIndex = 13;
            BtnALTAClase.Text = "ALTA";
            BtnALTAClase.UseVisualStyleBackColor = false;
            BtnALTAClase.Click += BtnALTAClase_Click;
            // 
            // BtnBAJAClase
            // 
            BtnBAJAClase.Anchor = AnchorStyles.None;
            BtnBAJAClase.BackColor = Color.FromArgb(20, 20, 20);
            BtnBAJAClase.FlatAppearance.BorderColor = Color.Gray;
            BtnBAJAClase.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnBAJAClase.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnBAJAClase.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnBAJAClase.ForeColor = Color.FromArgb(0, 205, 255);
            BtnBAJAClase.Location = new Point(0, 45);
            BtnBAJAClase.Name = "BtnBAJAClase";
            BtnBAJAClase.Size = new Size(219, 36);
            BtnBAJAClase.TabIndex = 14;
            BtnBAJAClase.Text = "BAJA";
            BtnBAJAClase.UseVisualStyleBackColor = false;
            BtnBAJAClase.Click += BtnBAJAClase_Click;
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
            BtnIndicador.Text = "INDICADOR";
            BtnIndicador.UseVisualStyleBackColor = false;
            BtnIndicador.Click += BtnIndicador_Click;
            // 
            // PnlIndicador
            // 
            PnlIndicador.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PnlIndicador.Controls.Add(BtnPago);
            PnlIndicador.Controls.Add(BtnIndicadorCliente);
            PnlIndicador.Controls.Add(BtnIndicadorProfesor);
            PnlIndicador.Controls.Add(BtnIndicadorReserva);
            PnlIndicador.Location = new Point(12, 458);
            PnlIndicador.Name = "PnlIndicador";
            PnlIndicador.Size = new Size(219, 215);
            PnlIndicador.TabIndex = 16;
            PnlIndicador.Visible = false;
            // 
            // BtnPago
            // 
            BtnPago.Anchor = AnchorStyles.None;
            BtnPago.BackColor = Color.FromArgb(20, 20, 20);
            BtnPago.FlatAppearance.BorderColor = Color.Gray;
            BtnPago.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnPago.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnPago.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnPago.ForeColor = Color.FromArgb(0, 205, 255);
            BtnPago.Location = new Point(0, 129);
            BtnPago.Name = "BtnPago";
            BtnPago.Size = new Size(219, 36);
            BtnPago.TabIndex = 16;
            BtnPago.Text = "PAGO";
            BtnPago.UseVisualStyleBackColor = false;
            BtnPago.Click += BtnPago_Click;
            // 
            // BtnIndicadorReserva
            // 
            BtnIndicadorReserva.Anchor = AnchorStyles.None;
            BtnIndicadorReserva.BackColor = Color.FromArgb(20, 20, 20);
            BtnIndicadorReserva.FlatAppearance.BorderColor = Color.Gray;
            BtnIndicadorReserva.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnIndicadorReserva.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnIndicadorReserva.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIndicadorReserva.ForeColor = Color.FromArgb(0, 205, 255);
            BtnIndicadorReserva.Location = new Point(0, 87);
            BtnIndicadorReserva.Name = "BtnIndicadorReserva";
            BtnIndicadorReserva.Size = new Size(219, 36);
            BtnIndicadorReserva.TabIndex = 15;
            BtnIndicadorReserva.Text = "RESERVA";
            BtnIndicadorReserva.UseVisualStyleBackColor = false;
            BtnIndicadorReserva.Click += BtnIndicadorReserva_Click;
            // 
            // BtnIndicadorCliente
            // 
            BtnIndicadorCliente.Anchor = AnchorStyles.None;
            BtnIndicadorCliente.BackColor = Color.FromArgb(20, 20, 20);
            BtnIndicadorCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnIndicadorCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnIndicadorCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnIndicadorCliente.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIndicadorCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnIndicadorCliente.Location = new Point(0, 3);
            BtnIndicadorCliente.Name = "BtnIndicadorCliente";
            BtnIndicadorCliente.Size = new Size(219, 36);
            BtnIndicadorCliente.TabIndex = 13;
            BtnIndicadorCliente.Text = "CLIENTE";
            BtnIndicadorCliente.UseVisualStyleBackColor = false;
            BtnIndicadorCliente.Click += BtnIndicadorCliente_Click;
            // 
            // BtnIndicadorProfesor
            // 
            BtnIndicadorProfesor.Anchor = AnchorStyles.None;
            BtnIndicadorProfesor.BackColor = Color.FromArgb(20, 20, 20);
            BtnIndicadorProfesor.FlatAppearance.BorderColor = Color.Gray;
            BtnIndicadorProfesor.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnIndicadorProfesor.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnIndicadorProfesor.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIndicadorProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            BtnIndicadorProfesor.Location = new Point(0, 45);
            BtnIndicadorProfesor.Name = "BtnIndicadorProfesor";
            BtnIndicadorProfesor.Size = new Size(219, 36);
            BtnIndicadorProfesor.TabIndex = 14;
            BtnIndicadorProfesor.Text = "PROFESOR";
            BtnIndicadorProfesor.UseVisualStyleBackColor = false;
            BtnIndicadorProfesor.Click += BtnIndicadorProfesor_Click;
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
            BtnReserva.Click += BtnReserva_Click;
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
            PnlContenedorInicio.Dock = DockStyle.Fill;
            PnlContenedorInicio.Location = new Point(250, 30);
            PnlContenedorInicio.Name = "PnlContenedorInicio";
            PnlContenedorInicio.Size = new Size(1116, 738);
            PnlContenedorInicio.TabIndex = 2;
            PnlContenedorInicio.Paint += PnlContenedorInicio_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(20, 20, 20);
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 205, 255);
            button1.Location = new Point(244, 369);
            button1.Name = "button1";
            button1.Size = new Size(201, 66);
            button1.TabIndex = 14;
            button1.Text = "PROFESOR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnIndicadorProfesor_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(20, 20, 20);
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 205, 255);
            button2.Location = new Point(244, 297);
            button2.Name = "button2";
            button2.Size = new Size(201, 66);
            button2.TabIndex = 13;
            button2.Text = "CLIENTE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnIndicadorCliente_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(20, 20, 20);
            button3.FlatAppearance.BorderColor = Color.Gray;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            button3.FlatAppearance.MouseOverBackColor = Color.Gray;
            button3.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 205, 255);
            button3.Location = new Point(244, 441);
            button3.Name = "button3";
            button3.Size = new Size(201, 66);
            button3.TabIndex = 15;
            button3.Text = "RESERVA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BtnIndicadorReserva_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(20, 20, 20);
            button4.FlatAppearance.BorderColor = Color.Gray;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            button4.FlatAppearance.MouseOverBackColor = Color.Gray;
            button4.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 205, 255);
            button4.Location = new Point(244, 513);
            button4.Name = "button4";
            button4.Size = new Size(201, 66);
            button4.TabIndex = 16;
            button4.Text = "PAGO";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BtnPago_Click;
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
            PnlCliente.ResumeLayout(false);
            PnlProfesor.ResumeLayout(false);
            PnlReserva.ResumeLayout(false);
            PnlClase.ResumeLayout(false);
            PnlIndicador.ResumeLayout(false);
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
        private Button BtnIndicadorReserva;
        private Button BtnIndicadorCliente;
        private Button BtnIndicadorProfesor;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}