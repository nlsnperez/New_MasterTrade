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
        CRUDProveedores crud;
        CRUD_Clientes crud2;

        public FormularioPersonas()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUDProveedores();
            crud2 = new CRUD_Clientes();
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

        public Persona GetPersona()
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
            comboOcupacion.Enabled = true;
            comboDocumento.Enabled = true;
            txtDocumento.Enabled = true;
            bttnGuardar.Enabled = true;
            bttnActualizar.Enabled = false;
            bttnEliminar2.Enabled = false;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (GetPersona().IsEmpty())
            {
                MessageBox.Show("Complete todos los campos!");
            }
            else
            {
                if (!GetPersona().ValidDocumento())
                {
                    MessageBox.Show(GetPersona().Documento + " no es un número de documento válido. Inténtelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            if (MessageBox.Show("¿Desea registrar los datos de este " + comboOcupacion.Text.ToLower() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (comboOcupacion.SelectedIndex == 0)
                                {
                                    crud2.Create(GetPersona());
                                    Limpiar();
                                }
                                else
                                {
                                    crud.Create(GetPersona(), comboOcupacion.Text);
                                    Limpiar();
                                }                                
                            }
                        }
                    }
                }

            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar los datos de este " + comboOcupacion.Text.ToLower() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                crud.Update(GetPersona(), comboOcupacion.Text);
            }
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            if (crud.PersonaDatos(comboOcupacion.Text, txtBuscar.Text).Rows.Count > 0)
            {
                SetDatos(crud.PersonaDatos(comboOcupacion.Text, txtBuscar.Text));
            }
            else
            {
                MessageBox.Show("No se encontró ningún producto con el serial introducido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void OpenPersona(string tabla, string filtro)
        {
            if (crud.PersonaDatos(tabla, filtro).Rows.Count > 0)
            {
                SetDatos(crud.PersonaDatos(tabla, filtro));
                comboOcupacion.Text = tabla.ToUpper();
            }
        }

        public void SetDatos(DataTable x)
        {
            DataTable resultado = x;

            comboDocumento.Text = resultado.Rows[0][1].ToString().Substring(0, 1);
            txtDocumento.Text = resultado.Rows[0][1].ToString().Remove(0, 1);
            txtRazonSocial.Text = resultado.Rows[0][2].ToString();
            txtDireccion.Text = resultado.Rows[0][3].ToString();
            txtTelefono.Text = resultado.Rows[0][4].ToString();
            txtCorreo.Text = resultado.Rows[0][5].ToString();

            txtBuscar.Text = "";
            comboOcupacion.Enabled = false;
            comboDocumento.Enabled = false;
            txtDocumento.Enabled = false;
            bttnGuardar.Enabled = false;
            bttnActualizar.Enabled = true;
            bttnEliminar2.Enabled = true;
        }

        public void RegistroExterno(int x)
        {
            txtDocumento.Focus();
            label1.Visible = false;
            txtBuscar.Visible = false;
            bttnBuscar.Visible = false;

            comboOcupacion.SelectedIndex = x - 1;
            comboOcupacion.Enabled = false;
        }
    }
}
