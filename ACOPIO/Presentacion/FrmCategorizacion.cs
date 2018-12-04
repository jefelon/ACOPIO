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
    public partial class FrmCategorizacion : Form
    {
        public FrmCategorizacion()
        {
            InitializeComponent();
        }

        private void FrmCategorizacion_Load(object sender, EventArgs e)
        {
            DataSet ds = FCampania.GetAll();
            DataTable dt = ds.Tables[0];
            cmbCampania.ValueMember = "Id";
            cmbCampania.DisplayMember = "Nombre";
            cmbCampania.DataSource = dt;

            DataSet ds2 = FCentroAcopio.GetAll();
            DataTable dt2 = ds2.Tables[0];
            cmbCentroAcopio.ValueMember = "Id";
            cmbCentroAcopio.DisplayMember = "Nombre";
            cmbCentroAcopio.DataSource = dt2;
            cmbCentroAcopio.SelectedValue = Usuario.CentroAcopioId;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmAgregarItemCat frm = new FrmAgregarItemCat();
            frm.ShowDialog();

            dgvDatos.Rows.Add(NroSaco(), frm.cantidad, frm.categoriaId, frm.categoria, frm.raza, frm.colorId, frm.color);
            calcularTotales();
        }

        private void calcularTotales()
        {
            int cantSacos = 0;
            double total = 0;

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                total += Convert.ToDouble(row.Cells["Cantidad"].Value);
                cantSacos += 1;
            }
            txtNroSacos.Text = cantSacos.ToString();
            txtCantidad.Text = String.Format("{0:n2}", total);
        }

        private int calcularSacos()
        {
            int cantSacos = 1;
           

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {             
                cantSacos += 1;
            }
            
            return cantSacos;
        }

        private int NroSaco()
        {
            int nroSaco;
            DataSet ds = FCategorizacionDetalle.GetNroSaco();
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count <= 0 || dt.Rows[0]["NroSaco"] == DBNull.Value)
            {
                nroSaco = 1;
                if (dgvDatos.Rows.Count > 0)
                {
                    nroSaco=calcularSacos();
                }
            }
            else {
                nroSaco = Convert.ToInt32(dt.Rows[0]["NroSaco"]);
                nroSaco +=1;
                if (dgvDatos.Rows.Count > 0)
                {                   

                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        nroSaco += 1;
                    }
                }

            }

            return nroSaco;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sResultado = validarDatos();
            if (sResultado == "")
            {
                try
                {
                    Categorizacion categorizacion = new Categorizacion();
                    categorizacion.Fecha = dtpFecha.Value;
                    categorizacion.CentroAcopio.Id = Convert.ToInt32(cmbCentroAcopio.SelectedValue.ToString());
                    categorizacion.Campania.Id = Convert.ToInt32(cmbCampania.SelectedValue.ToString());
                    categorizacion.UsuarioId = Usuario.Id;

                    int returId = FCategorizacion.Insertar(categorizacion);
                    if (returId > 0)
                    {



                        foreach (DataGridViewRow row in dgvDatos.Rows)
                        {
                            CategorizacionDetalle categorizacionDetalle = new CategorizacionDetalle();
                            categorizacionDetalle.NroSaco = Convert.ToInt32(row.Cells[0].Value.ToString());
                            categorizacionDetalle.CategorizacionId = returId;
                            categorizacionDetalle.Cantidad = Convert.ToDouble(row.Cells[1].Value.ToString());
                            categorizacionDetalle.Producto = "Fibra de Alpaca";
                            categorizacionDetalle.Categoria.Id = Convert.ToInt32(row.Cells[2].Value.ToString());
                            categorizacionDetalle.Raza = row.Cells[4].Value.ToString();
                            categorizacionDetalle.Color.Id = Convert.ToInt32(row.Cells[5].Value.ToString());

                            int returnDetalleId = FCategorizacionDetalle.Insertar(categorizacionDetalle);

                        }
                    }

                    MessageBox.Show("Categorización Guardado.", "Guardando...");

                    FrmCategorizacion_Load(null, null);

                    dgvDatos.Rows.Clear();
                    txtNroSacos.Text = "";
                    txtCantidad.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
            else
            {
                MessageBox.Show("Error + \n" + sResultado);
                FrmCategorizacion_Load(null, null);
            }
        }

        public string validarDatos()
        {
            string reultado = "";
            //if (txtNombre.Text == "")
            //{
            //    reultado = "Seleccione un productor";
            //    txtDni.Focus();
            //}
            return reultado;
        }
    }
}
