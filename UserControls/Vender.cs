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
        CRUD_Usuarios crud_usuarios = new CRUD_Usuarios();
        DataTable carrito = new DataTable();
        CRUD_Bitacora bitacora = new CRUD_Bitacora();
        List<int> dias_garantia;
        int IdVenta = 0;
        int IdCliente = 0;
        decimal tasa_cambio = 0;

        public Vender()
        {
            InitializeComponent();
            try
            {
                Vender_Load(null, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Config() //CONFIGURACIÓN ESTANDAR DEL SISTEMA
        {
            crud = new CRUD_Ventas();
            dias_garantia = new List<int>();
            tableCarrito.AutoGenerateColumns = false;
            //ConfigControles("OFF");
            LimpiarCampos();
            ConfigCarrito();
        }


        //BOTONES

        public void Check_Duplicado(int y, int z)
        {
            for (int x = 0; x < carrito.Rows.Count - 1; x++)
            {
                if (carrito.Rows[x][0].ToString() == carrito.Rows[y][0].ToString())
                {
                    carrito.Rows.RemoveAt(x);
                    GetSubTotal();
                    //int cant = int.Parse(carrito.Rows[x][4].ToString()) + int.Parse(carrito.Rows[y][4].ToString());
                    //if (cant > z) carrito.Rows[x][4] = z;
                    //else carrito.Rows[x][4] = cant;
                    //carrito.Rows[x][5] = decimal.Parse(carrito.Rows[x][3].ToString()) * decimal.Parse(carrito.Rows[y][4].ToString());
                    //carrito.Rows.RemoveAt(carrito.Rows.Count - 1);
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

                    bttnBuscarProductos.Enabled = true;
                    bttnBuscar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    comboMoneda.Enabled = true;
                    comboTasaCambio.Enabled = true;

                    comboMoneda.ValueMember = "id_mon";
                    comboMoneda.DisplayMember = "nom_mon";
                    comboMoneda.DataSource = crud.Moneda();
                    break;
                case "OFF":
                    txtNumeroOrden.Enabled = false;

                    txtCliente.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;

                    bttnGuardar.Enabled = false;
                    tableCarrito.DataSource = null;
                    carrito.Rows.Clear();
                    LimpiarCampos();
                    break;
            }
        }

        public void LimpiarCampos()
        {
            try
            {
                ConfigControles("ON");
                txtCliente.Focus();
                IdVenta = crud.GetIdVentas();
                txtNumeroOrden.Text = "";
                txtNumeroOrden.Text = IdVenta.ToString("000000000");
                comboMoneda.SelectedIndex = 0;
                txtMoneda.Text = comboMoneda.Text;

                txtCliente.Text = "";
                txtRazonSocial.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";

                txtSubTotalBs.Text = "0,00";
                txtMoneda.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            if (comboMoneda.Text == "BOLÍVAR FUERTE (BS)")
            {
                txtSubTotalBs.Text = x.ToString("0.00").Replace('.', ',');
            }
            else
            {
                txtSubTotalBs.Text = x.ToString("0.00").Replace(',', '.');
            }
            
        }


        private void bttnNuevaVenta_Click(object sender, EventArgs e)
        {
                        
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
            if (tableCarrito.Columns[e.ColumnIndex].Name == "Remover")
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
            else
            {
                if (e.RowIndex >= 0)
                {
                    int id = Int32.Parse(tableCarrito.Rows[e.RowIndex].Cells["columnId"].Value.ToString());
                    SesionIniciada.Instancia.MostrarDialog(new AgregarProducto(null, this, id));
                    //AgregarProducto y = new AgregarProducto(null, this, id);
                    //y.ShowDialog();
                }                
            }
        }

        private void bttnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                Form x = new Form();
                BuscarClientes y = new BuscarClientes();
                SesionIniciada.Instancia.MostrarDialog(y);
                if (y.x != 0)
                {
                    SetDatos(crud_usuarios.Usuario(y.x, y.y));
                }
            }
            else
            {
                Persona cliente = crud_usuarios.Usuario(0, txtCliente.Text);
                if (cliente != null)
                {
                    MessageBox.Show("Cliente encontrado!", "CLIENTE ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetDatos(cliente);
                }
                else
                {
                    if (MessageBox.Show("Cliente no encontrado, ¿Desea registrarlo?", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form x = new Form();
                        FormularioPersonas y = new FormularioPersonas(0);
                        y.RegistroExterno(1, txtCliente.Text);
                        x.StartPosition = FormStartPosition.CenterScreen;
                        x.Size = new Size(y.Width + 15, y.Height + 30);
                        x.Controls.Add(y);
                        x.ShowDialog();
                        Persona nuevo_cliente = crud_usuarios.Usuario(0, txtCliente.Text);
                        if (nuevo_cliente != null)
                        {
                            SetDatos(nuevo_cliente);
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

        public void SetDatos(Persona cliente)
        {
            IdCliente = cliente.Id;
            txtCliente.Text = cliente.Documento;
            txtRazonSocial.Text = cliente.RazonSocial;
            txtDireccion.Text = cliente.Direccion;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
        }

        private void bttnBuscarProductos_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarDialog(new BuscarProductos(null, this));
        }

        private Venta GetVenta()
        {
            Venta venta = new Venta(IdVenta,
                                    IdCliente,
                                    Convert.ToInt32(comboTasaCambio.SelectedValue),
                                    txtNumeroOrden.Text,
                                    System.DateTime.Now);
            return venta;
        }

        private List<Detalle> GetDetalle()
        {
            List<Detalle> detalle = new List<Detalle>();

            for (int i = 0; i <= tableCarrito.Rows.Count - 1; i++)
            {
                Detalle x = new Detalle(0,
                                        IdVenta,
                                        Int32.Parse(tableCarrito.Rows[i].Cells["columnId"].Value.ToString()),
                                        Int32.Parse(tableCarrito.Rows[i].Cells["columnCantidad"].Value.ToString()),
                                        decimal.Parse(tableCarrito.Rows[i].Cells["columnPrecioU"].Value.ToString()),
                                        decimal.Parse(tableCarrito.Rows[i].Cells["columnPrecioT"].Value.ToString()));
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
                if (MessageBox.Show("¿Desea registrar esta venta?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConfirmarFactura factura = new ConfirmarFactura(GetVenta(), GetDetalle(), dias_garantia, Convert.ToDecimal(txtSubTotalBs.Text.Replace(',', '.')));
                    SesionIniciada.Instancia.MostrarDialog(factura);
                    if (factura.VentaCompletada == true)
                    {
                        ConfigControles("OFF");
                        factura.Dispose();
                    }
                    else
                    {
                        factura.Dispose();
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
                txtValor.Text = tasa_cambio.ToString();
                if (tableCarrito.Rows.Count > 0) GetSubTotal();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Vender_Load(object sender, EventArgs e)
        {
            Config();
            txtMoneda.Text = comboMoneda.Text;
            bttnAtras.Visible = false;
        }
    }
}
