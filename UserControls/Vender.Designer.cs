
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboMoneda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSubTotalUs = new System.Windows.Forms.TextBox();
            this.txtSubTotalBs = new System.Windows.Forms.TextBox();
            this.comboImpuesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotalUs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalBs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumeroOrden = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.tableCarrito = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remover = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttnBuscarProductos = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.bttnNuevaVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMoneda
            // 
            this.comboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoneda.FormattingEnabled = true;
            this.comboMoneda.Location = new System.Drawing.Point(120, 62);
            this.comboMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(287, 24);
            this.comboMoneda.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "MONEDA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(829, 114);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 103;
            this.label14.Text = "TOTAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(831, 53);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 102;
            this.label13.Text = "SUBTOTAL ($)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(831, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 101;
            this.label12.Text = "SUBTOTAL (Bs)";
            // 
            // txtSubTotalUs
            // 
            this.txtSubTotalUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalUs.Location = new System.Drawing.Point(948, 48);
            this.txtSubTotalUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubTotalUs.Name = "txtSubTotalUs";
            this.txtSubTotalUs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotalUs.Size = new System.Drawing.Size(177, 22);
            this.txtSubTotalUs.TabIndex = 100;
            this.txtSubTotalUs.Text = "0";
            // 
            // txtSubTotalBs
            // 
            this.txtSubTotalBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotalBs.Location = new System.Drawing.Point(948, 17);
            this.txtSubTotalBs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubTotalBs.Name = "txtSubTotalBs";
            this.txtSubTotalBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotalBs.Size = new System.Drawing.Size(177, 22);
            this.txtSubTotalBs.TabIndex = 99;
            this.txtSubTotalBs.Text = "0";
            // 
            // comboImpuesto
            // 
            this.comboImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImpuesto.FormattingEnabled = true;
            this.comboImpuesto.Location = new System.Drawing.Point(948, 79);
            this.comboImpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboImpuesto.Name = "comboImpuesto";
            this.comboImpuesto.Size = new System.Drawing.Size(68, 24);
            this.comboImpuesto.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "V. ORDEN #";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpuesto.Location = new System.Drawing.Point(1023, 79);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtImpuesto.Size = new System.Drawing.Size(102, 22);
            this.txtImpuesto.TabIndex = 92;
            this.txtImpuesto.Text = "0";
            // 
            // txtTotalUs
            // 
            this.txtTotalUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalUs.Location = new System.Drawing.Point(948, 194);
            this.txtTotalUs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalUs.Name = "txtTotalUs";
            this.txtTotalUs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalUs.Size = new System.Drawing.Size(177, 22);
            this.txtTotalUs.TabIndex = 95;
            this.txtTotalUs.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(829, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 93;
            this.label10.Text = "US $";
            // 
            // txtTotalBs
            // 
            this.txtTotalBs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBs.Location = new System.Drawing.Point(948, 154);
            this.txtTotalBs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalBs.Name = "txtTotalBs";
            this.txtTotalBs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBs.Size = new System.Drawing.Size(177, 22);
            this.txtTotalBs.TabIndex = 91;
            this.txtTotalBs.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(829, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 75;
            this.label9.Text = "Bs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(416, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "NOMBRE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(831, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 94;
            this.label11.Text = "IMPUESTO (%)";
            // 
            // txtNumeroOrden
            // 
            this.txtNumeroOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroOrden.Location = new System.Drawing.Point(120, 17);
            this.txtNumeroOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroOrden.Name = "txtNumeroOrden";
            this.txtNumeroOrden.Size = new System.Drawing.Size(289, 22);
            this.txtNumeroOrden.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(416, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "CORREO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(416, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "TELÉFONO";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(524, 194);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(289, 22);
            this.txtCorreo.TabIndex = 84;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(524, 150);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(289, 22);
            this.txtTelefono.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(416, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "DIRECCIÓN";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(524, 106);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(289, 22);
            this.txtDireccion.TabIndex = 81;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Location = new System.Drawing.Point(524, 62);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(289, 22);
            this.txtRazonSocial.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(416, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(524, 17);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(243, 22);
            this.txtCliente.TabIndex = 77;
            // 
            // tableCarrito
            // 
            this.tableCarrito.AllowUserToAddRows = false;
            this.tableCarrito.AllowUserToDeleteRows = false;
            this.tableCarrito.AllowUserToResizeColumns = false;
            this.tableCarrito.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tableCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCarrito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.tableCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnSerial,
            this.columnDescripcion,
            this.columnPrecioU,
            this.columnCantidad,
            this.columnPrecioT,
            this.Remover});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCarrito.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableCarrito.EnableHeadersVisualStyles = false;
            this.tableCarrito.Location = new System.Drawing.Point(0, 236);
            this.tableCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableCarrito.Name = "tableCarrito";
            this.tableCarrito.ReadOnly = true;
            this.tableCarrito.RowHeadersVisible = false;
            this.tableCarrito.RowHeadersWidth = 51;
            this.tableCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCarrito.Size = new System.Drawing.Size(1144, 374);
            this.tableCarrito.TabIndex = 76;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Remover";
            this.dataGridViewImageColumn1.Image = global::New_MasterTrade.Properties.Resources.delete__2_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bttnBuscarProductos
            // 
            this.bttnBuscarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnBuscarProductos.FlatAppearance.BorderSize = 0;
            this.bttnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscarProductos.Image = global::New_MasterTrade.Properties.Resources.boxes;
            this.bttnBuscarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscarProductos.Location = new System.Drawing.Point(157, 628);
            this.bttnBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnBuscarProductos.Name = "bttnBuscarProductos";
            this.bttnBuscarProductos.Size = new System.Drawing.Size(133, 30);
            this.bttnBuscarProductos.TabIndex = 104;
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
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(133, 30);
            this.bttnGuardar.TabIndex = 90;
            this.bttnGuardar.Text = "REGISTRAR";
            this.bttnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
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
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(133, 30);
            this.bttnCancelar.TabIndex = 97;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnBuscar.FlatAppearance.BorderSize = 0;
            this.bttnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscar.Image = global::New_MasterTrade.Properties.Resources.browsing;
            this.bttnBuscar.Location = new System.Drawing.Point(776, 16);
            this.bttnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(37, 28);
            this.bttnBuscar.TabIndex = 87;
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click_1);
            // 
            // bttnNuevaVenta
            // 
            this.bttnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.bttnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.bttnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevaVenta.Image = global::New_MasterTrade.Properties.Resources.plus1;
            this.bttnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnNuevaVenta.Location = new System.Drawing.Point(16, 628);
            this.bttnNuevaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnNuevaVenta.Name = "bttnNuevaVenta";
            this.bttnNuevaVenta.Size = new System.Drawing.Size(133, 30);
            this.bttnNuevaVenta.TabIndex = 96;
            this.bttnNuevaVenta.Text = "NUEVO";
            this.bttnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnNuevaVenta.UseVisualStyleBackColor = false;
            this.bttnNuevaVenta.Click += new System.EventHandler(this.bttnNuevaVenta_Click);
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.comboMoneda);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vender";
            this.Size = new System.Drawing.Size(1144, 678);
            ((System.ComponentModel.ISupportInitialize)(this.tableCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMoneda;
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
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotalUs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalBs;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView tableCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioT;
        private System.Windows.Forms.DataGridViewImageColumn Remover;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
