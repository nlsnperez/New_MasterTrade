namespace New_MasterTrade.Custom_Controls
{
    partial class ConfirmarFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboMetodoPago = new System.Windows.Forms.ComboBox();
            this.comboImpuesto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtCantidadImpuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÉTODO DE PAGO:";
            // 
            // comboMetodoPago
            // 
            this.comboMetodoPago.FormattingEnabled = true;
            this.comboMetodoPago.Location = new System.Drawing.Point(361, 15);
            this.comboMetodoPago.Name = "comboMetodoPago";
            this.comboMetodoPago.Size = new System.Drawing.Size(287, 24);
            this.comboMetodoPago.TabIndex = 1;
            // 
            // comboImpuesto
            // 
            this.comboImpuesto.FormattingEnabled = true;
            this.comboImpuesto.Location = new System.Drawing.Point(361, 76);
            this.comboImpuesto.Name = "comboImpuesto";
            this.comboImpuesto.Size = new System.Drawing.Size(81, 24);
            this.comboImpuesto.TabIndex = 3;
            this.comboImpuesto.SelectedIndexChanged += new System.EventHandler(this.comboImpuesto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "IMPUESTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(361, 134);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(287, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(448, 78);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(200, 22);
            this.txtImpuesto.TabIndex = 7;
            // 
            // txtCantidadImpuesto
            // 
            this.txtCantidadImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadImpuesto.Enabled = false;
            this.txtCantidadImpuesto.Location = new System.Drawing.Point(361, 106);
            this.txtCantidadImpuesto.Name = "txtCantidadImpuesto";
            this.txtCantidadImpuesto.Size = new System.Drawing.Size(287, 22);
            this.txtCantidadImpuesto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "CANTIDAD DE IMPUESTO:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(361, 45);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(287, 22);
            this.txtSubTotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "SUBTOTAL";
            // 
            // ConfirmarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidadImpuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboImpuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMetodoPago);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmarFactura";
            this.Size = new System.Drawing.Size(800, 246);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMetodoPago;
        private System.Windows.Forms.ComboBox comboImpuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtCantidadImpuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label6;
    }
}
