﻿
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
            this.label4 = new System.Windows.Forms.Label();
            this.bttnNuevo = new System.Windows.Forms.Button();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.comboDocumento = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContrasegna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContrasegna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
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
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "USUARIOS";
            // 
            // bttnNuevo
            // 
            this.bttnNuevo.Location = new System.Drawing.Point(822, 17);
            this.bttnNuevo.Name = "bttnNuevo";
            this.bttnNuevo.Size = new System.Drawing.Size(70, 40);
            this.bttnNuevo.TabIndex = 22;
            this.bttnNuevo.Text = "NUEVO";
            this.bttnNuevo.UseVisualStyleBackColor = true;
            this.bttnNuevo.Click += new System.EventHandler(this.bttnNuevo_Click);
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
            this.ColumnUsuario,
            this.columnContrasegna,
            this.columnNombre,
            this.ColumnApellido,
            this.ColumnNivel});
            this.tablaUsuarios.Location = new System.Drawing.Point(10, 63);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUsuarios.Size = new System.Drawing.Size(461, 654);
            this.tablaUsuarios.TabIndex = 23;
            this.tablaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellClick);
            // 
            // comboDocumento
            // 
            this.comboDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.comboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDocumento.FormattingEnabled = true;
            this.comboDocumento.Location = new System.Drawing.Point(599, 162);
            this.comboDocumento.Name = "comboDocumento";
            this.comboDocumento.Size = new System.Drawing.Size(75, 28);
            this.comboDocumento.TabIndex = 26;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(680, 163);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(222, 26);
            this.txtDocumento.TabIndex = 24;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(487, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "DOCUMENTO\r\nDE IDENTIDAD:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(599, 247);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 26);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(487, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "NOMBRE:";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(599, 331);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(303, 26);
            this.txtApellido.TabIndex = 29;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(487, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "APELLIDO:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(599, 415);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(303, 26);
            this.txtUsuario.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(487, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "USUARIO:";
            // 
            // txtContrasegna
            // 
            this.txtContrasegna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasegna.BackColor = System.Drawing.SystemColors.Control;
            this.txtContrasegna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasegna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasegna.Location = new System.Drawing.Point(599, 499);
            this.txtContrasegna.Name = "txtContrasegna";
            this.txtContrasegna.Size = new System.Drawing.Size(303, 26);
            this.txtContrasegna.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(487, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "CONTRASEÑA:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(488, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "NIVEL";
            // 
            // comboNivel
            // 
            this.comboNivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboNivel.BackColor = System.Drawing.SystemColors.Control;
            this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Location = new System.Drawing.Point(599, 583);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(303, 28);
            this.comboNivel.TabIndex = 36;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnGuardar.FlatAppearance.BorderSize = 0;
            this.bttnGuardar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.Location = new System.Drawing.Point(812, 677);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(90, 40);
            this.bttnGuardar.TabIndex = 37;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnCancelar.FlatAppearance.BorderSize = 0;
            this.bttnCancelar.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.Location = new System.Drawing.Point(716, 677);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(90, 40);
            this.bttnCancelar.TabIndex = 38;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(488, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(599, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(303, 26);
            this.txtID.TabIndex = 40;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnId.DataPropertyName = "id_usuario";
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnUsuario
            // 
            this.ColumnUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUsuario.DataPropertyName = "usuario";
            this.ColumnUsuario.HeaderText = "Usuario";
            this.ColumnUsuario.Name = "ColumnUsuario";
            // 
            // columnContrasegna
            // 
            this.columnContrasegna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnContrasegna.DataPropertyName = "contrasegna";
            this.columnContrasegna.HeaderText = "Contraseña";
            this.columnContrasegna.Name = "columnContrasegna";
            // 
            // columnNombre
            // 
            this.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNombre.DataPropertyName = "nombre";
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnApellido.DataPropertyName = "apellido";
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.Name = "ColumnApellido";
            // 
            // ColumnNivel
            // 
            this.ColumnNivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNivel.DataPropertyName = "nivel";
            this.ColumnNivel.HeaderText = "Nivel";
            this.ColumnNivel.Name = "ColumnNivel";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.comboNivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContrasegna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.bttnNuevo);
            this.Controls.Add(this.label4);
            this.Name = "Usuarios";
            this.Size = new System.Drawing.Size(922, 734);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnNuevo;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.ComboBox comboDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContrasegna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContrasegna;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNivel;
    }
}
