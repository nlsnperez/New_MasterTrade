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
    public partial class BuscarProveedores : Form
    {
        public string x { get; set; }
        CRUD_Proveedores crud;

        public BuscarProveedores(int y)
        {
            InitializeComponent();
            Config(y);
            txtBuscar.Focus();
        }

        public void Config(int y)
        {
            crud = new CRUD_Proveedores();
            this.x = "";
            if (crud.Tabla().Rows.Count > 0)
            {
                tablaPersonas.AutoGenerateColumns = false;
                tablaPersonas.DataSource = crud.TablaActivos();
                tablaPersonas.ClearSelection();
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     
        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                this.x = tablaPersonas.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.Close();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTablaActivos(txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
