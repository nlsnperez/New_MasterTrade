using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Comprar : UserControl
    {
        CRUD_Compras crud;
        CRUD_Proveedores personas;
        DataTable carrito = new DataTable();
        int IdCompra = 0;
        int IdProveedor = 0;
        
        public Comprar()
        {
            InitializeComponent();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            Config();
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
                    carrito.Rows[x][4] = int.Parse(carrito.Rows[x][4].ToString()) + int.Parse(carrito.Rows[y][4].ToString());
                    carrito.Rows[x][5] = decimal.Parse(carrito.Rows[x][5].ToString()) + decimal.Parse(carrito.Rows[y][5].ToString());
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
                    txtProveedor.Enabled = true;

                    bttnNuevaCompra.Enabled = false;
                    bttnBuscarProductos.Enabled = true;
                    bttnBuscar.Enabled = true;
                    bttnCancelar.Enabled = true;                    
                    break;
                case "OFF":
                    txtNumeroOrden.Enabled = false;
                    
                    txtProveedor.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtCorreo.Enabled = false;

                    comboImpuesto.Enabled = false;
                    txtImpuesto.Enabled = false;
                    txtSubTotalBs.Enabled = false;
                    txtSubTotalUs.Enabled = false;
                    txtTotalBs.Enabled = false;
                    txtTotalUs.Enabled = false;

                    bttnNuevaCompra.Enabled = true;
                    bttnBuscarProductos.Enabled = false;
                    bttnBuscar.Enabled = false;
                    bttnCancelar.Enabled = false;
                    bttnGuardar.Enabled = false;
                    tableCarrito.DataSource = null;
                    carrito.Rows.Clear();
                    LimpiarCampos();
                    comboImpuesto.DataSource = null;
                    break;
            }
        }

        public void LimpiarCampos()
        {
            txtNumeroOrden.Text = "";

            txtProveedor.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            txtSubTotalBs.Text = "0";
            txtSubTotalUs.Text = "0";
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


        private void bttnNuevaCompra_Click(object sender, EventArgs e)
        {
            ConfigControles("ON");
            txtProveedor.Focus();
            IdCompra = crud.GetIdCompras();
            txtNumeroOrden.Text = "MT-C"+ IdCompra.ToString("00");
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            ConfigControles("OFF");
        }

        public void AddProduct(string[] producto)
        {
            carrito.Rows.Add(producto);
            comboImpuesto.Enabled = true;
            ConfigCombo();
            GetSubTotal();
            CalcPorcentaje();
            GetTotal();
            if (carrito.Rows.Count > 1) Check_Duplicado(carrito.Rows.Count - 1);
            tableCarrito.DataSource = carrito;
            bttnGuardar.Enabled = true;
        }

        private void tableCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("¿Desea remover este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tableCarrito.Rows.RemoveAt(e.RowIndex);
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
            if (txtProveedor.Text == "")
            {
                Form x = new Form();
                BuscarPersonas y = new BuscarPersonas(1);
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
                        FormularioPersonas y = new FormularioPersonas();
                        y.RegistroExterno(2);
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

        public void CalcPorcentaje()
        {
            decimal porcentaje = decimal.Parse(comboImpuesto.Text);
            decimal total = decimal.Parse(txtSubTotalBs.Text);

            decimal drantotal = (total * porcentaje) / 100;

            txtImpuesto.Text = drantotal.ToString("0.00");
        }

        private Compra GetCompra()
        {
            Compra compra = new Compra(IdCompra,
                                       txtNumeroOrden.Text,
                                       IdProveedor,
                                       System.DateTime.Now);
            return compra;
        }
        
        private List<Detalle> GetDetalle()
        {
            List<Detalle> detalle = new List<Detalle>();
            
            for (int i = 0; i <= tableCarrito.Rows.Count - 1; i++)
            {
                Detalle x = new Detalle(IdCompra,
                                        Int32.Parse(tableCarrito.Rows[i].Cells[0].Value.ToString()),
                                        Int32.Parse(tableCarrito.Rows[i].Cells[4].Value.ToString()),
                                        decimal.Parse(tableCarrito.Rows[i].Cells[5].Value.ToString()),
                                        decimal.Parse(tableCarrito.Rows[i].Cells[5].Value.ToString()));
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
                    ConfigControles("OFF");
                }
            }            
        }
        //CONFIGURACIONES
    }
}
