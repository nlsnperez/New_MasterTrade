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
    public partial class BuscarPersonas : UserControl
    {
        public string x { get; set; }
        CRUDPersonas crud;

        public BuscarPersonas(int x)
        {
            InitializeComponent();
            Config(x);
            txtBuscar.Focus();
        }

        public void Config(int x)
        {
            crud = new CRUDPersonas();
            comboTabla.Enabled = false;
            FillComboBoxes();
            comboTabla.SelectedIndex = x - 1;
            if (crud.Tabla(comboTabla.Text).Rows.Count > 0)
            {
                tablaPersonas.DataSource = crud.Tabla(comboTabla.Text);
                tablaPersonas.ClearSelection();
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     
        }

        public void FillComboBoxes()
        {
            comboTabla.Items.Add("PROVEEDOR");
            comboTabla.Items.Add("CLIENTE");            
        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                this.x = tablaPersonas.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.ParentForm.Close();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTabla(comboTabla.Text, txtBuscar.Text);
        }
    }
}
