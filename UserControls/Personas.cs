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
        private CRUDPersonas crud;
        bool IsCollapsed;
        public Personas()
        {
            InitializeComponent();
            Config();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            //Config();
        }

        public void Config()
        {
            crud = new CRUDPersonas();
            tablaPersonas.AutoGenerateColumns = false;
            comboTabla.Enabled = false;
            txtBuscar.Enabled = false;
            FillComboBoxes();
        }

        //BOTONES//


        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Form x = new Form();
                FormularioPersonas y = new FormularioPersonas();
                y.OpenPersona(comboTabla.Text, tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            tablaPersonas.DataSource = crud.Tabla(comboTabla.Text.ToLower());
            comboTabla.Enabled = true;
            txtBuscar.Enabled = true;
            txtBuscar.Focus();
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTabla(comboTabla.Text, txtBuscar.Text);
        }

        private void comboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablaPersonas.DataSource = crud.Tabla(comboTabla.Text.ToLower());
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

        //TABLA//
    }
}
