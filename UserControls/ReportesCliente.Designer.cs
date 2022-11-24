
namespace New_MasterTrade.UserControls
{
    partial class ReportesCliente
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
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(223, 263);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(578, 21);
            this.comboFiltro.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "DOCUMENTO DE IDENTIDAD:";
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(223, 227);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(578, 21);
            this.comboClientes.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "CLIENTES:";
            // 
            // bttnGenerar
            // 
            this.bttnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGenerar.FlatAppearance.BorderSize = 0;
            this.bttnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGenerar.Image = global::New_MasterTrade.Properties.Resources.archivo_pdf__1_;
            this.bttnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGenerar.Location = new System.Drawing.Point(223, 299);
            this.bttnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnGenerar.Name = "bttnGenerar";
            this.bttnGenerar.Size = new System.Drawing.Size(100, 24);
            this.bttnGenerar.TabIndex = 64;
            this.bttnGenerar.Text = "GENERAR";
            this.bttnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGenerar.UseVisualStyleBackColor = false;
            this.bttnGenerar.Click += new System.EventHandler(this.bttnGenerar_Click);
            // 
            // ReportesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.bttnGenerar);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.label2);
            this.Name = "ReportesCliente";
            this.Size = new System.Drawing.Size(858, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnGenerar;
    }
}
