using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __Front___Sistema_GYM_Genie
{
    public partial class FrmTableroInicio : Form
    {
        public FrmTableroInicio()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AbrirFormHija(object formhija)
        {
            if (this.PnlContenedorInicio.Controls.Count > 0)
                this.PnlContenedorInicio.Controls.RemoveAt(0);
            Form? jb = formhija as Form;
            jb.TopLevel = false;
            jb.Dock = DockStyle.Fill;
            this.PnlContenedorInicio.Controls.Add(jb);
            this.PnlContenedorInicio.Tag = jb;
            jb.Show();
        }
        private void FrmTableroInicio_Load(object sender, EventArgs e)
        {
            BtnInicio_Click(null, e);
        }

        private void FrmTableroInicio_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnInicio_Click(object? sender, EventArgs e)
        {
            AbrirFormHija(new FrmHijaInicio());
            BtnProfesor.Visible = true;
            BtnReserva.Visible = true;
            BtnIndicador.Visible = true;
            BtnClase.Visible = true;
            BtnCliente.Visible = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Hide();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmHijaCliente());
            BtnProfesor.Visible = false;
            BtnReserva.Visible = false;
            BtnIndicador.Visible = false;
            BtnClase.Visible = false;
        }

        private void BtnProfesor_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmHijaProfesor());
            BtnCliente.Visible = false;
            BtnReserva.Visible = false;
            BtnIndicador.Visible = false;
            BtnClase.Visible = false;
        }
    }
}
