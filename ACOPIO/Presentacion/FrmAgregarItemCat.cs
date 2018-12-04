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
    public partial class FrmAgregarItemCat : Form
    {
        public FrmAgregarItemCat()
        {
            InitializeComponent();
        }

        public string raza, color,categoria;
        public int colorId, categoriaId;
        public double cantidad;
        private void FrmAgregarItemCat_Load(object sender, EventArgs e)
        {
            DataSet ds = FColor.GetAll();
            DataTable dt = ds.Tables[0];
            cmbColor.ValueMember = "Id";
            cmbColor.DisplayMember = "Nombre";
            cmbColor.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                if (rbtExtraFina.Checked == true)
                {
                    categoriaId = 1;
                    categoria = rbtExtraFina.Text;
                }
                else if (rbtFina.Checked == true)
                {
                    categoriaId = 2;
                    categoria = rbtFina.Text;
                }
                else if (rbtSemiFina.Checked == true)
                {
                    categoriaId = 3;
                    categoria = rbtSemiFina.Text;
                }

                else if (rbtGruesa.Checked == true)
                {
                    categoriaId = 4;
                    categoria = rbtGruesa.Text;

                }
                //=========================
                if (rbtHuacaya.Checked == true)
                {
                    raza = "Huacaya";
                }
                else
                {
                    raza = "Suri";
                }
                //=========================
                
                    colorId = Convert.ToInt32(cmbColor.SelectedValue.ToString());
                    color = cmbColor.Text;

                cantidad = Convert.ToDouble(txtCantidad.Text);
            }

            Close();
        }
    }
}
