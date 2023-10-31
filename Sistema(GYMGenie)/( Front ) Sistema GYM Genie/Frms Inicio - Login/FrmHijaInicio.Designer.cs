namespace __Front___Sistema_GYM_Genie
{
    partial class FrmHijaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHijaInicio));
            PreInicio = new PictureBox();
            HoraFecha = new System.Windows.Forms.Timer(components);
            LblHora = new Label();
            LblFecha = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PreInicio).BeginInit();
            SuspendLayout();
            // 
            // PreInicio
            // 
            PreInicio.Dock = DockStyle.Fill;
            PreInicio.Image = Properties.Resources.Gimnasio;
            PreInicio.Location = new Point(0, 0);
            PreInicio.Name = "PreInicio";
            PreInicio.Size = new Size(1116, 738);
            PreInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            PreInicio.TabIndex = 0;
            PreInicio.TabStop = false;
            // 
            // HoraFecha
            // 
            HoraFecha.Enabled = true;
            HoraFecha.Tick += HoraFecha_Tick;
            // 
            // LblHora
            // 
            LblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblHora.BackColor = Color.White;
            LblHora.BorderStyle = BorderStyle.Fixed3D;
            LblHora.Font = new Font("Impact", 54F, FontStyle.Italic, GraphicsUnit.Point);
            LblHora.ForeColor = Color.FromArgb(0, 205, 255);
            LblHora.Location = new Point(20, 559);
            LblHora.Name = "LblHora";
            LblHora.Size = new Size(304, 89);
            LblHora.TabIndex = 1;
            LblHora.Text = "Hora";
            // 
            // LblFecha
            // 
            LblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LblFecha.AutoSize = true;
            LblFecha.BorderStyle = BorderStyle.Fixed3D;
            LblFecha.Font = new Font("Impact", 24F, FontStyle.Italic, GraphicsUnit.Point);
            LblFecha.ForeColor = Color.FromArgb(0, 205, 255);
            LblFecha.Location = new Point(20, 663);
            LblFecha.Name = "LblFecha";
            LblFecha.Size = new Size(97, 41);
            LblFecha.TabIndex = 2;
            LblFecha.Text = "Fecha";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Impact", 68.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(23, 23, 23);
            label1.Location = new Point(197, 304);
            label1.Name = "label1";
            label1.Size = new Size(772, 114);
            label1.TabIndex = 3;
            label1.Text = "Sé tu mejor versión";
            // 
            // FrmHijaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(label1);
            Controls.Add(LblFecha);
            Controls.Add(LblHora);
            Controls.Add(PreInicio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHijaInicio";
            Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)PreInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PreInicio;
        private System.Windows.Forms.Timer HoraFecha;
        private Label LblHora;
        private Label LblFecha;
        private Label label1;
    }
}