namespace __Front___Sistema_GYM_Genie.Frms_Cliente
{
    partial class FrmResumenCliente
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
            PnlResumencCliente = new Panel();
            DgvResumenCliente = new DataGridView();
            personaBindingSource = new BindingSource(components);
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
            PnlResumencCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvResumenCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PnlResumencCliente
            // 
            PnlResumencCliente.BackColor = Color.FromArgb(20, 20, 20);
            PnlResumencCliente.Controls.Add(DgvResumenCliente);
            PnlResumencCliente.Dock = DockStyle.Fill;
            PnlResumencCliente.Location = new Point(0, 0);
            PnlResumencCliente.Name = "PnlResumencCliente";
            PnlResumencCliente.Size = new Size(1116, 738);
            PnlResumencCliente.TabIndex = 0;
            // 
            // DgvResumenCliente
            // 
            DgvResumenCliente.AllowUserToAddRows = false;
            DgvResumenCliente.AllowUserToDeleteRows = false;
            DgvResumenCliente.AutoGenerateColumns = false;
            DgvResumenCliente.BackgroundColor = Color.FromArgb(20, 20, 20);
            DgvResumenCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvResumenCliente.Columns.AddRange(new DataGridViewColumn[] { personaIdDataGridViewTextBoxColumn, dNIPersonaDataGridViewTextBoxColumn, nombrePersonaDataGridViewTextBoxColumn, apellidoPersonaDataGridViewTextBoxColumn, telefonoPersonaDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, correoElectronicoDataGridViewTextBoxColumn, nombreUsuarioDataGridViewTextBoxColumn, contraseniaDataGridViewTextBoxColumn, ciudadDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, alturaDireccionDataGridViewTextBoxColumn });
            DgvResumenCliente.DataSource = personaBindingSource;
            DgvResumenCliente.Dock = DockStyle.Fill;
            DgvResumenCliente.GridColor = Color.FromArgb(20, 20, 20);
            DgvResumenCliente.Location = new Point(0, 0);
            DgvResumenCliente.Name = "DgvResumenCliente";
            DgvResumenCliente.ReadOnly = true;
            DgvResumenCliente.RowTemplate.Height = 25;
            DgvResumenCliente.Size = new Size(1116, 738);
            DgvResumenCliente.TabIndex = 0;
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Sistema_GYM_Genie.Clases.Persona);
            // 
            // personaIdDataGridViewTextBoxColumn
            // 
            personaIdDataGridViewTextBoxColumn.DataPropertyName = "PersonaId";
            personaIdDataGridViewTextBoxColumn.HeaderText = "ID";
            personaIdDataGridViewTextBoxColumn.Name = "personaIdDataGridViewTextBoxColumn";
            personaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNIPersonaDataGridViewTextBoxColumn
            // 
            dNIPersonaDataGridViewTextBoxColumn.DataPropertyName = "DNI_Persona";
            dNIPersonaDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIPersonaDataGridViewTextBoxColumn.Name = "dNIPersonaDataGridViewTextBoxColumn";
            dNIPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePersonaDataGridViewTextBoxColumn
            // 
            nombrePersonaDataGridViewTextBoxColumn.DataPropertyName = "NombrePersona";
            nombrePersonaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombrePersonaDataGridViewTextBoxColumn.Name = "nombrePersonaDataGridViewTextBoxColumn";
            nombrePersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoPersonaDataGridViewTextBoxColumn
            // 
            apellidoPersonaDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPersona";
            apellidoPersonaDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoPersonaDataGridViewTextBoxColumn.Name = "apellidoPersonaDataGridViewTextBoxColumn";
            apellidoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoPersonaDataGridViewTextBoxColumn
            // 
            telefonoPersonaDataGridViewTextBoxColumn.DataPropertyName = "TelefonoPersona";
            telefonoPersonaDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            telefonoPersonaDataGridViewTextBoxColumn.Name = "telefonoPersonaDataGridViewTextBoxColumn";
            telefonoPersonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo Electronico";
            correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseniaDataGridViewTextBoxColumn
            // 
            contraseniaDataGridViewTextBoxColumn.DataPropertyName = "Contrasenia";
            contraseniaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            contraseniaDataGridViewTextBoxColumn.Name = "contraseniaDataGridViewTextBoxColumn";
            contraseniaDataGridViewTextBoxColumn.ReadOnly = true;
            contraseniaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alturaDireccionDataGridViewTextBoxColumn
            // 
            alturaDireccionDataGridViewTextBoxColumn.DataPropertyName = "AlturaDireccion";
            alturaDireccionDataGridViewTextBoxColumn.HeaderText = "Altura";
            alturaDireccionDataGridViewTextBoxColumn.Name = "alturaDireccionDataGridViewTextBoxColumn";
            alturaDireccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmResumenCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(PnlResumencCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmResumenCliente";
            Text = "FrmResumenCliente";
            PnlResumencCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvResumenCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlResumencCliente;
        private DataGridView DgvResumenCliente;
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
        private BindingSource personaBindingSource;
    }
}