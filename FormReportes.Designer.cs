namespace New_MasterTrade
{
    partial class FormReportes
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
            this.CRV_Ventana = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_Ventana
            // 
            this.CRV_Ventana.ActiveViewIndex = -1;
            this.CRV_Ventana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_Ventana.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_Ventana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_Ventana.Location = new System.Drawing.Point(0, 0);
            this.CRV_Ventana.Name = "CRV_Ventana";
            this.CRV_Ventana.Size = new System.Drawing.Size(1126, 631);
            this.CRV_Ventana.TabIndex = 0;
            this.CRV_Ventana.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.ParameterPanel;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 631);
            this.Controls.Add(this.CRV_Ventana);
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_Ventana;
    }
}