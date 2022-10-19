
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaPersonas = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTabla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboOcupacion = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboDocumento = new System.Windows.Forms.ComboBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnAtras = new System.Windows.Forms.Button();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonas)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaPersonas
            // 
            this.tablaPersonas.AllowUserToAddRows = false;
            this.tablaPersonas.AllowUserToDeleteRows = false;
            this.tablaPersonas.AllowUserToResizeColumns = false;
            this.tablaPersonas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaPersonas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaPersonas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.RazonSocial,
            this.Direccion,
            this.Telefono,
            this.Correo,
            this.btnEditar,
            this.btnEliminar});
            this.tablaPersonas.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaPersonas.Location = new System.Drawing.Point(10, 132);
            this.tablaPersonas.Margin = new System.Windows.Forms.Padding(10);
            this.tablaPersonas.MultiSelect = false;
            this.tablaPersonas.Name = "tablaPersonas";
            this.tablaPersonas.ReadOnly = true;
            this.tablaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPersonas.Size = new System.Drawing.Size(902, 592);
            this.tablaPersonas.TabIndex = 32;
            this.tablaPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPersonas_CellClick);
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Documento.DataPropertyName = "documento_identidad";
            this.Documento.HeaderText = "Documento de identidad";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RazonSocial.DataPropertyName = "razon_social";
            this.RazonSocial.HeaderText = "Razón social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "direccion";
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
            this.Correo.DataPropertyName = "correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnActualizar.FlatAppearance.BorderSize = 0;
            this.bttnActualizar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnActualizar.Location = new System.Drawing.Point(673, 545);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(90, 40);
            this.bttnActualizar.TabIndex = 7;
            this.bttnActualizar.Text = "ACTUALIZAR";
            this.bttnActualizar.UseVisualStyleBackColor = true;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnGuardar.FlatAppearance.BorderSize = 0;
            this.bttnGuardar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.Location = new System.Drawing.Point(769, 545);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(90, 40);
            this.bttnGuardar.TabIndex = 8;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(339, 168);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(520, 26);
            this.txtDocumento.TabIndex = 0;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "DOCCUMENTO DE IDENTIDAD:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(621, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "BUSCAR";
            // 
            // comboTabla
            // 
            this.comboTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTabla.BackColor = System.Drawing.Color.White;
            this.comboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTabla.FormattingEnabled = true;
            this.comboTabla.Location = new System.Drawing.Point(97, 94);
            this.comboTabla.Name = "comboTabla";
            this.comboTabla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboTabla.Size = new System.Drawing.Size(173, 28);
            this.comboTabla.TabIndex = 9;
            this.comboTabla.SelectedIndexChanged += new System.EventHandler(this.comboTabla_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "TABLA";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(703, 95);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(211, 26);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(46, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "OCUPACIÓN";
            // 
            // comboOcupacion
            // 
            this.comboOcupacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboOcupacion.BackColor = System.Drawing.SystemColors.Control;
            this.comboOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboOcupacion.FormattingEnabled = true;
            this.comboOcupacion.Location = new System.Drawing.Point(258, 506);
            this.comboOcupacion.Name = "comboOcupacion";
            this.comboOcupacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboOcupacion.Size = new System.Drawing.Size(601, 28);
            this.comboOcupacion.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(258, 466);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(601, 26);
            this.txtCorreo.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(46, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "CORREO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(258, 426);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(601, 26);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(46, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "TELÉFONO";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(258, 238);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(601, 179);
            this.txtDireccion.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "DIRECCIÓN";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(258, 203);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(601, 26);
            this.txtRazonSocial.TabIndex = 1;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "RAZÓN SOCIAL";
            // 
            // comboDocumento
            // 
            this.comboDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.comboDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDocumento.FormattingEnabled = true;
            this.comboDocumento.Location = new System.Drawing.Point(258, 167);
            this.comboDocumento.Name = "comboDocumento";
            this.comboDocumento.Size = new System.Drawing.Size(75, 28);
            this.comboDocumento.TabIndex = 18;
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnCancelar.FlatAppearance.BorderSize = 0;
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.Location = new System.Drawing.Point(577, 545);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(90, 40);
            this.bttnCancelar.TabIndex = 9;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.Location = new System.Drawing.Point(822, 17);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(90, 40);
            this.bttnRegistrar.TabIndex = 37;
            this.bttnRegistrar.Text = "REGISTRAR";
            this.bttnRegistrar.UseVisualStyleBackColor = true;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSlide.Controls.Add(this.label4);
            this.panelSlide.Controls.Add(this.bttnAtras);
            this.panelSlide.Controls.Add(this.comboDocumento);
            this.panelSlide.Controls.Add(this.bttnActualizar);
            this.panelSlide.Controls.Add(this.txtDocumento);
            this.panelSlide.Controls.Add(this.bttnGuardar);
            this.panelSlide.Controls.Add(this.bttnCancelar);
            this.panelSlide.Controls.Add(this.txtRazonSocial);
            this.panelSlide.Controls.Add(this.txtDireccion);
            this.panelSlide.Controls.Add(this.txtTelefono);
            this.panelSlide.Controls.Add(this.txtCorreo);
            this.panelSlide.Controls.Add(this.comboOcupacion);
            this.panelSlide.Controls.Add(this.label12);
            this.panelSlide.Controls.Add(this.label1);
            this.panelSlide.Controls.Add(this.label11);
            this.panelSlide.Controls.Add(this.label10);
            this.panelSlide.Controls.Add(this.label9);
            this.panelSlide.Controls.Add(this.label8);
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.MaximumSize = new System.Drawing.Size(922, 734);
            this.panelSlide.MinimumSize = new System.Drawing.Size(2, 734);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(922, 734);
            this.panelSlide.TabIndex = 38;
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
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "FORMULARIO";
            // 
            // bttnAtras
            // 
            this.bttnAtras.Location = new System.Drawing.Point(822, 17);
            this.bttnAtras.Name = "bttnAtras";
            this.bttnAtras.Size = new System.Drawing.Size(70, 40);
            this.bttnAtras.TabIndex = 19;
            this.bttnAtras.Text = "ATRÁS";
            this.bttnAtras.UseVisualStyleBackColor = true;
            this.bttnAtras.Click += new System.EventHandler(this.bttnAtras_Click);
            // 
            // timerSlide
            // 
            this.timerSlide.Interval = 1;
            this.timerSlide.Tick += new System.EventHandler(this.timerSlide_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bttnRegistrar);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.comboTabla);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tablaPersonas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 734);
            this.panel2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "REGISTROS";
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel2);
            this.Name = "Personas";
            this.Size = new System.Drawing.Size(922, 734);
            this.Load += new System.EventHandler(this.Personas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonas)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaPersonas;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboOcupacion;
        private System.Windows.Forms.ComboBox comboTabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Timer timerSlide;
        private System.Windows.Forms.Button bttnAtras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
