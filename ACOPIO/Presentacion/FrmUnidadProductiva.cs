using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Entidad;
using ACOPIO.Datos;

namespace ACOPIO.Presentacion
{
    public partial class FrmUnidadProductiva : Form
    {
        public FrmUnidadProductiva()
        {
            InitializeComponent();
        }
        public int id = 0;
        public string nombre;
        private void FrmUnidadProductiva_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                txtCodigo.Text = id.ToString();
                txtNombre.Text = nombre;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtCodigo.Text == "")
                    {
                        UnidadProductiva unipr = new UnidadProductiva();
                        unipr.Nombre = txtNombre.Text;

                        int returnId = FUnidadProductiva.Insertar(unipr);
                        if (returnId > 0)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        UnidadProductiva unipr = new UnidadProductiva();
                        unipr.Id = Convert.ToInt32(txtCodigo.Text);
                        unipr.Nombre = txtNombre.Text;
                        int returnId = FUnidadProductiva.Actualizar(unipr);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Errores: \n" + sResultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string validarDatos()
        {
            string resultado = "";
            if (txtNombre.Text == "")
            {
                resultado = "El nombre está vacio.";
                txtNombre.Focus();
            }
            return resultado;
        }
    }
}
