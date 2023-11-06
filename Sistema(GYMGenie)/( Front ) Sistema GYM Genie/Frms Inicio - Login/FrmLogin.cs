using System.Runtime.InteropServices;
using Sistema_GYM_Genie.Clases;

namespace __Front___Sistema_GYM_Genie
{
    public partial class FrmLogin : Form
    {
        Principal principal = new Principal();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            // Obtenemos el usuario y la contraseña ingresados en los campos de texto
            string usuario = TxtUsuario.Text;
            string contraseña = TxtContrasena.Text;

            // Validamos el usuario y la contraseña con el método de la clase Principal
            bool valido = principal.ValidarLogIn(usuario, contraseña);

            // Si el usuario y la contraseña son válidos, mostramos un mensaje de bienvenida
            if (valido)
            {
                MessageBox.Show("Bienvenido " + usuario);
                FrmTableroInicio frmTableroInicio = new FrmTableroInicio();
                frmTableroInicio.Show();
                Hide();

            }
            // Si no son válidos, mostramos un mensaje de error
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");

                TxtUsuario.Clear();
                TxtContrasena.Clear();
            }


            //NO BORRAR PORQUE SI NOHAY PROFESORES NO SE PUEDEN CREAR

            //FrmTableroInicio frmTableroInicio = new FrmTableroInicio();
            //frmTableroInicio.Show();
            //Hide();
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {
            LblUsuario.Visible = false;
        }

        private void LblContrasena_Click(object sender, EventArgs e)
        {
            LblContrasena.Visible = false;
        }

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}