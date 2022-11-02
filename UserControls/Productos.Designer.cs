namespace New_MasterTrade.UserControls
{
    partial class Productos
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
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.bttnCargar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columPCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.AllowUserToResizeColumns = false;
            this.tablaProductos.AllowUserToResizeRows = false;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnCategoria,
            this.columnMarca,
            this.columnModelo,
            this.columnSerial,
            this.columnDescripcion,
            this.columPCompra,
            this.columnPVenta,
            this.columnImagen,
            this.columnEliminar});
            this.tablaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablaProductos.Location = new System.Drawing.Point(0, 0);
            this.tablaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.Height = 24;
            this.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProductos.Size = new System.Drawing.Size(858, 494);
            this.tablaProductos.TabIndex = 0;
            this.tablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellClick);
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregar.Location = new System.Drawing.Point(12, 510);
            this.bttnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(85, 24);
            this.bttnAgregar.TabIndex = 33;
            this.bttnAgregar.Text = "REGISTRAR";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // bttnCargar
            // 
            this.bttnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCargar.Location = new System.Drawing.Point(101, 510);
            this.bttnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCargar.Name = "bttnCargar";
            this.bttnCargar.Size = new System.Drawing.Size(85, 24);
            this.bttnCargar.TabIndex = 34;
            this.bttnCargar.Text = "CARGAR";
            this.bttnCargar.UseVisualStyleBackColor = true;
            this.bttnCargar.Click += new System.EventHandler(this.bttnCargar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(661, 512);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 20);
            this.txtBuscar.TabIndex = 36;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "BUSCAR: ";
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.DataPropertyName = "id";
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnCategoria
            // 
            this.columnCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCategoria.DataPropertyName = "categoria";
            this.columnCategoria.HeaderText = "Categoría";
            this.columnCategoria.Name = "columnCategoria";
            this.columnCategoria.ReadOnly = true;
            // 
            // columnMarca
            // 
            this.columnMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnMarca.DataPropertyName = "marca";
            this.columnMarca.HeaderText = "Marca";
            this.columnMarca.Name = "columnMarca";
            this.columnMarca.ReadOnly = true;
            // 
            // columnModelo
            // 
            this.columnModelo.DataPropertyName = "modelo";
            this.columnModelo.HeaderText = "Modelo";
            this.columnModelo.Name = "columnModelo";
            this.columnModelo.ReadOnly = true;
            // 
            // columnSerial
            // 
            this.columnSerial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnSerial.DataPropertyName = "serial";
            this.columnSerial.HeaderText = "Serial";
            this.columnSerial.Name = "columnSerial";
            this.columnSerial.ReadOnly = true;
            // 
            // columnDescripcion
            // 
            this.columnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDescripcion.DataPropertyName = "descr";
            this.columnDescripcion.HeaderText = "Descripción";
            this.columnDescripcion.Name = "columnDescripcion";
            this.columnDescripcion.ReadOnly = true;
            // 
            // columPCompra
            // 
            this.columPCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columPCompra.DataPropertyName = "p_com";
            this.columPCompra.HeaderText = "P. Compra";
            this.columPCompra.Name = "columPCompra";
            this.columPCompra.ReadOnly = true;
            // 
            // columnPVenta
            // 
            this.columnPVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPVenta.DataPropertyName = "p_ven";
            this.columnPVenta.HeaderText = "P. Venta";
            this.columnPVenta.Name = "columnPVenta";
            this.columnPVenta.ReadOnly = true;
            // 
            // columnImagen
            // 
            this.columnImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnImagen.DataPropertyName = "imagen";
            this.columnImagen.HeaderText = "Imagen";
            this.columnImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.columnImagen.Name = "columnImagen";
            this.columnImagen.ReadOnly = true;
            this.columnImagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnEliminar
            // 
            this.columnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnEliminar.HeaderText = "";
            this.columnEliminar.Name = "columnEliminar";
            this.columnEliminar.ReadOnly = true;
            this.columnEliminar.Text = "DETALLES";
            this.columnEliminar.UseColumnTextForButtonValue = true;
            // 
            // ResgistrosProductos_Prototipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCargar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.tablaProductos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResgistrosProductos_Prototipo";
            this.Size = new System.Drawing.Size(858, 551);
            this.Load += new System.EventHandler(this.ResgistrosProductos_Prototipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Button bttnCargar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columPCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPVenta;
        private System.Windows.Forms.DataGridViewImageColumn columnImagen;
        private System.Windows.Forms.DataGridViewButtonColumn columnEliminar;
    }
}
