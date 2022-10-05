
namespace New_MasterTrade.Custom_Controls
{
    partial class RegistroVenta
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
            this.bttnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnRegistro
            // 
            this.bttnRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnRegistro.Location = new System.Drawing.Point(0, 0);
            this.bttnRegistro.Name = "bttnRegistro";
            this.bttnRegistro.Size = new System.Drawing.Size(800, 100);
            this.bttnRegistro.TabIndex = 0;
            this.bttnRegistro.Text = "REGISTRO";
            this.bttnRegistro.UseVisualStyleBackColor = true;
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.bttnRegistro);
            this.Name = "RegistroVenta";
            this.Size = new System.Drawing.Size(800, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnRegistro;
    }
}
