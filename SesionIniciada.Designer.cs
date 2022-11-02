
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
            this.bttnMinimizar = new System.Windows.Forms.Button();
            this.bttnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
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
            this.bttnUsuarios = new System.Windows.Forms.Button();
            this.bttnSeguridad = new System.Windows.Forms.Button();
            this.bttnAjustes = new System.Windows.Forms.Button();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDropDown3 = new System.Windows.Forms.Panel();
            this.bttnTransacciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FormUsuarios = new New_MasterTrade.UserControls.Usuarios();
            this.FormComprar = new New_MasterTrade.UserControls.Comprar();
            this.FormPersonas = new New_MasterTrade.Personas();
            this.formProductos = new New_MasterTrade.UserControls.ResgistrosProductos_Prototipo();
            this.PanelContenedor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelDropDown2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDropDown3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.Controls.Add(this.FormPersonas);
            this.PanelContenedor.Controls.Add(this.formProductos);
            this.PanelContenedor.Controls.Add(this.FormComprar);
            this.PanelContenedor.Controls.Add(this.FormUsuarios);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelContenedor.Location = new System.Drawing.Point(142, 0);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(5);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(858, 561);
            this.PanelContenedor.TabIndex = 0;
            // 
            // bttnMinimizar
            // 
            this.bttnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.bttnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMinimizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMinimizar.ForeColor = System.Drawing.Color.White;
            this.bttnMinimizar.Location = new System.Drawing.Point(932, 3);
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
            this.bttnCerrar.Location = new System.Drawing.Point(967, 3);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(29, 28);
            this.bttnCerrar.TabIndex = 0;
            this.bttnCerrar.Text = "X";
            this.bttnCerrar.UseVisualStyleBackColor = true;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lblNivel);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.bttnMinimizar);
            this.panel2.Controls.Add(this.bttnCerrar);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 34);
            this.panel2.TabIndex = 4;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.ForeColor = System.Drawing.Color.White;
            this.lblNivel.Location = new System.Drawing.Point(185, 11);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 13);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "Nivel";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(99, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(12, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // bttnProductos
            // 
            this.bttnProductos.BackColor = System.Drawing.SystemColors.Control;
            this.bttnProductos.FlatAppearance.BorderSize = 0;
            this.bttnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnProductos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnProductos.Location = new System.Drawing.Point(0, 76);
            this.bttnProductos.Name = "bttnProductos";
            this.bttnProductos.Size = new System.Drawing.Size(140, 38);
            this.bttnProductos.TabIndex = 10;
            this.bttnProductos.Text = "PRODUCTOS";
            this.bttnProductos.UseVisualStyleBackColor = false;
            this.bttnProductos.Click += new System.EventHandler(this.bttnProductos_Click);
            // 
            // bttnPersonas
            // 
            this.bttnPersonas.BackColor = System.Drawing.SystemColors.Control;
            this.bttnPersonas.FlatAppearance.BorderSize = 0;
            this.bttnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPersonas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPersonas.Location = new System.Drawing.Point(0, 38);
            this.bttnPersonas.Name = "bttnPersonas";
            this.bttnPersonas.Size = new System.Drawing.Size(140, 38);
            this.bttnPersonas.TabIndex = 11;
            this.bttnPersonas.Text = "CLIENTES Y\r\nPROVEEDORES";
            this.bttnPersonas.UseVisualStyleBackColor = false;
            this.bttnPersonas.Click += new System.EventHandler(this.bttnPersonas_Click);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDropDown.BackColor = System.Drawing.Color.DimGray;
            this.panelDropDown.Controls.Add(this.button1);
            this.panelDropDown.Controls.Add(this.bttnVentas);
            this.panelDropDown.Controls.Add(this.bttnCatalogo);
            this.panelDropDown.Controls.Add(this.bttnPersonas);
            this.panelDropDown.Controls.Add(this.bttnProductos);
            this.panelDropDown.Location = new System.Drawing.Point(3, 3);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(140, 190);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(140, 38);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(140, 190);
            this.panelDropDown.TabIndex = 14;
            // 
            // bttnVentas
            // 
            this.bttnVentas.BackColor = System.Drawing.SystemColors.Control;
            this.bttnVentas.FlatAppearance.BorderSize = 0;
            this.bttnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVentas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVentas.Location = new System.Drawing.Point(0, 114);
            this.bttnVentas.Name = "bttnVentas";
            this.bttnVentas.Size = new System.Drawing.Size(140, 38);
            this.bttnVentas.TabIndex = 16;
            this.bttnVentas.Text = "COMPRAS";
            this.bttnVentas.UseVisualStyleBackColor = false;
            // 
            // bttnCatalogo
            // 
            this.bttnCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnCatalogo.FlatAppearance.BorderSize = 0;
            this.bttnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCatalogo.Font = new System.Drawing.Font("Arial", 9F);
            this.bttnCatalogo.Location = new System.Drawing.Point(0, 0);
            this.bttnCatalogo.Name = "bttnCatalogo";
            this.bttnCatalogo.Size = new System.Drawing.Size(140, 38);
            this.bttnCatalogo.TabIndex = 14;
            this.bttnCatalogo.Text = "ARCHIVO";
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
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown);
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown3);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown2);
            this.flowLayoutPanel1.Controls.Add(this.bttnSalir);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 561);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // bttnVender
            // 
            this.bttnVender.BackColor = System.Drawing.SystemColors.Control;
            this.bttnVender.FlatAppearance.BorderSize = 0;
            this.bttnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnVender.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnVender.Location = new System.Drawing.Point(0, 76);
            this.bttnVender.Name = "bttnVender";
            this.bttnVender.Size = new System.Drawing.Size(140, 38);
            this.bttnVender.TabIndex = 9;
            this.bttnVender.Text = "VENDER";
            this.bttnVender.UseVisualStyleBackColor = false;
            // 
            // bttnComprar
            // 
            this.bttnComprar.BackColor = System.Drawing.SystemColors.Control;
            this.bttnComprar.FlatAppearance.BorderSize = 0;
            this.bttnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnComprar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnComprar.Location = new System.Drawing.Point(0, 38);
            this.bttnComprar.Name = "bttnComprar";
            this.bttnComprar.Size = new System.Drawing.Size(140, 38);
            this.bttnComprar.TabIndex = 8;
            this.bttnComprar.Text = "COMPRAR";
            this.bttnComprar.UseVisualStyleBackColor = false;
            this.bttnComprar.Click += new System.EventHandler(this.bttnComprar_Click);
            // 
            // panelDropDown2
            // 
            this.panelDropDown2.Controls.Add(this.bttnUsuarios);
            this.panelDropDown2.Controls.Add(this.bttnSeguridad);
            this.panelDropDown2.Controls.Add(this.bttnAjustes);
            this.panelDropDown2.Location = new System.Drawing.Point(3, 402);
            this.panelDropDown2.MaximumSize = new System.Drawing.Size(140, 114);
            this.panelDropDown2.MinimumSize = new System.Drawing.Size(140, 38);
            this.panelDropDown2.Name = "panelDropDown2";
            this.panelDropDown2.Size = new System.Drawing.Size(140, 114);
            this.panelDropDown2.TabIndex = 15;
            // 
            // bttnUsuarios
            // 
            this.bttnUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.bttnUsuarios.FlatAppearance.BorderSize = 0;
            this.bttnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUsuarios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUsuarios.Location = new System.Drawing.Point(0, 38);
            this.bttnUsuarios.Name = "bttnUsuarios";
            this.bttnUsuarios.Size = new System.Drawing.Size(140, 38);
            this.bttnUsuarios.TabIndex = 19;
            this.bttnUsuarios.Text = "USUARIOS";
            this.bttnUsuarios.UseVisualStyleBackColor = false;
            this.bttnUsuarios.Click += new System.EventHandler(this.bttnUsuarios_Click);
            // 
            // bttnSeguridad
            // 
            this.bttnSeguridad.BackColor = System.Drawing.SystemColors.Control;
            this.bttnSeguridad.FlatAppearance.BorderSize = 0;
            this.bttnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSeguridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSeguridad.Location = new System.Drawing.Point(0, 76);
            this.bttnSeguridad.Name = "bttnSeguridad";
            this.bttnSeguridad.Size = new System.Drawing.Size(140, 38);
            this.bttnSeguridad.TabIndex = 18;
            this.bttnSeguridad.Text = "IMPUESTOS &\r\n VALOR DOLAR\r\n";
            this.bttnSeguridad.UseVisualStyleBackColor = false;
            // 
            // bttnAjustes
            // 
            this.bttnAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnAjustes.FlatAppearance.BorderSize = 0;
            this.bttnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAjustes.Font = new System.Drawing.Font("Arial", 9F);
            this.bttnAjustes.Location = new System.Drawing.Point(0, 0);
            this.bttnAjustes.Name = "bttnAjustes";
            this.bttnAjustes.Size = new System.Drawing.Size(140, 38);
            this.bttnAjustes.TabIndex = 13;
            this.bttnAjustes.Text = "MANTENIMIENTO";
            this.bttnAjustes.UseVisualStyleBackColor = false;
            this.bttnAjustes.Click += new System.EventHandler(this.bttnAjustes_Click_1);
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnSalir.FlatAppearance.BorderSize = 0;
            this.bttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalir.Font = new System.Drawing.Font("Arial", 9F);
            this.bttnSalir.Location = new System.Drawing.Point(3, 522);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(140, 38);
            this.bttnSalir.TabIndex = 12;
            this.bttnSalir.Text = "SALIR";
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelContenedor);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 561);
            this.panel1.TabIndex = 11;
            // 
            // panelDropDown3
            // 
            this.panelDropDown3.Controls.Add(this.button2);
            this.panelDropDown3.Controls.Add(this.bttnTransacciones);
            this.panelDropDown3.Controls.Add(this.bttnVender);
            this.panelDropDown3.Controls.Add(this.bttnComprar);
            this.panelDropDown3.Location = new System.Drawing.Point(3, 199);
            this.panelDropDown3.MinimumSize = new System.Drawing.Size(140, 38);
            this.panelDropDown3.Name = "panelDropDown3";
            this.panelDropDown3.Size = new System.Drawing.Size(140, 153);
            this.panelDropDown3.TabIndex = 16;
            // 
            // bttnTransacciones
            // 
            this.bttnTransacciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.bttnTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnTransacciones.FlatAppearance.BorderSize = 0;
            this.bttnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnTransacciones.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTransacciones.Location = new System.Drawing.Point(0, 0);
            this.bttnTransacciones.Name = "bttnTransacciones";
            this.bttnTransacciones.Size = new System.Drawing.Size(140, 38);
            this.bttnTransacciones.TabIndex = 17;
            this.bttnTransacciones.Text = "TRANSACCIONES";
            this.bttnTransacciones.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "VENTAS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 38);
            this.button2.TabIndex = 18;
            this.button2.Text = "REGISTRAR\r\nFACTURA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(100)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9F);
            this.button3.Location = new System.Drawing.Point(3, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "REPORTES";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormUsuarios
            // 
            this.FormUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormUsuarios.Location = new System.Drawing.Point(0, 0);
            this.FormUsuarios.Name = "FormUsuarios";
            this.FormUsuarios.Size = new System.Drawing.Size(858, 561);
            this.FormUsuarios.TabIndex = 12;
            // 
            // FormComprar
            // 
            this.FormComprar.BackColor = System.Drawing.SystemColors.Control;
            this.FormComprar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormComprar.Location = new System.Drawing.Point(0, 0);
            this.FormComprar.Margin = new System.Windows.Forms.Padding(4);
            this.FormComprar.Name = "FormComprar";
            this.FormComprar.Size = new System.Drawing.Size(858, 561);
            this.FormComprar.TabIndex = 5;
            // 
            // FormPersonas
            // 
            this.FormPersonas.BackColor = System.Drawing.Color.White;
            this.FormPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPersonas.Location = new System.Drawing.Point(0, 0);
            this.FormPersonas.Name = "FormPersonas";
            this.FormPersonas.Size = new System.Drawing.Size(858, 561);
            this.FormPersonas.TabIndex = 11;
            // 
            // formProductos
            // 
            this.formProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formProductos.Location = new System.Drawing.Point(0, 0);
            this.formProductos.Margin = new System.Windows.Forms.Padding(2);
            this.formProductos.Name = "formProductos";
            this.formProductos.Size = new System.Drawing.Size(858, 561);
            this.formProductos.TabIndex = 10;
            // 
            // SesionIniciada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            this.panelDropDown3.ResumeLayout(false);
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
        private System.Windows.Forms.Button bttnUsuarios;
        private System.Windows.Forms.Button bttnSeguridad;
        private System.Windows.Forms.Timer timer2;
        private UserControls.ResgistrosProductos_Prototipo formProductos;
        private System.Windows.Forms.Panel panel1;
        private Personas FormPersonas;
        private UserControls.Usuarios FormUsuarios;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelDropDown3;
        private System.Windows.Forms.Button bttnTransacciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}