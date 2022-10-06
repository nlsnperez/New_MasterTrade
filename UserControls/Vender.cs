using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Vender : UserControl
    {
        CRUDTransacciones crud;
        DataTable carrito = new DataTable();
        DataTable productos = new DataTable();
        int index = 0;
        decimal total = 0;

        public Vender()
        {
            InitializeComponent();
        }

        private void Vender_Load(object sender, EventArgs e)
        {
            Config();
        }

        public void Config()
        {
            crud = new CRUDTransacciones();
            tableCarrito.AutoGenerateColumns = false;
            ConfigControles("INICIO");
            ConfigCarrito();
        }

        private void ConfigControles(string modo)
        {
            switch (modo)
            {
                case "INICIO":
                    lblVenta.Hide();
                    txtCantidad.Enabled = false;
                    txtCodigo.Enabled = false;
                    txtNombreProducto.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtTotal.Enabled = false;

                    bttnNuevaVenta.Enabled = true;
                    bttnBuscar.Enabled = false;
                    bttnCancelar.Enabled = false;
                    btnConfirmar.Enabled = false;
                    break;
                case "ACTIVAR":
                    txtCantidad.Enabled = false;
                    txtCodigo.Enabled = false;
                    txtNombreProducto.Enabled = false;
                    txtPrecio.Enabled = false;
                    txtTotal.Enabled = false;

                    bttnBuscar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    bttnNuevaVenta.Enabled = false;
                    break;
            }
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)//LIMITA LOS TEXBOXES PARA QUE ACEPTEN SÓLO NÚMEROS
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearData("RESET");
            ConfigControles("INICIO");
        }

        public void ClearData(string modo)
        {
            switch (modo)
            {
                case "CLEAN":
                    txtCodigo.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtTotal.Text = "";
                    break;
                case "RESET":
                    txtCodigo.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtTotal.Text = "";
                    carrito.Rows.Clear();
                    tableCarrito.DataSource = null;
                    total = 0;
                    lblTotal.Text = "00,00Bs";
                    ConfigControles("INICIO");
                    break;
                case "PARTIAL":
                    tableCarrito.DataSource = null;
                    carrito.Rows.Clear();
                    total = 0;
                    lblTotal.Text = "00,00 Bs";
                    break;
            }
        }

        public void Check_Duplicado(int y)
        {
            for (int x = 0; x < carrito.Rows.Count - 1; x++)
            {
                if (carrito.Rows[x][0].ToString() == carrito.Rows[y][0].ToString())
                {
                    carrito.Rows[x][3] = int.Parse(carrito.Rows[x][3].ToString()) + int.Parse(carrito.Rows[y][3].ToString());
                    carrito.Rows[x][5] = decimal.Parse(carrito.Rows[x][5].ToString()) + decimal.Parse(carrito.Rows[y][5].ToString());
                    //if (int.Parse(carrito.Rows[x][2].ToString()) > txtCantidad.Maximum)
                    //{
                    //    MessageBox.Show("La cantidad de productos ingresada excede a la cantidad disponible por lo que se ajustarán los datos automáticamente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    carrito.Rows[x][2] = int.Parse(carrito.Rows[x][2].ToString()) - (int.Parse(carrito.Rows[x][2].ToString()) - txtCantidad.Maximum);
                    //    carrito.Rows[x][3] = decimal.Parse(carrito.Rows[x][2].ToString()) * decimal.Parse(txtPrecio.Text);
                    //}
                    carrito.Rows.RemoveAt(carrito.Rows.Count - 1);
                    break;
                }
            }
        }

        public void ConfigCarrito()//CONFIGURA LAS COLUMNAS DE LA TABLA CARRITO
        {
            if (carrito.Columns.Count == 0)
            {
                carrito = new DataTable();
                carrito.Columns.Add("Id");
                carrito.Columns.Add("Código");
                carrito.Columns.Add("Nombre");
                carrito.Columns.Add("Cantidad");
                carrito.Columns.Add("Precio");
                carrito.Columns.Add("PrecioTotal");
            }
        }

        public decimal Calc_Precio(decimal precio, decimal cantidad)//CALCULA EL PRECIO DE LA VENTA
        {
            return precio * cantidad;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            ConfirmarTransaccion y = new ConfirmarTransaccion(2, GetDetalle());
            x.Size = new Size(600, 350);
            x.FormBorderStyle = FormBorderStyle.None;
            x.StartPosition = FormStartPosition.CenterParent;
            x.Controls.Add(y);
            x.ShowDialog();
            ClearData("RESET");
        }

        private List<Detalle> GetDetalle()//GENERA UNA VENTA CON LOS DATOS SUMINISTRADOS
        {
            List<Detalle> detalle = new List<Detalle>();
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                
                Detalle x = new Detalle(lblVenta.Text, carrito.Rows[i]["Código"].ToString(), Int32.Parse(carrito.Rows[i]["Cantidad"].ToString()), float.Parse(carrito.Rows[i]["PrecioTotal"].ToString()));
                detalle.Add(x);
            }
            return detalle;
        }

        public void ValidarCantidad()
        {
            for (int i = 0; i <= productos.Rows.Count - 1; i++)
            {
                if (crud.CantidadDisponible(productos.Rows[i]["codigo_producto"].ToString()) == 0) productos.Rows[i].Delete();
            }
        }

        private decimal GetTotal()
        {
            decimal x = 0;
            for (int i = 0; i <= carrito.Rows.Count-1; i++)
            {
                x = x + decimal.Parse(carrito.Rows[i]["PrecioTotal"].ToString());
            }
            return x;
        }

        public void AddProduct(string[] producto) {
            carrito.Rows.Add(producto);
            if (carrito.Rows.Count > 1) Check_Duplicado(carrito.Rows.Count - 1);
            tableCarrito.DataSource = carrito;
            txtCantidad.Enabled = true;
            btnConfirmar.Enabled = true;

            total = GetTotal();
            lblTotal.Text = total.ToString() + "Bs";
        }

        private void tableCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("¿Desea eliminar este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    total = GetTotal() - decimal.Parse(carrito.Rows[carrito.Rows.Count - 1]["PrecioTotal"].ToString());//RESTA EL PRECIO DEL PRODUCTO ELIMINADO
                    lblTotal.Text = total.ToString() + " Bs";
                    tableCarrito.Rows.RemoveAt(e.RowIndex);
                    if (tableCarrito.Rows.Count == 0)
                    {
                        txtCantidad.Enabled = false;
                        btnConfirmar.Enabled = false;
                    }
                    ClearData("CLEAN");
                }                
            }
            else
            {
                index = e.RowIndex;
                txtCodigo.Text = tableCarrito.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombreProducto.Text = tableCarrito.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCantidad.Text = tableCarrito.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrecio.Text = tableCarrito.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTotal.Text = tableCarrito.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            BuscarProductos y = new BuscarProductos(this);
            x.Size = new Size(822, 634);
            x.FormBorderStyle = FormBorderStyle.None;
            x.StartPosition = FormStartPosition.CenterParent;
            x.Controls.Add(y);
            x.ShowDialog();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCantidad.Text == "" || txtCantidad.Text == "0")
                {
                    MessageBox.Show("Ingrese una cantidad válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    carrito.Rows[index]["Cantidad"] = txtCantidad.Text;
                    carrito.Rows[index]["PrecioTotal"] = Calc_Precio(decimal.Parse(txtCantidad.Text), decimal.Parse(txtPrecio.Text));
                    total = GetTotal();
                    lblTotal.Text = total.ToString() + "Bs";
                    ClearData("CLEAN");
                }
            }
        }

        private void bttnNuevaVenta_Click(object sender, EventArgs e)
        {
            lblVenta.Text = "MTV"+crud.VentasRealizadas().ToString("0000000");
            lblVenta.Show();
            ConfigControles("ACTIVAR");
        }
    }
}
