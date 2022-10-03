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
        bool IsCollapsed;
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
            panelSlide.Size = panelSlide.MinimumSize;
            txtNombre.MaxLength = 200;
            txtCosto.MaxLength = 13;
            txtStockMax.MaxLength = 10;
            txtStockMin.MaxLength = 10;
            FillComboBoxes();
            tablaProductos.AutoGenerateColumns = false;
            txtID.Enabled = false;
            txtCantidad.Enabled = false;
            Config_Botones("INICIO");
            RefreshTable(1);
            panel1.Size = MaximumSize;
        }

        public void FillComboBoxes()
        {
            if (comboCategoría.Items.Count > 0) comboCategoría.DataSource = null;
            comboCategoría.ValueMember = "id";
            comboCategoría.DisplayMember = "nombre";
            comboCategoría.DataSource = crud.Categorias();
            comboCategoría.SelectedIndex = 0;
        }

        //BOTONES//

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (btnGuardar.Text)
            {
                case "GUARDAR":
                    Guardar();
                    break;
                case "ACTUALIZAR":
                    Actualizar();
                    break;
            }
        }

        private void Guardar()
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
                        timerSlide.Start();
                    }

                }
            }
        }

        private void Actualizar()
        {
            if (MessageBox.Show("Desea actualizar los datos del producto: " + GetProducto().Codigo + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Update(GetProducto());
                Clear();
                RefreshTable(1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar los datos del prodcuto: " + lblCodigo.Text + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                crud.Delete(lblCodigo.Text);
                Clear();
                RefreshTable(1);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
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
            Producto producto = new Producto(Int32.Parse(txtID.Text), lblCodigo.Text, txtNombre.Text, comboCategoría.SelectedValue.ToString(), float.Parse(txtCosto.Text.Replace(',', '.'), CultureInfo.InvariantCulture), Int32.Parse(txtStockMax.Text), Int32.Parse(txtStockMin.Text));
            return producto;
        }        

        public void Clear()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "00,00";
            txtStockMin.Text = "0";
            txtStockMax.Text = "0";
            txtBuscar.Text = "";
            comboCategoría.SelectedIndex = 0;
            comboCategoría.Enabled = true;
            Config_Botones("INICIO");
            RefreshTable(1);
        }

        private void tablaProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblCodigo.Text = tablaProductos.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = tablaProductos.SelectedRows[0].Cells[1].Value.ToString();
            comboCategoría.SelectedValue = tablaProductos.SelectedRows[0].Cells[2].Value.ToString();
            txtCosto.Text = tablaProductos.SelectedRows[0].Cells[3].Value.ToString().Replace('.', ',');
            txtCantidad.Text = Convert.ToString(crud.ProductosComprados(lblCodigo.Text) - crud.ProductosVendidos(lblCodigo.Text));
            txtStockMax.Text = tablaProductos.SelectedRows[0].Cells[4].Value.ToString();
            txtStockMin.Text = tablaProductos.SelectedRows[0].Cells[5].Value.ToString();
            comboCategoría.Enabled = false;
            Config_Botones("SELECCIÓN");
        }        

        //PLACEHOLDERS//

        private void txtStockMax_Enter(object sender, EventArgs e)
        {
            if (txtStockMin.Text == "0")
            {
                txtStockMin.Text = "";
            }
        }

        private void txtStockMax_Leave(object sender, EventArgs e)
        {
            if (txtStockMin.Text == "")
            {
                txtStockMin.Text = "0";
            }
        }

        private void txtStockMin_Enter(object sender, EventArgs e)
        {
            if (txtStockMax.Text == "0")
            {
                txtStockMax.Text = "";
            }
        }

        private void txtStockMin_Leave(object sender, EventArgs e)
        {
            if (txtStockMax.Text == "")
            {
                txtStockMax.Text = "0";
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            txtID.Text = crud.GetLastID().ToString();
            lblCodigo.Text = "MTP" + crud.GetLastID().ToString("0000000");
            timerSlide.Start();
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panelSlide.Width += 50;
                if (panelSlide.Size == panelSlide.MaximumSize)
                {
                    timerSlide.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                panelSlide.Width -= 50;
                if (panelSlide.Size == panelSlide.MinimumSize)
                {
                    timerSlide.Stop();
                    IsCollapsed = true;
                }
            }
        }

        private void bttnAtras_Click(object sender, EventArgs e)
        {
            timerSlide.Start();
            btnGuardar.Text = "GUARDAR";
            Clear();
            lblCodigo.Text = "MTP0000000";
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Producto producto = crud.FindProducto(tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtID.Text = producto.Id.ToString();
                lblCodigo.Text = producto.Codigo;
                txtNombre.Text = producto.Nombre;
                comboCategoría.SelectedValue = producto.Categoria;
                txtCosto.Text = producto.Costo.ToString().Replace('.', ',');
                txtCantidad.Text = Convert.ToString(crud.ProductosComprados(lblCodigo.Text) - crud.ProductosVendidos(lblCodigo.Text));
                txtStockMax.Text = producto.StockMax.ToString();
                txtStockMin.Text = producto.StockMin.ToString();
                comboCategoría.Enabled = false;
                btnGuardar.Text = "ACTUALIZAR";
                timerSlide.Start();
            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    if (MessageBox.Show("Desea eliminar los datos del prodcuto: " + tablaProductos.Rows[e.RowIndex].Cells[2].Value.ToString() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        crud.Delete(tablaProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                        Clear();
                        RefreshTable(1);
                    }
                }
            }
        }
    }


}
