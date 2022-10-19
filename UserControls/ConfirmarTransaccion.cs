using New_MasterTrade.Base_de_Datos;
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

namespace New_MasterTrade.UserControls
{
    public partial class ConfirmarTransaccion : UserControl
    {
        List<Detalle> Detalle;
        CRUDPersonas crud2;
        CRUDTransacciones crud;        

        public ConfirmarTransaccion(int x, List<Detalle> detalle)
        {
            InitializeComponent();
            this.Detalle = detalle;
            Config(x);
        }

        public void Config(int x)
        {
            crud = new CRUDTransacciones();
            crud2 = new CRUDPersonas();
            lblTransaccion.Text = Detalle[0].Venta;
            switch (x)
            {
                case 1:
                    lblPersona.Text = "PROVEEDOR:";
                    FillComboBox(x);
                    break;
                case 2:
                    lblPersona.Text = "CLIENTE:";
                    FillComboBox(x);
                    break;
            }
        }

        public void FillComboBox(int x)
        {
            comboMetodoPago.DataSource = crud.MetodosPago();
            comboMetodoPago.ValueMember = "id";
            comboMetodoPago.DisplayMember = "descripcion";
            comboMetodoPago.SelectedIndex = 0;
            switch (x)
            {
                case 1:
                    comboRazonSocial.DataSource = crud2.GetTableProveedores();
                    comboRazonSocial.ValueMember = "id_proveedores";
                    comboRazonSocial.DisplayMember = "razon_social";
                    comboRazonSocial.SelectedIndex = 0;
                    break;
                case 2:
                    comboRazonSocial.DataSource = crud2.GetTable();
                    comboRazonSocial.ValueMember = "id_cliente";
                    comboRazonSocial.DisplayMember = "razon_social";
                    comboRazonSocial.SelectedIndex = 0;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void bttnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea confirmar la venta?", "¿CONFIRMAR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Create_Venta(GetVenta());
                this.ParentForm.Close();
            }
        }

        private Venta GetVenta()
        {
            Venta venta = new Venta(lblTransaccion.Text,
                                    int.Parse(comboRazonSocial.SelectedValue.ToString()),
                                    int.Parse(comboMetodoPago.SelectedValue.ToString()),
                                    System.DateTime.Now,
                                    this.Detalle);
            return venta;
        }
    }
}
