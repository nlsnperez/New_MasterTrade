using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
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
            FillComboBoxes();
        }

        //BOTONES//


        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                
            }
            else
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Desea eliminar los datos del" + comboTabla.SelectedItem.ToString().ToLower() + ": " + tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (comboTabla.SelectedIndex == 0)
                        {
                            crud.Delete(tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString(), "clientes");
                            Clear();
                        }
                        else
                        {
                            crud.Delete(tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString(), "proveedores");
                            Clear();
                        }
                    }
                }
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }     
        //BOTONES//

        //CONFIGURACIÓN///

        public void Clear()
        {
            
        }

        
        public void FillComboBoxes()
        {
            comboTabla.Items.Add("CLIENTE");
            comboTabla.Items.Add("PROVEEDOR");
            comboTabla.SelectedIndex = 0;
        }

        //CONFIGURACIÓN///

        //TABLA//

        private void comboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void bttnCargar_Click(object sender, EventArgs e)
        {
            tablaPersonas.DataSource = crud.Tabla(comboTabla.Text.ToLower());
            txtBuscar.Enabled = true;
            txtBuscar.Focus();
        }

        //TABLA//
    }
}
