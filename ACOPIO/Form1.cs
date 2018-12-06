using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Presentacion;

namespace ACOPIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void centrosDeAcopioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentroAcopios form = new FrmCentroAcopios();
            form.Show();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColores form = new FrmColores();
            form.Show();
        }

        private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductores form = new FrmProductores();
            form.Show();
        }

        private void moduloAcopioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcopio form = new FrmAcopio();
            form.Show();
        }

        private void moduloCategorizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorizacion form = new FrmCategorizacion();
            form.Show();
        }

        private void reporteConsolidadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rep frm = new rep();
            frm.Show();
        }

        private void preciosOfertadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrecios frm = new FrmPrecios();
            frm.Show();
        }
    }
}
