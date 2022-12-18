using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
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
    public partial class Productos : UserControl
    {
        private DataTable tabla = new DataTable();
        private int total_filas = 0;
        private int pagina = 0;
        private int total_paginas = 0;
        private int limite_registro = 20;
        CRUD_Productos crud;

        public Productos()
        {
            InitializeComponent();
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            tablaProductos.AutoGenerateColumns = false;
            CargarDatos(crud.TablaProductos());
            ConfigComboPaginas();
            ConfigCombos(); 
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

                DataTable resultados = crud.Categorias();
                comboCategoria.Items.Add("CUALQUIERA");
                for (int i = 0; i <= resultados.Rows.Count -1; i++)
                {
                    comboCategoria.Items.Add(resultados.Rows[i][1]);
                }
                comboCategoria.SelectedIndex = 0;

                resultados = crud.Marcas();
                comboMarca.Items.Add("CUALQUIERA");
                for (int i = 0; i <= resultados.Rows.Count - 1; i++)
                {
                    comboMarca.Items.Add(resultados.Rows[i][1]);
                }
                comboMarca.SelectedIndex = 0;

                resultados = crud.Modelos();
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

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarUserControl(new FormularioProductos());
        }

        private void ResgistrosProductos_Prototipo_Load(object sender, EventArgs e)
        {
            Config();
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && tablaProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = Convert.ToInt32(tablaProductos.Rows[e.RowIndex].Cells["columnId"].Value);
                Producto producto = crud.Producto(id);
                Form x = new Form();
                FormularioProductos y = new FormularioProductos();

                y.DatosProducto(producto);
                SesionIniciada.Instancia.MostrarUserControl(y);
            }
            else
            {
                if (e.ColumnIndex >= 0 && tablaProductos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (Convert.ToBoolean(tablaProductos.Rows[e.RowIndex].Cells["Activo"].Value) == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar los datos de este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int id = (int)tablaProductos.Rows[e.RowIndex].Cells["columnId"].Value;
                            crud.Delete(id, 0);
                            CargarDatos(crud.TablaProductos());
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(tablaProductos.Rows[e.RowIndex].Cells["Activo"].Value) == false)
                        {
                            if (MessageBox.Show("¿Desea restaurar los datos de este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                int id = (int)tablaProductos.Rows[e.RowIndex].Cells["columnId"].Value;
                                crud.Delete(id, 1);
                                CargarDatos(crud.TablaProductos());
                            }
                        }
                    }

                }
            }
        }

        private void tablaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaProductos.Columns[e.ColumnIndex].Name == "Activo")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    if (UserData.Nivel == 1)
                    {
                        tablaProductos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        tablaProductos.Rows[e.RowIndex].Cells["Eliminar"].Value = Properties.Resources.restore;
                    }
                    else
                    {
                        tablaProductos.Rows[e.RowIndex].Visible = false;
                    }
                }
            }
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

            DataTable resultados = crud.BuscarProductos(categoria, marca, modelo, serial, descripcion);
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
    }
}
