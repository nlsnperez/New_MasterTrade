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
    public partial class BuscarProductos : Form
    {
        private Comprar Compra;
        private Vender Venta;
        CRUD_Productos crud;

        public BuscarProductos(Comprar compra, Vender venta)
        {
            InitializeComponent();
            this.Compra = compra;
            this.Venta = venta;
            Config();
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            tablaProductos.AutoGenerateColumns = false;
            try
            {
                tablaProductos.DataSource = crud.ProductosActivos();
                ConfigCombos();

                //if (Venta == null)
                //{
                //    
                //}
                //else ConfigTablaVenta(crud.ProductosActivos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void ConfigCombos()
        {
            try
            {
                DataTable resultados = crud.CategoriasActivas();
                comboCategoria.Items.Add("CUALQUIERA");
                for (int i = 0; i <= resultados.Rows.Count - 1; i++)
                {
                    comboCategoria.Items.Add(resultados.Rows[i][1]);
                }
                comboCategoria.SelectedIndex = 0;

                resultados = crud.MarcasActivas();
                comboMarca.Items.Add("CUALQUIERA");
                for (int i = 0; i <= resultados.Rows.Count - 1; i++)
                {
                    comboMarca.Items.Add(resultados.Rows[i][1]);
                }
                comboMarca.SelectedIndex = 0;

                resultados = crud.ModelosActivos();
                comboModelo.Items.Add("CUALQUIERA");
                for (int i = 0; i <= resultados.Rows.Count - 1; i++)
                {
                    comboModelo.Items.Add(resultados.Rows[i][1]);
                }
                comboModelo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                    AgregarProducto y = new AgregarProducto(Compra, Venta, id);
                    y.ShowDialog();
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
                //tablaProductos.DataSource = crud.BuscarProductosActivos(txtBuscar.Text);
                //if (Venta == null)
                //{
                    
                //}
                //else ConfigTablaVenta(crud.BuscarProductosActivos(txtBuscar.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            string categoria = comboCategoria.Text;
            if (comboCategoria.Text == "CUALQUIERA")
            {
                categoria = "";
            }
            string marca = comboMarca.Text;
            if (comboMarca.Text == "CUALQUIERA")
            {
                marca = "";
            }
            string modelo = comboModelo.Text;
            if (comboModelo.Text == "CUALQUIERA")
            {
                modelo = "";
            }

            string serial = txtSerial.Text;
            string descripcion = txtDescripción.Text;

            if (comboCategoria.SelectedIndex == 0) categoria = "";
            if (comboMarca.SelectedIndex == 0) marca = "";
            if (comboModelo.SelectedIndex == 0) modelo = "";

            tablaProductos.DataSource = crud.BuscarProductosActivos(categoria, marca, modelo, serial, descripcion);

            comboCategoria.SelectedIndex = 0;
            comboMarca.SelectedIndex = 0;
            comboModelo.SelectedIndex = 0;
            txtSerial.Text = "";
            txtDescripción.Text = "";
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
