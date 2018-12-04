using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ACOPIO.Entidad;
using ACOPIO.Datos;

namespace ACOPIO.Presentacion
{
    public partial class FrmColor : Form
    {
        public FrmColor()
        {
            InitializeComponent();
        }

        public int id=0;
        public string nombre;
        private void FrmColor_Load(object sender, EventArgs e)
        {
            if( id>0)
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
                        Color color = new Color();
                        color.Nombre = txtNombre.Text;

                        int returnId = FColor.Insertar(color);
                        if (returnId > 0)
                        {                         
                           Close();
                        }
                    }
                    else
                    {
                        Color color = new Color();
                        color.Id = Convert.ToInt32(txtCodigo.Text);
                        color.Nombre = txtNombre.Text;
                        int returnId = FColor.Actualizar(color);
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
