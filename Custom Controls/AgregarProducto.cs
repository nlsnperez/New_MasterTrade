using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Custom_Controls
{
    public partial class AgregarProducto : UserControl
    {
        private Comprar Compra;
        private Vender Venta;
        CRUD_Ventas crud;
        int CantMax = 0;
        public AgregarProducto(Comprar compra, Vender venta)
        {
            InitializeComponent();
            Config();
            crud = new CRUD_Ventas();
            this.Compra = compra;
            this.Venta = venta;
        }

        public void Config()
        {
            txtId.Enabled = false;
            txtDescripcion.Enabled = false;
            txtSerial.Enabled = false;
            txtPrecio.Enabled = false;
            txtCantidad.Focus();
        }

        public void SetTexts(string[] producto)
        {
            txtId.Text = producto[0];
            if (Compra == null) CantMax = crud.CantidadMax(Int32.Parse(txtId.Text));
            txtSerial.Text = producto[1];
            txtDescripcion.Text = producto[2];
            txtCantidad.Text = producto[3];
            if (Venta == null)
            {
                txtPrecio.Text = producto[4];
            }else txtPrecio.Text = producto[5];

        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "1")
            {
                txtCantidad.Text = "";
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtCantidad.Text == "0")
            {
                txtCantidad.Text = "1";
            }
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (Venta == null)
            {
                decimal x = decimal.Parse(txtPrecio.Text) * decimal.Parse(txtCantidad.Text);
                string[] producto = { txtId.Text, txtSerial.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text, x.ToString()};
                Compra.AddProduct(producto);
            }
            else
            {
                if (Int32.Parse(txtCantidad.Text) > CantMax) txtCantidad.Text = CantMax.ToString();
                decimal x = decimal.Parse(txtPrecio.Text) * decimal.Parse(txtCantidad.Text);
                string[] producto = { txtId.Text, txtSerial.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text, x.ToString()};
                Venta.AddProduct(producto, CantMax);
            }
            this.ParentForm.Close();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
