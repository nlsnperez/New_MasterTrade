
namespace New_MasterTrade.Objetos
{
    partial class BuscarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columPCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // timerFade
            // 
            this.timerFade.Interval = 1;
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.AllowUserToResizeColumns = false;
            this.tablaProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnCategoria,
            this.columnMarca,
            this.columnModelo,
            this.columnSerial,
            this.columnDescripcion,
            this.columPCompra,
            this.columnPrecioVenta,
            this.Agregar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaProductos.EnableHeadersVisualStyles = false;
            this.tablaProductos.Location = new System.Drawing.Point(0, 60);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProductos.Size = new System.Drawing.Size(1144, 548);
            this.tablaProductos.TabIndex = 21;
            this.tablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellClick);
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.DataPropertyName = "id_pro";
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnCategoria
            // 
            this.columnCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCategoria.DataPropertyName = "categoria";
            this.columnCategoria.HeaderText = "Categoría";
            this.columnCategoria.MinimumWidth = 6;
            this.columnCategoria.Name = "columnCategoria";
            this.columnCategoria.ReadOnly = true;
            // 
            // columnMarca
            // 
            this.columnMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnMarca.DataPropertyName = "marca";
            this.columnMarca.HeaderText = "Marca";
            this.columnMarca.MinimumWidth = 6;
            this.columnMarca.Name = "columnMarca";
            this.columnMarca.ReadOnly = true;
            // 
            // columnModelo
            // 
            this.columnModelo.DataPropertyName = "modelo";
            this.columnModelo.HeaderText = "Modelo";
            this.columnModelo.MinimumWidth = 6;
            this.columnModelo.Name = "columnModelo";
            this.columnModelo.ReadOnly = true;
            this.columnModelo.Width = 125;
            // 
            // columnSerial
            // 
            this.columnSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSerial.DataPropertyName = "ser_pro";
            this.columnSerial.HeaderText = "Serial";
            this.columnSerial.MinimumWidth = 6;
            this.columnSerial.Name = "columnSerial";
            this.columnSerial.ReadOnly = true;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDescripcion.DataPropertyName = "des_pro";
            this.columnDescripcion.HeaderText = "Descripción";
            this.columnDescripcion.MinimumWidth = 6;
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.ReadOnly = true;
            // 
            // columPCompra
            // 
            this.columPCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columPCompra.DataPropertyName = "pco_pro";
            this.columPCompra.HeaderText = "P. Compra";
            this.columPCompra.MinimumWidth = 6;
            this.columPCompra.Name = "columPCompra";
            this.columPCompra.ReadOnly = true;
            // 
            // columnPrecioVenta
            // 
            this.columnPrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPrecioVenta.DataPropertyName = "pve_pro";
            this.columnPrecioVenta.HeaderText = "P. Venta";
            this.columnPrecioVenta.MinimumWidth = 6;
            this.columnPrecioVenta.Name = "columnPrecioVenta";
            this.columnPrecioVenta.ReadOnly = true;
            // 
            // Agregar
            // 
            this.Agregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.Image = global::New_MasterTrade.Properties.Resources.add_to_basket;
            this.Agregar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Agregar.MinimumWidth = 6;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(370, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(404, 38);
            this.label9.TabIndex = 118;
            this.label9.Text = "AGREGAR PRODUCTOS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtDescripción
            // 
            this.txtDescripción.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripción.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripción.Location = new System.Drawing.Point(601, 643);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(143, 22);
            this.txtDescripción.TabIndex = 137;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(601, 623);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 136;
            this.label5.Text = "DESCRIPCIÓN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(303, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 135;
            this.label4.Text = "MODELO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(158, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 134;
            this.label3.Text = "MARCA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 133;
            this.label2.Text = "CATEGORÍA";
            // 
            // comboModelo
            // 
            this.comboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(307, 642);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(143, 24);
            this.comboModelo.TabIndex = 132;
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(160, 642);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(143, 24);
            this.comboMarca.TabIndex = 131;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(13, 642);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(143, 24);
            this.comboCategoria.TabIndex = 130;
            // 
            // txtSerial
            // 
            this.txtSerial.BackColor = System.Drawing.SystemColors.Control;
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerial.Location = new System.Drawing.Point(454, 643);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerial.MaxLength = 13;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(143, 22);
            this.txtSerial.TabIndex = 129;
            this.txtSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(452, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "SERIAL";
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnBuscar.FlatAppearance.BorderSize = 0;
            this.bttnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBuscar.Image = global::New_MasterTrade.Properties.Resources.browsing;
            this.bttnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnBuscar.Location = new System.Drawing.Point(999, 635);
            this.bttnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(133, 30);
            this.bttnBuscar.TabIndex = 138;
            this.bttnBuscar.Text = "BUSCAR";
            this.bttnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::New_MasterTrade.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(999, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 139;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1144, 678);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerFade;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columPCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrecioVenta;
        private System.Windows.Forms.DataGridViewImageColumn Agregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button button1;
    }
}
