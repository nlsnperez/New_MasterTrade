﻿
namespace New_MasterTrade
{
    partial class Proveedores
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
            this.tablaPersonas = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPersonas
            // 
            this.tablaPersonas.AllowUserToAddRows = false;
            this.tablaPersonas.AllowUserToDeleteRows = false;
            this.tablaPersonas.AllowUserToResizeColumns = false;
            this.tablaPersonas.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaPersonas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.Documento,
            this.RazonSocial,
            this.Direccion,
            this.Telefono,
            this.Correo,
            this.Activo,
            this.Detalles,
            this.Eliminar});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaPersonas.DefaultCellStyle = dataGridViewCellStyle9;
            this.tablaPersonas.EnableHeadersVisualStyles = false;
            this.tablaPersonas.Location = new System.Drawing.Point(0, 60);
            this.tablaPersonas.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tablaPersonas.MultiSelect = false;
            this.tablaPersonas.Name = "tablaPersonas";
            this.tablaPersonas.ReadOnly = true;
            this.tablaPersonas.RowHeadersVisible = false;
            this.tablaPersonas.RowHeadersWidth = 51;
            this.tablaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPersonas.Size = new System.Drawing.Size(1144, 548);
            this.tablaPersonas.TabIndex = 32;
            this.tablaPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPersonas_CellClick);
            this.tablaPersonas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaPersonas_CellFormatting);
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.DataPropertyName = "id_prv";
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.DataPropertyName = "doc_prv";
            this.Documento.HeaderText = "Documento de identidad";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RazonSocial.DataPropertyName = "raz_prv";
            this.RazonSocial.HeaderText = "Razón social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "dir_prv";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DataPropertyName = "tel_prv";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.DataPropertyName = "cor_prv";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "act_prv";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 2;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 2;
            // 
            // Detalles
            // 
            this.Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalles.HeaderText = "Editar";
            this.Detalles.Image = global::New_MasterTrade.Properties.Resources.edit__2_;
            this.Detalles.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::New_MasterTrade.Properties.Resources.delete__2_;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp_1);
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
            // bttnAgregar
            // 
            this.bttnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnAgregar.FlatAppearance.BorderSize = 0;
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregar.Image = global::New_MasterTrade.Properties.Resources.pencil;
            this.bttnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAgregar.Location = new System.Drawing.Point(16, 628);
            this.bttnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(133, 30);
            this.bttnAgregar.TabIndex = 39;
            this.bttnAgregar.Text = "REGISTRAR";
            this.bttnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnAgregar.UseVisualStyleBackColor = false;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(311, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(522, 38);
            this.label9.TabIndex = 118;
            this.label9.Text = "PROVEEDORES REGISTRADOS";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaPersonas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Proveedores";
            this.Size = new System.Drawing.Size(1144, 678);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaPersonas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewImageColumn Detalles;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Label label9;
    }
}
