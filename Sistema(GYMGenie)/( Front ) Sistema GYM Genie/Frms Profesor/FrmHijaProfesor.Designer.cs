namespace __Front___Sistema_GYM_Genie
{
    partial class FrmHijaProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHijaProfesor));
            LblTituloProfesor = new Label();
            panel1 = new Panel();
            TxtContra = new TextBox();
            label6 = new Label();
            TxtUsuario = new TextBox();
            label5 = new Label();
            BtnIngresar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aliasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sueldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIPersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombrePersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoPersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoPersonaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoElectronicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contraseniaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ciudadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profesorBindingSource = new BindingSource(components);
            button1 = new Button();
            TxtAliasp = new TextBox();
            TxtTitulop = new TextBox();
            LblPeso = new Label();
            BtnEliminar = new Button();
            BtnCancelar = new Button();
            BtnAgregar = new Button();
            DtpFechap = new DateTimePicker();
            TxtDireccionp = new TextBox();
            label8 = new Label();
            TxtCiudadp = new TextBox();
            label7 = new Label();
            TxtCorreop = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtTelefonop = new TextBox();
            label2 = new Label();
            TxtApellidop = new TextBox();
            LblApellido = new Label();
            TxtNombrep = new TextBox();
            LblNombre = new Label();
            TxtDNIp = new TextBox();
            LblDNI = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // LblTituloProfesor
            // 
            LblTituloProfesor.Anchor = AnchorStyles.Top;
            LblTituloProfesor.BorderStyle = BorderStyle.Fixed3D;
            LblTituloProfesor.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            LblTituloProfesor.ForeColor = Color.FromArgb(0, 205, 255);
            LblTituloProfesor.Location = new Point(54, 29);
            LblTituloProfesor.Name = "LblTituloProfesor";
            LblTituloProfesor.Size = new Size(223, 66);
            LblTituloProfesor.TabIndex = 12;
            LblTituloProfesor.Text = "PROFESOR";
            LblTituloProfesor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(TxtContra);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TxtUsuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(BtnIngresar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TxtAliasp);
            panel1.Controls.Add(TxtTitulop);
            panel1.Controls.Add(LblPeso);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(DtpFechap);
            panel1.Controls.Add(TxtDireccionp);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(TxtCiudadp);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(TxtCorreop);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtTelefonop);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtApellidop);
            panel1.Controls.Add(LblApellido);
            panel1.Controls.Add(TxtNombrep);
            panel1.Controls.Add(LblNombre);
            panel1.Controls.Add(TxtDNIp);
            panel1.Controls.Add(LblDNI);
            panel1.Controls.Add(LblTituloProfesor);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 738);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // TxtContra
            // 
            TxtContra.Anchor = AnchorStyles.Left;
            TxtContra.Cursor = Cursors.IBeam;
            TxtContra.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtContra.Location = new Point(540, 370);
            TxtContra.Name = "TxtContra";
            TxtContra.Size = new Size(164, 20);
            TxtContra.TabIndex = 80;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(415, 370);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 79;
            label6.Text = "Contraseña: ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Anchor = AnchorStyles.Left;
            TxtUsuario.Cursor = Cursors.IBeam;
            TxtUsuario.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtUsuario.Location = new Point(540, 326);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(164, 20);
            TxtUsuario.TabIndex = 78;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(415, 326);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 77;
            label5.Text = "Usuario: ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Cursor = Cursors.AppStarting;
            BtnIngresar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIngresar.ForeColor = Color.FromArgb(7, 29, 49);
            BtnIngresar.Location = new Point(856, 569);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(113, 29);
            BtnIngresar.TabIndex = 76;
            BtnIngresar.Text = "VOLVER";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(415, 284);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 75;
            label1.Text = "Alias: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tituloDataGridViewTextBoxColumn, aliasDataGridViewTextBoxColumn, sueldoDataGridViewTextBoxColumn, dNIPersonaDataGridViewTextBoxColumn, nombrePersonaDataGridViewTextBoxColumn, apellidoPersonaDataGridViewTextBoxColumn, telefonoPersonaDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, correoElectronicoDataGridViewTextBoxColumn, nombreUsuarioDataGridViewTextBoxColumn, contraseniaDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = profesorBindingSource;
            dataGridView1.Location = new Point(10, 630);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1111, 219);
            dataGridView1.TabIndex = 74;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            aliasDataGridViewTextBoxColumn.DataPropertyName = "Alias";
            aliasDataGridViewTextBoxColumn.HeaderText = "Alias";
            aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            // 
            // sueldoDataGridViewTextBoxColumn
            // 
            sueldoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo";
            sueldoDataGridViewTextBoxColumn.HeaderText = "Sueldo";
            sueldoDataGridViewTextBoxColumn.Name = "sueldoDataGridViewTextBoxColumn";
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
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "NombreUsuario";
            nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            // 
            // contraseniaDataGridViewTextBoxColumn
            // 
            contraseniaDataGridViewTextBoxColumn.DataPropertyName = "Contrasenia";
            contraseniaDataGridViewTextBoxColumn.HeaderText = "Contrasenia";
            contraseniaDataGridViewTextBoxColumn.Name = "contraseniaDataGridViewTextBoxColumn";
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
            // profesorBindingSource
            // 
            profesorBindingSource.DataSource = typeof(Sistema_GYM_Genie.Clases.Profesor);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.AppStarting;
            button1.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 205, 255);
            button1.Location = new Point(777, 160);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 73;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TxtAliasp
            // 
            TxtAliasp.Anchor = AnchorStyles.Left;
            TxtAliasp.Cursor = Cursors.IBeam;
            TxtAliasp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtAliasp.Location = new Point(540, 285);
            TxtAliasp.Name = "TxtAliasp";
            TxtAliasp.Size = new Size(164, 20);
            TxtAliasp.TabIndex = 72;
            // 
            // TxtTitulop
            // 
            TxtTitulop.Anchor = AnchorStyles.Left;
            TxtTitulop.Cursor = Cursors.IBeam;
            TxtTitulop.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtTitulop.Location = new Point(540, 243);
            TxtTitulop.Name = "TxtTitulop";
            TxtTitulop.Size = new Size(164, 20);
            TxtTitulop.TabIndex = 70;
            // 
            // LblPeso
            // 
            LblPeso.Anchor = AnchorStyles.Left;
            LblPeso.BackColor = Color.White;
            LblPeso.BorderStyle = BorderStyle.Fixed3D;
            LblPeso.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblPeso.Location = new Point(415, 241);
            LblPeso.Name = "LblPeso";
            LblPeso.Size = new Size(102, 21);
            LblPeso.TabIndex = 69;
            LblPeso.Text = "TITULO: ";
            LblPeso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Left;
            BtnEliminar.BackColor = Color.FromArgb(64, 64, 64);
            BtnEliminar.Cursor = Cursors.AppStarting;
            BtnEliminar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnEliminar.ForeColor = Color.FromArgb(0, 205, 255);
            BtnEliminar.Location = new Point(777, 198);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(113, 33);
            BtnEliminar.TabIndex = 68;
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
            BtnCancelar.Location = new Point(777, 237);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(113, 33);
            BtnCancelar.TabIndex = 67;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Left;
            BtnAgregar.BackColor = Color.FromArgb(64, 64, 64);
            BtnAgregar.Cursor = Cursors.AppStarting;
            BtnAgregar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnAgregar.ForeColor = Color.FromArgb(0, 205, 255);
            BtnAgregar.Location = new Point(777, 120);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(113, 33);
            BtnAgregar.TabIndex = 66;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // DtpFechap
            // 
            DtpFechap.Anchor = AnchorStyles.Left;
            DtpFechap.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            DtpFechap.Format = DateTimePickerFormat.Short;
            DtpFechap.Location = new Point(226, 285);
            DtpFechap.Name = "DtpFechap";
            DtpFechap.Size = new Size(118, 20);
            DtpFechap.TabIndex = 65;
            DtpFechap.Value = new DateTime(2023, 10, 30, 0, 0, 0, 0);
            // 
            // TxtDireccionp
            // 
            TxtDireccionp.Anchor = AnchorStyles.Left;
            TxtDireccionp.Cursor = Cursors.IBeam;
            TxtDireccionp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDireccionp.Location = new Point(540, 204);
            TxtDireccionp.Name = "TxtDireccionp";
            TxtDireccionp.Size = new Size(164, 20);
            TxtDireccionp.TabIndex = 64;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(415, 203);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 63;
            label8.Text = "DIRECCIÓN: ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCiudadp
            // 
            TxtCiudadp.Anchor = AnchorStyles.Left;
            TxtCiudadp.Cursor = Cursors.IBeam;
            TxtCiudadp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCiudadp.Location = new Point(540, 162);
            TxtCiudadp.Name = "TxtCiudadp";
            TxtCiudadp.Size = new Size(164, 20);
            TxtCiudadp.TabIndex = 62;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(415, 160);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 61;
            label7.Text = "CIUDAD: ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCorreop
            // 
            TxtCorreop.Anchor = AnchorStyles.Left;
            TxtCorreop.Cursor = Cursors.IBeam;
            TxtCorreop.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCorreop.Location = new Point(540, 120);
            TxtCorreop.Name = "TxtCorreop";
            TxtCorreop.Size = new Size(164, 20);
            TxtCorreop.TabIndex = 60;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(415, 120);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 59;
            label4.Text = "CORREO: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 286);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 58;
            label3.Text = "FECHA NACIMIENTO: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtTelefonop
            // 
            TxtTelefonop.Anchor = AnchorStyles.Left;
            TxtTelefonop.Cursor = Cursors.IBeam;
            TxtTelefonop.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtTelefonop.Location = new Point(179, 243);
            TxtTelefonop.Name = "TxtTelefonop";
            TxtTelefonop.Size = new Size(164, 20);
            TxtTelefonop.TabIndex = 57;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 241);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 56;
            label2.Text = "TELÉFONO: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtApellidop
            // 
            TxtApellidop.Anchor = AnchorStyles.Left;
            TxtApellidop.Cursor = Cursors.IBeam;
            TxtApellidop.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtApellidop.Location = new Point(179, 200);
            TxtApellidop.Name = "TxtApellidop";
            TxtApellidop.Size = new Size(164, 20);
            TxtApellidop.TabIndex = 55;
            // 
            // LblApellido
            // 
            LblApellido.Anchor = AnchorStyles.Left;
            LblApellido.BackColor = Color.White;
            LblApellido.BorderStyle = BorderStyle.Fixed3D;
            LblApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblApellido.Location = new Point(54, 200);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(102, 21);
            LblApellido.TabIndex = 54;
            LblApellido.Text = "APELLIDO: ";
            LblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtNombrep
            // 
            TxtNombrep.Anchor = AnchorStyles.Left;
            TxtNombrep.Cursor = Cursors.IBeam;
            TxtNombrep.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombrep.Location = new Point(179, 160);
            TxtNombrep.Name = "TxtNombrep";
            TxtNombrep.Size = new Size(164, 20);
            TxtNombrep.TabIndex = 53;
            // 
            // LblNombre
            // 
            LblNombre.Anchor = AnchorStyles.Left;
            LblNombre.BackColor = Color.White;
            LblNombre.BorderStyle = BorderStyle.Fixed3D;
            LblNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblNombre.Location = new Point(54, 160);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(102, 21);
            LblNombre.TabIndex = 52;
            LblNombre.Text = "NOMBRE: ";
            LblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtDNIp
            // 
            TxtDNIp.Anchor = AnchorStyles.Left;
            TxtDNIp.Cursor = Cursors.IBeam;
            TxtDNIp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDNIp.Location = new Point(179, 120);
            TxtDNIp.Name = "TxtDNIp";
            TxtDNIp.Size = new Size(164, 20);
            TxtDNIp.TabIndex = 51;
            TxtDNIp.TextChanged += TxtDNIp_Leave;
            // 
            // LblDNI
            // 
            LblDNI.Anchor = AnchorStyles.Left;
            LblDNI.BackColor = Color.White;
            LblDNI.BorderStyle = BorderStyle.Fixed3D;
            LblDNI.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDNI.Location = new Point(54, 120);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(102, 21);
            LblDNI.TabIndex = 50;
            LblDNI.Text = "DNI: ";
            LblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmHijaProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1116, 738);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHijaProfesor";
            Text = "FrmHijaProfesor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profesorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LblTituloProfesor;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cBUDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sueldoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombrePersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoPersonaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseniaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private BindingSource profesorBindingSource;
        private Button button1;
        private TextBox TxtAliasp;
        private TextBox TxtTitulop;
        private Label LblPeso;
        private Button BtnEliminar;
        private Button BtnCancelar;
        private Button BtnAgregar;
        private DateTimePicker DtpFechap;
        private TextBox TxtDireccionp;
        private Label label8;
        private TextBox TxtCiudadp;
        private Label label7;
        private TextBox TxtCorreop;
        private Label label4;
        private Label label3;
        private TextBox TxtTelefonop;
        private Label label2;
        private TextBox TxtApellidop;
        private Label LblApellido;
        private TextBox TxtNombrep;
        private Label LblNombre;
        private TextBox TxtDNIp;
        private Label LblDNI;
        private Label label1;
        private Button BtnIngresar;
        private TextBox TxtContra;
        private Label label6;
        private TextBox TxtUsuario;
        private Label label5;
    }
}