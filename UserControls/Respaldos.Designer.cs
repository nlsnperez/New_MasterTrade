
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
            this.bttnRestaurar = new System.Windows.Forms.Button();
            this.bttnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnRestaurar
            // 
            this.bttnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRestaurar.Image = global::New_MasterTrade.Properties.Resources.importar;
            this.bttnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnRestaurar.Location = new System.Drawing.Point(323, 278);
            this.bttnRestaurar.Name = "bttnRestaurar";
            this.bttnRestaurar.Size = new System.Drawing.Size(212, 78);
            this.bttnRestaurar.TabIndex = 1;
            this.bttnRestaurar.Text = "IMPORTAR BASE\r\nDE DATOS";
            this.bttnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnRestaurar.UseVisualStyleBackColor = false;
            this.bttnRestaurar.Click += new System.EventHandler(this.bttnRestaurar_Click);
            // 
            // bttnGenerar
            // 
            this.bttnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGenerar.Image = global::New_MasterTrade.Properties.Resources.export;
            this.bttnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGenerar.Location = new System.Drawing.Point(323, 194);
            this.bttnGenerar.Name = "bttnGenerar";
            this.bttnGenerar.Size = new System.Drawing.Size(212, 78);
            this.bttnGenerar.TabIndex = 0;
            this.bttnGenerar.Text = "EXPORTAR BASE\r\nDE DATOS";
            this.bttnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGenerar.UseVisualStyleBackColor = false;
            this.bttnGenerar.Click += new System.EventHandler(this.bttnGenerar_Click);
            // 
            // Respaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
