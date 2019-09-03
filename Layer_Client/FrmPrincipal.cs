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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void BtnBuscarOferta_Click(object sender, EventArgs e)
        {
            FrmBuscarOferta buscarOferta = new FrmBuscarOferta();
            buscarOferta.MdiParent = this;
            buscarOferta.Dock = DockStyle.Fill;
            buscarOferta.Show();
        }
    }
}
