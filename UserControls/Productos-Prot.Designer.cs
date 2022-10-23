namespace New_MasterTrade.UserControls
{
    partial class Productos_Prot
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(771, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 22);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1025, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(20, 90);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(300, 300);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 4;
            this.pbImagen.TabStop = false;
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregar.Location = new System.Drawing.Point(20, 406);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(137, 35);
            this.bttnAgregar.TabIndex = 5;
            this.bttnAgregar.Text = "AGREGAR";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar.Location = new System.Drawing.Point(183, 406);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(137, 35);
            this.bttnEliminar.TabIndex = 6;
            this.bttnEliminar.Text = "ELIMINAR";
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID PRODUCTO";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(494, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 22);
            this.txtID.TabIndex = 9;
            this.txtID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(494, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(494, 187);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(246, 166);
            this.txtDescripcion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "MARCA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "CATEGORÍA";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Location = new System.Drawing.Point(494, 485);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(246, 22);
            this.txtPrecioVenta.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "PRECIO DE VENTA";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Location = new System.Drawing.Point(494, 535);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(246, 22);
            this.txtPrecioCompra.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "PRECIO DE COMPRA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(494, 585);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(246, 22);
            this.txtCantidad.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "CANTIDAD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(770, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "ESTADO";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(494, 381);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(246, 24);
            this.comboMarca.TabIndex = 28;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(494, 433);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(246, 24);
            this.comboCategoria.TabIndex = 29;
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(882, 86);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(246, 24);
            this.comboEstado.TabIndex = 30;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(19, 629);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 30);
            this.button4.TabIndex = 32;
            this.button4.Text = "GUARDAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(140, 629);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 30);
            this.button5.TabIndex = 33;
            this.button5.Text = "ACTUALIZAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(261, 629);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 30);
            this.button6.TabIndex = 34;
            this.button6.Text = "ELIMINAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            this.openImage.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // Productos_Prot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Productos_Prot";
            this.Size = new System.Drawing.Size(1144, 678);
            this.Load += new System.EventHandler(this.Productos_Prot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openImage;
    }
}
