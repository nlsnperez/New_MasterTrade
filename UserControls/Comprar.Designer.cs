
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableCarrito = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remover = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.txtSubTotalBs = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.bttnBuscarProductos = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnNuevaCompra = new System.Windows.Forms.Button();
            this.comboTasaCambio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboMoneda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // tableCarrito
            // 
            this.tableCarrito.AllowUserToAddRows = false;
            this.tableCarrito.AllowUserToDeleteRows = false;
            this.tableCarrito.AllowUserToResizeColumns = false;
            this.tableCarrito.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tableCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCarrito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.tableCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnSerial,
            this.columnDescripcion,
            this.columnPrecioU,
            this.columnCantidad,
            this.columnPrecioT,
            this.Remover});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableCarrito.EnableHeadersVisualStyles = false;
            this.tableCarrito.Location = new System.Drawing.Point(0, 233);
            this.tableCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.tableCarrito.Name = "tableCarrito";
            this.tableCarrito.ReadOnly = true;
            this.tableCarrito.RowHeadersVisible = false;
            this.tableCarrito.RowHeadersWidth = 51;
            this.tableCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCarrito.Size = new System.Drawing.Size(1144, 374);
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
            // Remover
            // 
            this.Remover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remover.HeaderText = "Remover";
            this.Remover.Image = global::New_MasterTrade.Properties.Resources.delete__2_;
            this.Remover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Remover.MinimumWidth = 6;
            this.Remover.Name = "Remover";
            this.Remover.ReadOnly = true;
            this.Remover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedor.Location = new System.Drawing.Point(524, 14);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(243, 22);
            this.txtProveedor.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
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
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
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
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(289, 22);
            this.txtRazonSocial.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
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
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(289, 22);
            this.txtDireccion.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
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
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(289, 22);
            this.txtTelefono.TabIndex = 47;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(524, 191);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(289, 22);
            this.txtCorreo.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(416, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "CORREO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
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
            this.txtNumeroOrden.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(289, 22);
            this.txtNumeroOrden.TabIndex = 51;
            // 
            // txtSubTotalBs
            // 
            this.txtSubTotalBs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSubTotalBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalBs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtSubTotalBs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.txtSubTotalBs.Location = new System.Drawing.Point(831, 58);
            this.txtSubTotalBs.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotalBs.Multiline = true;
            this.txtSubTotalBs.Name = "txtSubTotalBs";
            this.txtSubTotalBs.ReadOnly = true;
            this.txtSubTotalBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotalBs.Size = new System.Drawing.Size(295, 109);
            this.txtSubTotalBs.TabIndex = 66;
            this.txtSubTotalBs.Text = "0";
            this.txtSubTotalBs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(825, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 71;
            this.label14.Text = "TOTAL";
            // 
            // bttnBuscarProductos
            // 
            this.bttnBuscarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnBuscarProductos.FlatAppearance.BorderSize = 0;
            this.bttnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscarProductos.Image = global::New_MasterTrade.Properties.Resources.boxes;
            this.bttnBuscarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscarProductos.Location = new System.Drawing.Point(157, 628);
            this.bttnBuscarProductos.Margin = new System.Windows.Forms.Padding(4);
            this.bttnBuscarProductos.Name = "bttnBuscarProductos";
            this.bttnBuscarProductos.Size = new System.Drawing.Size(133, 30);
            this.bttnBuscarProductos.TabIndex = 72;
            this.bttnBuscarProductos.Text = "PRODUCTOS";
            this.bttnBuscarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscarProductos.UseVisualStyleBackColor = false;
            this.bttnBuscarProductos.Click += new System.EventHandler(this.bttnBuscarProductos_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGuardar.FlatAppearance.BorderSize = 0;
            this.bttnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Image = global::New_MasterTrade.Properties.Resources.floppy_disk1;
            this.bttnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGuardar.Location = new System.Drawing.Point(440, 628);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(133, 30);
            this.bttnGuardar.TabIndex = 55;
            this.bttnGuardar.Text = "REGISTRAR";
            this.bttnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnBuscar.FlatAppearance.BorderSize = 0;
            this.bttnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscar.Image = global::New_MasterTrade.Properties.Resources.browsing;
            this.bttnBuscar.Location = new System.Drawing.Point(776, 12);
            this.bttnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(37, 28);
            this.bttnBuscar.TabIndex = 50;
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click_1);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnCancelar.FlatAppearance.BorderSize = 0;
            this.bttnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Image = global::New_MasterTrade.Properties.Resources.cancel;
            this.bttnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCancelar.Location = new System.Drawing.Point(299, 628);
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(133, 30);
            this.bttnCancelar.TabIndex = 63;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnNuevaCompra
            // 
            this.bttnNuevaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnNuevaCompra.FlatAppearance.BorderSize = 0;
            this.bttnNuevaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.bttnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevaCompra.Image = global::New_MasterTrade.Properties.Resources.plus1;
            this.bttnNuevaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnNuevaCompra.Location = new System.Drawing.Point(16, 628);
            this.bttnNuevaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.bttnNuevaCompra.Name = "bttnNuevaCompra";
            this.bttnNuevaCompra.Size = new System.Drawing.Size(133, 30);
            this.bttnNuevaCompra.TabIndex = 61;
            this.bttnNuevaCompra.Text = "NUEVO";
            this.bttnNuevaCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnNuevaCompra.UseVisualStyleBackColor = false;
            this.bttnNuevaCompra.Click += new System.EventHandler(this.bttnNuevaCompra_Click);
            // 
            // comboTasaCambio
            // 
            this.comboTasaCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTasaCambio.Enabled = false;
            this.comboTasaCambio.FormattingEnabled = true;
            this.comboTasaCambio.Location = new System.Drawing.Point(120, 102);
            this.comboTasaCambio.Margin = new System.Windows.Forms.Padding(4);
            this.comboTasaCambio.Name = "comboTasaCambio";
            this.comboTasaCambio.Size = new System.Drawing.Size(287, 24);
            this.comboTasaCambio.TabIndex = 112;
            this.comboTasaCambio.SelectedIndexChanged += new System.EventHandler(this.comboTasaCambio_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(12, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 32);
            this.label8.TabIndex = 111;
            this.label8.Text = "TASA DE\r\nCAMBIO";
            // 
            // comboMoneda
            // 
            this.comboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoneda.Enabled = false;
            this.comboMoneda.FormattingEnabled = true;
            this.comboMoneda.Location = new System.Drawing.Point(120, 58);
            this.comboMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(287, 24);
            this.comboMoneda.TabIndex = 110;
            this.comboMoneda.SelectedIndexChanged += new System.EventHandler(this.comboMoneda_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "MONEDA";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMoneda.Location = new System.Drawing.Point(831, 176);
            this.txtMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoneda.Multiline = true;
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.ReadOnly = true;
            this.txtMoneda.Size = new System.Drawing.Size(296, 39);
            this.txtMoneda.TabIndex = 113;
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.comboTasaCambio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboMoneda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bttnBuscarProductos);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.txtSubTotalBs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroOrden);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnNuevaCompra);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.tableCarrito);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comprar";
            this.Size = new System.Drawing.Size(1144, 678);
            this.Load += new System.EventHandler(this.Comprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).EndInit();
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
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnNuevaCompra;
        private System.Windows.Forms.Button bttnBuscarProductos;
        private System.Windows.Forms.TextBox txtSubTotalBs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioT;
        private System.Windows.Forms.DataGridViewImageColumn Remover;
        private System.Windows.Forms.ComboBox comboTasaCambio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboMoneda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMoneda;
    }
}
