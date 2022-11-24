
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnGenerar
            // 
            this.bttnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGenerar.FlatAppearance.BorderSize = 0;
            this.bttnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGenerar.Image = global::New_MasterTrade.Properties.Resources.archivo_pdf__1_;
            this.bttnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGenerar.Location = new System.Drawing.Point(223, 117);
            this.bttnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnGenerar.Name = "bttnGenerar";
            this.bttnGenerar.Size = new System.Drawing.Size(100, 24);
            this.bttnGenerar.TabIndex = 74;
            this.bttnGenerar.Text = "GENERAR";
            this.bttnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGenerar.UseVisualStyleBackColor = false;
            this.bttnGenerar.Click += new System.EventHandler(this.bttnGenerar_Click);
            // 
            // combocategoria
            // 
            this.combocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.Location = new System.Drawing.Point(223, 62);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(578, 21);
            this.combocategoria.TabIndex = 73;
            this.combocategoria.SelectedIndexChanged += new System.EventHandler(this.combocategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "CATEGORÍA:";
            // 
            // comboProductos
            // 
            this.comboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Location = new System.Drawing.Point(223, 24);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(578, 21);
            this.comboProductos.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "PRODUCTOS:";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(223, 100);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(578, 21);
            this.comboMarca.TabIndex = 76;
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.comboMarca_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(58, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "MARCA:";
            // 
            // comboModelo
            // 
            this.comboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(223, 138);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(578, 21);
            this.comboModelo.TabIndex = 78;
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.comboModelo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(58, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "MODELO:";
            // 
            // comboPrecioCompra
            // 
            this.comboPrecioCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrecioCompra.FormattingEnabled = true;
            this.comboPrecioCompra.Location = new System.Drawing.Point(223, 41);
            this.comboPrecioCompra.Name = "comboPrecioCompra";
            this.comboPrecioCompra.Size = new System.Drawing.Size(578, 21);
            this.comboPrecioCompra.TabIndex = 80;
            this.comboPrecioCompra.SelectedIndexChanged += new System.EventHandler(this.comboPrecioCompra_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(58, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "PRECIO DE COMPRA:";
            // 
            // comboPrecioVenta
            // 
            this.comboPrecioVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrecioVenta.FormattingEnabled = true;
            this.comboPrecioVenta.Location = new System.Drawing.Point(223, 79);
            this.comboPrecioVenta.Name = "comboPrecioVenta";
            this.comboPrecioVenta.Size = new System.Drawing.Size(578, 21);
            this.comboPrecioVenta.TabIndex = 82;
            this.comboPrecioVenta.SelectedIndexChanged += new System.EventHandler(this.comboPrecioVenta_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(58, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "PRECIO DE VENTA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboProductos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.combocategoria);
            this.panel1.Controls.Add(this.comboModelo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboMarca);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 183);
            this.panel1.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bttnGenerar);
            this.panel2.Controls.Add(this.comboPrecioVenta);
            this.panel2.Controls.Add(this.comboPrecioCompra);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 183);
            this.panel2.TabIndex = 84;
            // 
            // ReportesProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportesProducto";
            this.Size = new System.Drawing.Size(858, 551);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
