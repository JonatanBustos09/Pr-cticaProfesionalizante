using Microsoft.EntityFrameworkCore;
using Sistema_GYM_Genie.Clases;
using Sistema_GYM_Genie.DBConection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Cliente cliente = new Cliente();
            cliente.DNI_Persona = int.Parse(TxtDNI.Text);
            cliente.NombrePersona = TxtNombre.Text;
            cliente.ApellidoPersona = TxtApellido.Text;
            cliente.TelefonoPersona = TxtTelefono.Text;
            cliente.FechaNacimiento = DateTime.Parse(DtpFecha.Text);
            cliente.CorreoElectronico = TxtCorreo.Text;
            cliente.Ciudad = TxtCiudad.Text;
            cliente.Direccion = TxtDireccion.Text;
            cliente.PesoCliente = float.Parse(TxtPeso.Text);
            cliente.AlturaCm = int.Parse(TxtAltura.Text);

            principal.AgregarCliente(cliente);
            MessageBox.Show($"La Persona {TxtNombre.Text} {TxtApellido.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BindingSource aBind = new BindingSource();
            aBind.DataSource = cliente;
            dataGridView1.DataSource = aBind;

            LimpiarCampos();
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PnlALTACliente_Paint(object sender, PaintEventArgs e)
        {
            using (var context = new Appdbcontext())
            {
                List<Cliente> listaClientes = context.Clientes.ToList();
                dataGridView1.DataSource = listaClientes;
            }
        }

        private void TxtDNI_Leave(object sender, System.EventArgs e)

        {
            int DNI_Cliente;
            try
            {
                DNI_Cliente = int.Parse(TxtDNI.Text);
            }
            catch (FormatException ex) { return; }

            var clienteEncontrado = principal.BuscarCliente(DNI_Cliente);

            if (clienteEncontrado == null)
            {
                return;
            }

            BindingSource aBind = new BindingSource();
            aBind.DataSource = clienteEncontrado;
            dataGridView1.DataSource = aBind;

            TxtNombre.Text = clienteEncontrado.NombrePersona;
            TxtApellido.Text = clienteEncontrado.ApellidoPersona;
            TxtTelefono.Text = clienteEncontrado.TelefonoPersona;
            DtpFecha.Text = clienteEncontrado.FechaNacimiento.ToString();
            TxtCorreo.Text = clienteEncontrado.CorreoElectronico;
            TxtCiudad.Text = clienteEncontrado.Ciudad;
            TxtDireccion.Text = clienteEncontrado.Direccion;
            TxtPeso.Text = clienteEncontrado.PesoCliente.ToString();
            TxtAltura.Text = clienteEncontrado.AlturaCm.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dniCliente = int.Parse(TxtDNI.Text);

            Cliente cliente = principal.BuscarCliente(dniCliente);

            if (cliente != null)
            {
                cliente.NombrePersona = TxtNombre.Text;
                cliente.ApellidoPersona = TxtApellido.Text;
                cliente.TelefonoPersona = TxtTelefono.Text;
                cliente.FechaNacimiento = DateTime.Parse(DtpFecha.Text);
                cliente.CorreoElectronico = TxtCorreo.Text;
                cliente.Ciudad = TxtCiudad.Text;
                cliente.Direccion = TxtDireccion.Text;
                cliente.PesoCliente = float.Parse(TxtPeso.Text);
                cliente.AlturaCm = int.Parse(TxtAltura.Text);

                principal.ModificarCliente(cliente);
                MessageBox.Show($"La Persona {TxtNombre.Text} {TxtApellido.Text} fue modificada con éxito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource aBind = new BindingSource();
            aBind.DataSource = cliente;
            dataGridView1.DataSource = aBind;

            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            bool deleted = principal.EliminarCliente(int.Parse(TxtDNI.Text));

            if (deleted)
            {
                MessageBox.Show($"La Persona fue eliminada con éxito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"La Persona NO existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarCampos();
        }
        private void validateNumber(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtDNI.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo números.");
                TxtDNI.Text = TxtDNI.Text.Remove(TxtDNI.Text.Length - 1);
            }
        }
        private void LimpiarCampos()
        {
            TxtDNI.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtCiudad.Clear();
            TxtDireccion.Clear();
            TxtPeso.Clear();
            TxtAltura.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            FrmTableroInicio FrmTableroInicio = new FrmTableroInicio();
            FrmTableroInicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentCell.RowIndex;

            Cliente clienteRes = dataGridView1.Rows[indice].DataBoundItem as Cliente;

            MessageBox.Show(principal.GenerarResumen(clienteRes.DNI_Persona));

        }
    }
}
