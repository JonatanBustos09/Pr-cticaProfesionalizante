using __Front___Sistema_GYM_Genie.Frms_Cliente;
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
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Hide();
        }

        // BOTONES PRINCIPALES DE TABLERO

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            PnlCliente.Visible = true;
            PnlClase.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnProfesor_Click(object sender, EventArgs e)
        {
            PnlProfesor.Visible = true;
            PnlCliente.Visible = false;
            PnlClase.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnReserva_Click(object sender, EventArgs e)
        {
            PnlReserva.Visible = true;
            PnlCliente.Visible = false;
            PnlClase.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
        }

        private void BtnIndicador_Click(object sender, EventArgs e)
        {
            PnlIndicador.Visible = true;
            PnlCliente.Visible = false;
            PnlClase.Visible = false;
            PnlProfesor.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnClase_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = true;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }



        // BOTONES SECUNDARIOS DE TABLERO

        private void PnlContenedorInicio_Paint(object sender, PaintEventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        // BOTONES PARA ABRIR FORMULARIO ABM CLIENTE

        private void BtnMODCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmHijaMODCliente());
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnBAJACliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmHijaBAJACliente());
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnALTACliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmHijaALTACliente());
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        // BOTONES PARA ABRIR FORMULARIOS DE ABM PROFESOR

        private void BtnMODProfesor_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnBAJAProfesor_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnALTAProfesor_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        // BOTONES PARA ABRIR FORMULARIOS DE ABM RESERVA

        private void BtnMODReserva_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnBAJAReserva_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnALTAReserva_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }
        // BOTONES PARA ABRIR FORMULARIOS DE ABM CLASE

        private void BtnMODClase_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnBAJAClase_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnALTAClase_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        // BOTONES PARA ABRIR FORMULARIOS DE INDICADORES
        private void BtnPago_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnIndicadorCliente_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;

        }

        private void BtnIndicadorProfesor_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }

        private void BtnIndicadorReserva_Click(object sender, EventArgs e)
        {
            PnlClase.Visible = false;
            PnlCliente.Visible = false;
            PnlProfesor.Visible = false;
            PnlIndicador.Visible = false;
            PnlReserva.Visible = false;
        }
    }
}
