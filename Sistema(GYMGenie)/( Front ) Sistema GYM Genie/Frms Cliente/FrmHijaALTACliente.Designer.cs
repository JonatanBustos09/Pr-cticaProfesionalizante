namespace __Front___Sistema_GYM_Genie.ABM_Cliente
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
            PnlContenedorALTA = new Panel();
            personaBindingSource = new BindingSource(components);
            button1 = new Button();
            PnlContenedorALTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PnlContenedorALTA
            // 
            PnlContenedorALTA.BackColor = Color.FromArgb(20, 20, 20);
            PnlContenedorALTA.Controls.Add(button1);
            PnlContenedorALTA.ForeColor = Color.FromArgb(20, 20, 20);
            PnlContenedorALTA.Location = new Point(1, 1);
            PnlContenedorALTA.Name = "PnlContenedorALTA";
            PnlContenedorALTA.Size = new Size(1103, 738);
            PnlContenedorALTA.TabIndex = 0;
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Sistema_GYM_Genie.Clases.Persona);
            // 
            // button1
            // 
            button1.Location = new Point(839, 105);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmHijaALTACliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 738);
            Controls.Add(PnlContenedorALTA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHijaALTACliente";
            Text = "FrmHijaALTACliente";
            PnlContenedorALTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlContenedorALTA;
        private BindingSource personaBindingSource;
        private Button button1;
    }
}