using New_MasterTrade.Base_de_Datos;
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
    public partial class ResgistrosProductos_Prototipo : UserControl
    {
        CRUD_Productos crud;
        public ResgistrosProductos_Prototipo()
        {
            InitializeComponent();
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            txtBuscar.Enabled = false;
            tablaProductos.AutoGenerateColumns = false;
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            Productos_Prot y = new Productos_Prot();
            x.Size = new Size(y.Width+30, y.Height+40);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }

        public void Detalles()
        {
            
        }

        private void ResgistrosProductos_Prototipo_Load(object sender, EventArgs e)
        {
            Config();
        }

        private void bttnCargar_Click(object sender, EventArgs e)
        {
            tablaProductos.DataSource = crud.TablaProductos();
            txtBuscar.Enabled = true;
            txtBuscar.Focus();
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                Form x = new Form();
                Productos_Prot y = new Productos_Prot();
                y.OpenProducto(tablaProductos.Rows[e.RowIndex].Cells[4].Value.ToString());
                x.Controls.Add(y);
                x.Size = new Size(y.Width + 30, y.Height + 40);                
                x.StartPosition = FormStartPosition.CenterScreen;
                x.ShowDialog();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaProductos.DataSource = crud.BuscarProductos(txtBuscar.Text);
        }
    }
}
