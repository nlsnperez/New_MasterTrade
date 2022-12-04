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
            dtpDesde.MaxDate = System.DateTime.Today;
            dtpHasta.MaxDate = System.DateTime.Today;
            ConfigComboMeses();
            ConfigCombo();
        }

        public void ConfigCombo()
        {
            //0
            comboReporte.Items.Add("CLIENTES REGISTRADOS");
            //1
            comboReporte.Items.Add("PROVEEDORES REGISTRADOS");
            //2
            comboReporte.Items.Add("PRODUCTOS REGISTRADOS");
            //3
            comboReporte.Items.Add("VENTAS REGISTRADAS");
            //4
            comboReporte.Items.Add("NÚMERO DE VENTAS REALIZADAS EN UN MES");
            //5
            comboReporte.Items.Add("NÚMERO DE VENTAS REALIZADAS EN UN AÑO");
            //6
            comboReporte.Items.Add("COMPRAS REGISTRADAS");            
            //7
            comboReporte.Items.Add("NÚMERO DE COMPRAS REALIZADAS EN UN MES");
            //8
            comboReporte.Items.Add("NÚMERO DE COMPRAS REALIZADAS EN UN AÑO");
            //9
            comboReporte.Items.Add("DESEMPEÑO DE VENDEDORES");
            //10
            comboReporte.Items.Add("TOP 10 CLIENTES FRECUENTES");
            //11
            comboReporte.Items.Add("TOP 10 PROVEEDORES PRINCIPALES");
            //12
            comboReporte.Items.Add("TOP 10 PRODUCTOS MÁS VENDIDOS");
            //13
            comboReporte.Items.Add("TOP 10 MARCAS MÁS VENDIDAS");
            comboReporte.SelectedIndex = 0;
        }

        public void ConfigComboMeses()
        {
            comboMeses.Items.Add("ENERO");
            comboMeses.Items.Add("FEBRERO");
            comboMeses.Items.Add("MARZO");
            comboMeses.Items.Add("ABRIL");
            comboMeses.Items.Add("MAYO");
            comboMeses.Items.Add("JUNIO");
            comboMeses.Items.Add("JULIO");
            comboMeses.Items.Add("AGOSTO");
            comboMeses.Items.Add("SEPTIEMBRE");
            comboMeses.Items.Add("OCTUBRE");
            comboMeses.Items.Add("NOVIEMBRE");
            comboMeses.Items.Add("DICIEMBRE");
            comboMeses.SelectedIndex = 0;
        }

        private void comboReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReporte.SelectedIndex == 3 || comboReporte.SelectedIndex == 6)
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
            else
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }

            if (comboReporte.SelectedIndex == 4 || comboReporte.SelectedIndex == 7)
            {
                comboMeses.Enabled = true;
                txtAgno.Enabled = true;
            }
            else
            {
                if (comboReporte.SelectedIndex == 5 || comboReporte.SelectedIndex == 8)
                {
                    comboMeses.Enabled = false;
                    txtAgno.Enabled = true;
                }
                else
                {
                    comboMeses.Enabled = false;
                    txtAgno.Enabled = false;
                }
            }
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            switch (comboReporte.Text)
            {
                case "CLIENTES REGISTRADOS":
                    reporte.Reporte_Cliente();
                    break;
                case "PROVEEDORES REGISTRADOS":
                    reporte.Reporte_Proveedor();
                    break;
                case "PRODUCTOS REGISTRADOS":
                    reporte.Reporte_Producto();
                    break;
                case "VENTAS REGISTRADAS":
                    break;
                case "NÚMERO DE VENTAS REALIZADAS EN UN MES":
                    break;
                case "NÚMERO DE VENTAS REALIZADAS EN UN AÑO":
                    if (txtAgno.Text == "")
                    {
                        MessageBox.Show("INGRESE UN AÑO PARA GENERAR EL REPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        reporte.Reporte_ComprasPorAgno(txtAgno.Text);
                    }
                    break;
                case "COMPRAS REGISTRADAS":
                    break;
                case "NÚMERO DE COMPRAS REALIZADAS EN UN MES":
                    break;
                case "NÚMERO DE COMPRAS REALIZADAS EN UN AÑO":
                    if (txtAgno.Text == "")
                    {
                        MessageBox.Show("INGRESE UN AÑO PARA GENERAR EL REPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        reporte.Reporte_VentasPorAgno(txtAgno.Text);
                    }                    
                    break;
                case "DESEMPEÑO DE VENDEDORES":
                    reporte.Reporte_VendedorEficiente();
                    break;
                case "TOP 10 CLIENTES FRECUENTES":
                    reporte.Reporte_VentasPorCliente();
                    break;
                case "TOP 10 PROVEEDORES PRINCIPALES":
                    reporte.Reporte_ProductosPorProveedor();
                    break;
                case "TOP 10 PRODUCTOS MÁS VENDIDOS":
                    reporte.Reporte_ProductoMasVendido();
                    break;
                case "TOP 10 MARCAS MÁS VENDIDAS":
                    reporte.Reporte_MarcasVendidas();
                    break;
            }
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
