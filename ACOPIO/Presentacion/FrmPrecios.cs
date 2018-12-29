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

                dgvDatos.Columns["Id"].Visible = false;
                dgvDatos.Columns["CategoriaId"].Visible = false;
                dgvDatos.Columns["ColorId"].Visible=false;
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
                frm.txtRaza.Text = dgvDatos.CurrentRow.Cells["Raza"].Value.ToString();
                frm.txtCategoriaId.Text = dgvDatos.CurrentRow.Cells["CategoriaId"].Value.ToString();
                frm.txtCategoria.Text = dgvDatos.CurrentRow.Cells["Categoria"].Value.ToString();
                frm.txtColorId.Text = dgvDatos.CurrentRow.Cells["ColorId"].Value.ToString();
                frm.txtColor.Text = dgvDatos.CurrentRow.Cells["Color"].Value.ToString();
                frm.txtPrecio.Text = dgvDatos.CurrentRow.Cells["Precio"].Value.ToString();
                frm.ShowDialog();

                FrmPrecios_Load(null,null);
            }
        }
    }
}
