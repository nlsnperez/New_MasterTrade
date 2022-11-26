using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
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
    public partial class Vendedores : UserControl
    {
        CRUD_Usuarios crud = new CRUD_Usuarios();
        public Vendedores()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            tablaVendedores.AutoGenerateColumns = false;
            CargarTabla();
        }

        public void CargarTabla()
        {
            try
            {
                tablaVendedores.DataSource = crud.Vendedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tablaVendedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaVendedores.Columns[e.ColumnIndex].Name == "ACTIVO")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    tablaVendedores.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    tablaVendedores.Rows[e.RowIndex].Cells["ELIMINAR"].Value = Properties.Resources.restore;
                }
            }
        }

        private void tablaVendedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaVendedores.Columns[e.ColumnIndex].Name == "ELIMINAR")
                {
                    if (Convert.ToBoolean(tablaVendedores.Rows[e.RowIndex].Cells["ACTIVO"].Value) == false)
                    {
                        if (MessageBox.Show("Desea restaurar a este vendedor?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = (int)tablaVendedores.Rows[e.RowIndex].Cells["ID"].Value;
                            crud.DeleteUsuario(id, 1);
                            CargarTabla();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Desea eliminar a este vendedor?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int id = (int)tablaVendedores.Rows[e.RowIndex].Cells["ID"].Value;
                            crud.DeleteUsuario(id, 0);
                            CargarTabla();
                        }
                    }
                }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tablaVendedores.DataSource = crud.BuscarVendedor(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
