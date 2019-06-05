namespace ACOPIO.Presentacion
{
    partial class rep
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CategorizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReporte = new ACOPIO.Presentacion.dsReporte();
            this.CategorizacionTableAdapter = new ACOPIO.Presentacion.dsReporteTableAdapters.CategorizacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CategorizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReporte";
            reportDataSource1.Value = this.CategorizacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ACOPIO.Presentacion.RptConsolidado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(845, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // CategorizacionBindingSource
            // 
            this.CategorizacionBindingSource.DataMember = "Categorizacion";
            this.CategorizacionBindingSource.DataSource = this.dsReporte;
            // 
            // dsReporte
            // 
            this.dsReporte.DataSetName = "dsReporte";
            this.dsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CategorizacionTableAdapter
            // 
            this.CategorizacionTableAdapter.ClearBeforeFill = true;
            // 
            // rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 468);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rep";
            this.Text = "rep";
            this.Load += new System.EventHandler(this.rep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategorizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CategorizacionBindingSource;
        private dsReporte dsReporte;
        private dsReporteTableAdapters.CategorizacionTableAdapter CategorizacionTableAdapter;
    }
}