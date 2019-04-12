namespace ACOPIO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeAcopioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preciosOfertadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloAcopioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloCategorizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteConsolidadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimpresiónDeReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGeneralTodosLosAcopiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCopiaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAcopioPorProvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centrosDeAcopioToolStripMenuItem,
            this.productoresToolStripMenuItem,
            this.campañasToolStripMenuItem,
            this.coloresToolStripMenuItem,
            this.preciosOfertadosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // centrosDeAcopioToolStripMenuItem
            // 
            this.centrosDeAcopioToolStripMenuItem.Name = "centrosDeAcopioToolStripMenuItem";
            this.centrosDeAcopioToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.centrosDeAcopioToolStripMenuItem.Text = "Centros de Acopio";
            this.centrosDeAcopioToolStripMenuItem.Click += new System.EventHandler(this.centrosDeAcopioToolStripMenuItem_Click);
            // 
            // productoresToolStripMenuItem
            // 
            this.productoresToolStripMenuItem.Name = "productoresToolStripMenuItem";
            this.productoresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.productoresToolStripMenuItem.Text = "Productores";
            this.productoresToolStripMenuItem.Click += new System.EventHandler(this.productoresToolStripMenuItem_Click);
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.campañasToolStripMenuItem.Text = "Campañas";
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.coloresToolStripMenuItem.Text = "Colores";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // preciosOfertadosToolStripMenuItem
            // 
            this.preciosOfertadosToolStripMenuItem.Name = "preciosOfertadosToolStripMenuItem";
            this.preciosOfertadosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.preciosOfertadosToolStripMenuItem.Text = "Precios Ofertados";
            this.preciosOfertadosToolStripMenuItem.Click += new System.EventHandler(this.preciosOfertadosToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloAcopioToolStripMenuItem,
            this.moduloCategorizaciónToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // moduloAcopioToolStripMenuItem
            // 
            this.moduloAcopioToolStripMenuItem.Name = "moduloAcopioToolStripMenuItem";
            this.moduloAcopioToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.moduloAcopioToolStripMenuItem.Text = "Modulo Acopio";
            this.moduloAcopioToolStripMenuItem.Click += new System.EventHandler(this.moduloAcopioToolStripMenuItem_Click);
            // 
            // moduloCategorizaciónToolStripMenuItem
            // 
            this.moduloCategorizaciónToolStripMenuItem.Name = "moduloCategorizaciónToolStripMenuItem";
            this.moduloCategorizaciónToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.moduloCategorizaciónToolStripMenuItem.Text = "Modulo Categorización";
            this.moduloCategorizaciónToolStripMenuItem.Click += new System.EventHandler(this.moduloCategorizaciónToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteConsolidadoToolStripMenuItem,
            this.reimpresiónDeReporteToolStripMenuItem,
            this.reporteGeneralTodosLosAcopiosToolStripMenuItem,
            this.reporteAcopioPorProvedorToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteConsolidadoToolStripMenuItem
            // 
            this.reporteConsolidadoToolStripMenuItem.Name = "reporteConsolidadoToolStripMenuItem";
            this.reporteConsolidadoToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.reporteConsolidadoToolStripMenuItem.Text = "Reporte consolidado";
            this.reporteConsolidadoToolStripMenuItem.Click += new System.EventHandler(this.reporteConsolidadoToolStripMenuItem_Click);
            // 
            // reimpresiónDeReporteToolStripMenuItem
            // 
            this.reimpresiónDeReporteToolStripMenuItem.Name = "reimpresiónDeReporteToolStripMenuItem";
            this.reimpresiónDeReporteToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.reimpresiónDeReporteToolStripMenuItem.Text = "Reimpresión de reporte";
            this.reimpresiónDeReporteToolStripMenuItem.Click += new System.EventHandler(this.reimpresiónDeReporteToolStripMenuItem_Click);
            // 
            // reporteGeneralTodosLosAcopiosToolStripMenuItem
            // 
            this.reporteGeneralTodosLosAcopiosToolStripMenuItem.Name = "reporteGeneralTodosLosAcopiosToolStripMenuItem";
            this.reporteGeneralTodosLosAcopiosToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.reporteGeneralTodosLosAcopiosToolStripMenuItem.Text = "Reporte general(Todos los acopios)";
            this.reporteGeneralTodosLosAcopiosToolStripMenuItem.Click += new System.EventHandler(this.reporteGeneralTodosLosAcopiosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCopiaBaseDeDatosToolStripMenuItem,
            this.restaurarBaseDeDatosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // crearCopiaBaseDeDatosToolStripMenuItem
            // 
            this.crearCopiaBaseDeDatosToolStripMenuItem.Name = "crearCopiaBaseDeDatosToolStripMenuItem";
            this.crearCopiaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.crearCopiaBaseDeDatosToolStripMenuItem.Text = "Crear Copia base de datos";
            this.crearCopiaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.crearCopiaBaseDeDatosToolStripMenuItem_Click);
            // 
            // restaurarBaseDeDatosToolStripMenuItem
            // 
            this.restaurarBaseDeDatosToolStripMenuItem.Name = "restaurarBaseDeDatosToolStripMenuItem";
            this.restaurarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.restaurarBaseDeDatosToolStripMenuItem.Text = "Restaurar Base de datos";
            this.restaurarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.restaurarBaseDeDatosToolStripMenuItem_Click);
            // 
            // reporteAcopioPorProvedorToolStripMenuItem
            // 
            this.reporteAcopioPorProvedorToolStripMenuItem.Name = "reporteAcopioPorProvedorToolStripMenuItem";
            this.reporteAcopioPorProvedorToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.reporteAcopioPorProvedorToolStripMenuItem.Text = "Reporte Acopio Por Provedor";
            this.reporteAcopioPorProvedorToolStripMenuItem.Click += new System.EventHandler(this.reporteAcopioPorProvedorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACOPIO.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 455);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centrosDeAcopioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloAcopioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloCategorizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteConsolidadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preciosOfertadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCopiaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reimpresiónDeReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGeneralTodosLosAcopiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAcopioPorProvedorToolStripMenuItem;
    }
}

