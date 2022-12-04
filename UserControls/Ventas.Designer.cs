
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
            this.NFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOrdenVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label9 = new System.Windows.Forms.Label();
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
            this.NFactura,
            this.NOrdenVenta,
            this.Cliente,
            this.MPago,
            this.TotalBs,
            this.Detalle});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaVentas.DefaultCellStyle = dataGridViewCellStyle9;
            this.tablaVentas.EnableHeadersVisualStyles = false;
            this.tablaVentas.Location = new System.Drawing.Point(0, 60);
            this.tablaVentas.Margin = new System.Windows.Forms.Padding(4);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.RowHeadersVisible = false;
            this.tablaVentas.RowHeadersWidth = 51;
            this.tablaVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaVentas.Size = new System.Drawing.Size(1144, 548);
            this.tablaVentas.TabIndex = 0;
            this.tablaVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaVentas_CellClick);
            // 
            // NFactura
            // 
            this.NFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NFactura.DataPropertyName = "id_fve";
            this.NFactura.HeaderText = "N. Factura";
            this.NFactura.MinimumWidth = 6;
            this.NFactura.Name = "NFactura";
            this.NFactura.ReadOnly = true;
            // 
            // NOrdenVenta
            // 
            this.NOrdenVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOrdenVenta.DataPropertyName = "num_ove";
            this.NOrdenVenta.HeaderText = "N. Orden de venta";
            this.NOrdenVenta.MinimumWidth = 6;
            this.NOrdenVenta.Name = "NOrdenVenta";
            this.NOrdenVenta.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "raz_cli";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // MPago
            // 
            this.MPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MPago.DataPropertyName = "des_mpa";
            this.MPago.HeaderText = "Método de pago";
            this.MPago.MinimumWidth = 6;
            this.MPago.Name = "MPago";
            this.MPago.ReadOnly = true;
            // 
            // TotalBs
            // 
            this.TotalBs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalBs.DataPropertyName = "tot_fve";
            this.TotalBs.HeaderText = "Total";
            this.TotalBs.MinimumWidth = 6;
            this.TotalBs.Name = "TotalBs";
            this.TotalBs.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Image = global::New_MasterTrade.Properties.Resources.copy1;
            this.Detalle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            this.Detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(375, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(394, 38);
            this.label9.TabIndex = 118;
            this.label9.Text = "VENTAS REGISTRADAS";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaVentas);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOrdenVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBs;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.Label label9;
    }
}
