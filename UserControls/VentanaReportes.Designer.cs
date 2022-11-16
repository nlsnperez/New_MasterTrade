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
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpDesde = new System.Windows.Forms.DateTimePicker();
            this.dpHasta = new System.Windows.Forms.DateTimePicker();
            this.bttnReporte = new System.Windows.Forms.Button();
            this.panelPerzonalizado = new System.Windows.Forms.Panel();
            this.panelPerzonalizado.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboReporte
            // 
            this.comboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReporte.FormattingEnabled = true;
            this.comboReporte.Location = new System.Drawing.Point(216, 257);
            this.comboReporte.Margin = new System.Windows.Forms.Padding(4);
            this.comboReporte.Name = "comboReporte";
            this.comboReporte.Size = new System.Drawing.Size(851, 24);
            this.comboReporte.TabIndex = 56;
            this.comboReporte.SelectedIndexChanged += new System.EventHandler(this.comboReporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "REPORTE:";
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(216, 302);
            this.comboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(851, 24);
            this.comboFiltro.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "DELIMITACIÓN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "DESDE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(289, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "HASTA:";
            // 
            // dpDesde
            // 
            this.dpDesde.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dpDesde.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dpDesde.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.dpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDesde.Location = new System.Drawing.Point(75, 15);
            this.dpDesde.Name = "dpDesde";
            this.dpDesde.Size = new System.Drawing.Size(200, 24);
            this.dpDesde.TabIndex = 61;
            // 
            // dpHasta
            // 
            this.dpHasta.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dpHasta.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dpHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.dpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpHasta.Location = new System.Drawing.Point(359, 15);
            this.dpHasta.Name = "dpHasta";
            this.dpHasta.Size = new System.Drawing.Size(200, 24);
            this.dpHasta.TabIndex = 62;
            // 
            // bttnReporte
            // 
            this.bttnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnReporte.FlatAppearance.BorderSize = 0;
            this.bttnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnReporte.Image = global::New_MasterTrade.Properties.Resources.archivo_pdf__1_;
            this.bttnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnReporte.Location = new System.Drawing.Point(216, 392);
            this.bttnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnReporte.Name = "bttnReporte";
            this.bttnReporte.Size = new System.Drawing.Size(133, 30);
            this.bttnReporte.TabIndex = 63;
            this.bttnReporte.Text = "IMPRIMIR";
            this.bttnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnReporte.UseVisualStyleBackColor = false;
            this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
            // 
            // panelPerzonalizado
            // 
            this.panelPerzonalizado.Controls.Add(this.dpHasta);
            this.panelPerzonalizado.Controls.Add(this.label3);
            this.panelPerzonalizado.Controls.Add(this.dpDesde);
            this.panelPerzonalizado.Controls.Add(this.label4);
            this.panelPerzonalizado.Location = new System.Drawing.Point(216, 333);
            this.panelPerzonalizado.Name = "panelPerzonalizado";
            this.panelPerzonalizado.Size = new System.Drawing.Size(851, 54);
            this.panelPerzonalizado.TabIndex = 64;
            // 
            // VentanaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.bttnReporte);
            this.Controls.Add(this.panelPerzonalizado);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboReporte);
            this.Controls.Add(this.label2);
            this.Name = "VentanaReportes";
            this.Size = new System.Drawing.Size(1144, 678);
            this.panelPerzonalizado.ResumeLayout(false);
            this.panelPerzonalizado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpDesde;
        private System.Windows.Forms.DateTimePicker dpHasta;
        private System.Windows.Forms.Button bttnReporte;
        private System.Windows.Forms.Panel panelPerzonalizado;
    }
}
