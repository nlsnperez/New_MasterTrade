
namespace New_MasterTrade.UserControls
{
    partial class Respaldos
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
            this.bttnGenerar = new System.Windows.Forms.Button();
            this.bttnRestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnGenerar
            // 
            this.bttnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGenerar.Location = new System.Drawing.Point(379, 224);
            this.bttnGenerar.Name = "bttnGenerar";
            this.bttnGenerar.Size = new System.Drawing.Size(100, 48);
            this.bttnGenerar.TabIndex = 0;
            this.bttnGenerar.Text = "GENERAR\r\nRESPALDO";
            this.bttnGenerar.UseVisualStyleBackColor = true;
            this.bttnGenerar.Click += new System.EventHandler(this.bttnGenerar_Click);
            // 
            // bttnRestaurar
            // 
            this.bttnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRestaurar.Location = new System.Drawing.Point(379, 278);
            this.bttnRestaurar.Name = "bttnRestaurar";
            this.bttnRestaurar.Size = new System.Drawing.Size(100, 48);
            this.bttnRestaurar.TabIndex = 1;
            this.bttnRestaurar.Text = "RESTAURAR\r\nRESPALDO";
            this.bttnRestaurar.UseVisualStyleBackColor = true;
            this.bttnRestaurar.Click += new System.EventHandler(this.bttnRestaurar_Click);
            // 
            // Respaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttnRestaurar);
            this.Controls.Add(this.bttnGenerar);
            this.Name = "Respaldos";
            this.Size = new System.Drawing.Size(858, 551);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnGenerar;
        private System.Windows.Forms.Button bttnRestaurar;
    }
}
