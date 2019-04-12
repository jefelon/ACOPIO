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
    public partial class RptAcopioGeneral : Form
    {
        public RptAcopioGeneral()
        {
            InitializeComponent();
        }

        private void RptAcopioGeneral_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReporte.RptAcopios' Puede moverla o quitarla según sea necesario.
            this.RptAcopiosTableAdapter.Fill(this.dsReporte.RptAcopios);

            this.reportViewer1.RefreshReport();
        }
    }
}
