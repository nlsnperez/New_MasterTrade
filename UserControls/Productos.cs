using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Productos_Prot : UserControl
    {
        CRUD_Productos crud;

        public Productos_Prot()
        {
            InitializeComponent();
            Config();
        }

        private void Productos_Prot_Load(object sender, EventArgs e)
        {
            //Config();
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            txtID.Text = crud.GetLastID().ToString();
            txtID.Enabled = false;
            comboCategoria.Focus();
            txtCantidad.Enabled = false;
            bttnActualizar.Enabled = false;
            bttnEliminar2.Enabled = false;
            ConfigCombos();
            ConfigLongitud();
        }

        public void ConfigLongitud()
        {
            txtSerial.MaxLength = 100;
            txtDescripcion.MaxLength = 500;
            txtPrecioVenta.MaxLength = 13;
            txtPrecioCompra.MaxLength = 13;
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                string imagen = openImage.FileName;
                pbImagen.Image = Image.FromFile(imagen);
            }            
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (pbImagen.Image != null)
            {
                pbImagen.Image = Properties.Resources.descripcion_del_producto;
            }            
        }

        public void ConfigCombos()
        {
            comboMarca.ValueMember = "id";
            comboMarca.DisplayMember = "nombre";
            comboMarca.DataSource = crud.Marcas();
            comboMarca.SelectedIndex = 0;

            comboCategoria.ValueMember = "id";
            comboCategoria.DisplayMember = "nombre";
            comboCategoria.DataSource = crud.Categorias();
            comboCategoria.SelectedIndex = 0;

            comboModelo.ValueMember = "id";
            comboModelo.DisplayMember = "nombre";
            comboModelo.DataSource = crud.Modelos();
            comboModelo.SelectedIndex = 0;

            comboEstado.Items.Add("No Disponible");
            comboEstado.Items.Add("Disponible");
            comboEstado.SelectedIndex = 0;
        }

        private Producto GetProducto()
        {
            bool estado = false;
            if (comboEstado.SelectedIndex == 1) estado = true;
            MemoryStream ms = new MemoryStream();
            pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
            byte[] imagen = ms.ToArray();

            Producto producto = new Producto(txtSerial.Text,
                                                txtDescripcion.Text,
                                                int.Parse(comboMarca.SelectedValue.ToString()),
                                                int.Parse(comboCategoria.SelectedValue.ToString()),
                                                int.Parse(comboModelo.SelectedValue.ToString()),
                                                decimal.Parse(txtPrecioCompra.Text),
                                                decimal.Parse(txtPrecioVenta.Text),
                                                estado,
                                                imagen);
            return producto;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar el producto: "+txtSerial.Text+"?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Create(GetProducto());
                Limpiar();
            }
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (crud.ProductoDatos(txtBuscar.Text).Rows.Count > 0)
            {
                SetDatos(crud.ProductoDatos(txtBuscar.Text));
            }
            else
            {
                MessageBox.Show("No se encontró ningún producto con el serial introducido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void OpenProducto(string filtro)
        {
            if (crud.ProductoDatos(filtro).Rows.Count > 0)
            {
                Console.WriteLine("¡Yei2!");
                SetDatos(crud.ProductoDatos(filtro));
            }
        }

        public void SetDatos(DataTable x)
        {
            DataTable resultado = x;
            byte[] imagen = (byte[])resultado.Rows[0][9];
            MemoryStream ms = new MemoryStream(imagen);

            txtID.Text = resultado.Rows[0][0].ToString();
            comboCategoria.SelectedValue = Int32.Parse(resultado.Rows[0][1].ToString());
            comboMarca.SelectedValue = Int32.Parse(resultado.Rows[0][2].ToString());
            comboModelo.SelectedValue = Int32.Parse(resultado.Rows[0][3].ToString());
            txtSerial.Text = resultado.Rows[0][4].ToString();
            txtDescripcion.Text = resultado.Rows[0][5].ToString();
            txtPrecioCompra.Text = resultado.Rows[0][6].ToString();
            txtPrecioVenta.Text = resultado.Rows[0][7].ToString();
            pbImagen.Image = Image.FromStream(ms);

            txtBuscar.Text = "";
            txtSerial.Enabled = false;
            bttnGuardar.Enabled = false;
            bttnActualizar.Enabled = true;
            bttnEliminar2.Enabled = true;
        }

        public void Limpiar()
        {
            txtID.Text = crud.GetLastID().ToString();
            txtSerial.Text = "";
            txtSerial.Enabled = true;
            txtDescripcion.Text = "";
            txtPrecioCompra.Text = "0";
            txtPrecioVenta.Text = "0";
            txtCantidad.Text = "0";
            txtBuscar.Text = "";
            comboMarca.SelectedIndex = 0;
            comboCategoria.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
            pbImagen.Image = Properties.Resources.descripcion_del_producto;
            bttnGuardar.Enabled = true;
            bttnActualizar.Enabled = false;
            bttnEliminar2.Enabled = false;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtPrecioVenta_Enter(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "0")
            {
                txtPrecioVenta.Text = "";
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "")
            {
                txtPrecioVenta.Text = "0";
            }
        }

        private void txtPrecioCompra_Enter(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "0")
            {
                txtPrecioCompra.Text = "";
            }
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "")
            {
                txtPrecioCompra.Text = "0";
            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar el producto: " + txtSerial.Text + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Update(GetProducto(), Int32.Parse(txtID.Text));
            }
        }
    }
}
