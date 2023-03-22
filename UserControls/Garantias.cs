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
    public partial class Garantias : UserControl
    {
        CRUD_Garantia crud = new CRUD_Garantia();
        public Garantias()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            tablaGrarantias.AutoGenerateColumns = false;

            try
            {
                tablaGrarantias.DataSource = crud.Tabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tablaGrarantias.DataSource = crud.BuscarTabla(txtBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
