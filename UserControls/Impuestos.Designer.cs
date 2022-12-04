namespace New_MasterTrade.UserControls
{
    partial class Impuestos
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
            this.bttnCerrar = new System.Windows.Forms.Button();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaImpuestos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PORCENTAJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaImpuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bttnCerrar.FlatAppearance.BorderSize = 0;
            this.bttnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCerrar.Location = new System.Drawing.Point(551, 0);
            this.bttnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(29, 30);
            this.bttnCerrar.TabIndex = 38;
            this.bttnCerrar.Text = "X";
            this.bttnCerrar.UseVisualStyleBackColor = false;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // bttnNuevo
            // 
            this.bttnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNuevo.Location = new System.Drawing.Point(115, 313);
            this.bttnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(113, 30);
            this.bttnNuevo.TabIndex = 37;
            this.bttnNuevo.Text = "NUEVO";
            this.bttnNuevo.UseVisualStyleBackColor = false;
            this.bttnNuevo.Click += new System.EventHandler(this.bttnNuevo_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.bttnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnActualizar.Location = new System.Drawing.Point(352, 313);
            this.bttnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(113, 30);
            this.bttnActualizar.TabIndex = 36;
            this.bttnActualizar.Text = "ACTUALIZAR";
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Location = new System.Drawing.Point(233, 313);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(113, 30);
            this.bttnGuardar.TabIndex = 35;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(210, 273);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 22);
            this.txtNombre.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(133, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "NOMBRE:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(39, 273);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(86, 22);
            this.txtID.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // tablaImpuestos
            // 
            this.tablaImpuestos.AllowUserToAddRows = false;
            this.tablaImpuestos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaImpuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaImpuestos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaImpuestos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaImpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaImpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IMPUESTO,
            this.PORCENTAJE,
            this.ACTIVO,
            this.DELETE});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaImpuestos.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaImpuestos.EnableHeadersVisualStyles = false;
            this.tablaImpuestos.Location = new System.Drawing.Point(0, 30);
            this.tablaImpuestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaImpuestos.Name = "tablaImpuestos";
            this.tablaImpuestos.ReadOnly = true;
            this.tablaImpuestos.RowHeadersVisible = false;
            this.tablaImpuestos.RowHeadersWidth = 51;
            this.tablaImpuestos.RowTemplate.Height = 24;
            this.tablaImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaImpuestos.Size = new System.Drawing.Size(580, 233);
            this.tablaImpuestos.TabIndex = 30;
            this.tablaImpuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaImpuestos_CellClick);
            this.tablaImpuestos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaImpuestos_CellFormatting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id_imp";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IMPUESTO
            // 
            this.IMPUESTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IMPUESTO.DataPropertyName = "des_imp";
            this.IMPUESTO.HeaderText = "IMPUESTO";
            this.IMPUESTO.MinimumWidth = 6;
            this.IMPUESTO.Name = "IMPUESTO";
            this.IMPUESTO.ReadOnly = true;
            this.IMPUESTO.Width = 113;
            // 
            // PORCENTAJE
            // 
            this.PORCENTAJE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PORCENTAJE.DataPropertyName = "por_imp";
            this.PORCENTAJE.HeaderText = "PORCENTAJE (%)";
            this.PORCENTAJE.MinimumWidth = 6;
            this.PORCENTAJE.Name = "PORCENTAJE";
            this.PORCENTAJE.ReadOnly = true;
            this.PORCENTAJE.Width = 149;
            // 
            // ACTIVO
            // 
            this.ACTIVO.DataPropertyName = "act_imp";
            this.ACTIVO.HeaderText = "ACTIVO";
            this.ACTIVO.MinimumWidth = 2;
            this.ACTIVO.Name = "ACTIVO";
            this.ACTIVO.ReadOnly = true;
            this.ACTIVO.Width = 2;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DELETE.HeaderText = "ELIMINAR";
            this.DELETE.Image = global::New_MasterTrade.Properties.Resources.delete__2_;
            this.DELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            this.DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DELETE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "IMPUESTOS";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(339, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "PORCENTAJE:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(448, 274);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPorcentaje.MaxLength = 10;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(121, 22);
            this.txtPorcentaje.TabIndex = 41;
            this.txtPorcentaje.Text = "0";
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // Impuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnCerrar);
            this.Controls.Add(this.bttnNuevo);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaImpuestos);
            this.Controls.Add(this.label3);
            this.Name = "Impuestos";
            this.Size = new System.Drawing.Size(580, 350);
            ((System.ComponentModel.ISupportInitialize)(this.tablaImpuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCerrar;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaImpuestos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PORCENTAJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIVO;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}
