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
        private bool registro_externo = false;

        public FormularioPersonas(int x)
        {
            InitializeComponent();
            Config(x);
        }

        public void Config(int x)
        {
            if (x == 0)
            {
                lblTitulo.Text = "REGISTRAR CLIENTE";
            }
            else
            {
                lblTitulo.Text = "REGISTRAR PROVEEDOR";
            }

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
            txtRazonSocial.MaxLength = 50;
            txtDireccion.MaxLength = 100;
            txtTelefono.MaxLength = 12;
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
            comboDocumento.Enabled = true;
            txtDocumento.Enabled = true;
            bttnGuardar.Enabled = true;
            bttnActualizar.Enabled = false;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (ProcesoDeAdmicion(GetPersona()))
            {
                switch (comboOcupacion.Text)
                {
                    case "CLIENTE":
                        if (crud2.ClienteDuplicado(GetPersona()))
                        {
                            MessageBox.Show("Ya existe un cliente registrado con el documento de identidad introducido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (MessageBox.Show("¿Desea registrar los datos de este cliente?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                crud2.Create(GetPersona());
                                bitacora.Create(UserData.Id, Modulos.Clientes, Accion.RegistroActualizado(UserData.NombreUsuario, GetPersona().Documento));
                                if (registro_externo == true)
                                {
                                    this.ParentForm.Close();
                                }
                                else
                                {
                                    Limpiar();
                                }
                            }
                        }
                        break;
                    case "PROVEEDOR":
                        if (crud.ProveedorDuplicado(GetPersona()))
                        {
                            MessageBox.Show("Ya existe un proveedor registrado con el documento de identidad introducido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (MessageBox.Show("¿Desea registrar los datos de este proveedor?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                crud.Create(GetPersona());
                                bitacora.Create(UserData.Id, Modulos.Proveedores, Accion.RegistroActualizado(UserData.NombreUsuario, GetPersona().Documento));
                                if (registro_externo == true)
                                {
                                    this.ParentForm.Close();
                                }
                                else
                                {
                                    Limpiar();
                                }
                            }
                        }
                        break;
                }
            }
        }

        public bool ProcesoDeAdmicion(Persona persona)
        {
            if (persona.IsEmpty())
            {
                MessageBox.Show("Complete todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!persona.ValidDocumento())
            {
                MessageBox.Show("El documento introducido es inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!persona.ValidPhone())
            {
                MessageBox.Show("El número de teléfono introducido es inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!persona.ValidEmail())
            {
                MessageBox.Show("El correo electrónico introducido es inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (ProcesoDeAdmicion(GetPersona()))
            {
                switch (comboOcupacion.Text)
                {
                    case "CLIENTE":
                        if (MessageBox.Show("¿Desea actualizar los datos de este cliente?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            crud2.Update(GetPersona());
                            Limpiar();
                            bitacora.Create(UserData.Id, Modulos.Clientes, Accion.RegistroActualizado(UserData.NombreUsuario, GetPersona().Documento));
                        }
                        break;
                    case "PROVEEDOR":
                        if (MessageBox.Show("¿Desea actualizar los datos de este proveedor?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            crud.Update(GetPersona());
                            Limpiar();
                            bitacora.Create(UserData.Id, Modulos.Proveedores, Accion.RegistroActualizado(UserData.NombreUsuario, GetPersona().Documento));
                        }
                        break;
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

        public void RegistroExterno(int x, string documento)
        {
            bttnAtrás.Visible = false;
            registro_externo = true;
            txtDocumento.Text = documento;
            txtDocumento.Enabled = false;
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

        private void bttnAtrás_Click(object sender, EventArgs e)
        {
            if (comboOcupacion.SelectedIndex == 0)
            {
                SesionIniciada.Instancia.MostrarUserControl(new Clientes());
            }
            else
            {
                SesionIniciada.Instancia.MostrarUserControl(new Proveedores());
            }
        }
    }
}
