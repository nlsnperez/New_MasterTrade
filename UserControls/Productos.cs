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
            txtBuscar.Enabled = false;
            tablaProductos.AutoGenerateColumns = false;
            CargarTabla();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            FormularioProductos y = new FormularioProductos();
            x.Size = new Size(y.Width+30, y.Height+40);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            tablaProductos.DataSource = crud.TablaProductos();
        }

        private void ResgistrosProductos_Prototipo_Load(object sender, EventArgs e)
        {
            Config();
        }

        private void CargarTabla()
        {
            if (crud.TablaProductos().Rows.Count > 0)
            {
                tablaProductos.DataSource = crud.TablaProductos();
                txtBuscar.Enabled = true;
                txtBuscar.Focus();
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                x.Controls.Add(y);
                x.Size = new Size(y.Width + 30, y.Height + 40);                
                x.StartPosition = FormStartPosition.CenterScreen;
                x.ShowDialog();
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
            tablaProductos.DataSource = crud.BuscarProductos(txtBuscar.Text);
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Reporte_Producto();
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
    }
}
