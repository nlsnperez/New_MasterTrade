namespace New_MasterTrade.UserControls
{
    partial class VentanaReportes
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
            this.comboReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnReporte = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboMeses = new System.Windows.Forms.ComboBox();
            this.txtAgno = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboReporte
            // 
            this.comboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReporte.FormattingEnabled = true;
            this.comboReporte.Location = new System.Drawing.Point(162, 229);
            this.comboReporte.Name = "comboReporte";
            this.comboReporte.Size = new System.Drawing.Size(639, 21);
            this.comboReporte.TabIndex = 56;
            this.comboReporte.SelectedIndexChanged += new System.EventHandler(this.comboReporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "REPORTE:";
            // 
            // bttnReporte
            // 
            this.bttnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnReporte.FlatAppearance.BorderSize = 0;
            this.bttnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnReporte.Image = global::New_MasterTrade.Properties.Resources.archivo_pdf__1_;
            this.bttnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnReporte.Location = new System.Drawing.Point(162, 335);
            this.bttnReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnReporte.Name = "bttnReporte";
            this.bttnReporte.Size = new System.Drawing.Size(100, 24);
            this.bttnReporte.TabIndex = 63;
            this.bttnReporte.Text = "IMPRIMIR";
            this.bttnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnReporte.UseVisualStyleBackColor = false;
            this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(355, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 31);
            this.label9.TabIndex = 118;
            this.label9.Text = "REPORTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "DESDE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(486, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "HASTA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(486, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "AÑO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(58, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 122;
            this.label5.Text = "MES:";
            // 
            // comboMeses
            // 
            this.comboMeses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMeses.Enabled = false;
            this.comboMeses.FormattingEnabled = true;
            this.comboMeses.Location = new System.Drawing.Point(162, 300);
            this.comboMeses.Name = "comboMeses";
            this.comboMeses.Size = new System.Drawing.Size(240, 21);
            this.comboMeses.TabIndex = 123;
            // 
            // txtAgno
            // 
            this.txtAgno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgno.Enabled = false;
            this.txtAgno.Location = new System.Drawing.Point(561, 300);
            this.txtAgno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgno.MaxLength = 4;
            this.txtAgno.Name = "txtAgno";
            this.txtAgno.Size = new System.Drawing.Size(240, 20);
            this.txtAgno.TabIndex = 124;
            this.txtAgno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Enabled = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(162, 265);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(240, 20);
            this.dtpDesde.TabIndex = 125;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Enabled = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(561, 265);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(240, 20);
            this.dtpHasta.TabIndex = 126;
            // 
            // VentanaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.txtAgno);
            this.Controls.Add(this.comboMeses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bttnReporte);
            this.Controls.Add(this.comboReporte);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VentanaReportes";
            this.Size = new System.Drawing.Size(858, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnReporte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMeses;
        private System.Windows.Forms.TextBox txtAgno;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
    }
}
