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
    public partial class ResgistrosProductos_Prototipo : UserControl
    {
        CRUD_Productos crud;
        public ResgistrosProductos_Prototipo()
        {
            InitializeComponent();
        }

        public void Config()
        {
            crud = new CRUD_Productos();
            tablaProductos.DataSource = crud.TablaProductos();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            Productos_Prot y = new Productos_Prot();
            x.Size = new Size(y.Width+30, y.Height+40);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();

            tablaProductos.DataSource = crud.TablaProductos();
        }

        private void ResgistrosProductos_Prototipo_Load(object sender, EventArgs e)
        {
            Config();
        }
    }
}
