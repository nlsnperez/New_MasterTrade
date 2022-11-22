using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
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
        CRUD_Proveedores crud;
        CRUD_Clientes crud2;
        CRUD_Bitacora bitacora = new CRUD_Bitacora();

        public FormularioPersonas(int x)
        {
            InitializeComponent();
            Config(x);
        }

        public void Config(int x)
        {
            crud = new CRUD_Proveedores();
            crud2 = new CRUD_Clientes();
            comboOcupacion.Focus();
            ConfigLongitud();
            ConfigCombos(x);
            bttnActualizar.Enabled = false;
        }

        public void ConfigCombos(int x)
        {
            comboOcupacion.Items.Add("CLIENTE");
            comboOcupacion.Items.Add("PROVEEDOR");
            comboOcupacion.SelectedIndex = x;
            comboOcupacion.Enabled = false;
            
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
            Persona persona = new Persona(comboDocumento.Text + txtDocumento.Text,
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
            comboDocumento.SelectedIndex = 0;
            comboOcupacion.SelectedIndex = 0;
            comboOcupacion.Enabled = true;
            comboDocumento.Enabled = true;
            txtDocumento.Enabled = true;
            bttnGuardar.Enabled = true;
            bttnActualizar.Enabled = false;
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
                                    bitacora.Create(UserData.Id, Modulos.Clientes, Accion.NuevoRegistro(UserData.NombreUsuario, GetPersona().Documento));
                                    Limpiar();
                                }
                                else
                                {
                                    crud.Create(GetPersona());
                                    bitacora.Create(UserData.Id, Modulos.Proveedores, Accion.NuevoRegistro(UserData.NombreUsuario, GetPersona().Documento));
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
                if (comboOcupacion.SelectedIndex == 0)
                {
                    crud2.Update(GetPersona());
                    bitacora.Create(UserData.Id, Modulos.Clientes, Accion.RegistroActualizado(UserData.NombreUsuario, GetPersona().Documento));
                }
                else
                {
                    crud.Update(GetPersona());
                    bitacora.Create(UserData.Id, Modulos.Proveedores, Accion.RegistroActualizado(UserData.NombreUsuario, GetPersona().Documento));
                }
            }            
        }

        public void DatosPersona(Persona persona, int x)
        {
            try
            {
                comboOcupacion.SelectedIndex = x;

                comboDocumento.Text = persona.Documento.Substring(0, 1);
                txtDocumento.Text = persona.Documento.Remove(0, 1);
                txtRazonSocial.Text = persona.RazonSocial;
                txtDireccion.Text = persona.Direccion;
                txtTelefono.Text = persona.Telefono;
                txtCorreo.Text = persona.Correo;

                comboOcupacion.Enabled = false;
                comboDocumento.Enabled = false;
                txtDocumento.Enabled = false;
                bttnGuardar.Enabled = false;
                bttnActualizar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RegistroExterno(int x)
        {
            txtDocumento.Focus();

            comboOcupacion.SelectedIndex = x - 1;
            comboOcupacion.Enabled = false;
        }

        private void txtDocumento_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.FromArgb(255, 212, 100);
            textBox.ForeColor = Color.Black;
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = SystemColors.Window;
            textBox.ForeColor = SystemColors.WindowText;
        }
    }
}
