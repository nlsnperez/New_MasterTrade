using New_MasterTrade.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Comprar : UserControl
    {
        CRUDTransacciones crud;

        public Comprar()
        {
            InitializeComponent();
        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            crud = new CRUDTransacciones();
            Config_Tables();
            txtCodigo.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtPrecio.Enabled = false;
            FillTables();
        }

        public void FillTables()
        {
            tableProductos.DataSource = crud.FindProductos();
        }

        private void tableProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodigo.Text = tableProductos.SelectedRows[0].Cells[0].Value.ToString().Remove(0, 1);
            txtNombreProducto.Text = tableProductos.SelectedRows[0].Cells[1].Value.ToString();
            txtCantidad.Text = "0";
            txtPrecio.Text = tableProductos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] producto = { txtCodigo.Text,txtNombreProducto.Text, txtCantidad.Text, txtPrecio.Text};
            tableCarrito.Rows.Add(producto);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            tableCarrito.Rows.RemoveAt(tableCarrito.Rows.Count - 1);            
        }

        public void Config_Tables()
        {
            tableProductos.AutoGenerateColumns = false;
            tableCarrito.AutoGenerateColumns = false;
            tableProductos.AllowUserToAddRows = false;
            tableCarrito.AllowUserToAddRows = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombreProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }
    }
}
