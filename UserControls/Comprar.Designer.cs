
namespace New_MasterTrade.UserControls
{
    partial class Comprar
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
            this.tableCarrito = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnBuscarProductos = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSubTotalUs = new System.Windows.Forms.TextBox();
            this.txtSubTotalBs = new System.Windows.Forms.TextBox();
            this.comboImpuesto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.bttnNuevaCompra = new System.Windows.Forms.Button();
            this.txtTotalUs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalBs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableCarrito.Location = new System.Drawing.Point(0, 233);
            this.tableCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableCarrito.Name = "tableCarrito";
            this.tableCarrito.ReadOnly = true;
            this.tableCarrito.RowHeadersWidth = 51;
            this.tableCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCarrito.Size = new System.Drawing.Size(813, 446);
            this.tableCarrito.TabIndex = 38;
            this.tableCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCarrito_CellClick);
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "Id";
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Visible = false;
            this.columnId.Width = 125;
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
            // columnDescripcion
            // 
            this.columnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDescripcion.DataPropertyName = "Descripcion";
            this.columnDescripcion.HeaderText = "Descripcion";
            this.columnDescripcion.MinimumWidth = 6;
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.ReadOnly = true;
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
            // columnCantidad
            // 
            this.columnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCantidad.DataPropertyName = "Cantidad";
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.MinimumWidth = 6;
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.ReadOnly = true;
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
            this.columnEliminar.HeaderText = "";
            this.columnEliminar.MinimumWidth = 6;
            this.columnEliminar.Name = "columnEliminar";
            this.columnEliminar.ReadOnly = true;
            this.columnEliminar.Text = "ELIMINAR";
            this.columnEliminar.UseColumnTextForButtonValue = true;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedor.Location = new System.Drawing.Point(524, 14);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(209, 22);
            this.txtProveedor.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "NOMBRE";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Location = new System.Drawing.Point(524, 58);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(289, 22);
            this.txtRazonSocial.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "DIRECCIÓN";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(524, 102);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(289, 22);
            this.txtDireccion.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "TELÉFONO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(524, 146);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(289, 22);
            this.txtTelefono.TabIndex = 47;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(524, 191);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(289, 22);
            this.txtCorreo.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "CORREO";
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscar.Location = new System.Drawing.Point(741, 12);
            this.bttnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(72, 28);
            this.bttnBuscar.TabIndex = 50;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "C. ORDEN #";
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroOrden.Location = new System.Drawing.Point(120, 14);
            this.txtNumeroOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(289, 22);
            this.txtNumeroOrden.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "FECHA";
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Location = new System.Drawing.Point(11, 562);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(291, 74);
            this.bttnGuardar.TabIndex = 55;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.bttnBuscarProductos);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.bttnGuardar);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtSubTotalUs);
            this.panel1.Controls.Add(this.txtSubTotalBs);
            this.panel1.Controls.Add(this.comboImpuesto);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.bttnCancelar);
            this.panel1.Controls.Add(this.txtImpuesto);
            this.panel1.Controls.Add(this.bttnNuevaCompra);
            this.panel1.Controls.Add(this.txtTotalUs);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTotalBs);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(823, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 652);
            this.panel1.TabIndex = 57;
            // 
            // bttnBuscarProductos
            // 
            this.bttnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscarProductos.Location = new System.Drawing.Point(11, 334);
            this.bttnBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnBuscarProductos.Name = "bttnBuscarProductos";
            this.bttnBuscarProductos.Size = new System.Drawing.Size(291, 74);
            this.bttnBuscarProductos.TabIndex = 72;
            this.bttnBuscarProductos.Text = "BUSCAR PRODUCTOS";
            this.bttnBuscarProductos.UseVisualStyleBackColor = true;
            this.bttnBuscarProductos.Click += new System.EventHandler(this.bttnBuscarProductos_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 106);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 71;
            this.label14.Text = "TOTAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "SUBTOTAL ($)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 69;
            this.label12.Text = "SUBTOTAL (Bs)";
            // 
            // txtSubTotalUs
            // 
            this.txtSubTotalUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalUs.Location = new System.Drawing.Point(124, 38);
            this.txtSubTotalUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubTotalUs.Name = "txtSubTotalUs";
            this.txtSubTotalUs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotalUs.Size = new System.Drawing.Size(177, 22);
            this.txtSubTotalUs.TabIndex = 68;
            this.txtSubTotalUs.Text = "0";
            // 
            // txtSubTotalBs
            // 
            this.txtSubTotalBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalBs.Location = new System.Drawing.Point(124, 5);
            this.txtSubTotalBs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubTotalBs.Name = "txtSubTotalBs";
            this.txtSubTotalBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotalBs.Size = new System.Drawing.Size(177, 22);
            this.txtSubTotalBs.TabIndex = 66;
            this.txtSubTotalBs.Text = "0";
            // 
            // comboImpuesto
            // 
            this.comboImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImpuesto.FormattingEnabled = true;
            this.comboImpuesto.Location = new System.Drawing.Point(124, 71);
            this.comboImpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboImpuesto.Name = "comboImpuesto";
            this.comboImpuesto.Size = new System.Drawing.Size(68, 24);
            this.comboImpuesto.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 59;
            this.label11.Text = "IMPUESTO (%)";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Location = new System.Drawing.Point(11, 448);
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(291, 74);
            this.bttnCancelar.TabIndex = 63;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpuesto.Location = new System.Drawing.Point(199, 71);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImpuesto.Size = new System.Drawing.Size(102, 22);
            this.txtImpuesto.TabIndex = 58;
            this.txtImpuesto.Text = "0";
            // 
            // bttnNuevaCompra
            // 
            this.bttnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevaCompra.Location = new System.Drawing.Point(11, 219);
            this.bttnNuevaCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnNuevaCompra.Name = "bttnNuevaCompra";
            this.bttnNuevaCompra.Size = new System.Drawing.Size(291, 74);
            this.bttnNuevaCompra.TabIndex = 61;
            this.bttnNuevaCompra.Text = "REGISTRAR";
            this.bttnNuevaCompra.UseVisualStyleBackColor = true;
            this.bttnNuevaCompra.Click += new System.EventHandler(this.bttnNuevaCompra_Click);
            // 
            // txtTotalUs
            // 
            this.txtTotalUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalUs.Location = new System.Drawing.Point(124, 174);
            this.txtTotalUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalUs.Name = "txtTotalUs";
            this.txtTotalUs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalUs.Size = new System.Drawing.Size(177, 22);
            this.txtTotalUs.TabIndex = 60;
            this.txtTotalUs.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "US $";
            // 
            // txtTotalBs
            // 
            this.txtTotalBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBs.Location = new System.Drawing.Point(124, 143);
            this.txtTotalBs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalBs.Name = "txtTotalBs";
            this.txtTotalBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBs.Size = new System.Drawing.Size(177, 22);
            this.txtTotalBs.TabIndex = 58;
            this.txtTotalBs.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(119, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "TOTAL";
            // 
            // dpFecha
            // 
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.Location = new System.Drawing.Point(120, 58);
            this.dpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dpFecha.MinDate = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(287, 22);
            this.dpFecha.TabIndex = 58;
            this.dpFecha.Value = new System.DateTime(2022, 10, 25, 0, 0, 0, 0);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.tableCarrito);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Comprar";
            this.Size = new System.Drawing.Size(1144, 678);
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableCarrito;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroOrden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalBs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalUs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnNuevaCompra;
        private System.Windows.Forms.ComboBox comboImpuesto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioT;
        private System.Windows.Forms.DataGridViewButtonColumn columnEliminar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSubTotalUs;
        private System.Windows.Forms.TextBox txtSubTotalBs;
        private System.Windows.Forms.Button bttnBuscarProductos;
    }
}
