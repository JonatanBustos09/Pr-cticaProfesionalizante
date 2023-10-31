using Sistema_GYM_Genie.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __Front___Sistema_GYM_Genie.Frms_Cliente
{
    public partial class FrmHijaALTACliente : Form
    {
        public FrmHijaALTACliente()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void PreVisible_Click(object sender, EventArgs e)
        {
            TxtContrasena.UseSystemPasswordChar = false;
            PreVisible.Visible = false;
            PreNoVisible.Visible = true;
        }

        private void PreNoVisible_Click(object sender, EventArgs e)
        {
            TxtContrasena.UseSystemPasswordChar = true;
            PreVisible.Visible = true;
            PreNoVisible.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DtpFecha.Value;

            principal.AltaPersona(int.Parse(TxtDNI.Text), TxtNombre.Text,TxtApellido.Text, int.Parse(TxtTelefono.Text),fecha,TxtCorreo.Text, TxtUsuario.Text, TxtContrasena.Text, TxtCiudad.Text, TxtDireccion.Text, int.Parse(TxtAltura.Text), checkBoxProfesor.Checked);
            MessageBox.Show($"La Persona {TxtNombre.Text} {TxtApellido.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
