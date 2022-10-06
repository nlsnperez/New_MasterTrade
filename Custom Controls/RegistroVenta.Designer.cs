
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.bttnDetalles = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrden.Location = new System.Drawing.Point(133, 53);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(236, 25);
            this.lblNumeroOrden.TabIndex = 1;
            this.lblNumeroOrden.Text = "NUMERO DE ORDEN";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(134, 78);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(89, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "00/00/0000";
            // 
            // bttnDetalles
            // 
            this.bttnDetalles.FlatAppearance.BorderSize = 0;
            this.bttnDetalles.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDetalles.Location = new System.Drawing.Point(652, 45);
            this.bttnDetalles.Name = "bttnDetalles";
            this.bttnDetalles.Size = new System.Drawing.Size(90, 40);
            this.bttnDetalles.TabIndex = 30;
            this.bttnDetalles.Text = "DETALLES";
            this.bttnDetalles.UseVisualStyleBackColor = true;
            this.bttnDetalles.Click += new System.EventHandler(this.bttnDetalles_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(133, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(29, 20);
            this.lblID.TabIndex = 31;
            this.lblID.Text = "#0";
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.bttnDetalles);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumeroOrden);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistroVenta";
            this.Size = new System.Drawing.Size(770, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button bttnDetalles;
        private System.Windows.Forms.Label lblID;
    }
}
