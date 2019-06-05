using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ACOPIO.Entidad;
using ACOPIO.Datos;

namespace ACOPIO.Presentacion
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private string nombreUsuario = "";
        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            nombreUsuario  = Interaction.InputBox("Escriba su nuevo nombre de usuario: ", "Cambiar Nombre de Usuario", Usuario.NombreUsuario, -1, -1);

            if (nombreUsuario!="")
            {
                int returnId = FUsuario.ActualizarNombreUsuario(Usuario.Id, nombreUsuario);

                MessageBox.Show("Nombre de usuario modificado corréctamente.");
            }
            
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Usuario.NombreUsuario;
            txtContrasena.Text = "******";
        }

        private string clave = "";
        private void btnEditarClave_Click(object sender, EventArgs e)
        {
            clave = Interaction.InputBox("Escriba su nueva clave: ", "Cambiando clave", "*******", -1, -1);

            if (clave != "")
            {
                int returnId = FUsuario.ActualizarClaveUsuario(Usuario.Id, clave);

                MessageBox.Show("Clave modificado corréctamente.");
            }
        }
    }

}
