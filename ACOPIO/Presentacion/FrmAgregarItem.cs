using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACOPIO.Presentacion
{
    public partial class FrmAgregarItem : Form
    {
        public FrmAgregarItem()
        {
            InitializeComponent();
        }

        public string calidad, raza,color;
        public int colorId;
        public double precio, cantidad;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "" && txtCantidad.Text != "")
            {
                if (rbtAdulta.Checked == true)
                {
                    calidad = "Adulta";
                }
                else {
                    calidad = "Tui";
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
                if (rbtBlanco.Checked == true)
                {
                    colorId = 1;
                    color = "Blanco";
                }
                else
                {
                    colorId = 2;
                    color = "Color";
                }

                precio = Convert.ToDouble(txtPrecio.Text);
                cantidad = Convert.ToDouble(txtCantidad.Text);
            }

            Close();
        }

        private void FrmAgregarItem_Load(object sender, EventArgs e)
        {

        }
    }
}
