
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
            this.components = new System.ComponentModel.Container();
            this.tablaCategorias = new System.Windows.Forms.DataGridView();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.timerDropDown = new System.Windows.Forms.Timer(this.components);
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).BeginInit();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaCategorias
            // 
            this.tablaCategorias.AllowUserToAddRows = false;
            this.tablaCategorias.AllowUserToDeleteRows = false;
            this.tablaCategorias.AllowUserToResizeColumns = false;
            this.tablaCategorias.AllowUserToResizeRows = false;
            this.tablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNombre,
            this.columnEditar,
            this.columnEliminar});
            this.tablaCategorias.Location = new System.Drawing.Point(12, 306);
            this.tablaCategorias.Name = "tablaCategorias";
            this.tablaCategorias.ReadOnly = true;
            this.tablaCategorias.Size = new System.Drawing.Size(898, 413);
            this.tablaCategorias.TabIndex = 0;
            this.tablaCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCategorias_CellClick);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.bttnGuardar);
            this.panelDropDown.Controls.Add(this.txtNombre);
            this.panelDropDown.Controls.Add(this.label2);
            this.panelDropDown.Controls.Add(this.txtId);
            this.panelDropDown.Controls.Add(this.label1);
            this.panelDropDown.Location = new System.Drawing.Point(12, 200);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(898, 100);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(898, 0);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(898, 100);
            this.panelDropDown.TabIndex = 1;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnGuardar.FlatAppearance.BorderSize = 0;
            this.bttnGuardar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.Location = new System.Drawing.Point(785, 33);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(90, 40);
            this.bttnGuardar.TabIndex = 9;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(230, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(520, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(157, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "NOMBRE:";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.SystemColors.Control;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(41, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 26);
            this.txtId.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "CATEGORÍAS";
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.Location = new System.Drawing.Point(822, 17);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(70, 40);
            this.bttnAgregar.TabIndex = 22;
            this.bttnAgregar.Text = "AGREGAR";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // timerDropDown
            // 
            this.timerDropDown.Interval = 10;
            this.timerDropDown.Tick += new System.EventHandler(this.timerDropDown_Tick);
            // 
            // columnId
            // 
            this.columnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnId.DataPropertyName = "id";
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnNombre
            // 
            this.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNombre.DataPropertyName = "nombre";
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            // 
            // columnEditar
            // 
            this.columnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEditar.HeaderText = "Editar";
            this.columnEditar.Name = "columnEditar";
            this.columnEditar.ReadOnly = true;
            this.columnEditar.Text = "EDITAR";
            this.columnEditar.UseColumnTextForButtonValue = true;
            // 
            // columnEliminar
            // 
            this.columnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEliminar.HeaderText = "Eliminar";
            this.columnEliminar.Name = "columnEliminar";
            this.columnEliminar.ReadOnly = true;
            this.columnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnEliminar.Text = "ELIMINAR";
            this.columnEliminar.UseColumnTextForButtonValue = true;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.tablaCategorias);
            this.Name = "Categorias";
            this.Size = new System.Drawing.Size(922, 734);
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCategorias)).EndInit();
            this.panelDropDown.ResumeLayout(false);
            this.panelDropDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCategorias;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Timer timerDropDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewButtonColumn columnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn columnEliminar;
    }
}
