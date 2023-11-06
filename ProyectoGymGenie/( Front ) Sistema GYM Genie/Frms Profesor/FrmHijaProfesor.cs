using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_GYM_Genie.Clases;
using Sistema_GYM_Genie.DBConection;

namespace __Front___Sistema_GYM_Genie
{
    public partial class FrmHijaProfesor : Form
    {
        Principal principal = new Principal();
        public FrmHijaProfesor()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.DNI_Persona = int.Parse(TxtDNIp.Text);
            profesor.NombrePersona = TxtNombrep.Text;
            profesor.ApellidoPersona = TxtApellidop.Text;
            profesor.TelefonoPersona = TxtTelefonop.Text;
            profesor.FechaNacimiento = DateTime.Parse(DtpFechap.Text);
            profesor.CorreoElectronico = TxtCorreop.Text;
            profesor.Ciudad = TxtCiudadp.Text;
            profesor.Direccion = TxtDireccionp.Text;
            profesor.Titulo = TxtTitulop.Text;
            profesor.Alias = TxtAliasp.Text;
            profesor.NombreUsuario = TxtUsuario.Text;
            profesor.Contrasenia = TxtContra.Text;

            principal.AgregarProfesor(profesor);
            MessageBox.Show($"La Persona {TxtNombrep.Text} {TxtApellidop.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            BindingSource aBind = new BindingSource();
            aBind.DataSource = profesor;
            dataGridView1.DataSource = aBind;

            LimpiarCampos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (var context = new Appdbcontext())
            {
                List<Profesor> listaProfesor = context.Profesores.ToList();
                dataGridView1.DataSource = listaProfesor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dniProfesor = int.Parse(TxtDNIp.Text);

            Profesor profesor = principal.BuscarProfesor(dniProfesor);


            if (profesor != null)
            {
                profesor.NombrePersona = TxtNombrep.Text;
                profesor.ApellidoPersona = TxtApellidop.Text;
                profesor.TelefonoPersona = TxtTelefonop.Text;
                profesor.FechaNacimiento = DateTime.Parse(DtpFechap.Text);
                profesor.CorreoElectronico = TxtCorreop.Text;
                profesor.Ciudad = TxtCiudadp.Text;
                profesor.Direccion = TxtDireccionp.Text;
                profesor.Titulo = TxtTitulop.Text;
                profesor.Alias = TxtAliasp.Text;

                principal.ModificarProfesor(profesor);

                MessageBox.Show($"El Profesor {TxtNombrep.Text} {TxtApellidop.Text} fue modificado con éxito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró un profesor con ese DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource aBind = new BindingSource();
            aBind.DataSource = profesor;
            dataGridView1.DataSource = aBind;
            LimpiarCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            bool deleted = principal.EliminarProfesor(int.Parse(TxtDNIp.Text));


            if (deleted)
            {
                MessageBox.Show($"La Persona fue eliminada con éxito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show($"La Persona NO existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LimpiarCampos();
        }


        private void LimpiarCampos()
        {
            TxtDNIp.Clear();
            TxtNombrep.Clear();
            TxtApellidop.Clear();
            TxtTelefonop.Clear();
            TxtCorreop.Clear();
            TxtCiudadp.Clear();
            TxtDireccionp.Clear();
            TxtAliasp.Clear();
            TxtTitulop.Clear();
            TxtContra.Clear();
            TxtUsuario.Clear();


        }

        private void TxtDNIp_Leave(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtDNIp.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor ingresar solo números.");
                TxtDNIp.Text = TxtDNIp.Text.Remove(TxtDNIp.Text.Length - 1);
            }

            int DNI_Profesor;
            try
            {
                DNI_Profesor = int.Parse(TxtDNIp.Text);
            }
            catch (FormatException ex) { return; }


            var profesorEncontrado = principal.BuscarProfesor(DNI_Profesor);

            if (profesorEncontrado == null)
            {
                // LimpiarCampos();

                return;
            }

            BindingSource aBind = new BindingSource();
            aBind.DataSource = profesorEncontrado;
            dataGridView1.DataSource = aBind;

            TxtNombrep.Text = profesorEncontrado.NombrePersona;
            TxtApellidop.Text = profesorEncontrado.ApellidoPersona;
            TxtTelefonop.Text = profesorEncontrado.TelefonoPersona;
            DtpFechap.Text = profesorEncontrado.FechaNacimiento.ToString();
            TxtCorreop.Text = profesorEncontrado.CorreoElectronico;
            TxtCiudadp.Text = profesorEncontrado.Ciudad;
            TxtDireccionp.Text = profesorEncontrado.Direccion;
            TxtTitulop.Text = profesorEncontrado.Titulo;
            TxtAliasp.Text = profesorEncontrado.Alias;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            FrmTableroInicio FrmTableroInicio = new FrmTableroInicio();
            FrmTableroInicio.Show();
            this.Hide();
        }
    }
}
