using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Custom_Controls;
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
        static FormularioProductos f_productos;
        public static FormularioProductos Instancia
        {
            get
            {
                if (f_productos == null)
                {
                    f_productos = new FormularioProductos();
                }
                return f_productos;
            }
        }

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
            bttnActualizar.Enabled = false;
            //bttnComprar.Visible = false;
            //bttnVender.Visible = false;
            ConfigCombos();
            ConfigLongitud();
        }

        public void ConfigLongitud()
        {
            txtSerial.MaxLength = 13;
            txtDescripcion.MaxLength = 100;
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
                comboMarca.DataSource = crud.MarcasActivas();
                comboMarca.SelectedIndex = 0;

                comboCategoria.ValueMember = "id_cat";
                comboCategoria.DisplayMember = "nom_cat";
                comboCategoria.DataSource = crud.CategoriasActivas();
                comboCategoria.SelectedIndex = 0;

                comboModelo.ValueMember = "id_mod";
                comboModelo.DisplayMember = "nom_mod";
                comboModelo.DataSource = crud.ModelosActivos();
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
            if (ProcesoDeAprobacion(GetProducto()))
            {
                if (crud.ProductoDuplicado(GetProducto().Serial))
                {
                    MessageBox.Show("Ya existe un producto registrado con el serial ingresado", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("¿Desea registrar este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        crud.Create(GetProducto());
                        if (UserData.Nivel == 1)
                        {
                            if (MessageBox.Show("¿Desea proseguir registrando una compra?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SesionIniciada.Instancia.MostrarUserControl(new Comprar());
                            }
                            else
                            {
                                Limpiar();
                            }
                        }
                        else
                        {
                            Limpiar();
                        }                        
                    }
                }
            }
        }

        public bool ProcesoDeAprobacion(Producto producto)
        {
            if (!producto.TamagnoSerial())
            {
                MessageBox.Show("Debe introducir un serial con 10 dígitos mínimo y 13 dígitos máximo", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (producto.IsEmpty())
            {
                MessageBox.Show("Complete todos los campos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!producto.PrecioCorrecto())
            {
                MessageBox.Show("El precio de venta no puede ser menor al precio de compra", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public int DiasDeGarantía()
        {
            switch (comboGarantia.SelectedIndex)
            {
                case 0:
                    return 3;
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
            SesionIniciada.Instancia.MostrarUserControl(new Productos());
            //Producto producto = crud.ProductoDatos(txtBuscar.Text);
            //if (producto != null)
            //{
            //    DatosProducto(producto);
            //}
            //else
            //{
            //    MessageBox.Show("No se encontró ningún producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        public void DatosProducto(Producto producto)
        {
            try
            {
                int cantidad = crud.ProductosComprados(producto.Id) - crud.ProductosVendidos(producto.Id);
                if (cantidad > 0)
                {
                    txtCantidad.BackColor = Color.FromArgb(149, 212, 90);
                    //bttnVender.Visible = true;
                }
                else
                {
                    txtCantidad.BackColor = Color.FromArgb(255, 97, 116);
                }

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
                txtCantidad.Text = cantidad.ToString();
                IndexGarantia(producto.Garantia);

                txtSerial.Enabled = false;
                bttnGuardar.Enabled = false;
                bttnActualizar.Enabled = true;
                //bttnComprar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void IndexGarantia(int x)
        {
            int y = 0;
            switch (x)
            {
                case 3:
                    comboGarantia.Text = "3 DÍAS";
                    break;
                case 7:
                    comboGarantia.Text = "1 SEMANA";
                    break;
                case 30:
                    comboGarantia.Text = "1 MES";
                    break;
                case 365:
                    comboGarantia.Text = "1 AÑO";
                    break;
            }
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
            if (ProcesoDeAprobacion(GetProducto()))
            {
                if (MessageBox.Show("¿Desea actualizar este producto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    crud.Update(GetProducto());
                    Limpiar();
                }
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

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            TextBox objeto = sender as TextBox;
            if (objeto.Name == "txtSerial")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnCategoria_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarDialog(new Categorias());
            ConfigCombos();
        }

        private void bttnMarca_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarDialog(new Marcas());
            ConfigCombos();
        }

        private void bttnModelo_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarDialog(new Modelos());
            ConfigCombos();
        }
    }
}
