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
    public partial class FrmAdministrarORH : Form
    {
        public FrmAdministrarORH()
        {
            InitializeComponent();
        }

        private void FrmAdministrarORH_Load(object sender, EventArgs e)
        {
            string[] datos = (new ORHEstadoLog()).obtenerPorCodigo(LoginInfo.codigo);
            txtCodigo.Text = LoginInfo.codigo.ToString();
            txtRuc.Text = datos[0];
            txtNombre.Text = datos[1];
            txtCorreo.Text = datos[2];
            txtContrasena.Text = datos[3];
            txtTelefono.Text = datos[4];
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[] {
                LoginInfo.codigo,
                txtRuc.Text,
                txtNombre.Text,
                txtCorreo.Text,
                txtContrasena.Text,
                txtTelefono.Text,
            };
            bool actualuzado = (new ORHEstadoLog()).actualizar(datos);
            if (actualuzado) {
                MessageBox.Show("Tus datos han sido actualizados.");
            }
            else {
                MessageBox.Show("Hubo un error al actualizar tus datos.");
            }
        }
    }
}
