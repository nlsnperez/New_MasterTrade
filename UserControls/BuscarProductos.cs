using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Objetos
{
    public partial class BuscarProductos : UserControl
    {
        private Comprar Compra;
        CRUD_Productos crud;
        DataTable carrito = new DataTable();

        public BuscarProductos(Comprar compra)
        {
            InitializeComponent();
            this.Compra = compra;
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            tablaProductos.AutoGenerateColumns = false;
            tablaProductos.DataSource = crud.TablaProductos();
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            Config();
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                Console.WriteLine("Yei1");
                string[] producto = {tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[5].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[6].Value.ToString(),
                                     Convert.ToString(1),
                                     tablaProductos.Rows[e.RowIndex].Cells[6].Value.ToString()};
                Console.WriteLine("Yei2");
                Compra.AddProduct(producto);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaProductos.DataSource = crud.BuscarProductos(txtBuscar.Text);
        }
    }
}
