
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
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.bttnCargar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContrasegna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDetalle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.AllowUserToDeleteRows = false;
            this.tablaUsuarios.AllowUserToResizeColumns = false;
            this.tablaUsuarios.AllowUserToResizeRows = false;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.columnNombre,
            this.columnDocumento,
            this.ColumnUsuario,
            this.columnContrasegna,
            this.columnDetalle});
            this.tablaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tablaUsuarios.MultiSelect = false;
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowHeadersWidth = 51;
            this.tablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUsuarios.Size = new System.Drawing.Size(858, 494);
            this.tablaUsuarios.TabIndex = 23;
            this.tablaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellClick);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnGuardar.FlatAppearance.BorderSize = 0;
            this.bttnGuardar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.Location = new System.Drawing.Point(552, -63);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(90, 40);
            this.bttnGuardar.TabIndex = 37;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnCancelar.FlatAppearance.BorderSize = 0;
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.Location = new System.Drawing.Point(456, -63);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(90, 40);
            this.bttnCancelar.TabIndex = 38;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRegistrar.Location = new System.Drawing.Point(14, 515);
            this.bttnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(85, 24);
            this.bttnRegistrar.TabIndex = 62;
            this.bttnRegistrar.Text = "REGISTRAR";
            this.bttnRegistrar.UseVisualStyleBackColor = true;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // bttnCargar
            // 
            this.bttnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCargar.Location = new System.Drawing.Point(103, 515);
            this.bttnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCargar.Name = "bttnCargar";
            this.bttnCargar.Size = new System.Drawing.Size(85, 24);
            this.bttnCargar.TabIndex = 63;
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
            this.txtBuscar.TabIndex = 65;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "BUSCAR: ";
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnId.DataPropertyName = "id_usu";
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // columnNombre
            // 
            this.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNombre.DataPropertyName = "nom_usu";
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.MinimumWidth = 6;
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            // 
            // columnDocumento
            // 
            this.columnDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDocumento.DataPropertyName = "cor_usu";
            this.columnDocumento.HeaderText = "Correo";
            this.columnDocumento.MinimumWidth = 6;
            this.columnDocumento.Name = "columnDocumento";
            this.columnDocumento.ReadOnly = true;
            // 
            // ColumnUsuario
            // 
            this.ColumnUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUsuario.DataPropertyName = "usr_usu";
            this.ColumnUsuario.HeaderText = "Usuario";
            this.ColumnUsuario.MinimumWidth = 6;
            this.ColumnUsuario.Name = "ColumnUsuario";
            this.ColumnUsuario.ReadOnly = true;
            // 
            // columnContrasegna
            // 
            this.columnContrasegna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnContrasegna.DataPropertyName = "pas_usu";
            this.columnContrasegna.HeaderText = "Contraseña";
            this.columnContrasegna.MinimumWidth = 6;
            this.columnContrasegna.Name = "columnContrasegna";
            this.columnContrasegna.ReadOnly = true;
            // 
            // columnDetalle
            // 
            this.columnDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnDetalle.HeaderText = "";
            this.columnDetalle.Name = "columnDetalle";
            this.columnDetalle.ReadOnly = true;
            this.columnDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnDetalle.Text = "DETALLE";
            this.columnDetalle.UseColumnTextForButtonValue = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCargar);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.tablaUsuarios);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(858, 551);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.Button bttnCargar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContrasegna;
        private System.Windows.Forms.DataGridViewButtonColumn columnDetalle;
    }
}
