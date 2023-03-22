
namespace New_MasterTrade.UserControls
{
    partial class FormularioUsuarios
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
            this.comboDocumento = new System.Windows.Forms.ComboBox();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContrasegna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chckMostrar = new System.Windows.Forms.CheckBox();
            this.chckVendedor = new System.Windows.Forms.CheckBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bttnAtrás = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboDocumento
            // 
            this.comboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumento.FormattingEnabled = true;
            this.comboDocumento.Location = new System.Drawing.Point(216, 260);
            this.comboDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.comboDocumento.Name = "comboDocumento";
            this.comboDocumento.Size = new System.Drawing.Size(55, 24);
            this.comboDocumento.TabIndex = 74;
            // 
            // comboNivel
            // 
            this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Location = new System.Drawing.Point(216, 85);
            this.comboNivel.Margin = new System.Windows.Forms.Padding(4);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(851, 24);
            this.comboNivel.TabIndex = 73;
            this.comboNivel.SelectedIndexChanged += new System.EventHandler(this.comboNivel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(77, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "NIVEL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmar.Location = new System.Drawing.Point(216, 435);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmar.MaxLength = 80;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(851, 22);
            this.txtConfirmar.TabIndex = 71;
            this.txtConfirmar.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtConfirmar.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(79, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 70;
            this.label5.Text = "CONFIRMAR\r\nCONTRASEÑA";
            // 
            // txtContrasegna
            // 
            this.txtContrasegna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasegna.Location = new System.Drawing.Point(216, 377);
            this.txtContrasegna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasegna.MaxLength = 80;
            this.txtContrasegna.Name = "txtContrasegna";
            this.txtContrasegna.Size = new System.Drawing.Size(851, 22);
            this.txtContrasegna.TabIndex = 69;
            this.txtContrasegna.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtContrasegna.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(80, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(216, 145);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(851, 22);
            this.txtUsuario.TabIndex = 67;
            this.txtUsuario.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(77, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "USUARIO";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Location = new System.Drawing.Point(279, 261);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.MaxLength = 10;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(788, 22);
            this.txtDocumento.TabIndex = 65;
            this.txtDocumento.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            this.txtDocumento.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(79, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 64;
            this.label1.Text = "DOCUMENTO DE\r\nIDENTIDAD";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(216, 203);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(851, 22);
            this.txtNombre.TabIndex = 63;
            this.txtNombre.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            this.txtNombre.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(79, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "NOMBRE";
            // 
            // chckMostrar
            // 
            this.chckMostrar.AutoSize = true;
            this.chckMostrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.chckMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.chckMostrar.Location = new System.Drawing.Point(216, 493);
            this.chckMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.chckMostrar.Name = "chckMostrar";
            this.chckMostrar.Size = new System.Drawing.Size(140, 20);
            this.chckMostrar.TabIndex = 79;
            this.chckMostrar.Text = "Mostrar contraseña";
            this.chckMostrar.UseVisualStyleBackColor = true;
            this.chckMostrar.CheckedChanged += new System.EventHandler(this.chckMostrar_CheckedChanged);
            // 
            // chckVendedor
            // 
            this.chckVendedor.AutoSize = true;
            this.chckVendedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.chckVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckVendedor.ForeColor = System.Drawing.SystemColors.Control;
            this.chckVendedor.Location = new System.Drawing.Point(216, 549);
            this.chckVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.chckVendedor.Name = "chckVendedor";
            this.chckVendedor.Size = new System.Drawing.Size(169, 20);
            this.chckVendedor.TabIndex = 81;
            this.chckVendedor.Text = "Asignar cómo vendedor";
            this.chckVendedor.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(216, 319);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.MaxLength = 150;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(851, 22);
            this.txtCorreo.TabIndex = 83;
            this.txtCorreo.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(80, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "CORREO";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(85)))), ((int)(((byte)(93)))));
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Image = global::New_MasterTrade.Properties.Resources.cancel;
            this.bttnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnCancelar.Location = new System.Drawing.Point(325, 628);
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(147, 30);
            this.bttnCancelar.TabIndex = 78;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnCancelar.UseVisualStyleBackColor = false;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.bttnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnActualizar.Image = global::New_MasterTrade.Properties.Resources.refresh;
            this.bttnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnActualizar.Location = new System.Drawing.Point(172, 628);
            this.bttnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(147, 30);
            this.bttnActualizar.TabIndex = 76;
            this.bttnActualizar.Text = "ACTUALIZAR";
            this.bttnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Image = global::New_MasterTrade.Properties.Resources.floppy_disk1;
            this.bttnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnGuardar.Location = new System.Drawing.Point(19, 628);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(147, 30);
            this.bttnGuardar.TabIndex = 75;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(417, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 32);
            this.label9.TabIndex = 120;
            this.label9.Text = "REGISTRAR USUARIO";
            // 
            // bttnAtrás
            // 
            this.bttnAtrás.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnAtrás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAtrás.Image = global::New_MasterTrade.Properties.Resources.atras;
            this.bttnAtrás.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAtrás.Location = new System.Drawing.Point(19, 12);
            this.bttnAtrás.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAtrás.Name = "bttnAtrás";
            this.bttnAtrás.Size = new System.Drawing.Size(106, 34);
            this.bttnAtrás.TabIndex = 121;
            this.bttnAtrás.Text = "ATRÁS";
            this.bttnAtrás.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnAtrás.UseVisualStyleBackColor = false;
            this.bttnAtrás.Click += new System.EventHandler(this.bttnAtrás_Click);
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.bttnAtrás);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chckVendedor);
            this.Controls.Add(this.chckMostrar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.comboDocumento);
            this.Controls.Add(this.comboNivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContrasegna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioUsuarios";
            this.Size = new System.Drawing.Size(1144, 678);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDocumento;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContrasegna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.CheckBox chckMostrar;
        private System.Windows.Forms.CheckBox chckVendedor;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bttnAtrás;
    }
}
