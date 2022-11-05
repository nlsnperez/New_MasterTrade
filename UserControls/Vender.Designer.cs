
namespace New_MasterTrade.UserControls
{
    partial class Vender
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
            this.comboPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bttnBuscarProductos = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSubTotalUs = new System.Windows.Forms.TextBox();
            this.txtSubTotalBs = new System.Windows.Forms.TextBox();
            this.comboImpuesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnPrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotalUs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalBs = new System.Windows.Forms.TextBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.columnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnNuevaVenta = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.columnPrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableCarrito = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // comboPago
            // 
            this.comboPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPago.FormattingEnabled = true;
            this.comboPago.Location = new System.Drawing.Point(90, 50);
            this.comboPago.Name = "comboPago";
            this.comboPago.Size = new System.Drawing.Size(216, 21);
            this.comboPago.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 26);
            this.label7.TabIndex = 105;
            this.label7.Text = "MÉTODO DE\r\nPAGO\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(622, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 103;
            this.label14.Text = "TOTAL";
            // 
            // bttnBuscarProductos
            // 
            this.bttnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscarProductos.Location = new System.Drawing.Point(103, 513);
            this.bttnBuscarProductos.Name = "bttnBuscarProductos";
            this.bttnBuscarProductos.Size = new System.Drawing.Size(85, 24);
            this.bttnBuscarProductos.TabIndex = 104;
            this.bttnBuscarProductos.Text = "PRODUCTOS";
            this.bttnBuscarProductos.UseVisualStyleBackColor = true;
            this.bttnBuscarProductos.Click += new System.EventHandler(this.bttnBuscarProductos_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(623, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 102;
            this.label13.Text = "SUBTOTAL ($)";
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Location = new System.Drawing.Point(285, 513);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(85, 24);
            this.bttnGuardar.TabIndex = 90;
            this.bttnGuardar.Text = "REGISTRAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(623, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "SUBTOTAL (Bs)";
            // 
            // txtSubTotalUs
            // 
            this.txtSubTotalUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalUs.Location = new System.Drawing.Point(711, 39);
            this.txtSubTotalUs.Name = "txtSubTotalUs";
            this.txtSubTotalUs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotalUs.Size = new System.Drawing.Size(133, 20);
            this.txtSubTotalUs.TabIndex = 100;
            this.txtSubTotalUs.Text = "0";
            // 
            // txtSubTotalBs
            // 
            this.txtSubTotalBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalBs.Location = new System.Drawing.Point(711, 14);
            this.txtSubTotalBs.Name = "txtSubTotalBs";
            this.txtSubTotalBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotalBs.Size = new System.Drawing.Size(133, 20);
            this.txtSubTotalBs.TabIndex = 99;
            this.txtSubTotalBs.Text = "0";
            // 
            // comboImpuesto
            // 
            this.comboImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImpuesto.FormattingEnabled = true;
            this.comboImpuesto.Location = new System.Drawing.Point(711, 64);
            this.comboImpuesto.Name = "comboImpuesto";
            this.comboImpuesto.Size = new System.Drawing.Size(52, 21);
            this.comboImpuesto.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "V. ORDEN #";
            // 
            // columnPrecioU
            // 
            this.columnPrecioU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPrecioU.DataPropertyName = "P.Unitario";
            this.columnPrecioU.HeaderText = "P. Unitario";
            this.columnPrecioU.MinimumWidth = 6;
            this.columnPrecioU.Name = "columnPrecioU";
            this.columnPrecioU.ReadOnly = true;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpuesto.Location = new System.Drawing.Point(767, 64);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImpuesto.Size = new System.Drawing.Size(77, 20);
            this.txtImpuesto.TabIndex = 92;
            this.txtImpuesto.Text = "0";
            // 
            // txtTotalUs
            // 
            this.txtTotalUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalUs.Location = new System.Drawing.Point(711, 158);
            this.txtTotalUs.Name = "txtTotalUs";
            this.txtTotalUs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalUs.Size = new System.Drawing.Size(133, 20);
            this.txtTotalUs.TabIndex = 95;
            this.txtTotalUs.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(622, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 93;
            this.label10.Text = "US $";
            // 
            // txtTotalBs
            // 
            this.txtTotalBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBs.Location = new System.Drawing.Point(711, 125);
            this.txtTotalBs.Name = "txtTotalBs";
            this.txtTotalBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBs.Size = new System.Drawing.Size(133, 20);
            this.txtTotalBs.TabIndex = 91;
            this.txtTotalBs.Text = "0";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Location = new System.Drawing.Point(194, 513);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(85, 24);
            this.bttnCancelar.TabIndex = 97;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Bs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "NOMBRE";
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDescripcion.DataPropertyName = "Descripcion";
            this.columnDescripcion.HeaderText = "Descripcion";
            this.columnDescripcion.MinimumWidth = 6;
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(623, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 94;
            this.label11.Text = "IMPUESTO (%)";
            // 
            // columnSerial
            // 
            this.columnSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSerial.DataPropertyName = "Serial";
            this.columnSerial.HeaderText = "Serial";
            this.columnSerial.MinimumWidth = 6;
            this.columnSerial.Name = "columnSerial";
            this.columnSerial.ReadOnly = true;
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "Id";
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 125;
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroOrden.Location = new System.Drawing.Point(90, 14);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(217, 20);
            this.txtNumeroOrden.TabIndex = 88;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscar.Location = new System.Drawing.Point(556, 13);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(54, 23);
            this.bttnBuscar.TabIndex = 87;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "CORREO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "TELÉFONO";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(393, 158);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(217, 20);
            this.txtCorreo.TabIndex = 84;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(393, 122);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(217, 20);
            this.txtTelefono.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "DIRECCIÓN";
            // 
            // bttnNuevaVenta
            // 
            this.bttnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevaVenta.Location = new System.Drawing.Point(12, 513);
            this.bttnNuevaVenta.Name = "bttnNuevaVenta";
            this.bttnNuevaVenta.Size = new System.Drawing.Size(85, 24);
            this.bttnNuevaVenta.TabIndex = 96;
            this.bttnNuevaVenta.Text = "NUEVO (+)";
            this.bttnNuevaVenta.UseVisualStyleBackColor = true;
            this.bttnNuevaVenta.Click += new System.EventHandler(this.bttnNuevaVenta_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(393, 86);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(217, 20);
            this.txtDireccion.TabIndex = 81;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Location = new System.Drawing.Point(393, 50);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(217, 20);
            this.txtRazonSocial.TabIndex = 79;
            // 
            // columnPrecioT
            // 
            this.columnPrecioT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPrecioT.DataPropertyName = "P.Total";
            this.columnPrecioT.HeaderText = "P. Total";
            this.columnPrecioT.MinimumWidth = 6;
            this.columnPrecioT.Name = "columnPrecioT";
            this.columnPrecioT.ReadOnly = true;
            // 
            // columnEliminar
            // 
            this.columnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnEliminar.HeaderText = "";
            this.columnEliminar.MinimumWidth = 6;
            this.columnEliminar.Name = "columnEliminar";
            this.columnEliminar.ReadOnly = true;
            this.columnEliminar.Text = "REMOVER";
            this.columnEliminar.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(393, 14);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(157, 20);
            this.txtCliente.TabIndex = 77;
            // 
            // columnCantidad
            // 
            this.columnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCantidad.DataPropertyName = "Cantidad";
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.MinimumWidth = 6;
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.ReadOnly = true;
            // 
            // tableCarrito
            // 
            this.tableCarrito.AllowUserToAddRows = false;
            this.tableCarrito.AllowUserToDeleteRows = false;
            this.tableCarrito.AllowUserToResizeColumns = false;
            this.tableCarrito.AllowUserToResizeRows = false;
            this.tableCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnSerial,
            this.columnDescripcion,
            this.columnPrecioU,
            this.columnCantidad,
            this.columnPrecioT,
            this.columnEliminar});
            this.tableCarrito.Location = new System.Drawing.Point(0, 192);
            this.tableCarrito.Name = "tableCarrito";
            this.tableCarrito.ReadOnly = true;
            this.tableCarrito.RowHeadersWidth = 51;
            this.tableCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCarrito.Size = new System.Drawing.Size(858, 304);
            this.tableCarrito.TabIndex = 76;
            this.tableCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCarrito_CellClick);
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bttnBuscarProductos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSubTotalUs);
            this.Controls.Add(this.txtSubTotalBs);
            this.Controls.Add(this.comboImpuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtTotalUs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalBs);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnNuevaVenta);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.tableCarrito);
            this.Name = "Vender";
            this.Size = new System.Drawing.Size(858, 551);
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bttnBuscarProductos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSubTotalUs;
        private System.Windows.Forms.TextBox txtSubTotalBs;
        private System.Windows.Forms.ComboBox comboImpuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioU;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotalUs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalBs;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnNuevaVenta;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioT;
        private System.Windows.Forms.DataGridViewButtonColumn columnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridView tableCarrito;
    }
}
