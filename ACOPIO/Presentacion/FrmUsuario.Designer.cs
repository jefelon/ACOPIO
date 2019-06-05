namespace ACOPIO.Presentacion
{
    partial class FrmUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnEditarUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnEditarClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(108, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnEditarUser
            // 
            this.btnEditarUser.Location = new System.Drawing.Point(275, 39);
            this.btnEditarUser.Name = "btnEditarUser";
            this.btnEditarUser.Size = new System.Drawing.Size(45, 23);
            this.btnEditarUser.TabIndex = 2;
            this.btnEditarUser.Text = "Editar";
            this.btnEditarUser.UseVisualStyleBackColor = true;
            this.btnEditarUser.Click += new System.EventHandler(this.btnEditarUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(108, 84);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(149, 20);
            this.txtContrasena.TabIndex = 1;
            // 
            // btnEditarClave
            // 
            this.btnEditarClave.Location = new System.Drawing.Point(275, 82);
            this.btnEditarClave.Name = "btnEditarClave";
            this.btnEditarClave.Size = new System.Drawing.Size(45, 23);
            this.btnEditarClave.TabIndex = 2;
            this.btnEditarClave.Text = "Editar";
            this.btnEditarClave.UseVisualStyleBackColor = true;
            this.btnEditarClave.Click += new System.EventHandler(this.btnEditarClave_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 144);
            this.Controls.Add(this.btnEditarClave);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.btnEditarUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEditarUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnEditarClave;
    }
}