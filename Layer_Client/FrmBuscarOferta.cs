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
    public partial class FrmBuscarOferta : Form
    {
        public FrmBuscarOferta()
        {
            InitializeComponent();
        }

        private void FrmBuscarOferta_Load(object sender, EventArgs e)
        {
            llenarDgvOfertas();

            cboCarrera.DataSource = (new CarreraLog()).obtenerLista();
            cboCarrera.DisplayMember = "Cod_Car";
            cboCarrera.ValueMember = "Nombre";
        }

        private void llenarDgvOfertas()
        {
            dgvOfertas.DataSource = (new OfertaLog()).obtenerLista();
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Eliminar";
            // deleteButton.Text = "X";
            deleteButton.UseColumnTextForButtonValue = true;
            dgvOfertas.Columns.Add(deleteButton);
            dgvOfertas.CellClick += dgvOfertas_CellClick;
            dgvOfertas.CellPainting += dgvOfertas_CellPainting;
        }

        private void dgvOfertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOfertas.Columns["Eliminar"].Index) {
                DialogResult result = MessageBox.Show("¿Eliminar registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.OK)) {
                    // string codigo = dgvOfertas.Columns["Cod_Ofe"].ToString();
                    string codigo = dgvOfertas.Rows[e.RowIndex].Cells[1].Value.ToString();
                    bool eliminado = (new OfertaLog()).eliminar(codigo);
                    if (!eliminado) {
                        MessageBox.Show("Hubo un error al eliminar el registro");
                    }
                    else {
                        MessageBox.Show("Registro eliminado");
                        llenarDgvOfertas();
                    }
                }
            }
        }

        private void dgvOfertas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //I supposed your button column is at index 0
            if (e.ColumnIndex == 0) {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                Image deleteIcon = Properties.Resources.delete_icon;
                var w = deleteIcon.Width;
                var h = deleteIcon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(deleteIcon, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvOfertas.DataSource as DataTable;
            bool actualizado = (new OfertaLog()).actualizarOfertas(dt);
            if (actualizado) {
                MessageBox.Show("Regitros actualizados.");
            } else
            {
                MessageBox.Show("Hubo un error al actualizar algunos registros.");
            }
            llenarDgvOfertas();
        }
    }
}
