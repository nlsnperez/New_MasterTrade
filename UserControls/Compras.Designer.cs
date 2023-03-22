
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaCompras = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnSiguiente = new System.Windows.Forms.Button();
            this.comboPaginas = new System.Windows.Forms.ComboBox();
            this.bttnAnterior = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCompras
            // 
            this.tablaCompras.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaCompras.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NOrden,
            this.Proveedor,
            this.Moneda,
            this.Total,
            this.Detalle});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCompras.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaCompras.EnableHeadersVisualStyles = false;
            this.tablaCompras.Location = new System.Drawing.Point(0, 49);
            this.tablaCompras.Name = "tablaCompras";
            this.tablaCompras.RowHeadersVisible = false;
            this.tablaCompras.RowHeadersWidth = 51;
            this.tablaCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCompras.Size = new System.Drawing.Size(858, 445);
            this.tablaCompras.TabIndex = 39;
            this.tablaCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCompras_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(661, 512);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 20);
            this.txtBuscar.TabIndex = 41;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(597, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "BUSCAR: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(268, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(354, 31);
            this.label9.TabIndex = 118;
            this.label9.Text = "COMPRAS REGISTRADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(372, 516);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 136;
            this.label3.Text = "PÁGINA:";
            // 
            // bttnSiguiente
            // 
            this.bttnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnSiguiente.FlatAppearance.BorderSize = 0;
            this.bttnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSiguiente.Location = new System.Drawing.Point(491, 510);
            this.bttnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSiguiente.Name = "bttnSiguiente";
            this.bttnSiguiente.Size = new System.Drawing.Size(24, 24);
            this.bttnSiguiente.TabIndex = 135;
            this.bttnSiguiente.Text = ">";
            this.bttnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnSiguiente.UseVisualStyleBackColor = false;
            this.bttnSiguiente.Click += new System.EventHandler(this.bttnSiguiente_Click);
            // 
            // comboPaginas
            // 
            this.comboPaginas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaginas.FormattingEnabled = true;
            this.comboPaginas.Location = new System.Drawing.Point(426, 512);
            this.comboPaginas.Margin = new System.Windows.Forms.Padding(2);
            this.comboPaginas.Name = "comboPaginas";
            this.comboPaginas.Size = new System.Drawing.Size(61, 21);
            this.comboPaginas.TabIndex = 134;
            this.comboPaginas.SelectedIndexChanged += new System.EventHandler(this.comboPaginas_SelectedIndexChanged_1);
            // 
            // bttnAnterior
            // 
            this.bttnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnAnterior.FlatAppearance.BorderSize = 0;
            this.bttnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAnterior.Location = new System.Drawing.Point(344, 510);
            this.bttnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.bttnAnterior.Name = "bttnAnterior";
            this.bttnAnterior.Size = new System.Drawing.Size(24, 24);
            this.bttnAnterior.TabIndex = 133;
            this.bttnAnterior.Text = "<";
            this.bttnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnAnterior.UseVisualStyleBackColor = false;
            this.bttnAnterior.Click += new System.EventHandler(this.bttnAnterior_Click);
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
            this.Proveedor.DataPropertyName = "raz_usu";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Moneda
            // 
            this.Moneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Moneda.DataPropertyName = "nom_mon";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "tot_oco";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
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
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnSiguiente);
            this.Controls.Add(this.comboPaginas);
            this.Controls.Add(this.bttnAnterior);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaCompras);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Compras";
            this.Size = new System.Drawing.Size(858, 551);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCompras;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnSiguiente;
        private System.Windows.Forms.ComboBox comboPaginas;
        private System.Windows.Forms.Button bttnAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
    }
}
