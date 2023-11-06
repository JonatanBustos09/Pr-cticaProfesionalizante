namespace __Front___Sistema_GYM_Genie.Frrm_Clases
{
    partial class FrmHijaABMClases
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
            claseBindingSource2 = new BindingSource(components);
            panel1 = new Panel();
            claseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreClaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            equipamientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costoClaseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profesorDNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource2).BeginInit();
            panel1.SuspendLayout();
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
            button1.Location = new Point(677, 209);
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
            BtnEliminar.Location = new Point(677, 247);
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
            BtnCancelar.Location = new Point(677, 286);
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
            BtnAgregar.Location = new Point(677, 169);
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
            TxtEquip.Location = new Point(312, 222);
            TxtEquip.Name = "TxtEquip";
            TxtEquip.Size = new Size(199, 20);
            TxtEquip.TabIndex = 58;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(58, 221);
            label2.Name = "label2";
            label2.Size = new Size(212, 21);
            label2.TabIndex = 57;
            label2.Text = "EQUIPAMIENTO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtCosto
            // 
            TxtCosto.Anchor = AnchorStyles.Left;
            TxtCosto.Cursor = Cursors.IBeam;
            TxtCosto.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtCosto.Location = new Point(312, 302);
            TxtCosto.Name = "TxtCosto";
            TxtCosto.Size = new Size(199, 20);
            TxtCosto.TabIndex = 56;
            // 
            // LblApellido
            // 
            LblApellido.Anchor = AnchorStyles.Left;
            LblApellido.BackColor = Color.White;
            LblApellido.BorderStyle = BorderStyle.Fixed3D;
            LblApellido.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblApellido.Location = new Point(59, 301);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(212, 21);
            LblApellido.TabIndex = 55;
            LblApellido.Text = "COSTO";
            LblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.FromArgb(20, 20, 20);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 205, 255);
            label1.Location = new Point(56, 43);
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
            LblDNI.Location = new Point(58, 177);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(212, 21);
            LblDNI.TabIndex = 51;
            LblDNI.Text = "NOMBRE DE LA CLASE";
            LblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtNombreC
            // 
            TxtNombreC.Anchor = AnchorStyles.Left;
            TxtNombreC.Cursor = Cursors.IBeam;
            TxtNombreC.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombreC.Location = new Point(312, 177);
            TxtNombreC.Name = "TxtNombreC";
            TxtNombreC.Size = new Size(199, 20);
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
            comboBoxPROFE.Location = new Point(312, 262);
            comboBoxPROFE.Name = "comboBoxPROFE";
            comboBoxPROFE.Size = new Size(301, 23);
            comboBoxPROFE.TabIndex = 77;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 262);
            label3.Name = "label3";
            label3.Size = new Size(212, 21);
            label3.TabIndex = 78;
            label3.Text = "PROFESOR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { claseIdDataGridViewTextBoxColumn, nombreClaseDataGridViewTextBoxColumn, equipamientoDataGridViewTextBoxColumn, costoClaseDataGridViewTextBoxColumn, profesorDNIDataGridViewTextBoxColumn });
            dataGridView1.DataSource = claseBindingSource2;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 465);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1112, 269);
            dataGridView1.TabIndex = 79;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // claseBindingSource2
            // 
            claseBindingSource2.DataSource = typeof(Sistema_GYM_Genie.Clases.Clase);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BtnCancelar);
            panel1.Controls.Add(comboBoxPROFE);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(TxtEquip);
            panel1.Controls.Add(LblDNI);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtNombreC);
            panel1.Controls.Add(TxtCosto);
            panel1.Controls.Add(LblApellido);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 738);
            panel1.TabIndex = 80;
            // 
            // claseIdDataGridViewTextBoxColumn
            // 
            claseIdDataGridViewTextBoxColumn.DataPropertyName = "ClaseId";
            claseIdDataGridViewTextBoxColumn.HeaderText = "Id";
            claseIdDataGridViewTextBoxColumn.Name = "claseIdDataGridViewTextBoxColumn";
            // 
            // nombreClaseDataGridViewTextBoxColumn
            // 
            nombreClaseDataGridViewTextBoxColumn.DataPropertyName = "NombreClase";
            nombreClaseDataGridViewTextBoxColumn.HeaderText = "Nombre de Clase";
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
            costoClaseDataGridViewTextBoxColumn.HeaderText = "Costo de Clase";
            costoClaseDataGridViewTextBoxColumn.Name = "costoClaseDataGridViewTextBoxColumn";
            // 
            // profesorDNIDataGridViewTextBoxColumn
            // 
            profesorDNIDataGridViewTextBoxColumn.DataPropertyName = "ProfesorDNI";
            profesorDNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            profesorDNIDataGridViewTextBoxColumn.Name = "profesorDNIDataGridViewTextBoxColumn";
            // 
            // FrmHijaABMClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(BtnIngresar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHijaABMClases";
            Text = "ABM_clases";
            Load += ABM_clases_Load;
            ((System.ComponentModel.ISupportInitialize)claseBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseBindingSource2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn tipoClaseDataGridViewTextBoxColumn;
        private BindingSource claseBindingSource2;
        private Panel panel1;
        private DataGridViewTextBoxColumn claseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreClaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn equipamientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costoClaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorDNIDataGridViewTextBoxColumn;
    }
}