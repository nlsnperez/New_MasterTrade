
namespace New_MasterTrade.UserControls
{
    partial class ReportesProducto
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
            this.comboGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bttnGenerar
            // 
            this.bttnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGenerar.FlatAppearance.BorderSize = 0;
            this.bttnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGenerar.Image = global::New_MasterTrade.Properties.Resources.archivo_pdf__1_;
            this.bttnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGenerar.Location = new System.Drawing.Point(298, 394);
            this.bttnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnGenerar.Name = "bttnGenerar";
            this.bttnGenerar.Size = new System.Drawing.Size(133, 30);
            this.bttnGenerar.TabIndex = 74;
            this.bttnGenerar.Text = "GENERAR";
            this.bttnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGenerar.UseVisualStyleBackColor = false;
            this.bttnGenerar.Click += new System.EventHandler(this.bttnGenerar_Click);
            // 
            // comboGrupo
            // 
            this.comboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(298, 300);
            this.comboGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.Size = new System.Drawing.Size(769, 24);
            this.comboGrupo.TabIndex = 73;
            this.comboGrupo.SelectedIndexChanged += new System.EventHandler(this.comboGrupo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(78, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "BUSCAR POR:";
            // 
            // comboProductos
            // 
            this.comboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Location = new System.Drawing.Point(298, 254);
            this.comboProductos.Margin = new System.Windows.Forms.Padding(4);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(769, 24);
            this.comboProductos.TabIndex = 71;
            this.comboProductos.SelectedIndexChanged += new System.EventHandler(this.comboProductos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(78, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "PRODUCTOS:";
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(298, 347);
            this.comboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(769, 24);
            this.comboFiltro.TabIndex = 76;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged);
            // 
            // ReportesProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.comboProductos);
            this.Controls.Add(this.bttnGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboGrupo);
            this.Controls.Add(this.comboFiltro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportesProducto";
            this.Size = new System.Drawing.Size(1144, 678);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnGenerar;
        private System.Windows.Forms.ComboBox comboGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFiltro;
    }
}
