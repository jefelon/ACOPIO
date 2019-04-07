using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ACOPIO.Presentacion
{
    public partial class FrmImpresionAcopio : Form
    {
        public FrmImpresionAcopio()
        {
            InitializeComponent();
        }

        public int AcopioId;
        private void ImpresionAcopio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReporte.Acopio' Puede moverla o quitarla según sea necesario.
            this.AcopioTableAdapter.Fill(this.dsReporte.Acopio);
            // TODO: esta línea de código carga datos en la tabla 'dsReporte.DetalleAcopio' Puede moverla o quitarla según sea necesario.
            this.DetalleAcopioTableAdapter.Fill(this.dsReporte.DetalleAcopio);

            ReportParameter p = new ReportParameter("AcopioId",""+AcopioId+"");
            reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
