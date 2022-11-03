
namespace New_MasterTrade.Custom_Controls
{
    partial class RecuperarContrasegna
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnAceptar = new System.Windows.Forms.Button();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Location = new System.Drawing.Point(475, 95);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(85, 24);
            this.bttnCancelar.TabIndex = 65;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnAceptar
            // 
            this.bttnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAceptar.Location = new System.Drawing.Point(566, 95);
            this.bttnAceptar.Name = "bttnAceptar";
            this.bttnAceptar.Size = new System.Drawing.Size(85, 24);
            this.bttnAceptar.TabIndex = 64;
            this.bttnAceptar.Text = "ACEPTAR";
            this.bttnAceptar.UseVisualStyleBackColor = true;
            this.bttnAceptar.Click += new System.EventHandler(this.bttnAceptar_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametro.Location = new System.Drawing.Point(300, 56);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(351, 20);
            this.txtParametro.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "NOMBRE DE USUARIO O CORREO ELECTRÓNICO:";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnAceptar);
            this.Name = "RecuperarContraseña";
            this.Size = new System.Drawing.Size(671, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnAceptar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label label2;
    }
}
