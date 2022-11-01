
namespace New_MasterTrade
{
    partial class Personas
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
            this.tablaPersonas = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCargar = new System.Windows.Forms.Button();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.comboTabla = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPersonas
            // 
            this.tablaPersonas.AllowUserToAddRows = false;
            this.tablaPersonas.AllowUserToDeleteRows = false;
            this.tablaPersonas.AllowUserToResizeColumns = false;
            this.tablaPersonas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.Documento,
            this.RazonSocial,
            this.Direccion,
            this.Telefono,
            this.Correo,
            this.btnEliminar});
            this.tablaPersonas.Location = new System.Drawing.Point(0, 0);
            this.tablaPersonas.Margin = new System.Windows.Forms.Padding(10);
            this.tablaPersonas.MultiSelect = false;
            this.tablaPersonas.Name = "tablaPersonas";
            this.tablaPersonas.ReadOnly = true;
            this.tablaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPersonas.Size = new System.Drawing.Size(858, 494);
            this.tablaPersonas.TabIndex = 32;
            this.tablaPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPersonas_CellClick);
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.DataPropertyName = "id";
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.DataPropertyName = "doc_id";
            this.Documento.HeaderText = "Documento de identidad";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RazonSocial.DataPropertyName = "raz_soc";
            this.RazonSocial.HeaderText = "Razón social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "direcc";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.DataPropertyName = "email";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Text = "DETALLES";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(661, 512);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 20);
            this.txtBuscar.TabIndex = 38;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "BUSCAR: ";
            // 
            // bttnCargar
            // 
            this.bttnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCargar.Location = new System.Drawing.Point(101, 510);
            this.bttnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCargar.Name = "bttnCargar";
            this.bttnCargar.Size = new System.Drawing.Size(85, 24);
            this.bttnCargar.TabIndex = 40;
            this.bttnCargar.Text = "CARGAR";
            this.bttnCargar.UseVisualStyleBackColor = true;
            this.bttnCargar.Click += new System.EventHandler(this.bttnCargar_Click);
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregar.Location = new System.Drawing.Point(12, 510);
            this.bttnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(85, 24);
            this.bttnAgregar.TabIndex = 39;
            this.bttnAgregar.Text = "REGISTRAR";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // comboTabla
            // 
            this.comboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTabla.FormattingEnabled = true;
            this.comboTabla.Location = new System.Drawing.Point(452, 512);
            this.comboTabla.Name = "comboTabla";
            this.comboTabla.Size = new System.Drawing.Size(129, 21);
            this.comboTabla.TabIndex = 56;
            this.comboTabla.SelectedIndexChanged += new System.EventHandler(this.comboTabla_SelectedIndexChanged_1);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboTabla);
            this.Controls.Add(this.bttnCargar);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaPersonas);
            this.Name = "Personas";
            this.Size = new System.Drawing.Size(858, 551);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaPersonas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCargar;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.ComboBox comboTabla;
    }
}
