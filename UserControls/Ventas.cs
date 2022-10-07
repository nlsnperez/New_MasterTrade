using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_MasterTrade.Custom_Controls;
using System.Windows.Forms;
using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;

namespace New_MasterTrade.UserControls
{
    public partial class Ventas : UserControl
    {
        CRUDTransacciones crud;
        DataTable ventas = new DataTable();
        bool IsCollapsed = true;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            Config();
        }

        public void Config()
        {
            crud = new CRUDTransacciones();
            tablaDetalle.AutoGenerateColumns = false;
            tablaDetalle.Enabled = false;
            panelSlide.Size = panelSlide.MinimumSize;
            PickerFecha.MaxDate = System.DateTime.Today;
            flowRegistros.AutoScroll = true;
        }

        public void LoadVentas()
        {
            flowRegistros.Controls.Clear();
            if (ventas.Rows.Count < 0) ventas.Clear();
            ventas = crud.Ventas();
            for (int i = 0; i <= ventas.Rows.Count - 1; i++)
            {
                flowRegistros.FlowDirection = FlowDirection.LeftToRight;
                RegistroVenta registro = new RegistroVenta(ventas.Rows[i]["id"].ToString(),
                                                           ventas.Rows[i]["numero_control"].ToString(),
                                                           ventas.Rows[i]["fecha_registro"].ToString(),
                                                           this);
                PickerFecha.MinDate = DateTime.Parse(ventas.Rows[i]["fecha_registro"].ToString());
                this.flowRegistros.Controls.Add(registro);
                this.flowRegistros.SetFlowBreak(registro, true);
                registro.Tag = i;
                registro.BringToFront();
            }
        }

        public void StartTimer(Venta venta)
        {
            lblID.Text = "#"+venta.Id.ToString();
            lblNumeroOrden.Text = venta.Numero_Control;
            lblCliente.Text = venta.ClienteNombre;
            lblMetodoPago.Text = venta.MetodoPagoDescripcion;
            lblFecha.Text = venta.FechaRegistro.ToShortDateString();
            tablaDetalle.DataSource = crud.GetDetalle(venta.Id);
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

        private void bttnRegresar_Click(object sender, EventArgs e)
        {
            timerSlide.Start();
        }
    }
}
