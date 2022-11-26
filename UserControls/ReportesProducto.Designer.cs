
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
            this.combocategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPrecioCompra = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPrecioVenta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkParametros = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bttnGenerar
            // 
            this.bttnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGenerar.FlatAppearance.BorderSize = 0;
            this.bttnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGenerar.Image = global::New_MasterTrade.Properties.Resources.archivo_pdf__1_;
            this.bttnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGenerar.Location = new System.Drawing.Point(298, 463);
            this.bttnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnGenerar.Name = "bttnGenerar";
            this.bttnGenerar.Size = new System.Drawing.Size(133, 30);
            this.bttnGenerar.TabIndex = 74;
            this.bttnGenerar.Text = "GENERAR";
            this.bttnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGenerar.UseVisualStyleBackColor = false;
            this.bttnGenerar.Click += new System.EventHandler(this.bttnGenerar_Click);
            // 
            // combocategoria
            // 
            this.combocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategoria.Enabled = false;
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.Location = new System.Drawing.Point(298, 231);
            this.combocategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(769, 24);
            this.combocategoria.TabIndex = 73;
            this.combocategoria.SelectedIndexChanged += new System.EventHandler(this.combocategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(78, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "CATEGORÍA:";
            // 
            // comboProductos
            // 
            this.comboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProductos.Enabled = false;
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Location = new System.Drawing.Point(298, 185);
            this.comboProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(769, 24);
            this.comboProductos.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(78, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "PRODUCTOS:";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.Enabled = false;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(298, 278);
            this.comboMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(769, 24);
            this.comboMarca.TabIndex = 76;
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.comboMarca_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(78, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "MARCA:";
            // 
            // comboModelo
            // 
            this.comboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModelo.Enabled = false;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(298, 325);
            this.comboModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(769, 24);
            this.comboModelo.TabIndex = 78;
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.comboModelo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(78, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "MODELO:";
            // 
            // comboPrecioCompra
            // 
            this.comboPrecioCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrecioCompra.Enabled = false;
            this.comboPrecioCompra.FormattingEnabled = true;
            this.comboPrecioCompra.Location = new System.Drawing.Point(298, 369);
            this.comboPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPrecioCompra.Name = "comboPrecioCompra";
            this.comboPrecioCompra.Size = new System.Drawing.Size(769, 24);
            this.comboPrecioCompra.TabIndex = 80;
            this.comboPrecioCompra.SelectedIndexChanged += new System.EventHandler(this.comboPrecioCompra_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(78, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "PRECIO DE COMPRA:";
            // 
            // comboPrecioVenta
            // 
            this.comboPrecioVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrecioVenta.Enabled = false;
            this.comboPrecioVenta.FormattingEnabled = true;
            this.comboPrecioVenta.Location = new System.Drawing.Point(298, 416);
            this.comboPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPrecioVenta.Name = "comboPrecioVenta";
            this.comboPrecioVenta.Size = new System.Drawing.Size(769, 24);
            this.comboPrecioVenta.TabIndex = 82;
            this.comboPrecioVenta.SelectedIndexChanged += new System.EventHandler(this.comboPrecioVenta_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(78, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "PRECIO DE VENTA:";
            // 
            // checkParametros
            // 
            this.checkParametros.AutoSize = true;
            this.checkParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkParametros.ForeColor = System.Drawing.SystemColors.Control;
            this.checkParametros.Location = new System.Drawing.Point(298, 139);
            this.checkParametros.Name = "checkParametros";
            this.checkParametros.Size = new System.Drawing.Size(161, 20);
            this.checkParametros.TabIndex = 83;
            this.checkParametros.Text = "USAR PARÁMETROS";
            this.checkParametros.UseVisualStyleBackColor = true;
            this.checkParametros.CheckedChanged += new System.EventHandler(this.checkParametros_CheckedChanged);
            // 
            // ReportesProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.checkParametros);
            this.Controls.Add(this.comboProductos);
            this.Controls.Add(this.bttnGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPrecioVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combocategoria);
            this.Controls.Add(this.comboPrecioCompra);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboMarca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportesProducto";
            this.Size = new System.Drawing.Size(1144, 678);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnGenerar;
        private System.Windows.Forms.ComboBox combocategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPrecioCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPrecioVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkParametros;
    }
}
