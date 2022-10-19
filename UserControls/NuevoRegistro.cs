using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class NuevoRegistro : UserControl
    {
        CRUDPersonas crud;
        public Persona Registro { get; set; }

        public NuevoRegistro(string x, string documento, int y)
        {
            InitializeComponent();
            Config(x, documento, y);
        }

        private void NuevoRegistro_Load(object sender, EventArgs e)
        {
            //Config();
        }

        public void Config(string x, string documento, int y)
        {
            crud = new CRUDPersonas();
            Registro = null;
            FillComboBoxes();
            SelectComboBox(x);
            txtDocumento.Text = documento;
            comboOcupacion.SelectedIndex = y;
            txtDocumento.Enabled = false;
            comboDocumento.Enabled = false;
            comboOcupacion.Enabled = false;
        }

        public void FillComboBoxes()
        {
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");

            comboOcupacion.Items.Add("CLIENTE");
            comboOcupacion.Items.Add("PROVEEDOR");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "" && txtDireccion.Text == "" && txtTelefono.Text == "" && txtCorreo.Text == "")
            {
                this.ParentForm.Close();
            }
            else
            {
                txtRazonSocial.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
            }
        }

        public void SelectComboBox(string x)
        {
            switch (x)
            {
                case "V":
                    comboDocumento.SelectedIndex = 0;
                    break;
                case "E":
                    comboDocumento.SelectedIndex = 1;
                    break;
                case "J":
                    comboDocumento.SelectedIndex = 2;
                    break;
                case "G":
                    comboDocumento.SelectedIndex = 3;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text == "" || txtRazonSocial.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("¡Por favor complete todos los datos", "DATOS INCOMPLETOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!GetPersona().ValidDocumento())
                {
                    MessageBox.Show(GetPersona().Documento + " no es un número de documento válido. Inténtelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDocumento.Enabled = true;
                }
                else
                {
                    if (!GetPersona().ValidPhone())
                    {
                        MessageBox.Show(GetPersona().Telefono + " no es un número de teléfono válido. Inténtelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!GetPersona().ValidEmail())
                        {
                            MessageBox.Show(GetPersona().Correo.ToUpper() + " no es una dirección de correo válida. Inténtelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (MessageBox.Show("¿Desea registrar el cliente: " + GetPersona().Documento + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (comboOcupacion.SelectedIndex == 0)
                                {
                                    crud.Create(GetPersona(), "clientes");
                                    Registro = GetPersona();
                                }
                                else
                                {
                                    crud.Create(GetPersona(), "proveedores");
                                    Registro = GetPersona();
                                }
                                this.ParentForm.Close();
                            }
                        }
                    }
                }
            }
        }

        private Persona GetPersona()
        {
            Persona persona = new Persona(comboDocumento.SelectedItem.ToString()+txtDocumento.Text, txtRazonSocial.Text.ToUpper(), txtDireccion.Text.ToUpper(), txtTelefono.Text, txtCorreo.Text.ToUpper());
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
    }
}
