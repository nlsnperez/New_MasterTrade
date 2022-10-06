
namespace New_MasterTrade.UserControls
{
    partial class Ventas
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
            this.flowRegistros = new System.Windows.Forms.FlowLayoutPanel();
            this.PickerFecha = new System.Windows.Forms.DateTimePicker();
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
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "VENTAS";
            // 
            // flowRegistros
            // 
            this.flowRegistros.AutoSize = true;
            this.flowRegistros.Location = new System.Drawing.Point(55, 106);
            this.flowRegistros.Margin = new System.Windows.Forms.Padding(5);
            this.flowRegistros.MaximumSize = new System.Drawing.Size(800, 600);
            this.flowRegistros.Name = "flowRegistros";
            this.flowRegistros.Size = new System.Drawing.Size(800, 600);
            this.flowRegistros.TabIndex = 23;
            // 
            // PickerFecha
            // 
            this.PickerFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PickerFecha.Location = new System.Drawing.Point(693, 37);
            this.PickerFecha.Name = "PickerFecha";
            this.PickerFecha.Size = new System.Drawing.Size(200, 20);
            this.PickerFecha.TabIndex = 24;
            this.PickerFecha.ValueChanged += new System.EventHandler(this.PickerFecha_ValueChanged);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PickerFecha);
            this.Controls.Add(this.flowRegistros);
            this.Controls.Add(this.label4);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(922, 734);
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowRegistros;
        private System.Windows.Forms.DateTimePicker PickerFecha;
    }
}
