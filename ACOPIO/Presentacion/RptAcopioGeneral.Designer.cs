namespace ACOPIO.Presentacion
{
    partial class RptAcopioGeneral
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
            this.dsReporte = new ACOPIO.Presentacion.dsReporte();
            this.RptAcopiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RptAcopiosTableAdapter = new ACOPIO.Presentacion.dsReporteTableAdapters.RptAcopiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RptAcopiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RptAcopiosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ACOPIO.Presentacion.RtpAcopioGeneral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1004, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsReporte
            // 
            this.dsReporte.DataSetName = "dsReporte";
            this.dsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RptAcopiosBindingSource
            // 
            this.RptAcopiosBindingSource.DataMember = "RptAcopios";
            this.RptAcopiosBindingSource.DataSource = this.dsReporte;
            // 
            // RptAcopiosTableAdapter
            // 
            this.RptAcopiosTableAdapter.ClearBeforeFill = true;
            // 
            // RptAcopioGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RptAcopioGeneral";
            this.Text = "RptAcopioGeneral";
            this.Load += new System.EventHandler(this.RptAcopioGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RptAcopiosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RptAcopiosBindingSource;
        private dsReporte dsReporte;
        private dsReporteTableAdapters.RptAcopiosTableAdapter RptAcopiosTableAdapter;
    }
}