
namespace New_MasterTrade.Forms
{
    partial class Credenciales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasegna = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasegna = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chckMostrar = new System.Windows.Forms.CheckBox();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(164, 101);
            this.txtNombreUsuario.MaxLength = 15;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(253, 20);
            this.txtNombreUsuario.TabIndex = 0;
            // 
            // txtContrasegna
            // 
            this.txtContrasegna.Location = new System.Drawing.Point(163, 134);
            this.txtContrasegna.MaxLength = 15;
            this.txtContrasegna.Name = "txtContrasegna";
            this.txtContrasegna.Size = new System.Drawing.Size(253, 20);
            this.txtContrasegna.TabIndex = 1;
            // 
            // txtConfirmarContrasegna
            // 
            this.txtConfirmarContrasegna.Location = new System.Drawing.Point(164, 167);
            this.txtConfirmarContrasegna.MaxLength = 15;
            this.txtConfirmarContrasegna.Name = "txtConfirmarContrasegna";
            this.txtConfirmarContrasegna.Size = new System.Drawing.Size(253, 20);
            this.txtConfirmarContrasegna.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(163, 68);
            this.txtId.MaxLength = 15;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(253, 20);
            this.txtId.TabIndex = 3;
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.bttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnGuardar.Location = new System.Drawing.Point(126, 249);
            this.bttnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(86, 24);
            this.bttnGuardar.TabIndex = 6;
            this.bttnGuardar.Text = "GUARDAR";
            this.bttnGuardar.UseVisualStyleBackColor = false;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.bttnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnActualizar.Location = new System.Drawing.Point(216, 249);
            this.bttnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(86, 24);
            this.bttnActualizar.TabIndex = 7;
            this.bttnActualizar.Text = "ACTUALIZAR";
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE DE USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(11, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // chckMostrar
            // 
            this.chckMostrar.AutoSize = true;
            this.chckMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chckMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckMostrar.ForeColor = System.Drawing.SystemColors.Control;
            this.chckMostrar.Location = new System.Drawing.Point(164, 199);
            this.chckMostrar.Name = "chckMostrar";
            this.chckMostrar.Size = new System.Drawing.Size(114, 17);
            this.chckMostrar.TabIndex = 13;
            this.chckMostrar.Text = "Mostrar contraseña";
            this.chckMostrar.UseVisualStyleBackColor = true;
            this.chckMostrar.CheckedChanged += new System.EventHandler(this.chckMostrar_CheckedChanged);
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalir.Image = global::New_MasterTrade.Properties.Resources.cancel;
            this.bttnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSalir.Location = new System.Drawing.Point(338, 11);
            this.bttnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(80, 28);
            this.bttnSalir.TabIndex = 119;
            this.bttnSalir.Text = "SALIR";
            this.bttnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(101, 10);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 31);
            this.lblTitulo.TabIndex = 120;
            this.lblTitulo.Text = "CREDENCIALES";
            // 
            // Credenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(429, 284);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.chckMostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtConfirmarContrasegna);
            this.Controls.Add(this.txtContrasegna);
            this.Controls.Add(this.txtNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Credenciales";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasegna;
        private System.Windows.Forms.TextBox txtConfirmarContrasegna;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chckMostrar;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Label lblTitulo;
    }
}