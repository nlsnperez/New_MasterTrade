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
        float total = 0;

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
                    string[] producto = { txtCodigo.Text, txtNombreProducto.Text, txtCantidad.Text, Calc_Precio(float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture), float.Parse(txtCantidad.Text, CultureInfo.InvariantCulture)).ToString()};
                    carrito.Rows.Add(producto);
                    tableCarrito.DataSource = carrito;

                    //CALCULA EL PRECIO TOTAL DE LA COMPRA Y LO MUESTRA EN UN LABEL
                    total = total + Calc_Precio(float.Parse(txtPrecio.Text, CultureInfo.InvariantCulture), float.Parse(txtCantidad.Text, CultureInfo.InvariantCulture));
                    lblTotal.Text = total.ToString() + " Bs";

                    btnAtras.Enabled = true;
                    btnConfirmar.Enabled = true;
                    Cancel_Order();
                }
            }
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar la compra?", "¿CONFIRMAR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Create_Compra(GetCompra());
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
            total = total - float.Parse(carrito.Rows[carrito.Rows.Count-1]["Precio"].ToString());//RESTA EL PRECIO DEL PRODUCTO ELIMINADO
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
        //BOTONES

        private Compra GetCompra()//GENERA UNA COMPRA CON LOS DATOS SUMINISTRADOS
        {
            List<Detalle_Compra> detalle = new List<Detalle_Compra>();
            for (int i = 0; i <= carrito.Rows.Count - 1; i++)
            {
                Detalle_Compra x = new Detalle_Compra(carrito.Rows[i]["Código"].ToString(), Int32.Parse(carrito.Rows[i]["Cantidad"].ToString()), float.Parse(carrito.Rows[i]["Precio"].ToString()));
                detalle.Add(x);
            }
            Compra compra = new Compra(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, detalle);
            compra.Generar_Codigo(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, crud.ComprasRealizadas());
            return compra;
        }

        public void Cancel_Order()//LIMPIA LOS CAMPOS ATENDIENDO A UN PARÁMETRO
        {
            if(txtCodigo.Text == ""|| txtNombreProducto.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
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
                    tableCarrito.DataSource = null;
                    carrito.Rows.Clear();
                    total = 0;
                    lblTotal.Text = "00,00 Bs";
                    break;
            }
            
        }

        public float Calc_Precio(float precio, float cantidad)//CALCULA EL PRECIO DE LA COMPRA
        {
            return (float) (precio * cantidad);
        }

        public void FillTables(int x)//BUSCA LOS REGISTROS EN LA BASE DE DATOS PARA LA TABLA DE PRODUCTOS
        {
            switch (x)
            {
                case 1:
                    tableProductos.DataSource = crud.FindProductos(comboDocumento.SelectedItem.ToString() + txtDocumento.Text);//BUSQUEDA GENERAL
                    break;
                case 2:
                    tableProductos.DataSource = crud.BuscarProductos(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, txtBuscar.Text);//BUSQUEDA ESPECÍFICA
                    break;
            }
            
        }
        //CLICKS & KEYPRESS

        private void tableProductos_MouseDoubleClick(object sender, MouseEventArgs e)//ORDENA LOS DATOS DE LA TABLA PRODUCTOS EN LOS TEXTBOXES CORRESPONDIENTES
        {
            txtCodigo.Text = tableProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombreProducto.Text = tableProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtCantidad.Enabled = true;
            txtCantidad.Text = "1";
            txtPrecio.Text = tableProductos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)//MÉTODO PARA BUSCAR UN PROVEEDOR EN LA BASE DE DATOS
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDocumento.Text == "")//VERIFICA QUE EL CAMPO NO ESTÉ VACÍO
                {
                    MessageBox.Show("¡Por favor ingrese un documento!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Persona proveedor = crud.FindPersona(comboDocumento.SelectedItem.ToString()+txtDocumento.Text);//BUSCA UN PROOVEDOR EN LA BASE DE DATOS
                    if (proveedor==null)//EN CASO QUE NO SE ENCUENTRE UN RESULTADO
                    {
                        if (MessageBox.Show("No hay un proveedor con el documento que introdujo ¿Desea registrar uno nuevo?", "PROVEEDOR NO ENCONTRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            NuevoRegistro();
                            txtDocumento.Text = "";

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
        }
        
        //CONFIGURACIONES
    }
}
