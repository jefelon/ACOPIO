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
    public partial class FrmProductor : Form
    {
        public FrmProductor()
        {
            InitializeComponent();
        }
        public int id;
        public string dni, nombre, sexo, edad, socio, unidadProductiva;

        private void FrmProductor_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                txtCodigo.Text = id.ToString();
                txtDni.Text=dni;
                txtNombre.Text = nombre;
                if (sexo == "M")
                {
                    rbtSexoM.Checked = true;
                }
                else
                {
                    rbtSexoF.Checked = true;
                }
                if (socio == "SI")
                {
                    rbtSocioSi.Checked = true;
                }
                else {
                    rbtSocioNo.Checked = true;
                }

                txtEdad.Text = edad;
                cmbUnidadProductiva.Text = unidadProductiva;
            }

            DataSet ds = FUnidadProductiva.GetAll();
            DataTable dt = ds.Tables[0];
            cmbUnidadProductiva.ValueMember = "Id";
            cmbUnidadProductiva.DisplayMember = "Nombre";
            cmbUnidadProductiva.DataSource = dt;
           
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
                        Productor productor = new Productor();
                        productor.Dni = txtDni.Text;
                        productor.Nombre = txtNombre.Text;
                        if (rbtSexoM.Checked == true)
                        { 
                            productor.Sexo = rbtSexoM.Text; 
                        }
                        else
                        { productor.Sexo = rbtSexoF.Text; }
                        
                        productor.Edad = Convert.ToInt32(txtEdad.Text);

                        if (rbtSocioSi.Checked == true)
                        { 
                            productor.Socio = rbtSocioSi.Text;
                        }
                        else
                        { 
                            productor.Socio = rbtSocioNo.Text;
                        }

                        productor.UnidadProductiva.Id = Convert.ToInt32(cmbUnidadProductiva.SelectedValue.ToString());

                        int returnId = FProductor.Insertar(productor);
                        if (returnId > 0)
                        {
                            Close();
                        }
                    }
                    else
                    {
                        Productor productor = new Productor();
                        productor.Id = Convert.ToInt32(txtCodigo.Text);
                        productor.Dni = txtDni.Text;
                        productor.Nombre = txtNombre.Text;
                        if (rbtSexoM.Checked == true)
                        {
                            productor.Sexo = rbtSexoM.Text;
                        }
                        else
                        { productor.Sexo = rbtSexoF.Text; }

                        productor.Edad = Convert.ToInt32(txtEdad.Text);

                        if (rbtSocioSi.Checked == true)
                        {
                            productor.Socio = rbtSocioSi.Text;
                        }
                        else
                        {
                            productor.Socio = rbtSocioNo.Text;
                        }

                        productor.UnidadProductiva.Id = Convert.ToInt32(cmbUnidadProductiva.SelectedValue.ToString());


                        int returnId = FProductor.Actualizar(productor);
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
            if (txtDni.Text == "")
            {
                resultado = "El DNI está vacio.";
                txtDni.Focus();
            }
            if (txtNombre.Text == "")
            {
                resultado = "El nombre está vacio.";
                txtNombre.Focus();
            }
            return resultado;
        }
    }
}
