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
    public partial class VentanaReportes : UserControl
    {
        Reporte reporte = new Reporte();
        public VentanaReportes()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            ConfigComboBoxes();
            ConfigDatePickers();
            //panelPerzonalizado.Visible = false;
        }

        public void ConfigComboBoxes()
        {
            comboReporte.Items.Add("VENTAS");
            comboReporte.SelectedIndex = 0;

            comboFiltro.Items.Add("ÚLTIMOS 7 DÍAS");
            comboFiltro.Items.Add("ÚLTIMOS 30 DÍAS");
            comboFiltro.Items.Add("ÚLTIMO AÑO");
            comboFiltro.Items.Add("PERSONALIZADO");
            comboFiltro.SelectedIndex = 0;
        }

        public void ConfigDatePickers()
        {
            dpHasta.MaxDate = System.DateTime.Today;
        }

        private void comboReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltro.Text == "PERSONALIZADO")
            {
                panelPerzonalizado.Visible = true;
            }else panelPerzonalizado.Visible = false;
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            //reporte.Reporte_ProductoMasVendido();
            reporte.Reporte_VendedorEficiente();
        }
    }
}
