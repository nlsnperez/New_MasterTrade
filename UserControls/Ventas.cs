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

namespace New_MasterTrade.UserControls
{
    public partial class Ventas : UserControl
    {
        CRUDTransacciones crud;
        DataTable ventas = new DataTable();
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
                                                           ventas.Rows[i]["fecha_registro"].ToString());
                PickerFecha.MinDate = DateTime.Parse(ventas.Rows[i]["fecha_registro"].ToString());
                this.flowRegistros.Controls.Add(registro);
                this.flowRegistros.SetFlowBreak(registro, true);
                registro.Tag = i;
                registro.BringToFront();
            }
        }

        private void PickerFecha_ValueChanged(object sender, EventArgs e)
        {
            //ventas.Clear();
            //ventas = crud.VentasByDate(PickerFecha.Value.ToShortDateString());
            //for (int i = 0; i <= ventas.Rows.Count - 1; i++)
            //{
            //    flowRegistros.FlowDirection = FlowDirection.LeftToRight;
            //    RegistroVenta registro = new RegistroVenta(ventas.Rows[i]["numero_control"].ToString(), ventas.Rows[i]["fecha_registro"].ToString());
            //    PickerFecha.MinDate = DateTime.Parse(ventas.Rows[i]["fecha_registro"].ToString());
            //    this.flowRegistros.Controls.Add(registro);
            //    this.flowRegistros.SetFlowBreak(registro, true);
            //    registro.Tag = i;
            //    registro.BringToFront();
            //}
        }
    }
}
