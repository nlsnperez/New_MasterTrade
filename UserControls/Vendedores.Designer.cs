namespace New_MasterTrade.UserControls
{
    partial class Vendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaVendedores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoIdentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(881, 630);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 22);
            this.txtBuscar.TabIndex = 40;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(796, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "BUSCAR: ";
            // 
            // tablaVendedores
            // 
            this.tablaVendedores.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaVendedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.tablaVendedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaVendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaVendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tablaVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.DocumentoIdentidad,
            this.ACTIVO,
            this.ELIMINAR});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaVendedores.DefaultCellStyle = dataGridViewCellStyle15;
            this.tablaVendedores.EnableHeadersVisualStyles = false;
            this.tablaVendedores.Location = new System.Drawing.Point(0, 60);
            this.tablaVendedores.Name = "tablaVendedores";
            this.tablaVendedores.RowHeadersVisible = false;
            this.tablaVendedores.RowHeadersWidth = 51;
            this.tablaVendedores.RowTemplate.Height = 24;
            this.tablaVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaVendedores.Size = new System.Drawing.Size(1144, 548);
            this.tablaVendedores.TabIndex = 41;
            this.tablaVendedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaVendedores_CellClick);
            this.tablaVendedores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaVendedores_CellFormatting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id_ven";
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOMBRE.DataPropertyName = "nom_usu";
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            // 
            // DocumentoIdentidad
            // 
            this.DocumentoIdentidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DocumentoIdentidad.DataPropertyName = "doc_usu";
            this.DocumentoIdentidad.HeaderText = "Documento de identidad";
            this.DocumentoIdentidad.MinimumWidth = 6;
            this.DocumentoIdentidad.Name = "DocumentoIdentidad";
            // 
            // ACTIVO
            // 
            this.ACTIVO.DataPropertyName = "act_ven";
            this.ACTIVO.HeaderText = "Activo";
            this.ACTIVO.MinimumWidth = 2;
            this.ACTIVO.Name = "ACTIVO";
            this.ACTIVO.Width = 2;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::New_MasterTrade.Properties.Resources.delete__2_;
            this.ELIMINAR.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ELIMINAR.MinimumWidth = 6;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(323, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(498, 38);
            this.label9.TabIndex = 119;
            this.label9.Text = "VENDEDORES REGISTRADOS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Vendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaVendedores);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Vendedores";
            this.Size = new System.Drawing.Size(1144, 678);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoIdentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.Label label9;
    }
}
