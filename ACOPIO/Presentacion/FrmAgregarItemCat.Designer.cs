namespace ACOPIO.Presentacion
{
    partial class FrmAgregarItemCat
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtSuri = new System.Windows.Forms.RadioButton();
            this.rbtHuacaya = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtFina = new System.Windows.Forms.RadioButton();
            this.rbtExtraFina = new System.Windows.Forms.RadioButton();
            this.rbtSemiFina = new System.Windows.Forms.RadioButton();
            this.rbtGruesa = new System.Windows.Forms.RadioButton();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(265, 244);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(69, 26);
            this.txtCantidad.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "libras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CANTIDAD:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbColor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(414, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 197);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COLOR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtSuri);
            this.groupBox2.Controls.Add(this.rbtHuacaya);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 197);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAZA";
            // 
            // rbtSuri
            // 
            this.rbtSuri.AutoSize = true;
            this.rbtSuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSuri.Location = new System.Drawing.Point(28, 78);
            this.rbtSuri.Name = "rbtSuri";
            this.rbtSuri.Size = new System.Drawing.Size(80, 35);
            this.rbtSuri.TabIndex = 0;
            this.rbtSuri.Text = "Suri";
            this.rbtSuri.UseVisualStyleBackColor = true;
            // 
            // rbtHuacaya
            // 
            this.rbtHuacaya.AutoSize = true;
            this.rbtHuacaya.Checked = true;
            this.rbtHuacaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtHuacaya.Location = new System.Drawing.Point(28, 34);
            this.rbtHuacaya.Name = "rbtHuacaya";
            this.rbtHuacaya.Size = new System.Drawing.Size(140, 35);
            this.rbtHuacaya.TabIndex = 0;
            this.rbtHuacaya.TabStop = true;
            this.rbtHuacaya.Text = "Huacaya";
            this.rbtHuacaya.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(253, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 38);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtGruesa);
            this.groupBox1.Controls.Add(this.rbtSemiFina);
            this.groupBox1.Controls.Add(this.rbtFina);
            this.groupBox1.Controls.Add(this.rbtExtraFina);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(201, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 197);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CATEGORIA";
            // 
            // rbtFina
            // 
            this.rbtFina.AutoSize = true;
            this.rbtFina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFina.Location = new System.Drawing.Point(28, 66);
            this.rbtFina.Name = "rbtFina";
            this.rbtFina.Size = new System.Drawing.Size(85, 35);
            this.rbtFina.TabIndex = 0;
            this.rbtFina.Text = "Fina";
            this.rbtFina.UseVisualStyleBackColor = true;
            // 
            // rbtExtraFina
            // 
            this.rbtExtraFina.AutoSize = true;
            this.rbtExtraFina.Checked = true;
            this.rbtExtraFina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtExtraFina.Location = new System.Drawing.Point(28, 25);
            this.rbtExtraFina.Name = "rbtExtraFina";
            this.rbtExtraFina.Size = new System.Drawing.Size(155, 35);
            this.rbtExtraFina.TabIndex = 0;
            this.rbtExtraFina.TabStop = true;
            this.rbtExtraFina.Text = "Extra Fina";
            this.rbtExtraFina.UseVisualStyleBackColor = true;
            // 
            // rbtSemiFina
            // 
            this.rbtSemiFina.AutoSize = true;
            this.rbtSemiFina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSemiFina.Location = new System.Drawing.Point(28, 107);
            this.rbtSemiFina.Name = "rbtSemiFina";
            this.rbtSemiFina.Size = new System.Drawing.Size(153, 35);
            this.rbtSemiFina.TabIndex = 0;
            this.rbtSemiFina.Text = "Semi Fina";
            this.rbtSemiFina.UseVisualStyleBackColor = true;
            // 
            // rbtGruesa
            // 
            this.rbtGruesa.AutoSize = true;
            this.rbtGruesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGruesa.Location = new System.Drawing.Point(28, 148);
            this.rbtGruesa.Name = "rbtGruesa";
            this.rbtGruesa.Size = new System.Drawing.Size(121, 35);
            this.rbtGruesa.TabIndex = 0;
            this.rbtGruesa.Text = "Gruesa";
            this.rbtGruesa.UseVisualStyleBackColor = true;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(24, 38);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 28);
            this.cmbColor.TabIndex = 0;
            // 
            // FrmAgregarItemCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmAgregarItemCat";
            this.Text = "FrmAgregarItemCat";
            this.Load += new System.EventHandler(this.FrmAgregarItemCat_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtSuri;
        private System.Windows.Forms.RadioButton rbtHuacaya;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtGruesa;
        private System.Windows.Forms.RadioButton rbtSemiFina;
        private System.Windows.Forms.RadioButton rbtFina;
        private System.Windows.Forms.RadioButton rbtExtraFina;
        private System.Windows.Forms.ComboBox cmbColor;
    }
}