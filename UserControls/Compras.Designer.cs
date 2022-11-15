﻿
namespace New_MasterTrade.UserControls
{
    partial class Compras
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
            this.tablaCompras = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCompras
            // 
            this.tablaCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaCompras.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NOrden,
            this.Proveedor,
            this.Fecha,
            this.Detalle});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCompras.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaCompras.EnableHeadersVisualStyles = false;
            this.tablaCompras.Location = new System.Drawing.Point(0, 0);
            this.tablaCompras.Margin = new System.Windows.Forms.Padding(4);
            this.tablaCompras.Name = "tablaCompras";
            this.tablaCompras.RowHeadersVisible = false;
            this.tablaCompras.RowHeadersWidth = 51;
            this.tablaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCompras.Size = new System.Drawing.Size(1144, 608);
            this.tablaCompras.TabIndex = 39;
            this.tablaCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCompras_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id_oco";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // NOrden
            // 
            this.NOrden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOrden.DataPropertyName = "num_oco";
            this.NOrden.HeaderText = "N. Orden";
            this.NOrden.MinimumWidth = 6;
            this.NOrden.Name = "NOrden";
            this.NOrden.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Proveedor.DataPropertyName = "raz_prv";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fec_oco";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
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
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.Location = new System.Drawing.Point(881, 630);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 22);
            this.txtBuscar.TabIndex = 41;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(796, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "BUSCAR: ";
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
            this.bttnReporte.TabIndex = 48;
            this.bttnReporte.Text = "REPORTE";
            this.bttnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnReporte.UseVisualStyleBackColor = false;
            this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.bttnReporte);
            this.Controls.Add(this.tablaCompras);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Compras";
            this.Size = new System.Drawing.Size(1144, 678);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCompras;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.Button bttnReporte;
    }
}
