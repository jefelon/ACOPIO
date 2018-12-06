using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Datos;

namespace ACOPIO.Presentacion
{
    public partial class FrmPrecios : Form
    {
        public FrmPrecios()
        {
            InitializeComponent();
        }

        private void FrmPrecios_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FCategoriaColorPrecio.GetAll();
                DataTable dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvDatos_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.Columns[e.ColumnIndex].HeaderText == "Editar")
            {
                FrmEditarPrecios frm = new FrmEditarPrecios();
                frm.txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                frm.ShowDialog();
            }
        }
    }
}
