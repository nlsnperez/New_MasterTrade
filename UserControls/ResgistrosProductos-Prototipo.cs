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
        public ResgistrosProductos_Prototipo()
        {
            InitializeComponent();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            Productos_Prot y = new Productos_Prot();
            x.Size = new Size(y.Width+30, y.Height+40);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }
    }
}
