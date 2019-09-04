using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layer_Client
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrasena = txtContrasena.Text;

            if (correo=="admin" && contrasena == "admin") {
                (new FrmAdminPrincipal()).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
        }
    }
}
