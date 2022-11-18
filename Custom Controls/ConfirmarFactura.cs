using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace New_MasterTrade.Custom_Controls
{
    public partial class ConfirmarFactura : UserControl
    {
        Venta OrdenVenta;
        List<Detalle> DetalleVenta;
        decimal Total;

        CRUD_Ventas crud = new CRUD_Ventas();

        public ConfirmarFactura(Venta venta, List<Detalle> detalle, decimal total)
        {
            InitializeComponent();

            OrdenVenta = venta;
            DetalleVenta = detalle;
            Total = total;
            Config();
        }

        public void Config()
        {
            ConfigComboBoxes();
            txtSubTotal.Text = Total.ToString();
        }

        public void ConfigComboBoxes()
        {
            try
            {
                comboMetodoPago.DataSource = crud.MetodosPago();
                comboMetodoPago.ValueMember = "id_mpa";
                comboMetodoPago.DisplayMember = "des_mpa";
                comboMetodoPago.SelectedIndex = 0;

                comboImpuesto.DataSource = crud.Impuestos();
                comboImpuesto.ValueMember = "id_imp";
                comboImpuesto.DisplayMember = "des_imp";
                comboImpuesto.SelectedIndex = 0;
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Calcular()
        {
            try
            {
                int id = (int)comboImpuesto.SelectedValue;
                decimal x = crud.PorcentajeImpuesto(id);
                txtImpuesto.Text = x.ToString();
                CalcPorcentaje(x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CalcPorcentaje(decimal x)
        {
            decimal porcentaje = x;
            decimal drantotal = (Total * porcentaje) / 100;
            decimal total = Total + drantotal;

            txtCantidadImpuesto.Text = drantotal.ToString("0.00");
            txtTotal.Text = total.ToString();
        }

        private void comboImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboImpuesto.ValueMember == "id_imp")
            {
                Calcular();
            }
        }
    }
}
