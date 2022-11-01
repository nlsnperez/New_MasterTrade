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
            txtContrasegna.PasswordChar = '*';
            txtConfirmar.PasswordChar = '*';
            ConfigCombos();
            bttnActualizar.Enabled = false;
            bttnEliminar2.Enabled = false;
        }

        public void Limpiar()
        {
            comboDocumento.SelectedIndex = 0;
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContrasegna.Text = "";
            txtConfirmar.Text = "";
            comboNivel.SelectedIndex = 1;
            chckMostrar.Checked = false;
        }

        public void ConfigCombos()
        {
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");
            comboDocumento.SelectedIndex = 0;

            comboNivel.Items.Add("OPERADOR");
            comboNivel.Items.Add("ADMINISTRADOR");
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
                txtContrasegna.PasswordChar = '*';
                txtConfirmar.PasswordChar = '*';
                chckMostrar.Text = "Mostrar contraseña";
            }
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (GetUsuario().IsEmpty())
            {
                MessageBox.Show("Complete todo los campos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!GetUsuario().ValidDocumento())
                {
                    MessageBox.Show("Ingrese un número de documento válido", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtContrasegna.Text != txtConfirmar.Text)
                    {
                        MessageBox.Show("Las contraseñas introducidas no coinciden", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea registrar este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            crud.Crear(GetUsuario());
                            Limpiar();
                        }
                    }
                }
            }
        }

        private Usuario GetUsuario()
        {
            Usuario usuario = new Usuario(txtUsuario.Text,
                                          txtContrasegna.Text,
                                          comboDocumento.Text+txtDocumento.Text,
                                          txtNombre.Text,
                                          comboDocumento.SelectedIndex);
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

        public void SetDatos(string id)
        {
            DataTable resultado = crud.UsuarioDatos(id);

            user_id = (int)resultado.Rows[0][0];
            txtUsuario.Text = resultado.Rows[0][1].ToString();
            txtContrasegna.Text = resultado.Rows[0][2].ToString();
            comboDocumento.Text = resultado.Rows[0][3].ToString().Substring(0,1);
            txtDocumento.Text = resultado.Rows[0][3].ToString().Remove(0,1);
            txtNombre.Text = resultado.Rows[0][4].ToString();
            comboNivel.SelectedIndex = (int)resultado.Rows[0][5];

            comboDocumento.Enabled = false;
            txtDocumento.Enabled = false;
            txtConfirmar.Visible = false;
            label5.Visible = false;
            bttnGuardar.Enabled = false;
            bttnActualizar.Enabled = true;
            bttnEliminar2.Enabled = true;
            bttnCancelar.Enabled = false;
        }
    }
}
