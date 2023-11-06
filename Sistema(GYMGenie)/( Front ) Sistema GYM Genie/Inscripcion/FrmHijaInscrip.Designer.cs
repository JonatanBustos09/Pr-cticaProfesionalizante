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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAgregarInscripcion
            // 
            btnAgregarInscripcion.Location = new Point(86, 185);
            btnAgregarInscripcion.Name = "btnAgregarInscripcion";
            btnAgregarInscripcion.Size = new Size(186, 23);
            btnAgregarInscripcion.TabIndex = 5;
            btnAgregarInscripcion.Text = "Agregar Inscripcion";
            btnAgregarInscripcion.UseVisualStyleBackColor = true;
            btnAgregarInscripcion.Click += btnAgregarInscripcion_Click;
            // 
            // comboBoxCla
            // 
            comboBoxCla.FormattingEnabled = true;
            comboBoxCla.Location = new Point(86, 126);
            comboBoxCla.Name = "comboBoxCla";
            comboBoxCla.Size = new Size(121, 23);
            comboBoxCla.TabIndex = 4;
            // 
            // comboBoxCli
            // 
            comboBoxCli.FormattingEnabled = true;
            comboBoxCli.Location = new Point(86, 72);
            comboBoxCli.Name = "comboBoxCli";
            comboBoxCli.Size = new Size(121, 23);
            comboBoxCli.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 75);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Elegir Clase";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 124);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 7;
            label2.Text = "Elegir Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(631, 366);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 21);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 9;
            label3.Text = "INSCRIPCIONES";
            // 
            // FormInscrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregarInscripcion);
            Controls.Add(comboBoxCla);
            Controls.Add(comboBoxCli);
            Name = "FormInscrip";
            Text = "FormInscrip";
            Load += FormInscrip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarInscripcion;
        private ComboBox comboBoxCla;
        private ComboBox comboBoxCli;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}