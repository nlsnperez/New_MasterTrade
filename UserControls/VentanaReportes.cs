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
            ConfigCombo();
        }

        public void ConfigCombo()
        {
            comboReporte.Items.Add("TOP 10 PRODUCTOS MÁS VENDIDOS");
            comboReporte.Items.Add("TOP 10 CLIENTES");
            comboReporte.Items.Add("TOP 10 PROVEEDORES CON MÁS PRODUCTOS");
            comboReporte.Items.Add("DESEMPEÑO DE VENDEDORES");
            comboReporte.Items.Add("MARCA MÁS VENDIDA");
            comboReporte.Items.Add("NÚMERO DE COMPRAS REALIZADAS EN EL AÑO");
            comboReporte.Items.Add("NÚMERO DE VENTAS REALIZADAS EN EL AÑO");
            comboReporte.SelectedIndex = 0;
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            switch (comboReporte.Text)
            {
                case "TOP 10 PRODUCTOS MÁS VENDIDOS":
                    reporte.Reporte_ProductoMasVendido();
                    break;
                case "TOP 10 CLIENTES":
                    reporte.Reporte_VentasPorCliente();
                    break;
                case "TOP 10 PROVEEDORES CON MÁS PRODUCTOS":
                    reporte.Reporte_ProductosPorProveedor();
                    break;
                case "DESEMPEÑO DE VENDEDORES":
                    reporte.Reporte_VendedorEficiente();
                    break;
                case "MARCA MÁS VENDIDA":
                    reporte.Reporte_MarcasVendidas();
                    break;
                case "NÚMERO DE COMPRAS REALIZADAS EN EL AÑO":
                    reporte.Reporte_ComprasPorAgno("2022");
                    break;
                case "NÚMERO DE VENTAS REALIZADAS EN EL AÑO":
                    reporte.Reporte_VentasPorAgno("2022");
                    break;
            }
        }

        private void comboReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
