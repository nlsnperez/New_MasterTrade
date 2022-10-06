using New_MasterTrade.Objetos;
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
    public partial class DetallesTransaccion : UserControl
    {
        public Venta TransaccionV;

        public DetallesTransaccion(Venta venta)
        {
            InitializeComponent();

            this.TransaccionV = venta;
            MessageBox.Show(TransaccionV.Detalle.Count.ToString());
            Config();
        }

        public void Config()
        {
            lblId.Text = "#"+TransaccionV.Id.ToString();
            lblNumeroOrden.Text = TransaccionV.Numero_Control;
            lblPago.Text = TransaccionV.MetodoPagoDescripcion;
            lblFecha.Text = TransaccionV.FechaRegistro.ToShortDateString();
        }

        public void ConfigDetalle()
        {
            SetProductos();
            SetCosto();
        }

        public void SetProductos()
        {
            for (int i = 0; i < TransaccionV.Detalle.Count()-1; i++)
            {
                flowProductos.FlowDirection = FlowDirection.LeftToRight;
                Label producto = new Label();
                producto.Text = TransaccionV.Detalle[i].Producto+"x"+ TransaccionV.Detalle[i].Cantidad.ToString();
                this.flowProductos.Controls.Add(producto);
                this.flowProductos.SetFlowBreak(producto, true);
                producto.Tag = i;
                producto.BringToFront();
            }
        }

        public void SetCosto()
        {
            for (int i = 0; i < TransaccionV.Detalle.Count() - 1; i++)
            {
                flowCantidad.FlowDirection = FlowDirection.LeftToRight;
                Label precio = new Label();
                precio.Text = TransaccionV.Detalle[i].Precio.ToString()+"Bs";
                this.flowCantidad.Controls.Add(precio);
                this.flowCantidad.SetFlowBreak(precio, true);
                precio.Tag = i;
                precio.BringToFront();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
