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
    public partial class FormularioUsuarios : UserControl
    {
        CRUD_Usuarios crud;
        int user_id = 0;

        public FormularioUsuarios()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUD_Usuarios();
            user_id = crud.GetId();
            txtContrasegna.PasswordChar = '●';
            txtConfirmar.PasswordChar = '●';
            ConfigCombos();
            bttnActualizar.Enabled = false;
        }

        public void Limpiar()
        {
            comboDocumento.SelectedIndex = 0;
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContrasegna.Text = "";
            txtConfirmar.Text = "";
            txtCorreo.Text = "";
            comboNivel.SelectedIndex = 0;
            chckMostrar.Checked = false;
        }

        public void ConfigCombos()
        {
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");
            comboDocumento.SelectedIndex = 0;

            comboNivel.Items.Add("ADMINISTRADOR");
            comboNivel.Items.Add("OPERADOR");
            comboNivel.SelectedIndex = 0;
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

        private void chckMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chckMostrar.Checked == true)
            {
                txtContrasegna.PasswordChar = (char)0;
                txtConfirmar.PasswordChar = (char)0;
                chckMostrar.Text = "Ocultar contraseña";
            }
            else
            {
                txtContrasegna.PasswordChar = '●';
                txtConfirmar.PasswordChar = '●';
                chckMostrar.Text = "Mostrar contraseña";
            }
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (ProcesoDeAdmicion(GetUsuario()))
            {
                if (NoRegistrosDuplicados(GetUsuario()))
                {
                    if (MessageBox.Show("¿Desea registrar este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //crud.Create(GetUsuario());
                        if (chckVendedor.Checked || comboNivel.SelectedIndex == 0)
                        {
                            crud.CrearVendedor(user_id);
                        }
                        Limpiar();
                    }
                }
            }
        }

        public bool ProcesoDeAdmicion(Usuario usuario)
        {
            if (usuario.IsEmpty())
            {
                MessageBox.Show("Complete todo los campos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!usuario.ValidDocumento())
            {
                MessageBox.Show("Ingrese un documento de identidad válido", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!usuario.ValidEmail())
            {
                MessageBox.Show("Ingrese un correo electrónico válido", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool NoRegistrosDuplicados(Usuario usuario)
        {
            if (crud.CorreoDuplicado(usuario.Correo))
            {
                MessageBox.Show("Ya existe un usuario registrado con el correo electrónico ingresado", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (crud.DocumentoDuplicado(usuario.Documento))
            {
                MessageBox.Show("Ya existe un usuario registrado con documento de identidad ingresado", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (crud.UserNameDuplicado(usuario.UserName))
            {
                MessageBox.Show("Ya existe un usuario registrado con el nombre de usuario ingresado", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private Usuario GetUsuario()
        {
            Usuario usuario = new Usuario(0,
                                          txtUsuario.Text,
                                          txtContrasegna.Text,
                                          txtCorreo.Text,
                                          comboDocumento.Text+txtDocumento.Text,
                                          txtNombre.Text,
                                          Nivel(comboNivel.SelectedIndex));
            return usuario;
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        public void DatosUsuario(Usuario usuario)
        {
            user_id = usuario.ID;
            if (crud.IsVendedor(user_id)) chckVendedor.Visible = false;
            txtNombre.Text = usuario.Nombre;
            txtUsuario.Text = usuario.UserName;
            txtContrasegna.Text = usuario.Contrasegna;
            comboDocumento.Text = usuario.Documento.Substring(0,1);
            txtDocumento.Text = usuario.Documento.Remove(0,1);
            txtCorreo.Text = usuario.Correo;

            if (usuario.Nivel == 1)
            {
                if (UserData.NombreUsuario != txtUsuario.Text)
                {
                    txtContrasegna.Enabled = false;
                    chckMostrar.Visible = false;
                }
                comboNivel.SelectedIndex = 0;
            }
            else
            {
                comboNivel.SelectedIndex = 1;
            }

            comboDocumento.Enabled = false;
            txtDocumento.Enabled = false;
            txtConfirmar.Visible = false;
            label5.Visible = false;
            bttnGuardar.Enabled = false;
            bttnActualizar.Enabled = true;
            bttnCancelar.Enabled = false;
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //crud.Update(GetUsuario());
                if (chckVendedor.Checked || comboNivel.SelectedIndex == 0)
                {
                    if (!crud.VendedorRegistrado(user_id))
                    {
                        crud.CrearVendedor(user_id);
                    }
                }
            }
        }

        private int Nivel(int x)
        {
            if (x == 0) return 1;
            else return 2;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.FromArgb(255, 212, 100);
            textBox.ForeColor = Color.Black;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = SystemColors.Window;
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void comboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNivel.SelectedIndex == 0)
            {
                chckVendedor.Visible = false;
            }
            else
            {
                chckVendedor.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bttnAtrás_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarUserControl(new Usuarios());
        }
    }
}
