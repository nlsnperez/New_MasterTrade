using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
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
        public bool VentaCompletada { get; set; }

        Venta OrdenVenta;
        List<Detalle> DetalleVenta;
        List<int> Garantias;
        decimal Total;

        CRUD_Ventas crud = new CRUD_Ventas();
        CRUD_Bitacora bitacora = new CRUD_Bitacora();

        public ConfirmarFactura(Venta venta, List<Detalle> detalle, List<int> garantias, decimal total)
        {
            InitializeComponent();

            OrdenVenta = venta;
            DetalleVenta = detalle;
            Garantias = garantias;
            Total = total;
            Config();
        }

        public void Config()
        {
            ConfigComboBoxes();
            txtSubTotal.Text = Total.ToString();
        }

        public void ConfigTextBoxes()
        {
            txtCantidadImpuesto.Enabled = false;
            txtImpuesto.Enabled = false;
            txtSubTotal.Enabled = false;
            txtTotal.Enabled = false;
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
            txtTotal.Text = total.ToString("0.00");
        }

        private void comboImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboImpuesto.ValueMember == "id_imp")
            {
                Calcular();
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            VentaCompletada = false;
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea registrar esta factura?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    crud.Crear(OrdenVenta);
                    crud.CrearDetalle(DetalleVenta);
                    crud.CrearGarantia(crud.Detalles(OrdenVenta.Id), Garantias);
                    crud.CrearFactura(new Factura(id: 0, vendedor: crud.Vendedor(UserData.Id), ordenVenta: OrdenVenta.Id, metodoPago: (int)comboMetodoPago.SelectedValue, impuesto: (int)comboImpuesto.SelectedValue, total_impuesto: decimal.Parse(txtCantidadImpuesto.Text), total: decimal.Parse(txtTotal.Text)));
                    Reporte reporte = new Reporte();
                    reporte.Reporte_Orden_Venta(OrdenVenta.NumeroOrden);
                    bitacora.Create(UserData.Id, Modulos.Vender, Accion.NuevaVenta(UserData.NombreUsuario, OrdenVenta.NumeroOrden));
                    VentaCompletada = true;
                    this.ParentForm.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
