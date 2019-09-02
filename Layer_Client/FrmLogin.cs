using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Layer_Logic.logica;

namespace Layer_Client
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrasena = txtContrasena.Text;

            string[] usuario = (new Login()).validarUsuario(correo, contrasena);
            if (usuario == null) {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
            else {
                LoginInfo.codigo = usuario[0];
                LoginInfo.nombre = usuario[1];
                (new FrmPrincipal()).Show();
                this.Hide();
            }
        }
    }
}
