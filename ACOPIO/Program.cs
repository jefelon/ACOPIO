using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ACOPIO.Presentacion;

namespace ACOPIO
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
                Application.Run(new Form1());
        }
    }
}
