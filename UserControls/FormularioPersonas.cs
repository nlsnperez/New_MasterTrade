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
    public partial class FormularioPersonas : UserControl
    {
        CRUDPersonas crud;
        public FormularioPersonas()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUDPersonas();
            comboOcupacion.Focus();
            ConfigLongitud();
            ConfigCombos();
            bttnActualizar.Enabled = false;
            bttnEliminar2.Enabled = false;
        }

        public void ConfigCombos()
        {
            comboOcupacion.Items.Add("CLIENTE");
            comboOcupacion.Items.Add("PROVEEDOR");
            comboOcupacion.SelectedIndex = 0;
            
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");
            comboDocumento.SelectedIndex = 0;
        }

        public void ConfigLongitud()
        {
            txtDocumento.MaxLength = 9;
            txtRazonSocial.MaxLength = 100;
            txtDireccion.MaxLength = 500;
            txtTelefono.MaxLength = 15;
            txtCorreo.MaxLength = 100;
        }

        private Persona GetPersona()
        {
            Persona persona = new Persona(comboDocumento.SelectedItem.ToString() + txtDocumento.Text,
                                          txtRazonSocial.Text,
                                          txtDireccion.Text,
                                          txtTelefono.Text,
                                          txtCorreo.Text);
            return persona;
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtBuscar.Text = "";
            comboDocumento.SelectedIndex = 0;
            comboOcupacion.SelectedIndex = 0;
            bttnGuardar.Enabled = true;
            bttnActualizar.Enabled = false;
            bttnEliminar2.Enabled = false;
        }
    }
}
