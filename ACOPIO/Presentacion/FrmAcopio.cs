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
    public partial class FrmAcopio : Form
    {
        public FrmAcopio()
        {
            InitializeComponent();
        }

        private static DataTable dt = new DataTable();
        private void FrmAcopio_Load(object sender, EventArgs e)
        {
            DataSet ds = FCampania.GetAll();
            DataTable dt = ds.Tables[0];
            cmbCampania.ValueMember = "Id";
            cmbCampania.DisplayMember = "Nombre";
            cmbCampania.DataSource = dt;
            cmbCampania.SelectedValue = Usuario.CampaniaId;

            DataSet ds2 = FCentroAcopio.GetAll();
            DataTable dt2 = ds2.Tables[0];
            cmbCentroAcopio.ValueMember = "Id";
            cmbCentroAcopio.DisplayMember = "Nombre";
            cmbCentroAcopio.DataSource = dt2;
            cmbCentroAcopio.SelectedValue = Usuario.CentroAcopioId;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            listarProductor();
        }
        public void listarProductor()
        {
            DataSet ds = FProductor.Buscar(txtDni.Text);
             dt = ds.Tables[0];


            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("No hay resultados para su criterio de busqueda, intente nuévamente", "No hay resultados");
                dgvProductor.DataSource = null;
                dgvProductor.Visible = false;
            }
            if (txtDni.TextLength < 1 && txtNombre.TextLength < 1)
            {
                dgvProductor.Visible = false;
            }
            else
            {
                dgvProductor.DataSource = dt;
                //dgvProductor.Columns["Id"].Visible = false;
                //dgvProductor.Columns["Nombre"].Visible = false;
                //dgvProductor.Columns["Dni"].Visible = false;
                //dgvProductor.Columns["UnidadProductiva"].Visible = false;
                dgvProductor.Visible = true;

            }
        }

        private void dgvProductor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            asignarProductor();
        }
        private void asignarProductor()
        {
            if (dgvProductor.CurrentRow != null)
            {
              txtIdProductor.Text = dgvProductor.CurrentRow.Cells["Id"].Value.ToString();
              txtNombre.Text = dgvProductor.CurrentRow.Cells["Nombre"].Value.ToString();
              txtDni.Text = dgvProductor.CurrentRow.Cells["Dni"].Value.ToString();
              txtUnidadProductiva.Text = dgvProductor.CurrentRow.Cells["UnidadProductiva"].Value.ToString();
              dgvProductor.DataSource = null;
              dgvProductor.Visible = false;
            }           
            btnProductos.Focus();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmAgregarItem frm = new FrmAgregarItem();
            frm.ShowDialog();

            dgvDatos.Rows.Add(frm.cantidad, frm.precio,"Fibra de alpaca", frm.calidad,frm.raza,frm.colorId, frm.color,frm.precio*frm.cantidad);//los datos del producto se agregan al dgvDatos
            calcularTotales();
        }
        private void calcularTotales()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                total += Convert.ToDouble(row.Cells["Importe"].Value);
            }
            txtImporte.Text = String.Format("{0:n2}", total);
        }

        private void dgvProductor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                asignarProductor();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sResultado = validarDatos();
            if (sResultado == "")
            {
                try
                {
                Acopio acopio = new Acopio();
                acopio.Fecha = dtpFecha.Value;
                acopio.CentroAcopio.Id = Convert.ToInt32(cmbCentroAcopio.SelectedValue.ToString());
                acopio.Campania.Id = Convert.ToInt32(cmbCampania.SelectedValue.ToString());
                acopio.Productor.Id = Convert.ToInt32(txtIdProductor.Text);
                acopio.UsuarioId = Usuario.Id;

                int returId = FAcopio.Insertar(acopio);
                if (returId > 0)
                {



                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        AcopioDetalle acopioDetalle = new AcopioDetalle();
                        acopioDetalle.AcopioId = returId;
                        acopioDetalle.Cantidad = Convert.ToDouble(row.Cells[0].Value.ToString());
                        acopioDetalle.ValorUnitario = Convert.ToDouble(row.Cells[1].Value.ToString());
                        acopioDetalle.Producto = row.Cells[2].Value.ToString();
                        acopioDetalle.Calidad = row.Cells[3].Value.ToString();
                        acopioDetalle.Raza = row.Cells[4].Value.ToString();
                        acopioDetalle.Color.Id = Convert.ToInt32(row.Cells[5].Value.ToString());
                        
  
                        int returnDetalleId = FAcopioDetalle.Insertar(acopioDetalle);

                    }
                }

                MessageBox.Show("Ingreso Guardado.","Guardando...");

                FrmImpresionAcopio frm = new FrmImpresionAcopio();
                frm.AcopioId = returId;
                frm.ShowDialog();

                FrmAcopio_Load(null, null);

                    dgvDatos.Rows.Clear();
                    txtIdProductor.Text = "";
                    txtDni.Text = "";
                    txtNombre.Text = "";
                    txtUnidadProductiva.Text = "";
                    txtImporte.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
            else
            {
                MessageBox.Show("Error + \n" + sResultado);
                FrmAcopio_Load(null, null);
            }  
        }
        public string validarDatos()
        {
            string reultado = "";
            if (txtNombre.Text == "")
            {
                reultado = "Seleccione un productor";
                txtDni.Focus();
            }
            return reultado;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            listarProductor();
        }
    }
}
