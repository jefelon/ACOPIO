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
    public partial class FrmAcopioListado : Form
    {
        public FrmAcopioListado()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        private void FrmAcopioListado_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FAcopio.GetAll();
                 dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy()); //dt es la tabla que creamos al inicio de esta hoja
                dv.RowFilter = cmbBuscar.Text + " Like '" + txtBuscar.Text + "%'";
                dgvDatos.DataSource = dv;

                if (dv.Count == 0)
                {
                    lblDatosNoEncontrados.Visible = true;
                }
                else
                {
                    lblDatosNoEncontrados.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmImpresionAcopio frm = new FrmImpresionAcopio();
            frm.AcopioId = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
            frm.Show();
        }
    }
}
