using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
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
    public partial class AgregarProducto : Form
    {
        private Comprar Compra;
        private Vender Venta;
        private int Id;
        CRUD_Ventas crud = new CRUD_Ventas();
        CRUD_Productos crud_productos = new CRUD_Productos();
        int CantMax = 0;
        public AgregarProducto(Comprar compra, Vender venta, int id)
        {
            InitializeComponent();
            this.Compra = compra;
            this.Venta = venta;
            this.Id = id;
            if (Compra != null)
            {
                lblCantidad.Visible = false;
            }
            Config();
        }

        public void Config()
        {
            txtId.Enabled = false;
            txtDescripcion.Enabled = false;
            txtSerial.Enabled = false;
            txtPrecio.Enabled = false;
            OrdenarDatos();
            txtCantidad.Focus();
        }

        public void OrdenarDatos()
        {
            Producto x = crud_productos.Producto(Id);
            txtId.Text = x.Id.ToString();
            if (Compra == null)
            {
                CantMax = crud.CantidadMax(x.Id);
                lblCantidad.Text += " " + CantMax.ToString()+" UNIDADES";
            }
            txtSerial.Text = x.Serial;
            txtDescripcion.Text = x.Descripcion;
            txtCantidad.Text = "1";
            if (Venta == null)
            {
                txtPrecio.Text = x.Precio_Compra.ToString();
            }else txtPrecio.Text = x.Precio_Venta.ToString();

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
                if (Int32.Parse(txtCantidad.Text) > CantMax)
                {
                    txtCantidad.Text = CantMax.ToString();
                    MessageBox.Show("La cantidad introducida excede a la cantidad de productos en stock por lo que ha sido ajustada automaticamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                decimal x = decimal.Parse(txtPrecio.Text) * decimal.Parse(txtCantidad.Text);
                string[] producto = { txtId.Text, txtSerial.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text, x.ToString()};
                Venta.AddProduct(producto, CantMax);
            }
            this.Close();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
