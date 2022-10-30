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
        CRUDTransacciones crud;
        CRUDPersonas personas;
        DataTable carrito = new DataTable();
        int Id = 0;
        
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
            crud = new CRUDTransacciones();
            personas = new CRUDPersonas();
            tableCarrito.AutoGenerateColumns = false;
            dpFecha.MinDate = System.DateTime.Today;
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
                    dpFecha.Enabled = true;

                    txtProveedor.Enabled = true;

                    bttnNuevaCompra.Enabled = false;
                    bttnBuscarProductos.Enabled = true;
                    bttnBuscar.Enabled = true;
                    bttnCancelar.Enabled = true;                    
                    break;
                case "OFF":
                    txtNumeroOrden.Enabled = false;
                    dpFecha.Enabled = false;
                    
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
            dpFecha.Value = System.DateTime.Today;

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
            comboImpuesto.ValueMember = "id";
            comboImpuesto.DisplayMember = "porc";

            CalcPorcentaje();
        }

        public void GetTotal()
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

            x = 0;
            x = (decimal.Parse(txtSubTotalBs.Text) + decimal.Parse(txtImpuesto.Text));
            txtTotalBs.Text = x.ToString("0.00");

            x = 0;
            x = decimal.Parse(txtSubTotalUs.Text) + (decimal.Parse(txtImpuesto.Text) / (decimal)8.40);
            txtTotalUs.Text = x.ToString("0.00");
        }


        private void bttnNuevaCompra_Click(object sender, EventArgs e)
        {
            ConfigControles("ON");
            Id = crud.GetIdCompras();
            txtNumeroOrden.Text = "MT-C"+Id.ToString("00");
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
            GetTotal();
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
                    GetTotal();
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
            if (personas.PersonaDatos("proveedor", txtProveedor.Text).Rows.Count > 0)
            {
                MessageBox.Show("¡Proveedor encontrado!", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable proveedor = personas.PersonaDatos("proveedor", txtProveedor.Text);
                txtRazonSocial.Text = proveedor.Rows[0][2].ToString();
                txtDireccion.Text = proveedor.Rows[0][3].ToString();
                txtTelefono.Text = proveedor.Rows[0][4].ToString();
                txtCorreo.Text = proveedor.Rows[0][5].ToString();
            }
            else
            {
                if (MessageBox.Show("¡Proveedor no encontrado! ¿Desea registrarlo?", "PROVEEDOR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
            }
        }

        private void bttnBuscarProductos_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            BuscarProductos y = new BuscarProductos(this);
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
        //CONFIGURACIONES
    }
}
