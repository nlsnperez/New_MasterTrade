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
            tableProductos.AutoGenerateColumns = false;
            tableCarrito.AutoGenerateColumns = false;
            labelDisponible.Visible = false;
            FillComboBox();
            ConfigControles("INICIO");
            ConfigCarrito();
        }

        private void FillComboBox()
        {
            if (comboDocumento.Items.Count > 0) comboDocumento.Items.Clear();
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");
            comboDocumento.SelectedIndex = 0;
        }

        private void ConfigControles(string modo)
        {
            switch (modo)
            {
                case "INICIO":
                    txtCantidad.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtTelefono.Enabled = false;

                    txtCodigo.Enabled = false;
                    txtNombreProducto.Enabled = false;
                    txtPrecio.Enabled = false;

                    btnAtras.Enabled = false;
                    btnConfirmar.Enabled = false;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            if (txtDocumento.Text == "")//VERIFICA QUE EL CAMPO NO ESTÉ VACÍO
            {
                MessageBox.Show("¡Por favor ingrese un documento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Persona cliente = crud.FindPersona(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, "clientes");//BUSCA UN CLIENTE EN LA BASE DE DATOS
                if (cliente == null)//EN CASO QUE NO SE ENCUENTRE UN RESULTADO
                {
                    if (MessageBox.Show("No hay un proveedor con el documento que introdujo ¿Desea registrar uno nuevo?", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        NuevoRegistro();
                    }
                }
                else//EN CASO QUE SE ENCUENTRE UN RESULTADO
                {
                    MessageBox.Show("CLIENTE: " + cliente.RazonSocial.ToUpper(), "¡CLIENTE ENCONTRADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRazonSocial.Text = cliente.RazonSocial;
                    txtTelefono.Text = cliente.Telefono;
                    txtDocumento.Enabled = false;
                    comboDocumento.Enabled = false;
                    FillTables(1); ///LLENA LA TABLA CON LOS PRODUCTOS REGISTRADOS
                }
            }
        }

        public void FillTables(int x)//BUSCA LOS REGISTROS EN LA BASE DE DATOS PARA LA TABLA DE PRODUCTOS
        {
            switch (x)
            {
                case 1:
                    productos = crud.FindProductos(2);//BUSQUEDA GENERAL
                    ValidarCantidad();
                    tableProductos.DataSource = productos;
                    break;
                case 2:
                    productos = crud.BuscarProductos(txtBuscar.Text, 2);//BUSQUEDA ESPECÍFICA
                    ValidarCantidad();
                    tableProductos.DataSource = productos;
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

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCliente();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            FillTables(2);
        }

        private void tableProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodigo.Text = tableProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreProducto.Text = tableProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtCantidad.Enabled = true;
            labelDisponible.Visible = true;
            txtCantidad.Maximum = decimal.Parse(crud.CantidadDisponible(tableProductos.SelectedRows[0].Cells[0].Value.ToString()).ToString());
            labelDisponible.Text = "Disponibles: " + crud.CantidadDisponible(tableProductos.SelectedRows[0].Cells[0].Value.ToString()).ToString();
            txtCantidad.Value = 1;
            txtPrecio.Text = tableProductos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel_Order();
        }

        private void Cancel_Order()
        {
            if (txtCodigo.Text == "" || txtNombreProducto.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
            {
                ClearData("RESET");
            }
            else
            {
                ClearData("CLEAN");
            }
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
                    labelDisponible.Text = "Disponible: 0";
                    txtCantidad.Enabled = false;
                    labelDisponible.Visible = false;
                    break;
                case "RESET":
                    txtCodigo.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtDocumento.Text = "";
                    txtRazonSocial.Text = "";
                    txtTelefono.Text = "";
                    txtCantidad.Enabled = false;
                    txtDocumento.Enabled = true;
                    comboDocumento.Enabled = true;
                    tableProductos.DataSource = null;
                    carrito.Rows.Clear();
                    total = 0;
                    lblTotal.Text = "00,00 Bs";
                    break;
                case "PARTIAL":
                    comboDocumento.SelectedIndex = 0;
                    tableCarrito.DataSource = null;
                    carrito.Rows.Clear();
                    total = 0;
                    lblTotal.Text = "00,00 Bs";
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombreProducto.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")//REVISA LOS CAMPOS VACÍOS
            {
                MessageBox.Show("¡Por favor complete todos los campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtCantidad.Text == "0")
                {
                    MessageBox.Show("¡Por favor ingrese una cantidad mayor a 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //AGREGA LOS DATOS A UN ARREGLO DE STRING Y SE ENVÍAN A LA TABLA DE CARRITO
                    string[] producto = { txtCodigo.Text, txtNombreProducto.Text, txtCantidad.Text, Calc_Precio(decimal.Parse(txtPrecio.Text), decimal.Parse(txtCantidad.Text)).ToString() };
                    carrito.Rows.Add(producto);
                    if (carrito.Rows.Count > 1) Check_Duplicado(carrito.Rows.Count - 1);
                    tableCarrito.DataSource = carrito;

                    //CALCULA EL PRECIO TOTAL DE LA COMPRA Y LO MUESTRA EN UN LABEL
                    total = GetTotal();
                    lblTotal.Text = total.ToString() + " Bs";

                    btnAtras.Enabled = true;
                    btnConfirmar.Enabled = true;
                    Cancel_Order();
                }
            }
        }
        public void Check_Duplicado(int y)
        {
            for (int x = 0; x < carrito.Rows.Count - 1; x++)
            {
                if (carrito.Rows[x][0].ToString() == carrito.Rows[y][0].ToString())
                {
                    carrito.Rows[x][2] = int.Parse(carrito.Rows[x][2].ToString()) + int.Parse(carrito.Rows[y][2].ToString());
                    carrito.Rows[x][3] = decimal.Parse(carrito.Rows[x][3].ToString()) + decimal.Parse(carrito.Rows[y][3].ToString());
                    if (int.Parse(carrito.Rows[x][2].ToString()) > txtCantidad.Maximum)
                    {
                        MessageBox.Show("La cantidad de productos ingresada excede a la cantidad disponible por lo que se ajustarán los datos automáticamente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        carrito.Rows[x][2] = int.Parse(carrito.Rows[x][2].ToString()) - (int.Parse(carrito.Rows[x][2].ToString()) - txtCantidad.Maximum);
                        carrito.Rows[x][3] = decimal.Parse(carrito.Rows[x][2].ToString()) * decimal.Parse(txtPrecio.Text);
                    }
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
                carrito.Columns.Add("Código");
                carrito.Columns.Add("Nombre");
                carrito.Columns.Add("Cantidad");
                carrito.Columns.Add("Precio");
            }
        }

        public decimal Calc_Precio(decimal precio, decimal cantidad)//CALCULA EL PRECIO DE LA VENTA
        {
            return precio * cantidad;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            total = GetTotal() - decimal.Parse(carrito.Rows[carrito.Rows.Count - 1]["Precio"].ToString());//RESTA EL PRECIO DEL PRODUCTO ELIMINADO
            carrito.Rows.RemoveAt(carrito.Rows.Count - 1);//REMUEVE EL PRODUCTO DE LA TABLA
            lblTotal.Text = total.ToString() + " Bs";
            if (carrito.Rows.Count == 0)
            {
                btnAtras.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar la venta?", "¿CONFIRMAR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Create_Venta(GetVenta());
                if (MessageBox.Show("¿Desea vender más productos al mismo cliente?", "¿CONFIRMAR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    ClearData("RESET");
                }
                else
                {
                    ClearData("PARTIAL");
                    FillTables(1);
                }

            }
        }

        private Venta GetVenta()//GENERA UNA VENTA CON LOS DATOS SUMINISTRADOS
        {
            List<Detalle> detalle = new List<Detalle>();
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                Detalle x = new Detalle(carrito.Rows[i]["Código"].ToString(), Int32.Parse(carrito.Rows[i]["Cantidad"].ToString()), float.Parse(carrito.Rows[i]["Precio"].ToString()));
                detalle.Add(x);
            }
            Venta venta = new Venta(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, detalle);
            venta.Generar_Codigo(crud.VentasRealizadas());
            return venta;
        }

        public void NuevoRegistro()
        {
            Form x = new Form();
            NuevoRegistro y = new NuevoRegistro(comboDocumento.SelectedItem.ToString(), txtDocumento.Text, 0);
            x.Size = new Size(400, 720);
            x.FormBorderStyle = FormBorderStyle.None;
            x.StartPosition = FormStartPosition.CenterParent;
            x.Controls.Add(y);
            x.ShowDialog();
            if (y.Registro != null)
            {
                comboDocumento.Enabled = false;
                txtDocumento.Enabled = false;
                txtRazonSocial.Text = y.Registro.RazonSocial;
                txtTelefono.Text = y.Registro.Telefono;
                FillTables(1);
            }
            else
            {
                comboDocumento.SelectedIndex = 0;
                txtDocumento.Text = "";
            }
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
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                x = x + decimal.Parse(carrito.Rows[i]["Precio"].ToString());
            }
            return x;
        }
    }
}
