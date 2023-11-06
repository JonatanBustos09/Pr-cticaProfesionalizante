using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Sistema_GYM_Genie.Clases;
using Sistema_GYM_Genie.DBConection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace __Front___Sistema_GYM_Genie.Frrm_Clases
{
    public partial class FrmHijaABMClases : Form
    {
        Principal principal = new Principal();

        public FrmHijaABMClases()
        {
            InitializeComponent();
        }

        private void ABM_clases_Load(object sender, EventArgs e)
        {
            List<Clase> ListaClases = principal.ListarClases();
            dataGridView1.DataSource = ListaClases;

            List<Profesor> nombresProfesores = principal.ListarProfesores();

            if (nombresProfesores.Count > 0)
            {
                comboBoxPROFE.DataSource = nombresProfesores;
                comboBoxPROFE.DisplayMember = "NombreCompleto";
                comboBoxPROFE.ValueMember = "DNI_Persona";
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxPROFE.SelectedItem != null)
            {
                int idProfesor = (int)comboBoxPROFE.SelectedValue;

                // Crear una nueva clase con los datos ingresados
                Clase clase = new Clase();
                clase.NombreClase = TxtNombreC.Text;
                clase.Equipamiento = TxtEquip.Text;
                Profesor prof = comboBoxPROFE.SelectedItem as Profesor;
                clase.ProfesorDNI = prof.DNI_Persona;
                clase.CostoClase = float.Parse(TxtCosto.Text);

                // Agregar la clase al contexo

                principal.AgregarClase(clase);

                //context.Clases.Add(clase);

                BindingSource aBind = new BindingSource();
                aBind.DataSource = principal.ListarClases();
                dataGridView1.DataSource = aBind;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un profesor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }


        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            FrmTableroInicio FrmTableroInicio = new FrmTableroInicio();
            FrmTableroInicio.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentCell.RowIndex;

            Clase claseMod = dataGridView1.Rows[indice].DataBoundItem as Clase;

            if (claseMod != null)
            {
                claseMod.NombreClase = TxtNombreC.Text;
                claseMod.Equipamiento = TxtEquip.Text;
                claseMod.CostoClase = float.Parse(TxtCosto.Text);
                claseMod.ProfesorDNI = (int)comboBoxPROFE.SelectedValue;

                principal.ModificarClase(claseMod);

                MessageBox.Show($"La clase fue modificada con éxito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindingSource aBind = new BindingSource();
                aBind.DataSource = principal.ListarClases();
                dataGridView1.DataSource = aBind;
            }

            else
            {
                MessageBox.Show("No se pudo modificar la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {

            TxtNombreC.Clear();
            TxtEquip.Clear();
            TxtCosto.Clear();


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentCell.RowIndex;

            Clase claseElim = dataGridView1.Rows[indice].DataBoundItem as Clase;

            if (claseElim != null)
            {
                principal.EliminarClase(claseElim);

                MessageBox.Show($"La clase fue eliminada con éxito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BindingSource aBind = new BindingSource();
                aBind.DataSource = principal.ListarClases();
                dataGridView1.DataSource = aBind;

            }
            else
            {
                MessageBox.Show("No se pudo eliminar la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
