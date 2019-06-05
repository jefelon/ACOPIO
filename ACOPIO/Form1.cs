using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Presentacion;
using System.Data.SQLite;
using System.IO;
using System.Configuration;

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

        private void crearCopiaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.SelectedPath;
                tempPath += "\\";

                using (var source = new SQLiteConnection("Data Source=acopio.db; Version=3;"))
                using (var destination = new SQLiteConnection("Data Source="+tempPath+"acopio.db; Version=3;"))
                {
                    source.Open();
                    destination.Open();
                    source.BackupDatabase(destination, "main", "main", -1, null, 0);

                    MessageBox.Show("Copia de seguridad creado correctamente","Copia OK");
                }
            }


        }

        private void restaurarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            string tempPath = "";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.FileName;

                using (var source = new SQLiteConnection("Data Source="+tempPath+"; Version=3;"))
                using (var destination = new SQLiteConnection("Data Source=acopio.db; Version=3;"))
                {
                    source.Open();
                    destination.Open();
                    source.BackupDatabase(destination, "main", "main", -1, null, 0);

                    MessageBox.Show("Copia de seguridad restaurado correctamente", "Copia OK");
                }
            }
        }

        private void reimpresiónDeReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcopioListado frm = new FrmAcopioListado();

            frm.Show();
        }

        private void reporteGeneralTodosLosAcopiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptAcopioGeneral frm = new RptAcopioGeneral();
            frm.Show();
        }

        private void reporteAcopioPorProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptAcopioFechasProveedor frm = new RptAcopioFechasProveedor();
            frm.Show();
        }

        private void aparienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApariencia frm = new FrmApariencia();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void campañasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCampanias frm = new FrmCampanias();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fondo;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            fondo=config.AppSettings.Settings["fondo"].Value;

            if(File.Exists(fondo)){
                 this.BackgroundImageLayout = ImageLayout.Stretch;
                 this.BackgroundImage = Image.FromFile(fondo);
            }
        }

        private void acercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
        }

        private void usuariosListadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unidadProductivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadProductivas form = new FrmUnidadProductivas();
            form.Show();
        }
    }
}
