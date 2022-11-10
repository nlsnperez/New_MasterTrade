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
    public partial class RegistrosBitacora : UserControl
    {
        CRUD_Bitacora crud = new CRUD_Bitacora();
        public RegistrosBitacora()
        {
            InitializeComponent();
            CargarTabla();
        }

        public void CargarTabla()
        {
            tablaBitacora.AutoGenerateColumns = false;
            if (crud.RegistrosBitacora().Rows.Count > 0)
            {
                tablaBitacora.DataSource = crud.RegistrosBitacora();
                txtBuscar.Enabled = true;
                txtBuscar.Focus();
            }
            else
            {
                MessageBox.Show("No hay registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tablaBitacora.DataSource = crud.BuscarBitacora(txtBuscar.Text);
        }

        private void tablaBitacora_MouseEnter(object sender, EventArgs e)
        {
            tablaBitacora.Focus();
        }
    }
}
