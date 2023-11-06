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

namespace __Front___Sistema_GYM_Genie.Inscripcion
{
    public partial class FormInscrip : Form
    {
        Principal principal = new Principal();

        public FormInscrip()
        {
            InitializeComponent();
        }


        private void FormInscrip_Load(object sender, EventArgs e)
        {
            List<Clase> ListaClases = principal.ListarClases();
            List<Cliente> listaClientes = principal.ListarClientes();

            comboBoxCla.DataSource = ListaClases;
            comboBoxCla.DisplayMember = "NombreClase";
            comboBoxCla.ValueMember = "ClaseId";

            comboBoxCli.DataSource = listaClientes;
            comboBoxCli.DisplayMember = "NombreCompleto";

        }

        private void btnAgregarInscripcion_Click(object sender, EventArgs e)
        {
            Clase claseId = (Clase)comboBoxCla.SelectedItem;
            Cliente dniCliente = (Cliente)comboBoxCli.SelectedItem;

            principal.AgregarInscripcion(claseId, dniCliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTableroInicio FrmTableroInicio = new FrmTableroInicio();
            FrmTableroInicio.Show();
            this.Hide();
        }
    }
}
