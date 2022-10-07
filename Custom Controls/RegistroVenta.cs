using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.UserControls;
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
        Ventas parentVentas;

        public RegistroVenta(string id, string numero_operacion, string fecha, Ventas venta)
        {
            InitializeComponent();
            crud = new CRUDTransacciones();
            lblID.Text = "#"+id;
            lblNumeroOrden.Text = numero_operacion;
            lblFecha.Text = fecha;
            parentVentas = venta;
        }

        private void bttnDetalles_Click(object sender, EventArgs e)
        {
            parentVentas.StartTimer(crud.GetVenta(Int32.Parse(lblID.Text.Remove(0, 1))));
        }
    }
}
