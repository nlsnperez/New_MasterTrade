using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Custom_Controls;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Management.Instrumentation;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Comprar : UserControl
    {
        CRUD_Compras crud;
        CRUD_Proveedores personas;
        DataTable carrito = new DataTable();
        CRUD_Bitacora bitacora = new CRUD_Bitacora();
        int IdCompra = 0;
        int IdProveedor = 0;
        decimal tasa_cambio = 0;

        static Comprar comprar;
        public static Comprar Instancia
        {
            get
            {
                if (comprar == null)
                {
                    comprar = new Comprar();
                }
                return comprar;
            }
        }

        public Comprar()
        {
            //comprar = this;
            InitializeComponent();
            Comprar_Load(null, new EventArgs());
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            Config();
            txtMoneda.Text = comboMoneda.Text;
            bttnAtras.Visible = false;
        }

        public void CompraExterna()
        {
            bttnAtras.Visible = true;
        }

        public void Config() //CONFIGURACIÓN ESTANDAR DEL SISTEMA
        {
            crud = new CRUD_Compras();
            personas = new CRUD_Proveedores();
            tableCarrito.AutoGenerateColumns = false;
            ConfigControles("OFF");
            ConfigCarrito();
        }


        //BOTONES

        public void Check_Duplicado(int y)
        {
            for (int x = 0; x < carrito.Rows.Count - 1; x++)
            {
                if (carrito.Rows[x][0].ToString() == carrito.Rows[y][0].ToString())
                {
                    carrito.Rows.RemoveAt(x);
                    GetSubTotal();
                    //carrito.Rows[x][4] = int.Parse(carrito.Rows[x][4].ToString()) + int.Parse(carrito.Rows[y][4].ToString());
                    //carrito.Rows[x][5] = decimal.Parse(carrito.Rows[x][5].ToString()) + decimal.Parse(carrito.Rows[y][5].ToString());
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
                    txtProveedor.Enabled = true;

                    bttnBuscarProductos.Enabled = true;
                    bttnBuscar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    ConfigCombo();
                    comboMoneda.Enabled = true;
                    comboTasaCambio.Enabled = true;
                    break;
                case "OFF":
                    txtNumeroOrden.Enabled = false;

                    txtProveedor.Enabled = false;
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
            ConfigControles("ON");
            txtProveedor.Focus();
            IdCompra = crud.GetIdCompras();
            txtNumeroOrden.Text = "";
            txtNumeroOrden.Text = IdCompra.ToString("000000000");
            comboMoneda.SelectedIndex = 0;

            txtProveedor.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            txtSubTotalBs.Text = "0.00";
            txtMoneda.Text = "";
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
            try
            {
                comboMoneda.ValueMember = "id_mon";
                comboMoneda.DisplayMember = "nom_mon";
                comboMoneda.DataSource = crud.Moneda();
                comboTasaCambio.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetSubTotal()
        {
            decimal x = 0;
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                x = x + decimal.Parse(carrito.Rows[i]["P.Total"].ToString());
            }
            decimal total = x / tasa_cambio;
            txtSubTotalBs.Text = total.ToString("0.00");
        }


        private void bttnNuevaCompra_Click(object sender, EventArgs e)
        {
            ConfigControles("ON");
            txtProveedor.Focus();
            IdCompra = crud.GetIdCompras();
            txtNumeroOrden.Text = IdCompra.ToString("000000000");
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            ConfigControles("OFF");
        }

        public void AddProduct(string[] producto)
        {
            carrito.Rows.Add(producto);
            ConfigCombo();
            GetSubTotal();
            if (carrito.Rows.Count > 1) Check_Duplicado(carrito.Rows.Count - 1);
            tableCarrito.DataSource = carrito;
            bttnGuardar.Enabled = true;
            comprar = this;
        }

        private void tableCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableCarrito.Columns[e.ColumnIndex].Name == "Remover")
            {
                if (MessageBox.Show("¿Desea remover este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tableCarrito.Rows.RemoveAt(e.RowIndex);
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
                    SesionIniciada.Instancia.MostrarDialog(new AgregarProducto(this, null, id));
                    //AgregarProducto y = new AgregarProducto(this, null, id);
                    //y.ShowDialog();
                }
            }
        }

        private void bttnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtProveedor.Text == "")
            {
                Form x = new Form();
                BuscarProveedores y = new BuscarProveedores(1);
                x.StartPosition = FormStartPosition.CenterScreen;
                x.Size = new Size(y.Width + 15, y.Height + 30);
                x.Controls.Add(y);
                x.ShowDialog();
                if (y.x != "")
                {
                    SetDatos(personas.ProveedorDatos(y.x));
                }
            }
            else
            {
                if (personas.ProveedorDatos(txtProveedor.Text).Rows.Count > 0)
                {
                    SetDatos(personas.ProveedorDatos(txtProveedor.Text));
                }
                else
                {
                    if (MessageBox.Show("Proveedor no encontrado, ¿Desea registrarlo?", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Form x = new Form();
                        FormularioPersonas y = new FormularioPersonas(1);
                        y.RegistroExterno(2, txtProveedor.Text);
                        x.StartPosition = FormStartPosition.CenterScreen;
                        x.Size = new Size(y.Width + 15, y.Height + 30);
                        x.Controls.Add(y);
                        x.ShowDialog();
                        if (personas.ProveedorDatos(txtProveedor.Text).Rows.Count > 0)
                        {
                            SetDatos(personas.ProveedorDatos(txtProveedor.Text));
                        }
                        else 
                        {
                            txtProveedor.Text = "";
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

            IdProveedor = Int32.Parse(resultado.Rows[0][0].ToString());
            txtProveedor.Text = resultado.Rows[0][1].ToString();
            txtRazonSocial.Text = resultado.Rows[0][2].ToString();
            txtDireccion.Text = resultado.Rows[0][3].ToString();
            txtTelefono.Text = resultado.Rows[0][4].ToString();
            txtCorreo.Text = resultado.Rows[0][5].ToString();
        }

        private void bttnBuscarProductos_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            BuscarProductos y = new BuscarProductos(this, null);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.Size = new Size(y.Width + 15, y.Height + 30);
            x.Controls.Add(y);
            x.ShowDialog();
        }

        private Compra GetCompra()
        {
            Compra compra = new Compra(IdCompra,
                                       txtNumeroOrden.Text,
                                       IdProveedor,
                                       (int)comboTasaCambio.SelectedValue,
                                       Convert.ToDecimal(txtSubTotalBs.Text),
                                       System.DateTime.Now);
            return compra;
        }
        
        private List<Detalle> GetDetalle()
        {
            List<Detalle> detalle = new List<Detalle>();
            
            for (int i = 0; i <= tableCarrito.Rows.Count - 1; i++)
            {
                Detalle x = new Detalle(IdCompra,
                                        Int32.Parse(tableCarrito.Rows[i].Cells["columnId"].Value.ToString()),
                                        Int32.Parse(tableCarrito.Rows[i].Cells["columnCantidad"].Value.ToString()),
                                        decimal.Parse(tableCarrito.Rows[i].Cells["columnPrecioT"].Value.ToString()));
                detalle.Add(x);
            }
            return detalle;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (GetCompra().IsEmpty())
            {
                MessageBox.Show("Debe seleccionar un proveedor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Desea registrar esta orden?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    crud.Crear(GetCompra());
                    crud.CrearDetalle(GetDetalle());
                    Reporte reporte = new Reporte();
                    reporte.Reporte_Orden_Compra(txtNumeroOrden.Text);
                    bitacora.Create(UserData.Id, Modulos.Comprar, Accion.NuevaCompra(UserData.NombreUsuario, txtNumeroOrden.Text));
                    ConfigControles("OFF");
                }
            }            
        }

        private void comboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMoneda.Text = comboMoneda.Text;
                int id = (int)comboMoneda.SelectedValue;
                comboTasaCambio.ValueMember = "id_tca";
                comboTasaCambio.DisplayMember = "des_tca";
                comboTasaCambio.DataSource = crud.TasaDeCambio(id);
                comboTasaCambio.SelectedIndex = 0;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboTasaCambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboTasaCambio.SelectedValue;
                tasa_cambio = crud.Valor_TasaCambio(id);
                txtValor.Text = tasa_cambio.ToString();
                GetSubTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnAtras_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarUserControl(FormularioProductos.Instancia);
        }
        //CONFIGURACIONES
    }
}
