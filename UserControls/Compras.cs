using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Compras : UserControl
    {
        CRUD_Compras crud;
        public Compras()
        {
            InitializeComponent();
            crud = new CRUD_Compras();
            txtBuscar.Enabled = false;
            CargarTabla();
        }

        public void CargarTabla()
        {
            tablaCompras.AutoGenerateColumns = false;
            if (crud.Compras().Rows.Count > 0)
            {
                tablaCompras.DataSource = crud.Compras();
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
            tablaCompras.DataSource = crud.BuscarCompras(txtBuscar.Text);
        }

        private void tablaCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string x = tablaCompras.Rows[e.RowIndex].Cells["NOrden"].Value.ToString();
                Reporte reporte = new Reporte();
                reporte.Reporte_Orden_Compra(x);
            }
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Reporte_Compra();
        }
    }
}
