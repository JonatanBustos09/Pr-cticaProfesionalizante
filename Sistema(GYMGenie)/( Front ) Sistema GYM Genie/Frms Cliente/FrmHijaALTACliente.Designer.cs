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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHijaALTACliente));
            PnlALTACliente = new Panel();
            BtnIngresar = new Button();
            dataGridView1 = new DataGridView();
            pesoClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alturaCmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIPersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombrePersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoPersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoPersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoElectronicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ciudadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource2 = new BindingSource(components);
            button1 = new Button();
            TxtAltura = new TextBox();
            LblAltura = new Label();
            TxtPeso = new TextBox();
            LblPeso = new Label();
            BtnEliminar = new Button();
            BtnCancelar = new Button();
            BtnAgregar = new Button();
            DtpFecha = new DateTimePicker();
            TxtDireccion = new TextBox();
            label8 = new Label();
            TxtCiudad = new TextBox();
            label7 = new Label();
            TxtCorreo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtTelefono = new TextBox();
            label2 = new Label();
            TxtApellido = new TextBox();
            LblApellido = new Label();
            TxtNombre = new TextBox();
            LblNombre = new Label();
            TxtDNI = new TextBox();
            LblDNI = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            clienteBindingSource = new BindingSource(components);
            clienteBindingSource1 = new BindingSource(components);
            button2 = new Button();
            PnlALTACliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // PnlALTACliente
            // 
            PnlALTACliente.BackColor = Color.FromArgb(20, 20, 20);
            PnlALTACliente.BorderStyle = BorderStyle.Fixed3D;
            PnlALTACliente.Controls.Add(button2);
            PnlALTACliente.Controls.Add(BtnIngresar);
            PnlALTACliente.Controls.Add(dataGridView1);
            PnlALTACliente.Controls.Add(button1);
            PnlALTACliente.Controls.Add(TxtAltura);
            PnlALTACliente.Controls.Add(LblAltura);
            PnlALTACliente.Controls.Add(TxtPeso);
            PnlALTACliente.Controls.Add(LblPeso);
            PnlALTACliente.Controls.Add(BtnEliminar);
            PnlALTACliente.Controls.Add(BtnCancelar);
            PnlALTACliente.Controls.Add(BtnAgregar);
            PnlALTACliente.Controls.Add(DtpFecha);
            PnlALTACliente.Controls.Add(TxtDireccion);
            PnlALTACliente.Controls.Add(label8);
            PnlALTACliente.Controls.Add(TxtCiudad);
            PnlALTACliente.Controls.Add(label7);
            PnlALTACliente.Controls.Add(TxtCorreo);
            PnlALTACliente.Controls.Add(label4);
            PnlALTACliente.Controls.Add(label3);
            PnlALTACliente.Controls.Add(TxtTelefono);
            PnlALTACliente.Controls.Add(label2);
            PnlALTACliente.Controls.Add(TxtApellido);
            PnlALTACliente.Controls.Add(LblApellido);
            PnlALTACliente.Controls.Add(TxtNombre);
            PnlALTACliente.Controls.Add(LblNombre);
            PnlALTACliente.Controls.Add(TxtDNI);
            PnlALTACliente.Controls.Add(LblDNI);
            PnlALTACliente.Controls.Add(label1);
            PnlALTACliente.Controls.Add(pictureBox3);
            PnlALTACliente.Controls.Add(pictureBox1);
            PnlALTACliente.Controls.Add(pictureBox2);
            PnlALTACliente.Dock = DockStyle.Fill;
            PnlALTACliente.Location = new Point(0, 0);
            PnlALTACliente.Name = "PnlALTACliente";
            PnlALTACliente.Size = new Size(1116, 738);
            PnlALTACliente.TabIndex = 9;
            PnlALTACliente.Paint += PnlALTACliente_Paint;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Cursor = Cursors.AppStarting;
            BtnIngresar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIngresar.ForeColor = Color.FromArgb(7, 29, 49);
            BtnIngresar.Location = new Point(941, 420);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(113, 29);
            BtnIngresar.TabIndex = 49;
            BtnIngresar.Text = "VOLVER";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { pesoClienteDataGridViewTextBoxColumn, alturaCmDataGridViewTextBoxColumn, dNIPersonaDataGridViewTextBoxColumn, nombrePersonaDataGridViewTextBoxColumn, apellidoPersonaDataGridViewTextBoxColumn, telefonoPersonaDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, correoElectronicoDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource2;
            dataGridView1.Location = new Point(-2, 513);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1111, 218);
            dataGridView1.TabIndex = 48;
            // 
            // pesoClienteDataGridViewTextBoxColumn
            // 
            pesoClienteDataGridViewTextBoxColumn.DataPropertyName = "PesoCliente";
            pesoClienteDataGridViewTextBoxColumn.HeaderText = "PesoCliente";
            pesoClienteDataGridViewTextBoxColumn.Name = "pesoClienteDataGridViewTextBoxColumn";
            // 
            // alturaCmDataGridViewTextBoxColumn
            // 
            alturaCmDataGridViewTextBoxColumn.DataPropertyName = "AlturaCm";
            alturaCmDataGridViewTextBoxColumn.HeaderText = "AlturaCm";
            alturaCmDataGridViewTextBoxColumn.Name = "alturaCmDataGridViewTextBoxColumn";
            // 
            // dNIPersonaDataGridViewTextBoxColumn
            // 
            dNIPersonaDataGridViewTextBoxColumn.DataPropertyName = "DNI_Persona";
            dNIPersonaDataGridViewTextBoxColumn.HeaderText = "DNI_Persona";
            dNIPersonaDataGridViewTextBoxColumn.Name = "dNIPersonaDataGridViewTextBoxColumn";
            // 
            // nombrePersonaDataGridViewTextBoxColumn
            // 
            nombrePersonaDataGridViewTextBoxColumn.DataPropertyName = "NombrePersona";
            nombrePersonaDataGridViewTextBoxColumn.HeaderText = "NombrePersona";
            nombrePersonaDataGridViewTextBoxColumn.Name = "nombrePersonaDataGridViewTextBoxColumn";
            // 
            // apellidoPersonaDataGridViewTextBoxColumn
            // 
            apellidoPersonaDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPersona";
            apellidoPersonaDataGridViewTextBoxColumn.HeaderText = "ApellidoPersona";
            apellidoPersonaDataGridViewTextBoxColumn.Name = "apellidoPersonaDataGridViewTextBoxColumn";
            // 
            // telefonoPersonaDataGridViewTextBoxColumn
            // 
            telefonoPersonaDataGridViewTextBoxColumn.DataPropertyName = "TelefonoPersona";
            telefonoPersonaDataGridViewTextBoxColumn.HeaderText = "TelefonoPersona";
            telefonoPersonaDataGridViewTextBoxColumn.Name = "telefonoPersonaDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            correoElectronicoDataGridViewTextBoxColumn.HeaderText = "CorreoElectronico";
            correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource2
            // 
            clienteBindingSource2.DataSource = typeof(Sistema_GYM_Genie.Clases.Cliente);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.AppStarting;
            button1.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 205, 255);
            button1.Location = new Point(774, 178);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 47;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TxtAltura
            // 
            TxtAltura.Anchor = AnchorStyles.Left;
            TxtAltura.Cursor = Cursors.IBeam;
            TxtAltura.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAltura.Location = new Point(537, 304);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(164, 20);
            TxtAltura.TabIndex = 46;
            // 
            // LblAltura
            // 
            LblAltura.Anchor = AnchorStyles.Left;
            LblAltura.BackColor = Color.White;
            LblAltura.BorderStyle = BorderStyle.Fixed3D;
            LblAltura.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblAltura.Location = new Point(412, 304);
            LblAltura.Name = "LblAltura";
            LblAltura.Size = new Size(102, 21);
            LblAltura.TabIndex = 45;
            LblAltura.Text = "ALTURA: ";
            LblAltura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPeso
            // 
            TxtPeso.Anchor = AnchorStyles.Left;
            TxtPeso.Cursor = Cursors.IBeam;
            TxtPeso.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPeso.Location = new Point(537, 261);
            TxtPeso.Name = "TxtPeso";
            TxtPeso.Size = new Size(164, 20);
            TxtPeso.TabIndex = 44;
            // 
            // LblPeso
            // 
            LblPeso.Anchor = AnchorStyles.Left;
            LblPeso.BackColor = Color.White;
            LblPeso.BorderStyle = BorderStyle.Fixed3D;
            LblPeso.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPeso.Location = new Point(412, 260);
            LblPeso.Name = "LblPeso";
            LblPeso.Size = new Size(102, 21);
            LblPeso.TabIndex = 43;
            LblPeso.Text = "PESO: ";
            LblPeso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Left;
            BtnEliminar.BackColor = Color.FromArgb(64, 64, 64);
            BtnEliminar.Cursor = Cursors.AppStarting;
            BtnEliminar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnEliminar.ForeColor = Color.FromArgb(0, 205, 255);
            BtnEliminar.Location = new Point(774, 216);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(113, 33);
            BtnEliminar.TabIndex = 42;
            BtnEliminar.Text = "ELIMINAR";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Left;
            BtnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            BtnCancelar.Cursor = Cursors.AppStarting;
            BtnCancelar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.FromArgb(0, 205, 255);
            BtnCancelar.Location = new Point(774, 255);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(113, 33);
            BtnCancelar.TabIndex = 38;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Left;
            BtnAgregar.BackColor = Color.FromArgb(64, 64, 64);
            BtnAgregar.Cursor = Cursors.AppStarting;
            BtnAgregar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnAgregar.ForeColor = Color.FromArgb(0, 205, 255);
            BtnAgregar.Location = new Point(774, 138);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(113, 33);
            BtnAgregar.TabIndex = 37;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // DtpFecha
            // 
            DtpFecha.Anchor = AnchorStyles.Left;
            DtpFecha.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFecha.Format = DateTimePickerFormat.Short;
            DtpFecha.Location = new Point(207, 304);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(133, 20);
            DtpFecha.TabIndex = 35;
            DtpFecha.Value = new DateTime(2023, 10, 30, 0, 0, 0, 0);
            DtpFecha.ValueChanged += DtpFecha_ValueChanged;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Anchor = AnchorStyles.Left;
            TxtDireccion.Cursor = Cursors.IBeam;
            TxtDireccion.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDireccion.Location = new Point(537, 218);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(164, 20);
            TxtDireccion.TabIndex = 28;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(412, 217);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 27;
            label8.Text = "DIRECCIÓN: ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCiudad
            // 
            TxtCiudad.Anchor = AnchorStyles.Left;
            TxtCiudad.Cursor = Cursors.IBeam;
            TxtCiudad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCiudad.Location = new Point(537, 178);
            TxtCiudad.Name = "TxtCiudad";
            TxtCiudad.Size = new Size(164, 20);
            TxtCiudad.TabIndex = 26;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(412, 177);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 25;
            label7.Text = "CIUDAD: ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Anchor = AnchorStyles.Left;
            TxtCorreo.Cursor = Cursors.IBeam;
            TxtCorreo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCorreo.Location = new Point(537, 138);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(164, 20);
            TxtCorreo.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(412, 138);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 19;
            label4.Text = "CORREO: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 303);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 17;
            label3.Text = "FECHA NACIMIENTO: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Anchor = AnchorStyles.Left;
            TxtTelefono.Cursor = Cursors.IBeam;
            TxtTelefono.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtTelefono.Location = new Point(176, 261);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(164, 20);
            TxtTelefono.TabIndex = 16;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 259);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 15;
            label2.Text = "TELÉFONO: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtApellido
            // 
            TxtApellido.Anchor = AnchorStyles.Left;
            TxtApellido.Cursor = Cursors.IBeam;
            TxtApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtApellido.Location = new Point(176, 218);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(164, 20);
            TxtApellido.TabIndex = 14;
            // 
            // LblApellido
            // 
            LblApellido.Anchor = AnchorStyles.Left;
            LblApellido.BackColor = Color.White;
            LblApellido.BorderStyle = BorderStyle.Fixed3D;
            LblApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblApellido.Location = new Point(51, 218);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(102, 21);
            LblApellido.TabIndex = 13;
            LblApellido.Text = "APELLIDO: ";
            LblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtNombre
            // 
            TxtNombre.Anchor = AnchorStyles.Left;
            TxtNombre.Cursor = Cursors.IBeam;
            TxtNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombre.Location = new Point(176, 178);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(164, 20);
            TxtNombre.TabIndex = 12;
            // 
            // LblNombre
            // 
            LblNombre.Anchor = AnchorStyles.Left;
            LblNombre.BackColor = Color.White;
            LblNombre.BorderStyle = BorderStyle.Fixed3D;
            LblNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblNombre.Location = new Point(51, 178);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(102, 21);
            LblNombre.TabIndex = 11;
            LblNombre.Text = "NOMBRE: ";
            LblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDNI
            // 
            TxtDNI.Anchor = AnchorStyles.Left;
            TxtDNI.Cursor = Cursors.IBeam;
            TxtDNI.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDNI.Location = new Point(176, 138);
            TxtDNI.Name = "TxtDNI";
            TxtDNI.Size = new Size(164, 20);
            TxtDNI.TabIndex = 10;
            TxtDNI.TextChanged += validateNumber;
            TxtDNI.Leave += TxtDNI_Leave;
            // 
            // LblDNI
            // 
            LblDNI.Anchor = AnchorStyles.Left;
            LblDNI.BackColor = Color.White;
            LblDNI.BorderStyle = BorderStyle.Fixed3D;
            LblDNI.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDNI.Location = new Point(51, 138);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(102, 21);
            LblDNI.TabIndex = 9;
            LblDNI.Text = "DNI: ";
            LblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 205, 255);
            label1.Location = new Point(51, 39);
            label1.Name = "label1";
            label1.Size = new Size(281, 66);
            label1.TabIndex = 8;
            label1.Text = "CLIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1771, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(167, 1467);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.Gimnasio4;
            pictureBox1.Location = new Point(1771, 506);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 1467);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1695, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 1467);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Sistema_GYM_Genie.Clases.Cliente);
            // 
            // clienteBindingSource1
            // 
            clienteBindingSource1.DataSource = typeof(Sistema_GYM_Genie.Clases.Cliente);
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 205, 255);
            button2.Location = new Point(924, 138);
            button2.Name = "button2";
            button2.Size = new Size(113, 33);
            button2.TabIndex = 50;
            button2.Text = "RESUMEN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            PnlALTACliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlALTACliente;
        private TextBox TxtApellido;
        private Label LblApellido;
        private TextBox TxtNombre;
        private Label LblNombre;
        private TextBox TxtDNI;
        private Label LblDNI;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox TxtDireccion;
        private Label label8;
        private TextBox TxtCiudad;
        private Label label7;
        private TextBox TxtCorreo;
        private Label label4;
        private Label label3;
        private TextBox TxtTelefono;
        private Label label2;
        private DateTimePicker DtpFecha;
        private Button BtnAgregar;
        private Button BtnCancelar;
        private Button BtnEliminar;
        private Button button1;
        private TextBox TxtAltura;
        private Label LblAltura;
        private TextBox TxtPeso;
        private Label LblPeso;
        private DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
        private DataGridView dataGridView1;
        private BindingSource clienteBindingSource2;
        private BindingSource clienteBindingSource1;
        private DataGridViewTextBoxColumn pesoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alturaCmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombrePersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private Button BtnIngresar;
        private Button button2;
    }
}