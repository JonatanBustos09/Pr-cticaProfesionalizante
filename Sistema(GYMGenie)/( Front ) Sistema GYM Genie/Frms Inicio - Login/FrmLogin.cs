using Sistema_GYM_Genie.Clases;
using System.Runtime.InteropServices;

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
            // Obtenemos el usuario y la contrase�a ingresados en los campos de texto
            string usuario = LblUsuario.Text;
            string contrase�a = LblContrasena.Text;

            // Validamos el usuario y la contrase�a con el m�todo de la clase Principal
            bool valido = principal.ValidarLogIn(usuario, contrase�a);

            // Si el usuario y la contrase�a son v�lidos, mostramos un mensaje de bienvenida
            if (valido)
            {
                MessageBox.Show("Bienvenido " + usuario);
                FrmTableroInicio frmTableroInicio = new FrmTableroInicio();
                frmTableroInicio.Show();
                //esto no deberia ser un this.hide()?
                Hide();
                
            }
            // Si no son v�lidos, mostramos un mensaje de error
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
            }
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
    }
}