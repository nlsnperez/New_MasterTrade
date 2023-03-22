
namespace New_MasterTrade.UserControls
{
    partial class RegistrosBitacora
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
            this.tablaBitacora = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnSiguiente = new System.Windows.Forms.Button();
            this.comboPaginas = new System.Windows.Forms.ComboBox();
            this.bttnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaBitacora
            // 
            this.tablaBitacora.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaBitacora.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Usuario,
            this.Modulo,
            this.Accion,
            this.Fecha,
            this.Hora});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaBitacora.DefaultCellStyle = dataGridViewCellStyle9;
            this.tablaBitacora.EnableHeadersVisualStyles = false;
            this.tablaBitacora.Location = new System.Drawing.Point(0, 49);
            this.tablaBitacora.Name = "tablaBitacora";
            this.tablaBitacora.ReadOnly = true;
            this.tablaBitacora.RowHeadersVisible = false;
            this.tablaBitacora.RowHeadersWidth = 51;
            this.tablaBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaBitacora.Size = new System.Drawing.Size(858, 445);
            this.tablaBitacora.TabIndex = 42;
            this.tablaBitacora.MouseEnter += new System.EventHandler(this.tablaBitacora_MouseEnter);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(661, 512);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 20);
            this.txtBuscar.TabIndex = 44;
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
            this.label1.TabIndex = 43;
            this.label1.Text = "BUSCAR: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(260, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(375, 31);
            this.label9.TabIndex = 118;
            this.label9.Text = "BITÁCORAS REGISTRADAS";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "id_bit";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Usuario.DataPropertyName = "raz_usu";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 73;
            // 
            // Modulo
            // 
            this.Modulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Modulo.DataPropertyName = "mod_bit";
            this.Modulo.HeaderText = "Módulo";
            this.Modulo.MinimumWidth = 6;
            this.Modulo.Name = "Modulo";
            this.Modulo.ReadOnly = true;
            this.Modulo.Width = 72;
            // 
            // Accion
            // 
            this.Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Accion.DataPropertyName = "acc_bit";
            this.Accion.HeaderText = "Acción";
            this.Accion.MinimumWidth = 6;
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha.DataPropertyName = "fec_bit";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Fecha.Width = 45;
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Hora.DataPropertyName = "hor_bit";
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 57;
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
            // RegistrosBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnSiguiente);
            this.Controls.Add(this.comboPaginas);
            this.Controls.Add(this.bttnAnterior);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tablaBitacora);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "RegistrosBitacora";
            this.Size = new System.Drawing.Size(858, 551);
            ((System.ComponentModel.ISupportInitialize)(this.tablaBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaBitacora;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnSiguiente;
        private System.Windows.Forms.ComboBox comboPaginas;
        private System.Windows.Forms.Button bttnAnterior;
    }
}
