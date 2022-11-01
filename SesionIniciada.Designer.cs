
namespace New_MasterTrade
{
    partial class SesionIniciada
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
            this.components = new System.ComponentModel.Container();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.FormComprar = new New_MasterTrade.UserControls.Comprar();
            this.FormPersonas = new New_MasterTrade.Personas();
            this.formProductos = new New_MasterTrade.UserControls.ResgistrosProductos_Prototipo();
            this.bttnMinimizar = new System.Windows.Forms.Button();
            this.bttnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bttnProductos = new System.Windows.Forms.Button();
            this.bttnPersonas = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.bttnVentas = new System.Windows.Forms.Button();
            this.bttnCatalogo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnVender = new System.Windows.Forms.Button();
            this.bttnComprar = new System.Windows.Forms.Button();
            this.panelDropDown2 = new System.Windows.Forms.Panel();
            this.bttnConfig = new System.Windows.Forms.Button();
            this.bttnUsuarios = new System.Windows.Forms.Button();
            this.bttnSeguridad = new System.Windows.Forms.Button();
            this.bttnRespaldo = new System.Windows.Forms.Button();
            this.bttnAjustes = new System.Windows.Forms.Button();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.usuarios1 = new New_MasterTrade.UserControls.Usuarios();
            this.PanelContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelDropDown2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Controls.Add(this.usuarios1);
            this.PanelContenedor.Controls.Add(this.FormComprar);
            this.PanelContenedor.Controls.Add(this.FormPersonas);
            this.PanelContenedor.Controls.Add(this.formProductos);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelContenedor.Location = new System.Drawing.Point(102, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(5);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(858, 552);
            this.PanelContenedor.TabIndex = 0;
            // 
            // FormComprar
            // 
            this.FormComprar.BackColor = System.Drawing.SystemColors.Control;
            this.FormComprar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormComprar.Location = new System.Drawing.Point(0, 0);
            this.FormComprar.Margin = new System.Windows.Forms.Padding(4);
            this.FormComprar.Name = "FormComprar";
            this.FormComprar.Size = new System.Drawing.Size(858, 552);
            this.FormComprar.TabIndex = 5;
            // 
            // FormPersonas
            // 
            this.FormPersonas.BackColor = System.Drawing.Color.White;
            this.FormPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPersonas.Location = new System.Drawing.Point(0, 0);
            this.FormPersonas.Name = "FormPersonas";
            this.FormPersonas.Size = new System.Drawing.Size(858, 552);
            this.FormPersonas.TabIndex = 11;
            // 
            // formProductos
            // 
            this.formProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formProductos.Location = new System.Drawing.Point(0, 0);
            this.formProductos.Margin = new System.Windows.Forms.Padding(2);
            this.formProductos.Name = "formProductos";
            this.formProductos.Size = new System.Drawing.Size(858, 552);
            this.formProductos.TabIndex = 10;
            // 
            // bttnMinimizar
            // 
            this.bttnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.bttnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMinimizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMinimizar.ForeColor = System.Drawing.Color.White;
            this.bttnMinimizar.Location = new System.Drawing.Point(893, 3);
            this.bttnMinimizar.Name = "bttnMinimizar";
            this.bttnMinimizar.Size = new System.Drawing.Size(29, 28);
            this.bttnMinimizar.TabIndex = 1;
            this.bttnMinimizar.Text = "-";
            this.bttnMinimizar.UseVisualStyleBackColor = false;
            this.bttnMinimizar.Click += new System.EventHandler(this.bttnMinimizar_Click);
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCerrar.ForeColor = System.Drawing.Color.White;
            this.bttnCerrar.Location = new System.Drawing.Point(928, 3);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(29, 28);
            this.bttnCerrar.TabIndex = 0;
            this.bttnCerrar.Text = "X";
            this.bttnCerrar.UseVisualStyleBackColor = true;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.bttnMinimizar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.bttnCerrar);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 34);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(848, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "V";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(12, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // bttnProductos
            // 
            this.bttnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.bttnProductos.FlatAppearance.BorderSize = 0;
            this.bttnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnProductos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnProductos.Location = new System.Drawing.Point(0, 60);
            this.bttnProductos.Name = "bttnProductos";
            this.bttnProductos.Size = new System.Drawing.Size(95, 30);
            this.bttnProductos.TabIndex = 10;
            this.bttnProductos.Text = "PRODUCTOS";
            this.bttnProductos.UseVisualStyleBackColor = false;
            this.bttnProductos.Click += new System.EventHandler(this.bttnProductos_Click);
            // 
            // bttnPersonas
            // 
            this.bttnPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.bttnPersonas.FlatAppearance.BorderSize = 0;
            this.bttnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPersonas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPersonas.Location = new System.Drawing.Point(0, 30);
            this.bttnPersonas.Name = "bttnPersonas";
            this.bttnPersonas.Size = new System.Drawing.Size(95, 30);
            this.bttnPersonas.TabIndex = 11;
            this.bttnPersonas.Text = "PERSONAS";
            this.bttnPersonas.UseVisualStyleBackColor = false;
            this.bttnPersonas.Click += new System.EventHandler(this.bttnPersonas_Click);
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.White;
            this.panelDropDown.Controls.Add(this.bttnVentas);
            this.panelDropDown.Controls.Add(this.bttnCatalogo);
            this.panelDropDown.Controls.Add(this.bttnPersonas);
            this.panelDropDown.Controls.Add(this.bttnProductos);
            this.panelDropDown.Location = new System.Drawing.Point(3, 75);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(95, 120);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(95, 30);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(95, 120);
            this.panelDropDown.TabIndex = 14;
            // 
            // bttnVentas
            // 
            this.bttnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.bttnVentas.FlatAppearance.BorderSize = 0;
            this.bttnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVentas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVentas.Location = new System.Drawing.Point(0, 90);
            this.bttnVentas.Name = "bttnVentas";
            this.bttnVentas.Size = new System.Drawing.Size(95, 30);
            this.bttnVentas.TabIndex = 16;
            this.bttnVentas.Text = "VENTAS";
            this.bttnVentas.UseVisualStyleBackColor = false;
            // 
            // bttnCatalogo
            // 
            this.bttnCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bttnCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnCatalogo.FlatAppearance.BorderSize = 0;
            this.bttnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCatalogo.Font = new System.Drawing.Font("Arial", 9F);
            this.bttnCatalogo.Location = new System.Drawing.Point(0, 0);
            this.bttnCatalogo.Name = "bttnCatalogo";
            this.bttnCatalogo.Size = new System.Drawing.Size(95, 30);
            this.bttnCatalogo.TabIndex = 14;
            this.bttnCatalogo.Text = "REGISTROS";
            this.bttnCatalogo.UseVisualStyleBackColor = false;
            this.bttnCatalogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.bttnVender);
            this.flowLayoutPanel1.Controls.Add(this.bttnComprar);
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown);
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown2);
            this.flowLayoutPanel1.Controls.Add(this.bttnSalir);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(102, 552);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // bttnVender
            // 
            this.bttnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bttnVender.FlatAppearance.BorderSize = 0;
            this.bttnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVender.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVender.Location = new System.Drawing.Point(3, 3);
            this.bttnVender.Name = "bttnVender";
            this.bttnVender.Size = new System.Drawing.Size(95, 30);
            this.bttnVender.TabIndex = 9;
            this.bttnVender.Text = "VENDER";
            this.bttnVender.UseVisualStyleBackColor = false;
            // 
            // bttnComprar
            // 
            this.bttnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bttnComprar.FlatAppearance.BorderSize = 0;
            this.bttnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnComprar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnComprar.Location = new System.Drawing.Point(3, 39);
            this.bttnComprar.Name = "bttnComprar";
            this.bttnComprar.Size = new System.Drawing.Size(95, 30);
            this.bttnComprar.TabIndex = 8;
            this.bttnComprar.Text = "COMPRAR";
            this.bttnComprar.UseVisualStyleBackColor = false;
            this.bttnComprar.Click += new System.EventHandler(this.bttnComprar_Click);
            // 
            // panelDropDown2
            // 
            this.panelDropDown2.Controls.Add(this.bttnConfig);
            this.panelDropDown2.Controls.Add(this.bttnUsuarios);
            this.panelDropDown2.Controls.Add(this.bttnSeguridad);
            this.panelDropDown2.Controls.Add(this.bttnRespaldo);
            this.panelDropDown2.Controls.Add(this.bttnAjustes);
            this.panelDropDown2.Location = new System.Drawing.Point(3, 201);
            this.panelDropDown2.MaximumSize = new System.Drawing.Size(95, 150);
            this.panelDropDown2.MinimumSize = new System.Drawing.Size(95, 33);
            this.panelDropDown2.Name = "panelDropDown2";
            this.panelDropDown2.Size = new System.Drawing.Size(95, 150);
            this.panelDropDown2.TabIndex = 15;
            // 
            // bttnConfig
            // 
            this.bttnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.bttnConfig.FlatAppearance.BorderSize = 0;
            this.bttnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnConfig.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnConfig.Location = new System.Drawing.Point(0, 120);
            this.bttnConfig.Name = "bttnConfig";
            this.bttnConfig.Size = new System.Drawing.Size(95, 30);
            this.bttnConfig.TabIndex = 20;
            this.bttnConfig.Text = "REPORTES";
            this.bttnConfig.UseVisualStyleBackColor = false;
            // 
            // bttnUsuarios
            // 
            this.bttnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.bttnUsuarios.FlatAppearance.BorderSize = 0;
            this.bttnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUsuarios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUsuarios.Location = new System.Drawing.Point(0, 63);
            this.bttnUsuarios.Name = "bttnUsuarios";
            this.bttnUsuarios.Size = new System.Drawing.Size(95, 30);
            this.bttnUsuarios.TabIndex = 19;
            this.bttnUsuarios.Text = "USUARIOS";
            this.bttnUsuarios.UseVisualStyleBackColor = false;
            // 
            // bttnSeguridad
            // 
            this.bttnSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.bttnSeguridad.FlatAppearance.BorderSize = 0;
            this.bttnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSeguridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSeguridad.Location = new System.Drawing.Point(0, 93);
            this.bttnSeguridad.Name = "bttnSeguridad";
            this.bttnSeguridad.Size = new System.Drawing.Size(95, 30);
            this.bttnSeguridad.TabIndex = 18;
            this.bttnSeguridad.Text = "SEGURIDAD";
            this.bttnSeguridad.UseVisualStyleBackColor = false;
            // 
            // bttnRespaldo
            // 
            this.bttnRespaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(101)))));
            this.bttnRespaldo.FlatAppearance.BorderSize = 0;
            this.bttnRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRespaldo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRespaldo.Location = new System.Drawing.Point(0, 33);
            this.bttnRespaldo.Name = "bttnRespaldo";
            this.bttnRespaldo.Size = new System.Drawing.Size(95, 30);
            this.bttnRespaldo.TabIndex = 17;
            this.bttnRespaldo.Text = "RESPALDO";
            this.bttnRespaldo.UseVisualStyleBackColor = false;
            // 
            // bttnAjustes
            // 
            this.bttnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bttnAjustes.FlatAppearance.BorderSize = 0;
            this.bttnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAjustes.Font = new System.Drawing.Font("Arial", 9F);
            this.bttnAjustes.Location = new System.Drawing.Point(0, 3);
            this.bttnAjustes.Name = "bttnAjustes";
            this.bttnAjustes.Size = new System.Drawing.Size(95, 30);
            this.bttnAjustes.TabIndex = 13;
            this.bttnAjustes.Text = "AJUSTES";
            this.bttnAjustes.UseVisualStyleBackColor = false;
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.bttnSalir.FlatAppearance.BorderSize = 0;
            this.bttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalir.Font = new System.Drawing.Font("Arial", 9F);
            this.bttnSalir.Location = new System.Drawing.Point(3, 357);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(95, 30);
            this.bttnSalir.TabIndex = 12;
            this.bttnSalir.Text = "SALIR";
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelContenedor);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 552);
            this.panel1.TabIndex = 11;
            // 
            // usuarios1
            // 
            this.usuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarios1.Location = new System.Drawing.Point(0, 0);
            this.usuarios1.Name = "usuarios1";
            this.usuarios1.Size = new System.Drawing.Size(858, 552);
            this.usuarios1.TabIndex = 12;
            // 
            // SesionIniciada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SesionIniciada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SesionIniciada";
            this.PanelContenedor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDropDown.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelDropDown2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button bttnCerrar;
        private System.Windows.Forms.Button bttnMinimizar;
        private System.Windows.Forms.Panel panel2;
        private UserControls.Comprar FormComprar;
        private System.Windows.Forms.Button bttnProductos;
        private System.Windows.Forms.Button bttnPersonas;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bttnVender;
        private System.Windows.Forms.Button bttnCatalogo;
        private System.Windows.Forms.Button bttnComprar;
        private System.Windows.Forms.Button bttnAjustes;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Button bttnVentas;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panelDropDown2;
        private System.Windows.Forms.Button bttnConfig;
        private System.Windows.Forms.Button bttnUsuarios;
        private System.Windows.Forms.Button bttnSeguridad;
        private System.Windows.Forms.Button bttnRespaldo;
        private System.Windows.Forms.Timer timer2;
        private UserControls.ResgistrosProductos_Prototipo formProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Personas FormPersonas;
        private UserControls.Usuarios usuarios1;
    }
}