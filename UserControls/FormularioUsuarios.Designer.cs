﻿
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
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnEliminar2 = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.chckMostrar = new System.Windows.Forms.CheckBox();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.chckVendedor = new System.Windows.Forms.CheckBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboDocumento
            // 
            this.comboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumento.FormattingEnabled = true;
            this.comboDocumento.Location = new System.Drawing.Point(512, 19);
            this.comboDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDocumento.Name = "comboDocumento";
            this.comboDocumento.Size = new System.Drawing.Size(55, 24);
            this.comboDocumento.TabIndex = 74;
            // 
            // comboNivel
            // 
            this.comboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Location = new System.Drawing.Point(126, 109);
            this.comboNivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(225, 24);
            this.comboNivel.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "NIVEL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmar.Location = new System.Drawing.Point(899, 64);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(225, 22);
            this.txtConfirmar.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(764, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 70;
            this.label5.Text = "CONFIRMAR\r\nCONTRASEÑA";
            // 
            // txtContrasegna
            // 
            this.txtContrasegna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasegna.Location = new System.Drawing.Point(512, 64);
            this.txtContrasegna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContrasegna.Name = "txtContrasegna";
            this.txtContrasegna.Size = new System.Drawing.Size(225, 22);
            this.txtContrasegna.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(126, 64);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(225, 22);
            this.txtUsuario.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "USUARIO";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Location = new System.Drawing.Point(575, 19);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(162, 22);
            this.txtDocumento.TabIndex = 65;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 64;
            this.label1.Text = "DOCUMENTO DE\r\nIDENTIDAD";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(126, 19);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 22);
            this.txtNombre.TabIndex = 63;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyLetters);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "NOMBRE";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancelar.Location = new System.Drawing.Point(391, 199);
            this.bttnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(113, 30);
            this.bttnCancelar.TabIndex = 78;
            this.bttnCancelar.Text = "CANCELAR";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnEliminar2
            // 
            this.bttnEliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEliminar2.Location = new System.Drawing.Point(270, 199);
            this.bttnEliminar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnEliminar2.Name = "bttnEliminar2";
            this.bttnEliminar2.Size = new System.Drawing.Size(113, 30);
            this.bttnEliminar2.TabIndex = 77;
            this.bttnEliminar2.Text = "ELIMINAR";
            this.bttnEliminar2.UseVisualStyleBackColor = true;
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnActualizar.Location = new System.Drawing.Point(148, 199);
            this.bttnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(113, 30);
            this.bttnActualizar.TabIndex = 76;
            this.bttnActualizar.Text = "ACTUALIZAR";
            this.bttnActualizar.UseVisualStyleBackColor = true;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Location = new System.Drawing.Point(27, 199);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(113, 30);
            this.bttnGuardar.TabIndex = 75;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // chckMostrar
            // 
            this.chckMostrar.AutoSize = true;
            this.chckMostrar.Location = new System.Drawing.Point(512, 113);
            this.chckMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chckMostrar.Name = "chckMostrar";
            this.chckMostrar.Size = new System.Drawing.Size(144, 20);
            this.chckMostrar.TabIndex = 79;
            this.chckMostrar.Text = "Mostrar contraseña";
            this.chckMostrar.UseVisualStyleBackColor = true;
            this.chckMostrar.CheckedChanged += new System.EventHandler(this.chckMostrar_CheckedChanged);
            // 
            // bttnSalir
            // 
            this.bttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalir.Location = new System.Drawing.Point(1011, 199);
            this.bttnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(113, 30);
            this.bttnSalir.TabIndex = 80;
            this.bttnSalir.Text = "SALIR";
            this.bttnSalir.UseVisualStyleBackColor = true;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // chckVendedor
            // 
            this.chckVendedor.AutoSize = true;
            this.chckVendedor.Location = new System.Drawing.Point(126, 156);
            this.chckVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chckVendedor.Name = "chckVendedor";
            this.chckVendedor.Size = new System.Drawing.Size(173, 20);
            this.chckVendedor.TabIndex = 81;
            this.chckVendedor.Text = "Asignar cómo vendedor";
            this.chckVendedor.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(899, 18);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(225, 22);
            this.txtCorreo.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(764, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 82;
            this.label7.Text = "CORREO";
            // 
            // FormularioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chckVendedor);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.chckMostrar);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnEliminar2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioUsuarios";
            this.Size = new System.Drawing.Size(1149, 246);
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
        private System.Windows.Forms.Button bttnEliminar2;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.CheckBox chckMostrar;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.CheckBox chckVendedor;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;
    }
}
