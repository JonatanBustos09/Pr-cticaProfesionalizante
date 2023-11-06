namespace __Front___Sistema_GYM_Genie.Frrm_Clases
{
    partial class ABM_clases
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
            BtnIngresar = new Button();
            claseBindingSource1 = new BindingSource(components);
            claseBindingSource = new BindingSource(components);
            button1 = new Button();
            BtnEliminar = new Button();
            BtnCancelar = new Button();
            BtnAgregar = new Button();
            TxtEquip = new TextBox();
            label2 = new Label();
            TxtCosto = new TextBox();
            LblApellido = new Label();
            label1 = new Label();
            LblDNI = new Label();
            TxtNombreC = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBoxPROFE = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            claseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoClaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreClaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            equipamientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costoClaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profesorDNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claseBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)claseBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // BtnIngresar
            // 
            BtnIngresar.Cursor = Cursors.AppStarting;
            BtnIngresar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnIngresar.ForeColor = Color.FromArgb(7, 29, 49);
            BtnIngresar.Location = new Point(1155, 424);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(113, 29);
            BtnIngresar.TabIndex = 76;
            BtnIngresar.Text = "VOLVER";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // claseBindingSource1
            // 
            claseBindingSource1.DataSource = typeof(Sistema_GYM_Genie.Clases.Clase);
            // 
            // claseBindingSource
            // 
            claseBindingSource.DataSource = typeof(Sistema_GYM_Genie.Clases.Clase);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.AppStarting;
            button1.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 205, 255);
            button1.Location = new Point(988, 182);
            button1.Name = "button1";
            button1.Size = new Size(113, 33);
            button1.TabIndex = 74;
            button1.Text = "MODIFICAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Left;
            BtnEliminar.BackColor = Color.FromArgb(64, 64, 64);
            BtnEliminar.Cursor = Cursors.AppStarting;
            BtnEliminar.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            BtnEliminar.ForeColor = Color.FromArgb(0, 205, 255);
            BtnEliminar.Location = new Point(988, 220);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(113, 33);
            BtnEliminar.TabIndex = 69;
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
            BtnCancelar.Location = new Point(988, 259);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(113, 33);
            BtnCancelar.TabIndex = 68;
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
            BtnAgregar.Location = new Point(988, 142);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(113, 33);
            BtnAgregar.TabIndex = 67;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // TxtEquip
            // 
            TxtEquip.Anchor = AnchorStyles.Left;
            TxtEquip.Cursor = Cursors.IBeam;
            TxtEquip.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtEquip.Location = new Point(553, 192);
            TxtEquip.Name = "TxtEquip";
            TxtEquip.Size = new Size(164, 20);
            TxtEquip.TabIndex = 58;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(264, 191);
            label2.Name = "label2";
            label2.Size = new Size(266, 21);
            label2.TabIndex = 57;
            label2.Text = "EQUIPAMIENTO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCosto
            // 
            TxtCosto.Anchor = AnchorStyles.Left;
            TxtCosto.Cursor = Cursors.IBeam;
            TxtCosto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCosto.Location = new Point(553, 272);
            TxtCosto.Name = "TxtCosto";
            TxtCosto.Size = new Size(164, 20);
            TxtCosto.TabIndex = 56;
            // 
            // LblApellido
            // 
            LblApellido.Anchor = AnchorStyles.Left;
            LblApellido.BackColor = Color.White;
            LblApellido.BorderStyle = BorderStyle.Fixed3D;
            LblApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblApellido.Location = new Point(265, 271);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(266, 21);
            LblApellido.TabIndex = 55;
            LblApellido.Text = "COSTO";
            LblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 205, 255);
            label1.Location = new Point(265, 43);
            label1.Name = "label1";
            label1.Size = new Size(281, 66);
            label1.TabIndex = 50;
            label1.Text = "CLASES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDNI
            // 
            LblDNI.Anchor = AnchorStyles.Left;
            LblDNI.BackColor = Color.White;
            LblDNI.BorderStyle = BorderStyle.Fixed3D;
            LblDNI.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDNI.Location = new Point(264, 147);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(266, 21);
            LblDNI.TabIndex = 51;
            LblDNI.Text = "NOMBRE DE LA CLASE";
            LblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtNombreC
            // 
            TxtNombreC.Anchor = AnchorStyles.Left;
            TxtNombreC.Cursor = Cursors.IBeam;
            TxtNombreC.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombreC.Location = new Point(553, 147);
            TxtNombreC.Name = "TxtNombreC";
            TxtNombreC.Size = new Size(164, 20);
            TxtNombreC.TabIndex = 52;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // comboBoxPROFE
            // 
            comboBoxPROFE.FormattingEnabled = true;
            comboBoxPROFE.Location = new Point(553, 230);
            comboBoxPROFE.Name = "comboBoxPROFE";
            comboBoxPROFE.Size = new Size(266, 23);
            comboBoxPROFE.TabIndex = 77;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(265, 232);
            label3.Name = "label3";
            label3.Size = new Size(266, 21);
            label3.TabIndex = 78;
            label3.Text = "PROFESOR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { claseIdDataGridViewTextBoxColumn, tipoClaseDataGridViewTextBoxColumn, nombreClaseDataGridViewTextBoxColumn, equipamientoDataGridViewTextBoxColumn, costoClaseDataGridViewTextBoxColumn, profesorDNIDataGridViewTextBoxColumn });
            dataGridView1.DataSource = claseBindingSource2;
            dataGridView1.Location = new Point(255, 517);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(749, 150);
            dataGridView1.TabIndex = 79;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // claseIdDataGridViewTextBoxColumn
            // 
            claseIdDataGridViewTextBoxColumn.DataPropertyName = "ClaseId";
            claseIdDataGridViewTextBoxColumn.HeaderText = "ClaseId";
            claseIdDataGridViewTextBoxColumn.Name = "claseIdDataGridViewTextBoxColumn";
            // 
            // tipoClaseDataGridViewTextBoxColumn
            // 
            tipoClaseDataGridViewTextBoxColumn.DataPropertyName = "TipoClase";
            tipoClaseDataGridViewTextBoxColumn.HeaderText = "TipoClase";
            tipoClaseDataGridViewTextBoxColumn.Name = "tipoClaseDataGridViewTextBoxColumn";
            // 
            // nombreClaseDataGridViewTextBoxColumn
            // 
            nombreClaseDataGridViewTextBoxColumn.DataPropertyName = "NombreClase";
            nombreClaseDataGridViewTextBoxColumn.HeaderText = "NombreClase";
            nombreClaseDataGridViewTextBoxColumn.Name = "nombreClaseDataGridViewTextBoxColumn";
            // 
            // equipamientoDataGridViewTextBoxColumn
            // 
            equipamientoDataGridViewTextBoxColumn.DataPropertyName = "Equipamiento";
            equipamientoDataGridViewTextBoxColumn.HeaderText = "Equipamiento";
            equipamientoDataGridViewTextBoxColumn.Name = "equipamientoDataGridViewTextBoxColumn";
            // 
            // costoClaseDataGridViewTextBoxColumn
            // 
            costoClaseDataGridViewTextBoxColumn.DataPropertyName = "CostoClase";
            costoClaseDataGridViewTextBoxColumn.HeaderText = "CostoClase";
            costoClaseDataGridViewTextBoxColumn.Name = "costoClaseDataGridViewTextBoxColumn";
            // 
            // profesorDNIDataGridViewTextBoxColumn
            // 
            profesorDNIDataGridViewTextBoxColumn.DataPropertyName = "ProfesorDNI";
            profesorDNIDataGridViewTextBoxColumn.HeaderText = "ProfesorDNI";
            profesorDNIDataGridViewTextBoxColumn.Name = "profesorDNIDataGridViewTextBoxColumn";
            // 
            // claseBindingSource2
            // 
            claseBindingSource2.DataSource = typeof(Sistema_GYM_Genie.Clases.Clase);
            // 
            // ABM_clases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 778);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(comboBoxPROFE);
            Controls.Add(BtnIngresar);
            Controls.Add(button1);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregar);
            Controls.Add(TxtEquip);
            Controls.Add(label2);
            Controls.Add(TxtCosto);
            Controls.Add(LblApellido);
            Controls.Add(TxtNombreC);
            Controls.Add(LblDNI);
            Controls.Add(label1);
            Name = "ABM_clases";
            Text = "ABM_clases";
            Load += ABM_clases_Load;
            ((System.ComponentModel.ISupportInitialize)claseBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnIngresar;
        private Button button1;
        private Button BtnEliminar;
        private Button BtnCancelar;
        private Button BtnAgregar;
        private TextBox TxtEquip;
        private Label label2;
        private TextBox TxtCosto;
        private Label LblApellido;
        private Label label1;
        private Label LblDNI;
        private TextBox TxtNombreC;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBoxPROFE;
        private Label label3;
        private DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private BindingSource claseBindingSource;
        private BindingSource claseBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn claseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoClaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn equipamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costoClaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorDNIDataGridViewTextBoxColumn;
        private BindingSource claseBindingSource2;
    }
}