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
    public partial class FormularioProductos : UserControl
    {
        CRUD_Productos crud;

        public FormularioProductos()
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
                pbImagen.Image = Properties.Resources.ImagenPlaceHolder;
            }            
        }

        public void ConfigCombos()
        {
            try
            {
                comboMarca.ValueMember = "id_mar";
                comboMarca.DisplayMember = "nom_mar";
                comboMarca.DataSource = crud.Marcas();
                comboMarca.SelectedIndex = 0;

                comboCategoria.ValueMember = "id_cat";
                comboCategoria.DisplayMember = "nom_cat";
                comboCategoria.DataSource = crud.Categorias();
                comboCategoria.SelectedIndex = 0;

                comboModelo.ValueMember = "id_mod";
                comboModelo.DisplayMember = "nom_mod";
                comboModelo.DataSource = crud.Modelos();
                comboModelo.SelectedIndex = 0;

                comboGarantia.Items.Add("3 DÍAS");
                comboGarantia.Items.Add("1 SEMANA");
                comboGarantia.Items.Add("1 MES");
                comboGarantia.Items.Add("1 AÑO");
                comboGarantia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Producto GetProducto()
        {
            MemoryStream ms = new MemoryStream();
            pbImagen.Image.Save(ms, pbImagen.Image.RawFormat);
            byte[] imagen = ms.ToArray();

            Producto producto = new Producto(0, txtSerial.Text,
                                                txtDescripcion.Text,
                                                int.Parse(comboMarca.SelectedValue.ToString()),
                                                int.Parse(comboCategoria.SelectedValue.ToString()),
                                                int.Parse(comboModelo.SelectedValue.ToString()),
                                                decimal.Parse(txtPrecioCompra.Text),
                                                decimal.Parse(txtPrecioVenta.Text),
                                                DiasDeGarantía(),
                                                imagen);
            return producto;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (GetProducto().IsEmpty())
            {
                MessageBox.Show("Complete todos los campos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("¿Desea registrar el producto: " + txtSerial.Text + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    crud.Create(GetProducto());
                    Limpiar();
                }
            }
        }

        public int DiasDeGarantía()
        {
            switch (comboGarantia.SelectedIndex)
            {
                case 0:
                    return 5;
                case 1:
                    return 7;
                case 2:
                    return 30;
                case 3:
                    return 365;
            }
            return 0;
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

        public void DatosProducto(Producto producto)
        {
            try
            {
                byte[] imagen = producto.Imagen;
                MemoryStream ms = new MemoryStream(imagen);
                pbImagen.Image = Image.FromStream(ms);

                txtID.Text = producto.Id.ToString();
                comboCategoria.SelectedValue = producto.Categoria;
                comboMarca.SelectedValue = producto.Marca;
                comboModelo.SelectedValue = producto.Modelo;
                txtSerial.Text = producto.Serial.ToString();
                txtDescripcion.Text = producto.Descripcion;
                txtPrecioCompra.Text = producto.Precio_Compra.ToString();
                txtPrecioVenta.Text = producto.Precio_Venta.ToString();

                txtBuscar.Text = "";
                txtSerial.Enabled = false;
                bttnGuardar.Enabled = false;
                bttnActualizar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void SetDatos(DataTable x)
        {
            DataTable resultado = x;
            byte[] imagen = (byte[])resultado.Rows[0][8];
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
            comboModelo.SelectedIndex = 0;
            comboGarantia.SelectedIndex = 0;
            pbImagen.Image = Properties.Resources.ImagenPlaceHolder;
            bttnGuardar.Enabled = true;
            bttnActualizar.Enabled = false;
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
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.FromArgb(255, 212, 100);
            textBox.ForeColor = Color.Black;
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrecioVenta.Text == "")
            {
                txtPrecioVenta.Text = "0";
            }
            TextBox textBox = sender as TextBox;
            textBox.BackColor = SystemColors.Window;
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void txtPrecioCompra_Enter(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "0")
            {
                txtPrecioCompra.Text = "";
            }
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.FromArgb(255, 212, 100);
            textBox.ForeColor = Color.Black;
        }

        private void txtPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrecioCompra.Text == "")
            {
                txtPrecioCompra.Text = "0";
            }
            TextBox textBox = sender as TextBox;
            textBox.BackColor = SystemColors.Window;
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar el producto: " + txtSerial.Text + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Update(GetProducto(), Int32.Parse(txtID.Text));
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.FromArgb(255, 212, 100);
            textBox.ForeColor = Color.Black;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = SystemColors.Window;
            textBox.ForeColor = SystemColors.WindowText;
        }
    }
}
