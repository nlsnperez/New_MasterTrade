
namespace New_MasterTrade.UserControls
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.flowRegistros = new System.Windows.Forms.FlowLayoutPanel();
            this.PickerFecha = new System.Windows.Forms.DateTimePicker();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnRegresar = new System.Windows.Forms.Button();
            this.tablaDetalle = new System.Windows.Forms.DataGridView();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.panelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "VENTAS";
            // 
            // flowRegistros
            // 
            this.flowRegistros.AutoSize = true;
            this.flowRegistros.Location = new System.Drawing.Point(55, 106);
            this.flowRegistros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowRegistros.MaximumSize = new System.Drawing.Size(800, 600);
            this.flowRegistros.Name = "flowRegistros";
            this.flowRegistros.Size = new System.Drawing.Size(800, 600);
            this.flowRegistros.TabIndex = 23;
            // 
            // PickerFecha
            // 
            this.PickerFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickerFecha.Location = new System.Drawing.Point(518, 47);
            this.PickerFecha.Name = "PickerFecha";
            this.PickerFecha.Size = new System.Drawing.Size(200, 20);
            this.PickerFecha.TabIndex = 24;
            // 
            // panelSlide
            // 
            this.panelSlide.Controls.Add(this.lblTotal);
            this.panelSlide.Controls.Add(this.label8);
            this.panelSlide.Controls.Add(this.label6);
            this.panelSlide.Controls.Add(this.lblFecha);
            this.panelSlide.Controls.Add(this.label7);
            this.panelSlide.Controls.Add(this.bttnRegresar);
            this.panelSlide.Controls.Add(this.tablaDetalle);
            this.panelSlide.Controls.Add(this.lblMetodoPago);
            this.panelSlide.Controls.Add(this.lblCliente);
            this.panelSlide.Controls.Add(this.lblNumeroOrden);
            this.panelSlide.Controls.Add(this.lblID);
            this.panelSlide.Controls.Add(this.label5);
            this.panelSlide.Controls.Add(this.label3);
            this.panelSlide.Controls.Add(this.label2);
            this.panelSlide.Controls.Add(this.label1);
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSlide.MaximumSize = new System.Drawing.Size(922, 734);
            this.panelSlide.MinimumSize = new System.Drawing.Size(0, 734);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(922, 734);
            this.panelSlide.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(226, 226);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(80, 17);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "00/00/0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "FECHA";
            // 
            // bttnRegresar
            // 
            this.bttnRegresar.Location = new System.Drawing.Point(822, 17);
            this.bttnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnRegresar.Name = "bttnRegresar";
            this.bttnRegresar.Size = new System.Drawing.Size(70, 40);
            this.bttnRegresar.TabIndex = 9;
            this.bttnRegresar.Text = "ATRÁS";
            this.bttnRegresar.UseVisualStyleBackColor = true;
            this.bttnRegresar.Click += new System.EventHandler(this.bttnRegresar_Click);
            // 
            // tablaDetalle
            // 
            this.tablaDetalle.AllowUserToAddRows = false;
            this.tablaDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnProducto,
            this.columnCantidad,
            this.columnPrecioUnitario,
            this.columnTotal});
            this.tablaDetalle.Location = new System.Drawing.Point(24, 300);
            this.tablaDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablaDetalle.Name = "tablaDetalle";
            this.tablaDetalle.RowHeadersWidth = 51;
            this.tablaDetalle.RowTemplate.Height = 24;
            this.tablaDetalle.Size = new System.Drawing.Size(854, 338);
            this.tablaDetalle.TabIndex = 8;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(226, 188);
            this.lblMetodoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMetodoPago.Size = new System.Drawing.Size(136, 17);
            this.lblMetodoPago.TabIndex = 7;
            this.lblMetodoPago.Text = "MÉTODO DE PAGO";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(226, 151);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliente.Size = new System.Drawing.Size(65, 17);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "CLIENTE";
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrden.Location = new System.Drawing.Point(226, 114);
            this.lblNumeroOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumeroOrden.Size = new System.Drawing.Size(146, 17);
            this.lblNumeroOrden.TabIndex = 5;
            this.lblNumeroOrden.Text = "NÚMERO DE ORDEN";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(226, 76);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblID.Size = new System.Drawing.Size(24, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "#0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "MÉTODO DE PAGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NÚMERO DE ORDEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // timerSlide
            // 
            this.timerSlide.Interval = 10;
            this.timerSlide.Tick += new System.EventHandler(this.timerSlide_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "DETALLES";
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.DataPropertyName = "venta";
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            // 
            // columnProducto
            // 
            this.columnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProducto.DataPropertyName = "nombre";
            this.columnProducto.HeaderText = "Producto";
            this.columnProducto.MinimumWidth = 6;
            this.columnProducto.Name = "columnProducto";
            // 
            // columnCantidad
            // 
            this.columnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCantidad.DataPropertyName = "cantidad";
            this.columnCantidad.HeaderText = "Cantidad";
            this.columnCantidad.MinimumWidth = 6;
            this.columnCantidad.Name = "columnCantidad";
            // 
            // columnPrecioUnitario
            // 
            this.columnPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPrecioUnitario.DataPropertyName = "costo";
            this.columnPrecioUnitario.HeaderText = "Precio Unitario";
            this.columnPrecioUnitario.Name = "columnPrecioUnitario";
            // 
            // columnTotal
            // 
            this.columnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTotal.DataPropertyName = "precio";
            this.columnTotal.HeaderText = "Precio Total";
            this.columnTotal.MinimumWidth = 6;
            this.columnTotal.Name = "columnTotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 656);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(117, 656);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 25);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0,00Bs";
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(723, 37);
            this.bttnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(132, 40);
            this.bttnBuscar.TabIndex = 25;
            this.bttnBuscar.Text = "BUSCAR";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.flowRegistros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.PickerFecha);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(922, 734);
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowRegistros;
        private System.Windows.Forms.DateTimePicker PickerFecha;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Timer timerSlide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView tablaDetalle;
        private System.Windows.Forms.Button bttnRegresar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button bttnBuscar;
    }
}
