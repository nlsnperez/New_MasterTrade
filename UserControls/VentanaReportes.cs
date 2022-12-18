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
            comboReporte.Items.Add("VENTAS REGISTRADAS EN UN RANGO DE FECHA");
            //5
            comboReporte.Items.Add("NÚMERO DE VENTAS REALIZADAS EN UN MES");
            //6
            comboReporte.Items.Add("NÚMERO DE VENTAS REALIZADAS EN UN AÑO");
            //7
            comboReporte.Items.Add("DESEMPEÑO DE VENDEDORES");
            //8
            comboReporte.Items.Add("TOP 10 CLIENTES FRECUENTES");
            //9
            comboReporte.Items.Add("TOP 10 PROVEEDORES PRINCIPALES");
            //10
            comboReporte.Items.Add("TOP 10 PRODUCTOS MÁS VENDIDOS");
            //11
            comboReporte.Items.Add("TOP 10 MARCAS MÁS VENDIDAS");
            //12
            comboReporte.Items.Add("TOP 10 CATEGORÍAS MÁS VENDIDAS");
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
            if (comboReporte.SelectedIndex == 4)
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
            else
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }

            if (comboReporte.SelectedIndex == 5)
            {
                comboMeses.Enabled = true;
            }
            else
            {
                comboMeses.Enabled = false;
            }          
            
            if (comboReporte.SelectedIndex == 5 || comboReporte.SelectedIndex == 6)
            {
                txtAgno.Enabled = true;
            }
            else
            {
                txtAgno.Enabled = false;
            }
        }

        public int Numero_Mes()
        {
            int x = 0;
            switch (comboMeses.Text)
            {
                case "ENERO":
                    x = 1;
                    break;
                case "FEBRERO":
                    x = 2;
                    break;
                case "MARZO":
                    x = 3;
                    break;
                case "ABRIL":
                    x = 4;
                    break;
                case "MAYO":
                    x = 5;
                    break;
                case "JUNIO":
                    x = 6;
                    break;
                case "JULIO":
                    x = 7;
                    break;
                case "AGOSTO":
                    x = 8;
                    break;
                case "SEPTIEMBRE":
                    x = 9;
                    break;
                case "OCTUBRE":
                    x = 10;
                    break;
                case "NOVIEMBRE":
                    x = 11;
                    break;
                case "DICIEMBRE":
                    x = 12;
                    break;                
            }
            return x;
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
                    reporte.Reporte_Venta();
                    break;
                case "VENTAS REGISTRADAS EN UN RANGO DE FECHA":
                    reporte.Reporte_VentaByFecha(dtpDesde.Value, dtpHasta.Value);
                    break;
                case "NÚMERO DE VENTAS REALIZADAS EN UN MES":
                    if (txtAgno.Text == "")
                    {
                        MessageBox.Show("INGRESE UN AÑO PARA GENERAR EL REPORTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int mes = Numero_Mes();
                        reporte.Reporte_VentasPorMes(mes.ToString(), txtAgno.Text);
                    }
                    break;
                case "NÚMERO DE VENTAS REALIZADAS EN UN AÑO":
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
                case "TOP 10 CATEGORÍAS MÁS VENDIDAS":
                    reporte.Reporte_Categoria_Mas_Vendida();
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
