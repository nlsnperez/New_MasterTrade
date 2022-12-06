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
        CRUD_Productos crud;
        public Productos()
        {
            InitializeComponent();
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            tablaProductos.AutoGenerateColumns = false;
            CargarTabla();
            ConfigCombos(); 
        }

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
            //Form x = new Form();
            //FormularioProductos y = new FormularioProductos();
            //x.Size = new Size(y.Width+30, y.Height+40);
            //x.Controls.Add(y);
            //x.StartPosition = FormStartPosition.CenterScreen;
            //x.ShowDialog();
            //CargarTabla();
        }

        private void ResgistrosProductos_Prototipo_Load(object sender, EventArgs e)
        {
            Config();
        }

        private void CargarTabla()
        {
            try
            {
                tablaProductos.DataSource = crud.TablaProductos();
                txtSerial.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                //x.Controls.Add(y);
                //x.Size = new Size(y.Width + 30, y.Height + 40);                
                //x.StartPosition = FormStartPosition.CenterScreen;
                //x.ShowDialog();
                //CargarTabla();
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
                            CargarTabla();
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
                                CargarTabla();
                            }
                        }
                    }

                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            //tablaProductos.DataSource = crud.BuscarProductos(txtSerial.Text);
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

            tablaProductos.DataSource = crud.BuscarProductos(categoria, marca, modelo, serial, descripcion);

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
