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
        DataTable carrito = new DataTable();
        decimal total = 0;

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
            ClearData("RESET");
            ConfigControles("INICIO");
            ConfigCarrito();
            FillComboBoxes();            
            Config_Tables();
        }


        //BOTONES
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "" || txtNombreProducto.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")//REVISA LOS CAMPOS VACÍOS
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
                    string[] producto = {txtCodigo.Text, txtNombreProducto.Text, txtCantidad.Text, Calc_Precio(decimal.Parse(txtPrecio.Text), decimal.Parse(txtCantidad.Text)).ToString()};
                    carrito.Rows.Add(producto);
                    if (carrito.Rows.Count > 1) Check_Duplicado(carrito.Rows.Count - 1);                    
                    tableCarrito.DataSource = carrito;

                    //CALCULA EL PRECIO TOTAL DE LA COMPRA Y LO MUESTRA EN UN LABEL
                    lblTotal.Text = GetTotal().ToString() + " Bs";

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
                    carrito.Rows.RemoveAt(carrito.Rows.Count - 1);
                    if (int.Parse(carrito.Rows[x][2].ToString()) > txtCantidad.Maximum)
                    {
                        carrito.Rows[x][2] = int.Parse(carrito.Rows[x][2].ToString()) - (int.Parse(carrito.Rows[x][2].ToString()) - txtCantidad.Maximum);
                        carrito.Rows[x][3] = decimal.Parse(carrito.Rows[x][2].ToString()) * decimal.Parse(txtPrecio.Text);
                        MessageBox.Show("La cantidad de productos ingresada excede a la cantidad disponible por lo que se ajustarán los datos automáticamente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar la compra?", "¿CONFIRMAR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //crud.Create_Compra(GetCompra());
                if (MessageBox.Show("¿Desea comprar más productos del mismo proveedor?", "¿CONFIRMAR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    ClearData("RESET");
                }
                else
                {
                    ClearData("PARTIAL");
                }

            }

        }

        private void btnAtras_Click(object sender, EventArgs e)//BOTÓN PARA SUSTRAER UN PRODUCTO DE LA LISTA
        {
            total = GetTotal() - decimal.Parse(carrito.Rows[carrito.Rows.Count-1]["Precio"].ToString());//RESTA EL PRECIO DEL PRODUCTO ELIMINADO
            carrito.Rows.RemoveAt(carrito.Rows.Count-1);//REMUEVE EL PRODUCTO DE LA TABLA
            lblTotal.Text = total.ToString() + " Bs";
            if (carrito.Rows.Count == 0)
            {
                btnAtras.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel_Order();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }
        //BOTONES

        //private Compra GetCompra()//GENERA UNA COMPRA CON LOS DATOS SUMINISTRADOS
        //{
        //    List<Detalle> detalle = new List<Detalle>();
        //    for (int i = 0; i <= carrito.Rows.Count - 1; i++)
        //    {
        //        Detalle x = new Detalle(carrito.Rows[i]["Código"].ToString(), Int32.Parse(carrito.Rows[i]["Cantidad"].ToString()), float.Parse(carrito.Rows[i]["Precio"].ToString()));
        //        detalle.Add(x);
        //    }
        //    Compra compra = new Compra(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, detalle);
        //    compra.Generar_Codigo(crud.ComprasRealizadas());
        //    return compra;
        //}

        public void Cancel_Order()//LIMPIA LOS CAMPOS ATENDIENDO A UN PARÁMETRO
        {
            if(txtCodigo.Text == ""|| txtNombreProducto.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "" /*|| carrito.Rows.Count > 0*/)
            {
                ClearData("RESET");
            }
            else
            {
                ClearData("CLEAN");
            }
            
        }

        public void ClearData(string modo)//REINICIA COMPLETAMENTE LOS COMPONENTES DEL FORMULARIO
        {
            switch (modo)
            {
                case "CLEAN":
                    txtCodigo.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtCantidad.Enabled = false;
                    break;
                case "RESET":
                    txtCodigo.Text = "";
                    txtNombreProducto.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtDocumento.Text = "";
                    txtRazonSocial.Text = "";
                    txtTelefono.Text = "";
                    tableCarrito.DataSource = null;
                    tableProductos.DataSource = null;
                    txtCantidad.Enabled = false;
                    txtDocumento.Enabled = true;
                    comboDocumento.Enabled = true;
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

        public decimal Calc_Precio(decimal precio, decimal cantidad)//CALCULA EL PRECIO DE LA COMPRA
        {
            return precio * cantidad;
        }

        public void FillTables(int x)//BUSCA LOS REGISTROS EN LA BASE DE DATOS PARA LA TABLA DE PRODUCTOS
        {
            switch (x)
            {
                case 1:
                    tableProductos.DataSource = crud.FindProductos(1);//BUSQUEDA GENERAL
                    break;
                case 2:
                    tableProductos.DataSource = crud.BuscarProductos(txtBuscar.Text, 1);//BUSQUEDA ESPECÍFICA
                    break;
            }
            
        }
        //CLICKS & KEYPRESS

        private void tableProductos_MouseDoubleClick(object sender, MouseEventArgs e)//ORDENA LOS DATOS DE LA TABLA PRODUCTOS EN LOS TEXTBOXES CORRESPONDIENTES
        {
            txtCodigo.Text = tableProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreProducto.Text = tableProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtCantidad.Enabled = true;
            txtCantidad.Minimum = decimal.Parse(tableProductos.SelectedRows[0].Cells[2].Value.ToString());
            txtCantidad.Maximum = decimal.Parse(tableProductos.SelectedRows[0].Cells[3].Value.ToString());
            txtCantidad.Value = decimal.Parse(tableProductos.SelectedRows[0].Cells[2].Value.ToString());
            txtPrecio.Text = tableProductos.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)//MÉTODO PARA BUSCAR UN PROVEEDOR EN LA BASE DE DATOS
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProveedor();
            }
        }

        private void BuscarProveedor()
        {
            if (txtDocumento.Text == "")//VERIFICA QUE EL CAMPO NO ESTÉ VACÍO
            {
                MessageBox.Show("¡Por favor ingrese un documento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Persona proveedor = crud.FindPersona(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, "proveedores");//BUSCA UN PROOVEDOR EN LA BASE DE DATOS
                if (proveedor == null)//EN CASO QUE NO SE ENCUENTRE UN RESULTADO
                {
                    if (MessageBox.Show("No hay un proveedor con el documento que introdujo ¿Desea registrar uno nuevo?", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        NuevoRegistro();
                    }
                }
                else//EN CASO QUE SE ENCUENTRE UN RESULTADO
                {
                    System.Windows.Forms.MessageBox.Show("PROVEEDOR: " + proveedor.RazonSocial.ToUpper(), "¡PROVEEDOR ENCONTRADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRazonSocial.Text = proveedor.RazonSocial;
                    txtTelefono.Text = proveedor.Telefono;
                    txtDocumento.Enabled = false;
                    comboDocumento.Enabled = false;
                    FillTables(1);//LLENA LA TABLA CON LOS PRODUCTOS REGISTRADOS DE ESE PROVEEDOR
                }
            }
        }
        //CLICKS & KEYPRESS

        //CONFIGURACIONES
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

        public void FillComboBoxes()//INTRODUCE LOS ITEMS AL COMBOBOX
        {
            if (comboDocumento.Items.Count > 0) comboDocumento.Items.Clear();
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");
            comboDocumento.SelectedIndex = 0;
        }

        public void ConfigControles(string modo)//CONFIGURACIÓN DE LOS BOTONES
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

        public void Config_Tables()//CONFIGURACIÓN DE LAS TABLAS
        {
            tableProductos.AutoGenerateColumns = false;
            tableCarrito.AutoGenerateColumns = false;
            tableProductos.AllowUserToAddRows = false;
            tableCarrito.AllowUserToAddRows = false;
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)//LIMITA LOS TEXBOXES PARA QUE ACEPTEN SÓLO NÚMEROS
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)//MÉTODO PARA BUSCAR PRODUCTOS ESPECÍFICOS EN LA BASE DE DATOS
        {
            FillTables(2);
        }

        public void NuevoRegistro()
        {
            Form x = new Form();
            NuevoRegistro y = new NuevoRegistro(comboDocumento.SelectedItem.ToString(), txtDocumento.Text, 1);
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

        private decimal GetTotal()
        {
            decimal x = 0;
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                x = x + decimal.Parse(carrito.Rows[i]["Precio"].ToString());
            }
            return x;
        }
        //CONFIGURACIONES
    }
}
