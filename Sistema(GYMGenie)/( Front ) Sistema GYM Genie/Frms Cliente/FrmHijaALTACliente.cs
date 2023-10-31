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
    }
}
