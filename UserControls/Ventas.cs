using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;

namespace New_MasterTrade.UserControls
{
    public partial class Ventas : UserControl
    {
        CRUD_Ventas crud;
        public Ventas()
        {
            InitializeComponent();
            crud = new CRUD_Ventas();
            txtBuscar.Enabled = false;
            CargarTabla();
        }

        public void CargarTabla()
        {
            if (crud.Facturas().Rows.Count > 0)
            {
                tablaVentas.DataSource = crud.Facturas();
                txtBuscar.Enabled = true;
                txtBuscar.Focus();
            }
            else
            {
                MessageBox.Show("No hay registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tablaVentas.DataSource = crud.BuscarFacuras(txtBuscar.Text);
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Reporte_Venta();
        }

        private void tablaVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && tablaVentas.Columns[e.ColumnIndex].Name == "Detalle")
            {
                string x = tablaVentas.Rows[e.RowIndex].Cells["NOrdenVenta"].Value.ToString();
                Reporte reporte = new Reporte();
                reporte.Reporte_Orden_Venta(x);
            }
        }
    }
}
