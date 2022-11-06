using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using New_MasterTrade.UserControls;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace New_MasterTrade
{
    public partial class Personas : UserControl
    {
        private CRUD_Proveedores crud;
        bool IsCollapsed;
        public Personas()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUD_Proveedores();
            FillComboBoxes();
            tablaPersonas.AutoGenerateColumns = false;
            tablaPersonas.DataSource = null;
            comboTabla.Enabled = false;
            txtBuscar.Enabled = false;
            CargarTabla();
            
        }

        //BOTONES//


        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Form x = new Form();
                FormularioPersonas y = new FormularioPersonas();
                y.OpenProveedor(comboTabla.Text, tablaPersonas.Rows[e.RowIndex].Cells[1].Value.ToString());
                x.Controls.Add(y);
                x.Size = new Size(y.Width + 30, y.Height + 40);                
                x.StartPosition = FormStartPosition.CenterScreen;
                x.ShowDialog();
            }
        }    
        //BOTONES//

        //CONFIGURACIÓN///

        
        public void FillComboBoxes()
        {
            comboTabla.Items.Add("CLIENTE");
            comboTabla.Items.Add("PROVEEDOR");
            comboTabla.SelectedIndex = 0;
        }

        //CONFIGURACIÓN///

        //TABLA//

        private void bttnCargar_Click(object sender, EventArgs e)
        {
                       
        }
        private void CargarTabla()
        {
            if (crud.Tabla(comboTabla.Text).Rows.Count > 0)
            {
                tablaPersonas.DataSource = crud.Tabla(comboTabla.Text);
                comboTabla.Enabled = true;
                txtBuscar.Enabled = true;
                txtBuscar.Focus();
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTabla(comboTabla.Text, txtBuscar.Text);
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            FormularioPersonas y = new FormularioPersonas();
            x.Size = new Size(y.Width + 30, y.Height + 40);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }

        private void comboTabla_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //TABLA//
    }
}
