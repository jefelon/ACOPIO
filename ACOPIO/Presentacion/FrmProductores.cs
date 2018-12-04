using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Datos;
using ACOPIO.Entidad;

namespace ACOPIO.Presentacion
{
    public partial class FrmProductores : Form
    {
        public FrmProductores()
        {
            InitializeComponent();
        }

        private void FrmProductores_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FProductor.GetAll();
                DataTable dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProductor frm = new FrmProductor();
            frm.ShowDialog();
            FrmProductores_Load(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                FrmProductor form = new FrmProductor();
                form.id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                form.dni = dgvDatos.CurrentRow.Cells["Dni"].Value.ToString();
                form.nombre = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                form.sexo = dgvDatos.CurrentRow.Cells["Sexo"].Value.ToString();
                form.edad = dgvDatos.CurrentRow.Cells["Edad"].Value.ToString();
                form.socio = dgvDatos.CurrentRow.Cells["Socio"].Value.ToString();
                form.unidadProductiva = dgvDatos.CurrentRow.Cells["UnidadProductiva"].Value.ToString();
                form.ShowDialog();

                FrmProductores_Load(null, null);

            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Productor productor = new Productor();
                    productor.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FProductor.Eliminar(productor);
                    //if (returnId > 0)
                    //{
                    FrmProductores_Load(null, null);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No se pudo eliminar, hay datos vinculados", "No se puede eliminar");
                    //}
                }
            } 
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
