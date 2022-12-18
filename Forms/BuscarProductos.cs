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
        private DataTable tabla = new DataTable();
        private int total_filas = 0;
        private int pagina = 0;
        private int total_paginas = 0;
        private int limite_registro = 20;

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
                CargarDatos(crud.ProductosActivos());
                ConfigComboPaginas();
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

        //MÉTODOS PARA EL PAGINADOR
        public void ReiniciarPaginador()
        {
            total_filas = 0;
            pagina = 0;
            total_paginas = 0;
            limite_registro = 20;
        }

        public void ConfigComboPaginas()
        {
            if (comboPaginas.Items.Count > 0) comboPaginas.Items.Clear();
            for (int i = 0; i <= total_paginas; i++)
            {
                comboPaginas.Items.Add(i + 1);
            }
            comboPaginas.SelectedIndex = 0;
        }

        public void CargarDatos(DataTable resultados)
        {
            tabla = resultados;
            total_filas = tabla.Rows.Count - 1;
            total_paginas = total_filas / limite_registro;
            tablaProductos.DataSource = Resultados(tabla);
        }

        private DataTable Resultados(DataTable resultados)
        {
            HabilitarBotones();
            return resultados.AsEnumerable().Skip(limite_registro * pagina).Take(limite_registro).CopyToDataTable();
        }

        private void HabilitarBotones()
        {
            if (pagina == 0)
            {
                bttnAnterior.Enabled = false;
            }
            else
            {
                bttnAnterior.Enabled = true;
            }

            if (pagina == total_paginas)
            {
                bttnSiguiente.Enabled = false;
            }
            else
            {
                bttnSiguiente.Enabled = true;
            }
        }

        private void comboPaginas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                pagina = Int32.Parse(comboPaginas.Text) - 1;
                tablaProductos.DataSource = Resultados(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                comboPaginas.SelectedIndex += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                comboPaginas.SelectedIndex -= 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //MÉTODOS PARA EL PAGINADOR

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

            DataTable resultados = crud.BuscarProductosActivos(categoria, marca, modelo, serial, descripcion);
            if (resultados.Rows.Count <= 0)
            {
                MessageBox.Show("No hay registros en la base de datos", "RESULTADOS NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReiniciarPaginador();
                CargarDatos(resultados);
                ConfigComboPaginas();
            }

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
