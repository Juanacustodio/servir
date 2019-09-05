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
    public partial class FrmPublicarOferta : Form
    {
        public FrmPublicarOferta()
        {
            InitializeComponent();
        }

        private void FrmPublicarOferta_Load(object sender, EventArgs e)
        {
            llenarDgvOfertas();
        }

        private void BtnPublicar_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvOfertas.DataSource as DataTable;
            bool actualizado = (new OfertaLog()).crear(dt);
            if (actualizado) {
                MessageBox.Show("Regitros creados.");
            }
            else {
                MessageBox.Show("Hubo un error al crear algunos registros.");
            }
            llenarDgvOfertas();
        }
        private void llenarDgvOfertas()
        {
            dgvOfertas.DataSource = (new OfertaLog()).obtenerListaVacia();
        }
    }
}
