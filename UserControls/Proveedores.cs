using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using New_MasterTrade.UserControls;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace New_MasterTrade
{
    public partial class Proveedores : UserControl
    {
        private CRUD_Proveedores crud;
        public Proveedores()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUD_Proveedores();
            tablaPersonas.AutoGenerateColumns = false;
            tablaPersonas.DataSource = null;
            txtBuscar.Enabled = false;
            CargarTabla();
            
        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Form x = new Form();
                FormularioPersonas y = new FormularioPersonas();
                y.OpenProveedor(1, tablaPersonas.Rows[e.RowIndex].Cells[1].Value.ToString());
                x.Controls.Add(y);
                x.Size = new Size(y.Width + 30, y.Height + 40);                
                x.StartPosition = FormStartPosition.CenterScreen;
                x.ShowDialog();
                CargarTabla();
            }
        }

        private void CargarTabla()
        {
            if (crud.Tabla().Rows.Count > 0)
            {
                tablaPersonas.DataSource = crud.Tabla();
                txtBuscar.Focus();
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTabla(txtBuscar.Text);
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            FormularioPersonas y = new FormularioPersonas();
            x.Size = new Size(y.Width + 30, y.Height + 40);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Reporte_Proveedor();
        }
    }
}
