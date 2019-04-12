using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Datos;
using Microsoft.Reporting.WinForms;

namespace ACOPIO.Presentacion
{
    public partial class RptAcopioFechasProveedor : Form
    {
        public RptAcopioFechasProveedor()
        {
            InitializeComponent();
        }

        private void RptAcopioFechasProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReporte.RptAcopios' Puede moverla o quitarla según sea necesario.
            this.RptAcopiosTableAdapter.Fill(this.dsReporte.RptAcopios);
            DataSet ds = FProductor.GetAll();
            DataTable dt = ds.Tables[0];
            cmbProductor.ValueMember = "Id";
            cmbProductor.DisplayMember = "Nombre";
            cmbProductor.DataSource = dt;
            
            
            // TODO: esta línea de código carga datos en la tabla 'dsReporte.RptAcopios' Puede moverla o quitarla según sea necesario.
            //this.RptAcopiosTableAdapter.Fill(this.dsReporte.RptAcopios);

            //this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.RptAcopiosTableAdapter.FillByProductorId(this.dsReporte.RptAcopios, Convert.ToInt32(cmbProductor.SelectedValue.ToString()), dtpDesde.Value.ToString("yyyy-MM-dd"), dtpHasta.Value.ToString("yyyy-MM-dd"));
            ReportParameter p = new ReportParameter("ProductorId2", "" + cmbProductor.SelectedValue.ToString() + "");
            ReportParameter p2 = new ReportParameter("Nombre", "" + cmbProductor.Text + "");
            this.reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.SetParameters(p2);
            this.reportViewer1.RefreshReport();
        }
    }
}
