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
    public partial class FrmCentroAcopio : Form
    {
        public FrmCentroAcopio()
        {
            InitializeComponent();
        }

        public int id = 0;
        public string nombre, ubicacion;
        private void FrmCentroAcopio_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                txtCodigo.Text = id.ToString();
                txtNombre.Text = nombre;
                txtUbicacion.Text = ubicacion;
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
                        CentroAcopio centroAcopio = new CentroAcopio();
                        centroAcopio.Nombre = txtNombre.Text;
                        centroAcopio.Ubicacion = txtUbicacion.Text;

                        int returnId = FCentroAcopio.Insertar(centroAcopio);
                        if (returnId > 0)
                        {
                            Close();
                        }
                    }
                    else
                    {                      
                        CentroAcopio centroAcopio = new CentroAcopio();
                        centroAcopio.Id = Convert.ToInt32(txtCodigo.Text);
                        centroAcopio.Nombre = txtNombre.Text;
                        centroAcopio.Ubicacion = txtUbicacion.Text;

                        int returnId = FCentroAcopio.Actualizar(centroAcopio);

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
            if (txtUbicacion.Text == "")
            {
                resultado = "La ubicación está vacio.";
                txtNombre.Focus();
            }
            return resultado;
        }
    }
}
