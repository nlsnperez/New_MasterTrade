namespace New_MasterTrade.UserControls
{
    partial class Categorias
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
            this.tablaCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.bttnCerrar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCategorias
            // 
            this.tablaCategorias.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaCategorias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CATEGORIA,
            this.ELIMINAR});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCategorias.DefaultCellStyle = dataGridViewCellStyle9;
            this.tablaCategorias.EnableHeadersVisualStyles = false;
            this.tablaCategorias.Location = new System.Drawing.Point(0, 30);
            this.tablaCategorias.Name = "tablaCategorias";
            this.tablaCategorias.ReadOnly = true;
            this.tablaCategorias.RowHeadersVisible = false;
            this.tablaCategorias.RowHeadersWidth = 51;
            this.tablaCategorias.RowTemplate.Height = 24;
            this.tablaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCategorias.Size = new System.Drawing.Size(572, 233);
            this.tablaCategorias.TabIndex = 0;
            this.tablaCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCategorias_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(58, 273);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(86, 22);
            this.txtID.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(239, 273);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(157, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE:";
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Location = new System.Drawing.Point(234, 312);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(105, 30);
            this.bttnGuardar.TabIndex = 5;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnActualizar.Location = new System.Drawing.Point(345, 312);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(105, 30);
            this.bttnActualizar.TabIndex = 6;
            this.bttnActualizar.Text = "ACTUALIZAR";
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnNuevo
            // 
            this.bttnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevo.Location = new System.Drawing.Point(123, 312);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(105, 30);
            this.bttnNuevo.TabIndex = 7;
            this.bttnNuevo.Text = "NUEVO";
            this.bttnNuevo.UseVisualStyleBackColor = false;
            this.bttnNuevo.Click += new System.EventHandler(this.bttnNuevo_Click);
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bttnCerrar.FlatAppearance.BorderSize = 0;
            this.bttnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCerrar.Location = new System.Drawing.Point(542, 0);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(30, 30);
            this.bttnCerrar.TabIndex = 8;
            this.bttnCerrar.Text = "X";
            this.bttnCerrar.UseVisualStyleBackColor = false;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id_cat";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CATEGORIA.DataPropertyName = "nom_cat";
            this.CATEGORIA.HeaderText = "CATEGORÍA";
            this.CATEGORIA.MinimumWidth = 6;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            this.CATEGORIA.Width = 121;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::New_MasterTrade.Properties.Resources.delete__2_;
            this.ELIMINAR.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ELIMINAR.MinimumWidth = 6;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.bttnCerrar);
            this.Controls.Add(this.bttnNuevo);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaCategorias);
            this.Name = "Categorias";
            this.Size = new System.Drawing.Size(572, 349);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.Button bttnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}
