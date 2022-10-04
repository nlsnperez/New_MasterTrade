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
        private Vender Venta;
        CRUDProductos crud;
        DataTable carrito = new DataTable();

        public BuscarProductos(Vender venta)
        {
            InitializeComponent();
            this.Venta = venta;
        }

        public void Config()
        {
            lblAgregado.Hide();
            tablaProductos.AutoGenerateColumns = false;
            tablaProductos.DataSource = crud.GetTable();
        }

        public void ConfigCarrito()//CONFIGURA LAS COLUMNAS DE LA TABLA CARRITO
        {
            if (carrito.Columns.Count == 0)
            {
                carrito = new DataTable();
                carrito.Columns.Add("Id");
                carrito.Columns.Add("Código");
                carrito.Columns.Add("Nombre");
                carrito.Columns.Add("Cantidad");
                carrito.Columns.Add("Precio total");
            }
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            crud = new CRUDProductos();
            Config();
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string[] producto = {tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                                     Convert.ToString(1),
                                     tablaProductos.Rows[e.RowIndex].Cells[3].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[3].Value.ToString()};
                Venta.AddProduct(producto);
                lblAgregado.Show();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaProductos.DataSource = crud.SearchTable(txtBuscar.Text);
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
