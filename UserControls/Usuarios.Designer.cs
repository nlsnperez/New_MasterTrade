
namespace New_MasterTrade.UserControls
{
    partial class Usuarios
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
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.AllowUserToDeleteRows = false;
            this.tablaUsuarios.AllowUserToResizeColumns = false;
            this.tablaUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.Contraseña,
            this.Nombre,
            this.Documento,
            this.Correo,
            this.Activo,
            this.Detalles,
            this.Eliminar});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuarios.DefaultCellStyle = dataGridViewCellStyle9;
            this.tablaUsuarios.EnableHeadersVisualStyles = false;
            this.tablaUsuarios.Location = new System.Drawing.Point(0, 60);
            this.tablaUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaUsuarios.MultiSelect = false;
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowHeadersVisible = false;
            this.tablaUsuarios.RowHeadersWidth = 51;
            this.tablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUsuarios.Size = new System.Drawing.Size(1144, 548);
            this.tablaUsuarios.TabIndex = 23;
            this.tablaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellClick);
            this.tablaUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaUsuarios_CellFormatting);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "id_usu";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.DataPropertyName = "usr_usu";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contraseña.DataPropertyName = "pas_usu";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MinimumWidth = 6;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "nom_usu";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.DataPropertyName = "doc_usu";
            this.Documento.HeaderText = "Documento de identidad";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.DataPropertyName = "cor_usu";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "act_usu";
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 2;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 2;
            // 
            // Detalles
            // 
            this.Detalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.Image = global::New_MasterTrade.Properties.Resources.edit__2_;
            this.Detalles.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.ReadOnly = true;
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnGuardar.FlatAppearance.BorderSize = 0;
            this.bttnGuardar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.Location = new System.Drawing.Point(736, -78);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(120, 49);
            this.bttnGuardar.TabIndex = 37;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnCancelar.FlatAppearance.BorderSize = 0;
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.Location = new System.Drawing.Point(608, -78);
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(120, 49);
            this.bttnCancelar.TabIndex = 38;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(881, 630);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 22);
            this.txtBuscar.TabIndex = 65;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(796, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "BUSCAR: ";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Detalles";
            this.dataGridViewImageColumn1.Image = global::New_MasterTrade.Properties.Resources.edit__2_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRegistrar.Image = global::New_MasterTrade.Properties.Resources.pencil;
            this.bttnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnRegistrar.Location = new System.Drawing.Point(19, 634);
            this.bttnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(133, 30);
            this.bttnRegistrar.TabIndex = 62;
            this.bttnRegistrar.Text = "REGISTRAR";
            this.bttnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnRegistrar.UseVisualStyleBackColor = false;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(362, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 38);
            this.label9.TabIndex = 119;
            this.label9.Text = "REGISTRO DE USUARIOS";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.tablaUsuarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(1144, 678);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewImageColumn Detalles;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Label label9;
    }
}
