using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace ACOPIO.Presentacion
{
    public partial class FrmApariencia : Form
    {
        public FrmApariencia()
        {
            InitializeComponent();
        }

        string ruta;
        private void btnImagen_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.png)|*.png ";
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.FileName = "Seleccione una imagen";
            openFileDialog1.Title = "Escoja una imagen";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                pictureBox1.BackgroundImage = Image.FromFile(ruta);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string archivoOrigen = @""+ruta+"";
                string rutaDestino = @"" + Application.StartupPath + "";

                string nombreImagen = String.Concat(Path.GetFileNameWithoutExtension(archivoOrigen),
                                                     "_",
                                                    DateTime.Now.ToString("ddMMyyyy"),
                                                    Path.GetExtension(archivoOrigen));

                File.Copy(archivoOrigen, Path.Combine(rutaDestino, nombreImagen));

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["fondo"].Value = nombreImagen;
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error : " + ex.Message);
            }
        }

        private void FrmApariencia_Load(object sender, EventArgs e)
        {
            string fondo;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            fondo = config.AppSettings.Settings["fondo"].Value;

            if (File.Exists(fondo))
            {
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.BackgroundImage = Image.FromFile(fondo);
            }
        }
    }
}
