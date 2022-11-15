
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.columnNFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVentas
            // 
            this.tablaVentas.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaVentas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNFactura,
            this.columnOVenta,
            this.columnCliente,
            this.columnMPago,
            this.columnTBs,
            this.columnTUs,
            this.Detalles});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaVentas.DefaultCellStyle = dataGridViewCellStyle9;
            this.tablaVentas.EnableHeadersVisualStyles = false;
            this.tablaVentas.Location = new System.Drawing.Point(0, 0);
            this.tablaVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.RowHeadersVisible = false;
            this.tablaVentas.RowHeadersWidth = 51;
            this.tablaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaVentas.Size = new System.Drawing.Size(1144, 608);
            this.tablaVentas.TabIndex = 0;
            // 
            // columnNFactura
            // 
            this.columnNFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNFactura.DataPropertyName = "id_fve";
            this.columnNFactura.HeaderText = "N. Factura";
            this.columnNFactura.MinimumWidth = 6;
            this.columnNFactura.Name = "columnNFactura";
            this.columnNFactura.ReadOnly = true;
            // 
            // columnOVenta
            // 
            this.columnOVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnOVenta.DataPropertyName = "num_ove";
            this.columnOVenta.HeaderText = "N. Orden de venta";
            this.columnOVenta.MinimumWidth = 6;
            this.columnOVenta.Name = "columnOVenta";
            this.columnOVenta.ReadOnly = true;
            // 
            // columnCliente
            // 
            this.columnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCliente.DataPropertyName = "raz_cli";
            this.columnCliente.HeaderText = "Cliente";
            this.columnCliente.MinimumWidth = 6;
            this.columnCliente.Name = "columnCliente";
            this.columnCliente.ReadOnly = true;
            // 
            // columnMPago
            // 
            this.columnMPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnMPago.DataPropertyName = "des_mpa";
            this.columnMPago.HeaderText = "Método de pago";
            this.columnMPago.MinimumWidth = 6;
            this.columnMPago.Name = "columnMPago";
            this.columnMPago.ReadOnly = true;
            // 
            // columnTBs
            // 
            this.columnTBs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTBs.DataPropertyName = "tbs_fve";
            this.columnTBs.HeaderText = "T. Bolívares";
            this.columnTBs.MinimumWidth = 6;
            this.columnTBs.Name = "columnTBs";
            this.columnTBs.ReadOnly = true;
            // 
            // columnTUs
            // 
            this.columnTUs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTUs.DataPropertyName = "tus_fve";
            this.columnTUs.HeaderText = "T. Dólares";
            this.columnTUs.MinimumWidth = 6;
            this.columnTUs.Name = "columnTUs";
            this.columnTUs.ReadOnly = true;
            // 
            // Detalles
            // 
            this.Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalles.HeaderText = "Editar";
            this.Detalles.Image = global::New_MasterTrade.Properties.Resources.copy1;
            this.Detalles.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(881, 630);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 22);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(796, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "BUSCAR: ";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::New_MasterTrade.Properties.Resources.copy1;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bttnReporte
            // 
            this.bttnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnReporte.FlatAppearance.BorderSize = 0;
            this.bttnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnReporte.Image = global::New_MasterTrade.Properties.Resources.archivo_pdf__1_;
            this.bttnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnReporte.Location = new System.Drawing.Point(16, 628);
            this.bttnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnReporte.Name = "bttnReporte";
            this.bttnReporte.Size = new System.Drawing.Size(133, 30);
            this.bttnReporte.TabIndex = 47;
            this.bttnReporte.Text = "REPORTE";
            this.bttnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnReporte.UseVisualStyleBackColor = false;
            this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.bttnReporte);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaVentas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(1144, 678);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVentas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTBs;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTUs;
        private System.Windows.Forms.DataGridViewImageColumn Detalles;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button bttnReporte;
    }
}
