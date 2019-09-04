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
    public partial class FrmAdminPrincipal : Form
    {
        public FrmAdminPrincipal()
        {
            InitializeComponent();
        }

        private void POSTULANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showForm(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void BtnBuscarCarrera_Click(object sender, EventArgs e)
        {
            showForm(new FrmBuscarCarrera());
        }

        private void BtnAgregarCarrera_Click(object sender, EventArgs e)
        {
            showForm(new FrmAgregarCarrera());
        }

        private void BtnBuscarCentroEstudios_Click(object sender, EventArgs e)
        {
            showForm(new FrmBuscarCentroEstudios());
        }

        private void BtnAgregarCentroEstudios_Click(object sender, EventArgs e)
        {
            showForm(new FrmAgregarCentroEstudios());
        }

        private void BtnBuscarOferta_Click(object sender, EventArgs e)
        {
            showForm(new FrmBuscarOferta());
        }

        private void BtnAgregarOferta_Click(object sender, EventArgs e)
        {
            showForm(new FrmPublicarOferta());
        }

        private void BtnBuscarORH_Click(object sender, EventArgs e)
        {
            showForm(new FrmBuscarORH());
        }

        private void BtnAgregarORH_Click(object sender, EventArgs e)
        {
            showForm(new FrmAgregarORH());
        }

        private void BtnBuscarPostulante_Click(object sender, EventArgs e)
        {
            showForm(new FrmBuscarPostulante());
        }

        private void BtnAgregarPostulante_Click(object sender, EventArgs e)
        {
            showForm(new FrmAgregarPostulante());
        }

        private void FrmAdminPrincipal_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
    }
}
