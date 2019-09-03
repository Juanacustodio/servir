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
            showForm(new FrmBuscarOferta());
        }

        private void BtnPublicarOferta_Click(object sender, EventArgs e)
        {
            showForm(new FrmPublicarOferta());
        }

        private void BtnAdministrar_Click(object sender, EventArgs e)
        {
            showForm(new FrmAdministrarORH());
        }

        private void showForm(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
