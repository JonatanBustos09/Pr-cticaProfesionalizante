namespace __Front___Sistema_GYM_Genie.Inscripcion
{
    partial class FrmHijaInscrip
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
            btnAgregarInscripcion = new Button();
            comboBoxCla = new ComboBox();
            comboBoxCli = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            LblNombre = new Label();
            LblDNI = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregarInscripcion
            // 
            btnAgregarInscripcion.BackColor = Color.FromArgb(64, 64, 64);
            btnAgregarInscripcion.Font = new Font("Impact", 14F, FontStyle.Italic, GraphicsUnit.Point);
            btnAgregarInscripcion.ForeColor = Color.FromArgb(0, 205, 255);
            btnAgregarInscripcion.Location = new Point(197, 326);
            btnAgregarInscripcion.Name = "btnAgregarInscripcion";
            btnAgregarInscripcion.Size = new Size(201, 35);
            btnAgregarInscripcion.TabIndex = 5;
            btnAgregarInscripcion.Text = "AGREGAR INSCRIPCIÓN";
            btnAgregarInscripcion.UseVisualStyleBackColor = false;
            btnAgregarInscripcion.Click += btnAgregarInscripcion_Click;
            // 
            // comboBoxCla
            // 
            comboBoxCla.FormattingEnabled = true;
            comboBoxCla.Location = new Point(193, 247);
            comboBoxCla.Name = "comboBoxCla";
            comboBoxCla.Size = new Size(205, 23);
            comboBoxCla.TabIndex = 4;
            // 
            // comboBoxCli
            // 
            comboBoxCli.FormattingEnabled = true;
            comboBoxCli.Location = new Point(193, 191);
            comboBoxCli.Name = "comboBoxCli";
            comboBoxCli.Size = new Size(205, 23);
            comboBoxCli.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(LblNombre);
            panel1.Controls.Add(LblDNI);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxCla);
            panel1.Controls.Add(btnAgregarInscripcion);
            panel1.Controls.Add(comboBoxCli);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 738);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.BackColor = Color.FromArgb(20, 20, 20);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Impact", 34F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 205, 255);
            label4.Location = new Point(43, 26);
            label4.Name = "label4";
            label4.Size = new Size(316, 66);
            label4.TabIndex = 51;
            label4.Text = "INSCRIPCIONES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            LblNombre.Anchor = AnchorStyles.Left;
            LblNombre.BackColor = Color.White;
            LblNombre.BorderStyle = BorderStyle.Fixed3D;
            LblNombre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblNombre.Location = new Point(43, 247);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(126, 21);
            LblNombre.TabIndex = 53;
            LblNombre.Text = "ELEGIR CLIENTE: ";
            LblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblDNI
            // 
            LblDNI.Anchor = AnchorStyles.Left;
            LblDNI.BackColor = Color.White;
            LblDNI.BorderStyle = BorderStyle.Fixed3D;
            LblDNI.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDNI.Location = new Point(43, 191);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(126, 21);
            LblDNI.TabIndex = 52;
            LblDNI.Text = "ELEGIR CLASE: ";
            LblDNI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmHijaInscrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHijaInscrip";
            Text = "FormInscrip";
            Load += FormInscrip_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarInscripcion;
        private ComboBox comboBoxCla;
        private ComboBox comboBoxCli;
        private Panel panel1;
        private Label label4;
        private Label LblNombre;
        private Label LblDNI;
    }
}