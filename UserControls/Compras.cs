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
            CargarTabla();
        }

        public void CargarTabla()
        {
            tablaCompras.AutoGenerateColumns = false;
            try
            {
                tablaCompras.DataSource = crud.Compras();
                txtBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
