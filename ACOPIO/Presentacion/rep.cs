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
    public partial class rep : Form
    {
        public rep()
        {
            InitializeComponent();
        }

        private void rep_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsReporte.Categorizacion' Puede moverla o quitarla según sea necesario.
            this.CategorizacionTableAdapter.Fill(this.dsReporte.Categorizacion);

            this.reportViewer1.RefreshReport();
        }
    }
}
