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
        public AgregarProducto(Comprar compra)
        {
            InitializeComponent();
            Config();
            this.Compra = compra;
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
            txtSerial.Text = producto[1];
            txtDescripcion.Text = producto[2];
            txtCantidad.Text = producto[3];
            txtPrecio.Text = producto[4];
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
            decimal x = decimal.Parse(txtPrecio.Text) * decimal.Parse(txtCantidad.Text);
            string[] producto = {txtId.Text, txtSerial.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text, x.ToString()};
            Compra.AddProduct(producto);
            this.ParentForm.Close();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
