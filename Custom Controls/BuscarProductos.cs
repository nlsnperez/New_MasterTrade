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
            try
            {
                if (Venta == null)
                {
                    tablaProductos.DataSource = crud.ProductosActivos();
                }
                else ConfigTablaVenta(crud.ProductosActivos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }


        }

        public void ConfigTablaVenta(DataTable tabla)
        {
            DataTable x = tabla;
            if (x.Rows.Count > 0)
            {                
                for (int i = 0; i <= x.Rows.Count-1; i++)
                {
                    int id = (int)x.Rows[i]["id_pro"];
                    Console.WriteLine(id);
                    int y = crud.ProductosComprados(id) - crud.ProductosVendidos(id);
                    Console.WriteLine(y);
                    Console.WriteLine(i);
                    if (y == 0)
                    {
                        x.Rows.RemoveAt(i);
                    }
                }
                tablaProductos.DataSource = x;
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaProductos.Columns[e.ColumnIndex].Name == "Agregar")
            {
                try
                {
                    int id = (int)tablaProductos.Rows[e.RowIndex].Cells["columnId"].Value;

                    Form x = new Form();
                    AgregarProducto y = new AgregarProducto(Compra, Venta, id);
                    x.Size = new Size(y.Width, y.Height);
                    x.Controls.Add(y);
                    x.StartPosition = FormStartPosition.CenterScreen;
                    x.FormBorderStyle = FormBorderStyle.None;
                    x.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Venta == null)
                {
                    tablaProductos.DataSource = crud.BuscarProductosActivos(txtBuscar.Text);
                }
                else ConfigTablaVenta(crud.BuscarProductosActivos(txtBuscar.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
