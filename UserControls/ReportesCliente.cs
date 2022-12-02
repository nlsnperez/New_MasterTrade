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
    public partial class ReportesCliente : UserControl
    {
        int x = 0;
        string y = "";
        Reporte reporte = new Reporte();

        public ReportesCliente()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            ConfigComboBoxes();
        }

        public void ConfigComboBoxes()
        {
            comboClientes.Items.Add("EN GENERAL");
            comboClientes.Items.Add("ACTIVOS");
            comboClientes.Items.Add("DESACTIVOS");
            comboClientes.SelectedIndex = 0;

            comboFiltro.Items.Add("GENERAL");
            comboFiltro.Items.Add("NACIONAL");
            comboFiltro.Items.Add("EXTRANGERO");
            comboFiltro.Items.Add("JURÍDICO");
            comboFiltro.Items.Add("GUBERNAMENTAL");
            comboFiltro.SelectedIndex = 0;
        }

        private void bttnGenerar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            reporte.Reporte_VentasPorCliente();
            //switch (comboFiltro.SelectedIndex)
            //{
            //    case 0:
            //        y = "";
            //        break;
            //    case 1:
            //        y = "V";
            //        break;
            //    case 2:
            //        y = "E";
            //        break;
            //    case 3:
            //        y = "J";
            //        break;
            //    case 4:
            //        y = "G";
            //        break;
            //}

            //switch (comboClientes.SelectedIndex)
            //{
            //    case 0:
            //        reporte.Reporte_Cliente(y);
            //        break;
            //    case 1:
            //        x = 1;
            //        reporte.Reporte_ClienteParametro(x, y);
            //        break;
            //    case 2:
            //        x = 0;
            //        reporte.Reporte_ClienteParametro(x, y);
            //        break;
            //}
        }
    }
}
