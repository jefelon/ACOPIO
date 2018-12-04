using ACOPIO.Datos;
using ACOPIO.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACOPIO.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtNombreUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();

                DataSet ds = FUsuario.iniciarSesion(usuario, contrasena);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no existe. Digitar correctamente el usuario y/o contraseña.", "ERROR DE INICIO DE SECION");
                }
                if (dt.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    Usuario.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                    Usuario.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                    Usuario.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                    Usuario.Tipo = dt.Rows[0]["Tipo"].ToString();
                    Usuario.CentroAcopioId =Convert.ToInt32(cmbCentroAcopio.SelectedValue.ToString());

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DataSet ds2 = FCentroAcopio.GetAll();
            DataTable dt2 = ds2.Tables[0];
            cmbCentroAcopio.ValueMember = "Id";
            cmbCentroAcopio.DisplayMember = "Nombre";
            cmbCentroAcopio.DataSource = dt2;
            cmbCentroAcopio.SelectedValue = Usuario.CentroAcopioId;
        }
    }
}
