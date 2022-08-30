using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade
{
    public partial class Productos : UserControl
    {
        CRUDProductos crud;
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Config();
        }

        public void Config()
        {
            crud = new CRUDProductos();
            txtCodigo.MaxLength = 100;
            txtNombre.MaxLength = 200;
            txtCosto.MaxLength = 13;
            txtStockMin.MaxLength = 10;
            txtStockMax.MaxLength = 10;
            FillComboBoxes();
            tablaProductos.AutoGenerateColumns = false;
            txtCantidad.Enabled = false;
            Config_Botones("INICIO");
            RefreshTable(1);
        }

        public void FillComboBoxes()
        {
            if (comboProveedor.Items.Count > 0) comboProveedor.DataSource = null;
            comboProveedor.ValueMember = "documento_identidad";
            comboProveedor.DisplayMember = "proveedor";
            comboProveedor.DataSource = crud.Proveedores();
            comboProveedor.SelectedIndex = 0;
        }

        //BOTONES//

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GetProducto().IsEmpty())
            {
                MessageBox.Show("Complete todos los campos!");
            }
            else
            {
               if (GetProducto().CompararStock() == false)
                {
                    MessageBox.Show("¡El stock máximo no puede ser menor al stock mínimo!", "INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("¿Desea registrar el producto: " + GetProducto().Codigo + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        crud.Create(GetProducto());
                        Clear();
                        RefreshTable(1);
                  }

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar los datos del prodcuto: " + txtCodigo.Text + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                crud.Delete(txtCodigo.Text);
                Clear();
                RefreshTable(1);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea actualizar los datos del producto: " + GetProducto().Codigo + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Update(GetProducto());
                Clear();
                RefreshTable(1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Config_Botones(String estado)
        {
            switch (estado)
            {
                case "INICIO":
                    btnGuardar.Enabled = true;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
                case "SELECCIÓN":
                    btnGuardar.Enabled = false;
                    btnActualizar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
            }
        }

        //BOTONES//

        public void RefreshTable(int x)
        {
            switch (x)
            {
                case 1:
                    tablaProductos.DataSource = crud.GetTable();
                    break;
                case 2:
                    tablaProductos.DataSource = crud.SearchTable(txtBuscar.Text);
                    break;
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshTable(2);
        }

        private Producto GetProducto()
        {
            Producto producto = new Producto(txtCodigo.Text, txtNombre.Text, comboProveedor.SelectedValue.ToString().Substring(comboProveedor.SelectedItem.ToString().LastIndexOf('-') + 1), float.Parse(txtCosto.Text.Replace(',', '.'), CultureInfo.InvariantCulture), Int32.Parse(txtStockMax.Text), Int32.Parse(txtStockMin.Text));
            return producto;
        }        

        public void Clear()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "00,00";
            txtStockMax.Text = "0";
            txtStockMin.Text = "0";
            txtBuscar.Text = "";
            txtCodigo.Enabled = true;
            comboProveedor.SelectedIndex = 0;
            comboProveedor.Enabled = true;
            comboProveedor.SelectedIndex = 1;
            Config_Botones("INICIO");
            RefreshTable(1);
        }

        private void tablaProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodigo.Text = tablaProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = tablaProductos.SelectedRows[0].Cells[1].Value.ToString();
            comboProveedor.SelectedValue = tablaProductos.SelectedRows[0].Cells[2].Value.ToString();
            txtCosto.Text = tablaProductos.SelectedRows[0].Cells[3].Value.ToString().Replace('.', ',');
            txtCantidad.Text = Convert.ToString(crud.ProductosComprados(txtCodigo.Text) - crud.ProductosVendidos(txtCodigo.Text));
            txtStockMax.Text = tablaProductos.SelectedRows[0].Cells[4].Value.ToString();
            txtStockMin.Text = tablaProductos.SelectedRows[0].Cells[5].Value.ToString();
            comboProveedor.Enabled = false;
            txtCodigo.Enabled = false;
            Config_Botones("SELECCIÓN");
        }        

        //PLACEHOLDERS//

        private void txtStockMax_Enter(object sender, EventArgs e)
        {
            if (txtStockMax.Text == "0")
            {
                txtStockMax.Text = "";
            }
        }

        private void txtStockMax_Leave(object sender, EventArgs e)
        {
            if (txtStockMax.Text == "")
            {
                txtStockMax.Text = "0";
            }
        }

        private void txtStockMin_Enter(object sender, EventArgs e)
        {
            if (txtStockMin.Text == "0")
            {
                txtStockMin.Text = "";
            }
        }

        private void txtStockMin_Leave(object sender, EventArgs e)
        {
            if (txtStockMin.Text == "")
            {
                txtStockMin.Text = "0";
            }
        }

        private void txtCosto_Enter(object sender, EventArgs e)
        {
            if (txtCosto.Text == "00,00")
            {
                txtCosto.Text = "";
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                txtCosto.Text = "00,00";
            }
        }
        
        //PLACEHOLDERS//

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }


}
