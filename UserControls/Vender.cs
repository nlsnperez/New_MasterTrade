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
            comboMoneda.SelectedIndex = 0;
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
                    comboImpuesto.Enabled = false;
                    txtImpuesto.Enabled = false;
                    txtSubTotalBs.Enabled = false;
                    txtSubTotalUs.Enabled = false;
                    txtTotalBs.Enabled = false;
                    txtTotalUs.Enabled = false;

                    bttnNuevaVenta.Enabled = true;
                    bttnBuscarProductos.Enabled = false;
                    bttnBuscar.Enabled = false;
                    bttnCancelar.Enabled = false;
                    bttnGuardar.Enabled = false;
                    tableCarrito.DataSource = null;
                    carrito.Rows.Clear();
                    LimpiarCampos();
                    comboMoneda.DataSource = null;
                    comboImpuesto.DataSource = null;
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
            txtSubTotalUs.Text = "0";
            txtImpuesto.Text = "";
            txtTotalBs.Text = "0";
            txtTotalUs.Text = "0";
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)//LIMITA LOS TEXBOXES PARA QUE ACEPTEN SÓLO NÚMEROS
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        public void ConfigCombo()
        {
            comboImpuesto.DataSource = crud.Impuestos();
            comboImpuesto.ValueMember = "id_imp";
            comboImpuesto.DisplayMember = "por_imp";

            CalcPorcentaje();
        }

        public void GetTotal()
        {
            decimal x = 0;
            x = (decimal.Parse(txtSubTotalBs.Text) + decimal.Parse(txtImpuesto.Text));
            txtTotalBs.Text = x.ToString("0.00");

            x = 0;
            x = decimal.Parse(txtSubTotalUs.Text) + (decimal.Parse(txtImpuesto.Text) / (decimal)8.40);
            txtTotalUs.Text = x.ToString("0.00");
        }

        public void GetSubTotal()
        {
            decimal x = 0;
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                x = x + decimal.Parse(carrito.Rows[i]["P.Total"].ToString());
            }
            txtSubTotalBs.Text = x.ToString("0.00");

            x = 0;
            x = decimal.Parse(txtSubTotalBs.Text) / (decimal)8.40;
            txtSubTotalUs.Text = x.ToString("0.00");
        }


        private void bttnNuevaVenta_Click(object sender, EventArgs e)
        {
            ConfigControles("ON");
            txtCliente.Focus();
            IdVenta = crud.GetIdVentas();
            txtNumeroOrden.Text = "MT-V" + IdVenta.ToString("000");
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            ConfigControles("OFF");
        }

        public void AddProduct(string[] producto, int cantmanx)
        {
            carrito.Rows.Add(producto);
            comboImpuesto.Enabled = true;
            ConfigCombo();
            GetSubTotal();
            CalcPorcentaje();
            GetTotal();
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
                    CalcPorcentaje();
                    GetTotal();
                    if (tableCarrito.Rows.Count < 1)
                    {
                        comboImpuesto.DataSource = null;
                        comboImpuesto.Enabled = false;
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
                        FormularioPersonas y = new FormularioPersonas();
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

        public void CalcPorcentaje()
        {
            decimal porcentaje = decimal.Parse(comboImpuesto.Text);
            decimal total = decimal.Parse(txtSubTotalBs.Text);

            decimal drantotal = (total * porcentaje) / 100;

            txtImpuesto.Text = drantotal.ToString("0.00");
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
                    ConfirmarFactura factura = new ConfirmarFactura(GetVenta(), GetDetalle(), Convert.ToDecimal(txtSubTotalBs.Text));
                    x.Size = factura.Size;
                    x.Controls.Add(factura);
                    x.StartPosition = FormStartPosition.CenterParent;
                    x.FormBorderStyle = FormBorderStyle.None;
                    x.Show();
                   
                    //crud.Crear(GetVenta());
                    //crud.CrearDetalle(GetDetalle());
                    //crud.CrearGarantia(crud.Detalles(IdVenta), dias_garantia);
                    //crud.CrearFactura(new Factura(id: 0, vendedor: crud.Vendedor(UserData.Id), ordenVenta: IdVenta, metodoPago: (int)comboMoneda.SelectedValue, impuesto: Convert.ToInt32(comboImpuesto.SelectedValue), total_Bs: decimal.Parse(txtTotalBs.Text), total_Us: decimal.Parse(txtTotalUs.Text)));
                    //bitacora.Create(UserData.Id, Modulos.Vender, Accion.NuevaVenta(UserData.NombreUsuario, txtNumeroOrden.Text));
                    //ConfigControles("OFF");
                }
            }
        }
    }
}
