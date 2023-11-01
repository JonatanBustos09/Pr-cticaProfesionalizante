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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DtpFecha.Value;

            principal.AgregarCliente(TxtDNI.Text, TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, fecha, TxtCorreo.Text, TxtCiudad.Text, TxtDireccion.Text, int.Parse(TxtAltura.Text), TxtPeso.Text, TxtAltura.Text,);
            MessageBox.Show($"La Persona {TxtNombre.Text} {TxtApellido.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
