using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Forms;
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
        CRUD_Usuarios crud = new CRUD_Usuarios();
        CRUD_Clientes crud2;
        CRUD_Bitacora bitacora = new CRUD_Bitacora();
        private bool registro_externo = false;
        public Persona Usuario { get; set; }

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
            comboNivel.Focus();
            ConfigLongitud();
            ConfigCombos(x);
            if (UserData.Nivel == 2)
            {
                comboNivel.SelectedIndex = 2;
                comboNivel.Enabled = false;
            }
            bttnCredenciales.Visible = false;
            comboNivel.Width = 639;
            bttnActualizar.Enabled = false;
        }

        public void ConfigCombos(int x)
        {
            try
            {
                comboNivel.ValueMember = "id_niv";
                comboNivel.DisplayMember = "des_niv";
                comboNivel.DataSource = crud.Nivel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            Persona persona = new Persona(0,
                                          (int)comboNivel.SelectedValue,
                                          comboDocumento.Text + txtDocumento.Text,
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
            if (UserData.Nivel == 2)
            {
                comboNivel.Enabled = false;
            }
            else
            {
                comboNivel.Enabled = true;
                comboNivel.SelectedIndex = 0;
            }
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
            Persona usuario = GetPersona();
            if (ProcesoDeAdmicion(usuario))
            {
                if (crud.DocumentoDuplicado(usuario.Documento))
                {
                    MessageBox.Show("Ya existe un usuario registrado con el documento de identidad introducido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (crud.CorreoDuplicado(usuario.Correo))
                    {
                        MessageBox.Show("Ya existe un usuario registrado con el correo electrónico introducido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea registrar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            crud.Create(usuario);
                            bitacora.Create(UserData.Id, Modulos.Clientes, Accion.RegistroActualizado(UserData.NombreUsuario, usuario.Documento));
                            if (registro_externo == true)
                            {
                                this.ParentForm.Close();
                            }
                            if (comboNivel.SelectedIndex < 2)
                            {
                                MessageBox.Show("Acaba de agregar un usuario con acceso al sistema por lo que debe agregar sus credenciales", "AGREGAR CREDENCIALES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Console.WriteLine(txtDocumento.Text);
                                Usuario = crud.Usuario(0, txtDocumento.Text);
                                SesionIniciada.Instancia.MostrarDialog(new Credenciales(Usuario));
                                Limpiar();
                            }
                            else
                            {
                                if (UserData.Nivel == 1)
                                {
                                    if (MessageBox.Show("Desea proseguir registrado una venta?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        Limpiar();
                                        SesionIniciada.Instancia.MostrarUserControl(new Vender());
                                    }
                                    else
                                    {
                                        Limpiar();
                                    }
                                }
                                else
                                {
                                    Limpiar();
                                }
                            }
                        }
                    }
                    
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
            Persona usuario = GetPersona();
            if (ProcesoDeAdmicion(GetPersona()))
            {
                if (MessageBox.Show("¿Desea actualizar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    crud.Update(usuario);
                    Limpiar();
                    bitacora.Create(UserData.Id, Modulos.Proveedores, Accion.RegistroActualizado(UserData.NombreUsuario, GetPersona().Documento));
                }
            }
        }

        public void DatosPersona(Persona persona)
        {
            try
            {
                Usuario = persona;               

                if (UserData.Nivel == 2)
                {
                    comboNivel.Enabled = false;
                    bttnCredenciales.Enabled = false;
                }
                else
                {
                    bttnCredenciales.Visible = true;
                    comboNivel.Width = 605;
                }
                if (persona.Nivel > 2)
                {
                    bttnCredenciales.Visible = false;
                    comboNivel.Width = 639;
                }

                comboNivel.SelectedIndex = persona.Nivel-1;
                if (UserData.Nivel != 1) comboNivel.Enabled = false;

                comboDocumento.Text = persona.Documento.Substring(0, 1);
                txtDocumento.Text = persona.Documento.Remove(0, 1);
                txtRazonSocial.Text = persona.RazonSocial;
                txtDireccion.Text = persona.Direccion;
                txtTelefono.Text = persona.Telefono;
                txtCorreo.Text = persona.Correo;

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
            comboNivel.SelectedIndex = 2;
            comboNivel.Width = 639;
            bttnCredenciales.Visible = false;
            comboNivel.Enabled = false;
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
            SesionIniciada.Instancia.MostrarUserControl(new Clientes());
        }

        private void bttnCredenciales_Click(object sender, EventArgs e)
        {
            Credenciales credenciales = new Credenciales(Usuario);
            credenciales.AcomodarDatos(crud.Credenciales(Usuario.Id));
            SesionIniciada.Instancia.MostrarDialog(credenciales);
        }
    }
}
