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

namespace New_MasterTrade.Custom_Controls
{
    public partial class RegistroVenta : UserControl
    {
        CRUDTransacciones crud;
        public RegistroVenta(string id, string numero_operacion, string fecha)
        {
            InitializeComponent();
            crud = new CRUDTransacciones();
            lblID.Text = "#"+id;
            lblNumeroOrden.Text = numero_operacion;
            lblFecha.Text = fecha;
        }

        private void bttnDetalles_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            Console.WriteLine("Aquí eta");
            DetallesTransaccion y = new DetallesTransaccion(crud.TransaccionV(Int32.Parse(lblID.Text.Remove(0, 1))));
            Console.WriteLine("Aquí eta2");
            x.FormBorderStyle = FormBorderStyle.None;
            x.Controls.Add(y);
            Console.WriteLine("Aquí eta3");
            x.Size = y.Size;
            x.StartPosition = FormStartPosition.CenterScreen;
            x.Show();
            Console.WriteLine("Aquí eta4");
        }
    }
}
