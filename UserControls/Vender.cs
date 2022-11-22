using CrystalDecisions.Shared;
using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Custom_Controls;
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
    public partial class Vender : UserControl
    {
        CRUD_Ventas crud;
        CRUD_Clientes crud_clientes;
        DataTable carrito = new DataTable();
        CRUD_Bitacora bitacora = new CRUD_Bitacora();
        List<int> dias_garantia;
        int IdVenta = 0;
        int IdCliente = 0;
        decimal tasa_cambio = 0;

        public Vender()
        {
            InitializeComponent();
            Config();
        }

        public void Config() //CONFIGURACIÓN ESTANDAR DEL SISTEMA
        {
            crud = new CRUD_Ventas();
            crud_clientes = new CRUD_Clientes();
            dias_garantia = new List<int>();
            tableCarrito.AutoGenerateColumns = false;
            ConfigControles("OFF");
            ConfigCarrito();

            comboMoneda.DataSource = crud.Moneda();
            comboMoneda.ValueMember = "id_mon";
            comboMoneda.DisplayMember = "nom_mon";
        }


        //BOTONES

        public void Check_Duplicado(int y, int z)
        {
            for (int x = 0; x < carrito.Rows.Count - 1; x++)
            {
                if (carrito.Rows[x][0].ToString() == carrito.Rows[y][0].ToString())
                {
                    int cant = int.Parse(carrito.Rows[x][4].ToString()) + int.Parse(carrito.Rows[y][4].ToString());
                    if (cant > z) carrito.Rows[x][4] = z;
                    else carrito.Rows[x][4] = cant;
                    carrito.Rows[x][5] = decimal.Parse(carrito.Rows[x][3].ToString()) * decimal.Parse(carrito.Rows[y][4].ToString());
                    carrito.Rows.RemoveAt(carrito.Rows.Count - 1);
                    break;
                }
            }
        }

        //BOTONES

        //CLICKS & KEYPRESS

        //CLICKS & KEYPRESS

        //CONFIGURACIONES
        public void ConfigCarrito()//CONFIGURA LAS COLUMNAS DE LA TABLA CARRITO
        {
            if (carrito.Columns.Count == 0)
            {
                carrito = new DataTable();
                carrito.Columns.Add("Id");
                carrito.Columns.Add("Serial");
                carrito.Columns.Add("Descripcion");
                carrito.Columns.Add("P.Unitario");
                carrito.Columns.Add("Cantidad");
                carrito.Columns.Add("P.Total");
            }
        }

        public void ConfigControles(string modo)//CONFIGURACIÓN DE LOS BOTONES
        {
            switch (modo)
            {
                case "ON":
                    txtCliente.Enabled = true;

                    bttnNuevaVenta.Enabled = false;
                    bttnBuscarProductos.Enabled = true;
                    bttnBuscar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    comboMoneda.Enabled = true;
                    break;
                case "OFF":
                    txtNumeroOrden.Enabled = false;

                    txtCliente.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;

                    comboMoneda.Enabled = false;

                    bttnNuevaVenta.Enabled = true;
                    bttnBuscarProductos.Enabled = false;
                    bttnBuscar.Enabled = false;
                    bttnCancelar.Enabled = false;
                    bttnGuardar.Enabled = false;
                    tableCarrito.DataSource = null;
                    carrito.Rows.Clear();
                    LimpiarCampos();
                    break;
            }
        }

        public void LimpiarCampos()
        {
            txtNumeroOrden.Text = "";

            txtCliente.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            txtSubTotalBs.Text = "0";
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)//LIMITA LOS TEXBOXES PARA QUE ACEPTEN SÓLO NÚMEROS
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        public void GetSubTotal()
        {
            decimal x = 0;
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                x = x + decimal.Parse(carrito.Rows[i]["P.Total"].ToString());
            }
            x = x / tasa_cambio;
            txtSubTotalBs.Text = x.ToString("0.00");
        }


        private void bttnNuevaVenta_Click(object sender, EventArgs e)
        {
            ConfigControles("ON");
            txtCliente.Focus();
            IdVenta = crud.GetIdVentas();
            txtNumeroOrden.Text = "MT-V" + IdVenta.ToString("000");
            comboMoneda.SelectedIndex = 0;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            ConfigControles("OFF");
        }

        public void AddProduct(string[] producto, int cantmanx)
        {
            carrito.Rows.Add(producto);
            GetSubTotal();
            if (carrito.Rows.Count > 1) Check_Duplicado(carrito.Rows.Count - 1, cantmanx);
            tableCarrito.DataSource = carrito;
            bttnGuardar.Enabled = true;
            int y = Int32.Parse(tableCarrito.Rows[tableCarrito.Rows.Count-1].Cells[0].Value.ToString());
            dias_garantia.Add(crud.Garantia(y));
        }

        private void tableCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("¿Desea remover este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tableCarrito.Rows.RemoveAt(e.RowIndex);
                    dias_garantia.RemoveAt(e.RowIndex);
                    GetSubTotal();
                    if (tableCarrito.Rows.Count < 1)
                    {
                        bttnGuardar.Enabled = false;
                    }
                }
            }
        }

        private void bttnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                Form x = new Form();
                BuscarClientes y = new BuscarClientes();
                x.StartPosition = FormStartPosition.CenterScreen;
                x.Size = new Size(y.Width + 15, y.Height + 30);
                x.Controls.Add(y);
                x.ShowDialog();
                if (y.x != "")
                {
                    SetDatos(crud_clientes.ClienteDatos(y.x));
                }
            }
            else
            {
                if (crud_clientes.ClienteDatos(txtCliente.Text).Rows.Count > 0)
                {
                    SetDatos(crud_clientes.ClienteDatos(txtCliente.Text));
                }
                else
                {
                    if (MessageBox.Show("Cliente no encontrado, ¿Desea registrarlo?", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form x = new Form();
                        FormularioPersonas y = new FormularioPersonas(0);
                        y.RegistroExterno(1);
                        x.StartPosition = FormStartPosition.CenterScreen;
                        x.Size = new Size(y.Width + 15, y.Height + 30);
                        x.Controls.Add(y);
                        x.ShowDialog();
                        if (crud_clientes.ClienteDatos(txtCliente.Text).Rows.Count > 0)
                        {
                            SetDatos(crud_clientes.ClienteDatos(txtCliente.Text));
                        }
                        else
                        {
                            txtCliente.Text = "";
                            txtRazonSocial.Text = "";
                            txtDireccion.Text = "";
                            txtTelefono.Text = "";
                            txtCorreo.Text = "";
                        }
                    }
                }
            }
        }

        public void SetDatos(DataTable tabla)
        {
            DataTable resultado = tabla;

            IdCliente = Int32.Parse(resultado.Rows[0][0].ToString());
            txtCliente.Text = resultado.Rows[0][1].ToString();
            txtRazonSocial.Text = resultado.Rows[0][2].ToString();
            txtDireccion.Text = resultado.Rows[0][3].ToString();
            txtTelefono.Text = resultado.Rows[0][4].ToString();
            txtCorreo.Text = resultado.Rows[0][5].ToString();
        }

        private void bttnBuscarProductos_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            BuscarProductos y = new BuscarProductos(null, this);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.Size = new Size(y.Width + 15, y.Height + 30);
            x.Controls.Add(y);
            x.ShowDialog();
        }

        private Venta GetVenta()
        {
            Venta venta = new Venta(IdVenta,
                                    IdCliente,
                                    Convert.ToInt32(comboMoneda.SelectedValue),
                                    txtNumeroOrden.Text,
                                    System.DateTime.Now);
            return venta;
        }

        private List<Detalle> GetDetalle()
        {
            List<Detalle> detalle = new List<Detalle>();

            for (int i = 0; i <= tableCarrito.Rows.Count - 1; i++)
            {
                Detalle x = new Detalle(IdVenta,
                                        Int32.Parse(tableCarrito.Rows[i].Cells[0].Value.ToString()),
                                        Int32.Parse(tableCarrito.Rows[i].Cells[4].Value.ToString()),
                                        decimal.Parse(tableCarrito.Rows[i].Cells[5].Value.ToString()));
                detalle.Add(x);
            }
            return detalle;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (GetVenta().IsEmpty())
            {
                MessageBox.Show("Debe seleccionar un cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Desea registrar esta orden?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form x = new Form();
                    ConfirmarFactura factura = new ConfirmarFactura(GetVenta(), GetDetalle(), dias_garantia,Convert.ToDecimal(txtSubTotalBs.Text));
                    x.Size = factura.Size;
                    x.Controls.Add(factura);
                    x.StartPosition = FormStartPosition.CenterScreen;
                    x.FormBorderStyle = FormBorderStyle.None;
                    x.ShowDialog();
                    if (factura.VentaCompletada == true)
                    {
                        ConfigControles("OFF");
                        factura.Dispose();
                        x.Dispose();
                    }
                    else
                    {
                        factura.Dispose();
                        x.Dispose();
                    }    
                }
            }
        }

        private void comboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMoneda.ValueMember == "id_mon")
            {
                try
                {
                    comboTasaCambio.DataSource = crud.Tasa_Cambio((int)comboMoneda.SelectedValue);
                    comboTasaCambio.ValueMember = "id_tca";
                    comboTasaCambio.DisplayMember = "des_tca";
                    comboTasaCambio.SelectedIndex = 0;
                    txtMoneda.Text = comboMoneda.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboTasaCambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTasaCambio.ValueMember == "id_tca")
            {
                tasa_cambio = crud.Valor_TasaCambio((int)comboTasaCambio.SelectedValue);
                if (tableCarrito.Rows.Count > 0) GetSubTotal();
            }
        }
    }
}
