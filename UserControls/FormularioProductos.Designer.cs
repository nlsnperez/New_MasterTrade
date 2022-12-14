﻿namespace New_MasterTrade.UserControls
{
    partial class FormularioProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
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
            this.comboGarantia = new System.Windows.Forms.ComboBox();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.bttnAtras = new System.Windows.Forms.Button();
            this.bttnModelo = new System.Windows.Forms.Button();
            this.bttnCategoria = new System.Windows.Forms.Button();
            this.bttnMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(347, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID PRODUCTO";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtID.Location = new System.Drawing.Point(503, 87);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 22);
            this.txtID.TabIndex = 9;
            this.txtID.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtID.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Location = new System.Drawing.Point(503, 283);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(246, 22);
            this.txtSerial.TabIndex = 11;
            this.txtSerial.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            this.txtSerial.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(347, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SERIAL";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(503, 331);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(246, 166);
            this.txtDescripcion.TabIndex = 13;
            this.txtDescripcion.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(347, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(347, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "MARCA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(347, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "CATEGORÍA";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Location = new System.Drawing.Point(503, 565);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.ReadOnly = true;
            this.txtPrecioVenta.Size = new System.Drawing.Size(246, 22);
            this.txtPrecioVenta.TabIndex = 19;
            this.txtPrecioVenta.Text = "0";
            this.txtPrecioVenta.Enter += new System.EventHandler(this.txtPrecioVenta_Enter);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(347, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "PRECIO DE COMPRA\r\n(Bs)";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Location = new System.Drawing.Point(503, 517);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.ReadOnly = true;
            this.txtPrecioCompra.Size = new System.Drawing.Size(246, 22);
            this.txtPrecioCompra.TabIndex = 21;
            this.txtPrecioCompra.Text = "0";
            this.txtPrecioCompra.Enter += new System.EventHandler(this.txtPrecioCompra_Enter);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            this.txtPrecioCompra.Leave += new System.EventHandler(this.txtPrecioCompra_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(347, 565);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "PRECIO DE VENTA\r\n(Bs)";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(884, 87);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(246, 22);
            this.txtCantidad.TabIndex = 23;
            this.txtCantidad.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(800, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "CANTIDAD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(800, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "GARANTÍA";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(503, 185);
            this.comboMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(247, 24);
            this.comboMarca.TabIndex = 28;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(503, 135);
            this.comboCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(247, 24);
            this.comboCategoria.TabIndex = 29;
            // 
            // comboGarantia
            // 
            this.comboGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGarantia.FormattingEnabled = true;
            this.comboGarantia.Location = new System.Drawing.Point(884, 135);
            this.comboGarantia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboGarantia.Name = "comboGarantia";
            this.comboGarantia.Size = new System.Drawing.Size(243, 24);
            this.comboGarantia.TabIndex = 30;
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            this.openImage.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            // 
            // comboModelo
            // 
            this.comboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(503, 234);
            this.comboModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(247, 24);
            this.comboModelo.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(347, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "MODELO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(77, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "IMAGEN DEL PRODUCTO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(391, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 38);
            this.label1.TabIndex = 44;
            this.label1.Text = "REGISTRAR PRODUCTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(116)))));
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Image = global::New_MasterTrade.Properties.Resources.cancel;
            this.bttnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCancelar.Location = new System.Drawing.Point(296, 628);
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(133, 30);
            this.bttnCancelar.TabIndex = 43;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.bttnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnActualizar.Image = global::New_MasterTrade.Properties.Resources.refresh;
            this.bttnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnActualizar.Location = new System.Drawing.Point(157, 628);
            this.bttnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(133, 30);
            this.bttnActualizar.TabIndex = 41;
            this.bttnActualizar.Text = "ACTUALIZAR";
            this.bttnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(212)))), ((int)(((byte)(90)))));
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Image = global::New_MasterTrade.Properties.Resources.floppy_disk1;
            this.bttnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGuardar.Location = new System.Drawing.Point(19, 628);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(133, 30);
            this.bttnGuardar.TabIndex = 40;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(116)))));
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar.Image = global::New_MasterTrade.Properties.Resources.cancel;
            this.bttnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEliminar.Location = new System.Drawing.Point(181, 426);
            this.bttnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(137, 34);
            this.bttnEliminar.TabIndex = 6;
            this.bttnEliminar.Text = "ELIMINAR";
            this.bttnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(212)))), ((int)(((byte)(90)))));
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregar.Image = global::New_MasterTrade.Properties.Resources.plus1;
            this.bttnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAgregar.Location = new System.Drawing.Point(20, 426);
            this.bttnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(137, 34);
            this.bttnAgregar.TabIndex = 5;
            this.bttnAgregar.Text = "AGREGAR";
            this.bttnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnAgregar.UseVisualStyleBackColor = false;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Image = global::New_MasterTrade.Properties.Resources.ImagenPlaceHolder;
            this.pbImagen.Location = new System.Drawing.Point(19, 117);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(301, 300);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 4;
            this.pbImagen.TabStop = false;
            // 
            // bttnAtras
            // 
            this.bttnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAtras.Image = global::New_MasterTrade.Properties.Resources.atras;
            this.bttnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAtras.Location = new System.Drawing.Point(20, 12);
            this.bttnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAtras.Name = "bttnAtras";
            this.bttnAtras.Size = new System.Drawing.Size(107, 34);
            this.bttnAtras.TabIndex = 3;
            this.bttnAtras.Text = "ATRÁS";
            this.bttnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnAtras.UseVisualStyleBackColor = false;
            this.bttnAtras.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // bttnModelo
            // 
            this.bttnModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnModelo.Image = global::New_MasterTrade.Properties.Resources.plus1;
            this.bttnModelo.Location = new System.Drawing.Point(756, 234);
            this.bttnModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnModelo.Name = "bttnModelo";
            this.bttnModelo.Size = new System.Drawing.Size(35, 25);
            this.bttnModelo.TabIndex = 45;
            this.bttnModelo.UseVisualStyleBackColor = false;
            this.bttnModelo.Click += new System.EventHandler(this.bttnModelo_Click);
            // 
            // bttnCategoria
            // 
            this.bttnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCategoria.Image = global::New_MasterTrade.Properties.Resources.plus1;
            this.bttnCategoria.Location = new System.Drawing.Point(756, 135);
            this.bttnCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnCategoria.Name = "bttnCategoria";
            this.bttnCategoria.Size = new System.Drawing.Size(35, 25);
            this.bttnCategoria.TabIndex = 46;
            this.bttnCategoria.UseVisualStyleBackColor = false;
            this.bttnCategoria.Click += new System.EventHandler(this.bttnCategoria_Click);
            // 
            // bttnMarca
            // 
            this.bttnMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMarca.Image = global::New_MasterTrade.Properties.Resources.plus1;
            this.bttnMarca.Location = new System.Drawing.Point(756, 186);
            this.bttnMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnMarca.Name = "bttnMarca";
            this.bttnMarca.Size = new System.Drawing.Size(35, 25);
            this.bttnMarca.TabIndex = 47;
            this.bttnMarca.UseVisualStyleBackColor = false;
            this.bttnMarca.Click += new System.EventHandler(this.bttnMarca_Click);
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.bttnMarca);
            this.Controls.Add(this.bttnCategoria);
            this.Controls.Add(this.bttnModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboGarantia);
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
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.bttnAtras);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioProductos";
            this.Size = new System.Drawing.Size(1144, 678);
            this.Load += new System.EventHandler(this.Productos_Prot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnAtras;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSerial;
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
        private System.Windows.Forms.ComboBox comboGarantia;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnModelo;
        private System.Windows.Forms.Button bttnCategoria;
        private System.Windows.Forms.Button bttnMarca;
    }
}
