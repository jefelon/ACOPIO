namespace ACOPIO.Presentacion
{
    partial class RptAcopioFechasProveedor
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
            this.cmbProductor = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.RptAcopiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReporte = new ACOPIO.Presentacion.dsReporte();
            this.RptAcopiosTableAdapter = new ACOPIO.Presentacion.dsReporteTableAdapters.RptAcopiosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RptAcopiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductor
            // 
            this.cmbProductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductor.FormattingEnabled = true;
            this.cmbProductor.Location = new System.Drawing.Point(499, 10);
            this.cmbProductor.Name = "cmbProductor";
            this.cmbProductor.Size = new System.Drawing.Size(234, 21);
            this.cmbProductor.TabIndex = 12;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(298, 12);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(101, 20);
            this.dtpHasta.TabIndex = 10;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(124, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(101, 20);
            this.dtpDesde.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DESDE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PROVEEDOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "HASTA:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RptAcopiosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ACOPIO.Presentacion.RtpAcopioFechasPorProductor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(817, 491);
            this.reportViewer1.TabIndex = 13;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(754, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // RptAcopiosBindingSource
            // 
            this.RptAcopiosBindingSource.DataMember = "RptAcopios";
            this.RptAcopiosBindingSource.DataSource = this.dsReporte;
            // 
            // dsReporte
            // 
            this.dsReporte.DataSetName = "dsReporte";
            this.dsReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RptAcopiosTableAdapter
            // 
            this.RptAcopiosTableAdapter.ClearBeforeFill = true;
            // 
            // RptAcopioFechasProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 565);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmbProductor);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RptAcopioFechasProveedor";
            this.Text = "RptAcopioFechasProductor";
            this.Load += new System.EventHandler(this.RptAcopioFechasProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RptAcopiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductor;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.BindingSource RptAcopiosBindingSource;
        private dsReporte dsReporte;
        private dsReporteTableAdapters.RptAcopiosTableAdapter RptAcopiosTableAdapter;
    }
}