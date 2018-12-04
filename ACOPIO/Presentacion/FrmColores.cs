using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Datos;
using System.Data;
using ACOPIO.Entidad;
using System.IO;

namespace ACOPIO.Presentacion
{
    public partial class FrmColores : Form
    {
        public FrmColores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmColor color = new FrmColor();
            color.ShowDialog();
            FrmColores_Load(null,null);
        }

        private void FrmColores_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FColor.GetAll();
                DataTable dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                if (dgvDatos.CurrentRow.Cells["Id"].Value.ToString() == "1" || dgvDatos.CurrentRow.Cells["Id"].Value.ToString() == "2")
                {
                    MessageBox.Show("No se puede borrar/modificar este color ya que se usa en otros lugares del sistema.");
                }
                else
                {
                    FrmColor color = new FrmColor();
                    color.id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    color.nombre = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                    color.ShowDialog();

                    FrmColores_Load(null, null);
                }
                
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (dgvDatos.CurrentRow.Cells["Id"].Value.ToString() == "1" || dgvDatos.CurrentRow.Cells["Id"].Value.ToString() == "2")
                    {
                        MessageBox.Show("No se puede borrar/modificar este color ya que se usa en otros lugares del sistema.");
                    }
                    else
                    {
                        Color color = new Color();
                        color.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                        int returnId = FColor.Eliminar(color);
                        //if (returnId > 0)
                        //{
                        FrmColores_Load(null, null);
                        //}
                        //else
                        //{
                        //    MessageBox.Show("No se pudo eliminar, hay datos vinculados", "No se puede eliminar");
                        //}
                    }
                }
            } 
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Listado.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportarDataGridViewExcel(dgvDatos, sfd.FileName);
            }
        }
        private void ExportarDataGridViewExcel(DataGridView grd, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < grd.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(grd.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < grd.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < grd.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(grd.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
            
        }
    }
}
