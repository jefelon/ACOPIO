namespace ACOPIO.Presentacion
{
    partial class FrmImpresionAcopio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReporte = new ACOPIO.Presentacion.dsReporte();
            this.AcopioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AcopioTableAdapter = new ACOPIO.Presentacion.dsReporteTableAdapters.AcopioTableAdapter();
            this.DetalleAcopioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleAcopioTableAdapter = new ACOPIO.Presentacion.dsReporteTableAdapters.DetalleAcopioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcopioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAcopioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Acopio";
            reportDataSource1.Value = this.AcopioBindingSource;
            reportDataSource2.Name = "DetalleAcopio";
            reportDataSource2.Value = this.DetalleAcopioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ACOPIO.Presentacion.Acopio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(737, 552);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsReporte
            // 
            this.dsReporte.DataSetName = "dsReporte";
            this.dsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AcopioBindingSource
            // 
            this.AcopioBindingSource.DataMember = "Acopio";
            this.AcopioBindingSource.DataSource = this.dsReporte;
            // 
            // AcopioTableAdapter
            // 
            this.AcopioTableAdapter.ClearBeforeFill = true;
            // 
            // DetalleAcopioBindingSource
            // 
            this.DetalleAcopioBindingSource.DataMember = "DetalleAcopio";
            this.DetalleAcopioBindingSource.DataSource = this.dsReporte;
            // 
            // DetalleAcopioTableAdapter
            // 
            this.DetalleAcopioTableAdapter.ClearBeforeFill = true;
            // 
            // ImpresionAcopio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 552);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ImpresionAcopio";
            this.Text = "ImpresionAcopio";
            this.Load += new System.EventHandler(this.ImpresionAcopio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcopioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAcopioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AcopioBindingSource;
        private dsReporte dsReporte;
        private System.Windows.Forms.BindingSource DetalleAcopioBindingSource;
        private dsReporteTableAdapters.AcopioTableAdapter AcopioTableAdapter;
        private dsReporteTableAdapters.DetalleAcopioTableAdapter DetalleAcopioTableAdapter;
    }
}