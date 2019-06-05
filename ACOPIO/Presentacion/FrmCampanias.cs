﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Datos;
using ACOPIO.Entidad;
using System.IO;

namespace ACOPIO.Presentacion
{
    public partial class FrmCampanias : Form
    {
        public FrmCampanias()
        {
            InitializeComponent();
        }

        private void FrmCampanias_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FCampania.GetAll();
                DataTable dt = ds.Tables[0];
                dgvDatos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCampania form = new FrmCampania();
            form.ShowDialog();
            FrmCampanias_Load(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                FrmCampania form = new FrmCampania();
                form.id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                form.nombre = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();;
                form.ShowDialog();

                FrmCampanias_Load(null, null);

            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("¿Está seguro de eliminar el dato seleccionados ? ", "Eliminando...",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Campania campania = new Campania();
                    campania.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                    int returnId = FCampania.Eliminar(campania);
                    //if (returnId > 0)
                    //{
                    FrmCampanias_Load(null, null);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No se pudo eliminar, hay datos vinculados", "No se puede eliminar");
                    //}
                }
            }

        private void btnExcel_Click(object sender, EventArgs e)
        {
             SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Campanias.xls";
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
