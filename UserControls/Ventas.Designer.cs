
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
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnNFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnOVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVentas
            // 
            this.tablaVentas.AllowUserToAddRows = false;
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNFactura,
            this.columnOVenta,
            this.columnCliente,
            this.columnMPago,
            this.columnTBs,
            this.columnTUs,
            this.columnDetalle});
            this.tablaVentas.Location = new System.Drawing.Point(0, 0);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.Size = new System.Drawing.Size(858, 494);
            this.tablaVentas.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(661, 512);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 20);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "BUSCAR: ";
            // 
            // columnNFactura
            // 
            this.columnNFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNFactura.DataPropertyName = "id_fve";
            this.columnNFactura.HeaderText = "N. Factura";
            this.columnNFactura.Name = "columnNFactura";
            this.columnNFactura.ReadOnly = true;
            // 
            // columnOVenta
            // 
            this.columnOVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnOVenta.DataPropertyName = "num_ove";
            this.columnOVenta.HeaderText = "N. Orden de venta";
            this.columnOVenta.Name = "columnOVenta";
            this.columnOVenta.ReadOnly = true;
            // 
            // columnCliente
            // 
            this.columnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCliente.DataPropertyName = "raz_cli";
            this.columnCliente.HeaderText = "Cliente";
            this.columnCliente.Name = "columnCliente";
            this.columnCliente.ReadOnly = true;
            // 
            // columnMPago
            // 
            this.columnMPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnMPago.DataPropertyName = "des_mpa";
            this.columnMPago.HeaderText = "Método de pago";
            this.columnMPago.Name = "columnMPago";
            this.columnMPago.ReadOnly = true;
            // 
            // columnTBs
            // 
            this.columnTBs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTBs.DataPropertyName = "tbs_fve";
            this.columnTBs.HeaderText = "T. Bolívares";
            this.columnTBs.Name = "columnTBs";
            this.columnTBs.ReadOnly = true;
            // 
            // columnTUs
            // 
            this.columnTUs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnTUs.DataPropertyName = "tus_fve";
            this.columnTUs.HeaderText = "T. Dólares";
            this.columnTUs.Name = "columnTUs";
            this.columnTUs.ReadOnly = true;
            // 
            // columnDetalle
            // 
            this.columnDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnDetalle.HeaderText = "";
            this.columnDetalle.Name = "columnDetalle";
            this.columnDetalle.Text = "DETALLE";
            this.columnDetalle.UseColumnTextForButtonValue = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaVentas);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(858, 551);
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
        private System.Windows.Forms.DataGridViewButtonColumn columnDetalle;
    }
}
