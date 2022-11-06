using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Custom_Controls;
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
        private Vender Venta;
        CRUD_Productos crud;

        public BuscarProductos(Comprar compra, Vender venta)
        {
            InitializeComponent();
            this.Compra = compra;
            this.Venta = venta;
            txtBuscar.Focus();
            Config();
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            tablaProductos.AutoGenerateColumns = false;
            if (Venta == null)
            {
                if (crud.TablaProductos().Rows.Count > 0)
                {
                    tablaProductos.DataSource = crud.TablaProductos();
                }
                else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else ConfigTablaVenta();


        }

        private void BuscarProductos_Load(object sender, EventArgs e)
        {
            
        }

        public void ConfigTablaVenta()
        {            
            if (crud.TablaProductos().Rows.Count > 0)
            {
                DataTable x = crud.TablaProductos();
                for (int i = 0; i <= x.Rows.Count-1; i++)
                {
                    int y = crud.ProductosComprados((int)x.Rows[i][0]) - crud.ProductosVendidos((int)x.Rows[i][0]);
                    if (y <= 0) x.Rows.RemoveAt(i);
                }
                tablaProductos.DataSource = x;
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                string[] producto = {tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[5].Value.ToString(),
                                     Convert.ToString(1),
                                     tablaProductos.Rows[e.RowIndex].Cells[6].Value.ToString(),
                                     tablaProductos.Rows[e.RowIndex].Cells[7].Value.ToString()};

                Form x = new Form();
                AgregarProducto y = new AgregarProducto(Compra, Venta);
                y.SetTexts(producto);
                x.Size = new Size(y.Width, y.Height);
                x.Controls.Add(y);
                x.StartPosition = FormStartPosition.CenterScreen;
                x.FormBorderStyle = FormBorderStyle.None;
                x.ShowDialog();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaProductos.DataSource = crud.BuscarProductos(txtBuscar.Text);
        }
    }
}
