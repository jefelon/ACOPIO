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
    public partial class FrmCampania : Form
    {
        public FrmCampania()
        {
            InitializeComponent();
        }
        public int id = 0;
        public string nombre;
        private void FrmCampania_Load(object sender, EventArgs e)
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
                        Campania campania = new Campania();
                        campania.Nombre = txtNombre.Text;

                        int returnId = FCampania.Insertar(campania);
                        if (returnId > 0)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        Campania campania = new Campania();
                        campania.Id = Convert.ToInt32(txtCodigo.Text);
                        campania.Nombre = txtNombre.Text;

                        int returnId = FCampania.Actualizar(campania);

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
