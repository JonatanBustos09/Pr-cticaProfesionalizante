namespace __Front___Sistema_GYM_Genie.Frms_Cliente
{
    partial class FrmHijaMODCliente
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
            PnlMODCliente = new Panel();
            BtnMODCliente = new Button();
            panel1 = new Panel();
            DgvMODCliente = new DataGridView();
            personaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            alturaDireccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personaBindingSource = new BindingSource(components);
            TxtBuscarDNI = new TextBox();
            LblBuscarDNI = new Label();
            label1 = new Label();
            PnlMODCliente.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMODCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PnlMODCliente
            // 
            PnlMODCliente.BackColor = Color.FromArgb(20, 20, 20);
            PnlMODCliente.Controls.Add(BtnMODCliente);
            PnlMODCliente.Controls.Add(panel1);
            PnlMODCliente.Controls.Add(TxtBuscarDNI);
            PnlMODCliente.Controls.Add(LblBuscarDNI);
            PnlMODCliente.Controls.Add(label1);
            PnlMODCliente.Dock = DockStyle.Fill;
            PnlMODCliente.Location = new Point(0, 0);
            PnlMODCliente.Name = "PnlMODCliente";
            PnlMODCliente.Size = new Size(1116, 738);
            PnlMODCliente.TabIndex = 0;
            // 
            // BtnMODCliente
            // 
            BtnMODCliente.Anchor = AnchorStyles.None;
            BtnMODCliente.BackColor = Color.FromArgb(64, 64, 64);
            BtnMODCliente.FlatAppearance.BorderColor = Color.Gray;
            BtnMODCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(7, 29, 49);
            BtnMODCliente.FlatAppearance.MouseOverBackColor = Color.Gray;
            BtnMODCliente.Font = new Font("Impact", 16F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMODCliente.ForeColor = Color.FromArgb(0, 205, 255);
            BtnMODCliente.Location = new Point(371, 135);
            BtnMODCliente.Name = "BtnMODCliente";
            BtnMODCliente.Size = new Size(120, 32);
            BtnMODCliente.TabIndex = 14;
            BtnMODCliente.Text = "MODIFICAR";
            BtnMODCliente.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvMODCliente);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 526);
            panel1.TabIndex = 13;
            // 
            // DgvMODCliente
            // 
            DgvMODCliente.AllowUserToAddRows = false;
            DgvMODCliente.AllowUserToDeleteRows = false;
            DgvMODCliente.AutoGenerateColumns = false;
            DgvMODCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMODCliente.Columns.AddRange(new DataGridViewColumn[] { personaIdDataGridViewTextBoxColumn, dNIPersonaDataGridViewTextBoxColumn, nombrePersonaDataGridViewTextBoxColumn, apellidoPersonaDataGridViewTextBoxColumn, telefonoPersonaDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, correoElectronicoDataGridViewTextBoxColumn, nombreUsuarioDataGridViewTextBoxColumn, contraseniaDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, alturaDireccionDataGridViewTextBoxColumn });
            DgvMODCliente.DataSource = personaBindingSource;
            DgvMODCliente.Dock = DockStyle.Fill;
            DgvMODCliente.Location = new Point(0, 0);
            DgvMODCliente.Name = "DgvMODCliente";
            DgvMODCliente.RowTemplate.Height = 25;
            DgvMODCliente.Size = new Size(1116, 526);
            DgvMODCliente.TabIndex = 0;
            // 
            // personaIdDataGridViewTextBoxColumn
            // 
            personaIdDataGridViewTextBoxColumn.DataPropertyName = "PersonaId";
            personaIdDataGridViewTextBoxColumn.HeaderText = "Id";
            personaIdDataGridViewTextBoxColumn.Name = "personaIdDataGridViewTextBoxColumn";
            // 
            // dNIPersonaDataGridViewTextBoxColumn
            // 
            dNIPersonaDataGridViewTextBoxColumn.DataPropertyName = "DNI_Persona";
            dNIPersonaDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIPersonaDataGridViewTextBoxColumn.Name = "dNIPersonaDataGridViewTextBoxColumn";
            // 
            // nombrePersonaDataGridViewTextBoxColumn
            // 
            nombrePersonaDataGridViewTextBoxColumn.DataPropertyName = "NombrePersona";
            nombrePersonaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombrePersonaDataGridViewTextBoxColumn.Name = "nombrePersonaDataGridViewTextBoxColumn";
            // 
            // apellidoPersonaDataGridViewTextBoxColumn
            // 
            apellidoPersonaDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPersona";
            apellidoPersonaDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoPersonaDataGridViewTextBoxColumn.Name = "apellidoPersonaDataGridViewTextBoxColumn";
            // 
            // telefonoPersonaDataGridViewTextBoxColumn
            // 
            telefonoPersonaDataGridViewTextBoxColumn.DataPropertyName = "TelefonoPersona";
            telefonoPersonaDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            telefonoPersonaDataGridViewTextBoxColumn.Name = "telefonoPersonaDataGridViewTextBoxColumn";
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de Nacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo Electronico";
            correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            // 
            // contraseniaDataGridViewTextBoxColumn
            // 
            contraseniaDataGridViewTextBoxColumn.DataPropertyName = "Contrasenia";
            contraseniaDataGridViewTextBoxColumn.HeaderText = "Contrasenia";
            contraseniaDataGridViewTextBoxColumn.Name = "contraseniaDataGridViewTextBoxColumn";
            contraseniaDataGridViewTextBoxColumn.Visible = false;
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
            direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // alturaDireccionDataGridViewTextBoxColumn
            // 
            alturaDireccionDataGridViewTextBoxColumn.DataPropertyName = "AlturaDireccion";
            alturaDireccionDataGridViewTextBoxColumn.HeaderText = "Altura";
            alturaDireccionDataGridViewTextBoxColumn.Name = "alturaDireccionDataGridViewTextBoxColumn";
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Sistema_GYM_Genie.Clases.Persona);
            // 
            // TxtBuscarDNI
            // 
            TxtBuscarDNI.Anchor = AnchorStyles.None;
            TxtBuscarDNI.Cursor = Cursors.IBeam;
            TxtBuscarDNI.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtBuscarDNI.Location = new Point(171, 141);
            TxtBuscarDNI.Name = "TxtBuscarDNI";
            TxtBuscarDNI.Size = new Size(164, 21);
            TxtBuscarDNI.TabIndex = 12;
            // 
            // LblBuscarDNI
            // 
            LblBuscarDNI.Anchor = AnchorStyles.None;
            LblBuscarDNI.BackColor = Color.White;
            LblBuscarDNI.BorderStyle = BorderStyle.Fixed3D;
            LblBuscarDNI.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblBuscarDNI.Location = new Point(46, 141);
            LblBuscarDNI.Name = "LblBuscarDNI";
            LblBuscarDNI.Size = new Size(97, 21);
            LblBuscarDNI.TabIndex = 11;
            LblBuscarDNI.Text = "BUSCAR DNI: ";
            LblBuscarDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 205, 255);
            label1.Location = new Point(371, 30);
            label1.Name = "label1";
            label1.Size = new Size(378, 66);
            label1.TabIndex = 9;
            label1.Text = "MODIFICAR CLIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmHijaMODCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(PnlMODCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHijaMODCliente";
            Text = "FrmHijaMODCliente";
            PnlMODCliente.ResumeLayout(false);
            PnlMODCliente.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMODCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMODCliente;
        private Label label1;
        private TextBox TxtBuscarDNI;
        private Label LblBuscarDNI;
        private Panel panel1;
        private DataGridView DgvMODCliente;
        private BindingSource personaBindingSource;
        private Button BtnMODCliente;
        private DataGridViewTextBoxColumn personaIdDataGridViewTextBoxColumn;
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
        private DataGridViewTextBoxColumn alturaDireccionDataGridViewTextBoxColumn;
    }
}