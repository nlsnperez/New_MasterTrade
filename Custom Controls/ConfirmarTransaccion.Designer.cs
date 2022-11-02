
namespace New_MasterTrade.UserControls
{
    partial class ConfirmarTransaccion
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
            this.comboRazonSocial = new System.Windows.Forms.ComboBox();
            this.comboMetodoPago = new System.Windows.Forms.ComboBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnConfirmar = new System.Windows.Forms.Button();
            this.lblPersona = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTransaccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboRazonSocial
            // 
            this.comboRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRazonSocial.FormattingEnabled = true;
            this.comboRazonSocial.Location = new System.Drawing.Point(172, 111);
            this.comboRazonSocial.Name = "comboRazonSocial";
            this.comboRazonSocial.Size = new System.Drawing.Size(410, 28);
            this.comboRazonSocial.TabIndex = 0;
            // 
            // comboMetodoPago
            // 
            this.comboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMetodoPago.FormattingEnabled = true;
            this.comboMetodoPago.Location = new System.Drawing.Point(172, 188);
            this.comboMetodoPago.Name = "comboMetodoPago";
            this.comboMetodoPago.Size = new System.Drawing.Size(410, 28);
            this.comboMetodoPago.TabIndex = 1;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(396, 263);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(90, 40);
            this.bttnCancelar.TabIndex = 2;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnConfirmar
            // 
            this.bttnConfirmar.Location = new System.Drawing.Point(492, 263);
            this.bttnConfirmar.Name = "bttnConfirmar";
            this.bttnConfirmar.Size = new System.Drawing.Size(90, 40);
            this.bttnConfirmar.TabIndex = 3;
            this.bttnConfirmar.Text = "CONFIRMAR";
            this.bttnConfirmar.UseVisualStyleBackColor = true;
            this.bttnConfirmar.Click += new System.EventHandler(this.bttnConfirmar_Click);
            // 
            // lblPersona
            // 
            this.lblPersona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersona.AutoSize = true;
            this.lblPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.ForeColor = System.Drawing.Color.Black;
            this.lblPersona.Location = new System.Drawing.Point(33, 117);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(77, 16);
            this.lblPersona.TabIndex = 18;
            this.lblPersona.Text = "PERSONA:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "MÉTODO DE PAGO:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "TRANSACCIÓN:";
            // 
            // lblTransaccion
            // 
            this.lblTransaccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransaccion.AutoSize = true;
            this.lblTransaccion.BackColor = System.Drawing.Color.Transparent;
            this.lblTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaccion.ForeColor = System.Drawing.Color.Black;
            this.lblTransaccion.Location = new System.Drawing.Point(488, 46);
            this.lblTransaccion.Name = "lblTransaccion";
            this.lblTransaccion.Size = new System.Drawing.Size(94, 16);
            this.lblTransaccion.TabIndex = 21;
            this.lblTransaccion.Text = "MT00000000";
            // 
            // ConfirmarTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTransaccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.bttnConfirmar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.comboMetodoPago);
            this.Controls.Add(this.comboRazonSocial);
            this.Name = "ConfirmarTransaccion";
            this.Size = new System.Drawing.Size(600, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRazonSocial;
        private System.Windows.Forms.ComboBox comboMetodoPago;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnConfirmar;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTransaccion;
    }
}
