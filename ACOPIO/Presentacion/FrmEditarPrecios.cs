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
    public partial class FrmEditarPrecios : Form
    {
        public FrmEditarPrecios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text == "")
                    {
                        CategoriaColorPrecio categoriaColorPrecio = new CategoriaColorPrecio();
                        categoriaColorPrecio.Precio = txtPrecio.Text;

                        int returnId = FCategoriaColorPrecio.Insertar(categoriaColorPrecio);
                        if (returnId > 0)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        CategoriaColorPrecio categoriaColorPrecio = new CategoriaColorPrecio();
                        categoriaColorPrecio.Id = Convert.ToInt32(txtId.Text);
                        categoriaColorPrecio.Precio = txtPrecio.Text;
                        int returnId = FCategoriaColorPrecio.ActualizarPrecio(categoriaColorPrecio);
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
            if (txtPrecio.Text == "")
            {
                resultado = "El nombre está vacio.";
                txtPrecio.Focus();
            }
            return resultado;
        }
    }
}
