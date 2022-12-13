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

namespace New_MasterTrade.Forms
{
    public partial class Credenciales : Form
    {
        CRUD_Usuarios crud = new CRUD_Usuarios();
        public Persona Usuario{ get; set; }
        private bool NuevoRegistro;

        public Credenciales(Persona usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            txtId.Text = Usuario.Id.ToString();
            bttnActualizar.Enabled = false;
            bttnSalir.Visible = false;
            txtContrasegna.PasswordChar = '●';
            txtConfirmarContrasegna.PasswordChar = '●';
        }

        public void AcomodarDatos(Credencial datos)
        {
            txtId.Text = datos.Id.ToString();
            txtNombreUsuario.Text = datos.NombreUsuario;
            txtContrasegna.Text = datos.Contrasegna;
            txtConfirmarContrasegna.Text = datos.Contrasegna;
            label5.Visible = false;
            txtConfirmarContrasegna.Visible = false;
            bttnGuardar.Enabled = false;
            bttnActualizar.Enabled = true;
            if (UserData.Id != Usuario.Id && Usuario.Nivel == 1)
            {
                bttnActualizar.Enabled = false;
                txtContrasegna.Enabled = false;
                txtNombreUsuario.Enabled = false;
                chckMostrar.Enabled = false;
            }
            bttnSalir.Visible = true;
        }

        public void ReiniciarCampos()
        {
            txtId.Text = "";
            txtNombreUsuario.Text = "";
            txtContrasegna.Text = "";
            txtConfirmarContrasegna.Text = "";

            txtConfirmarContrasegna.Visible = true;
            bttnGuardar.Enabled = true;
            bttnActualizar.Enabled = false;
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "" || txtContrasegna.Text == "" || txtConfirmarContrasegna.Text == "")
            {
                MessageBox.Show("¡Complete todos los campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtContrasegna.Text != txtConfirmarContrasegna.Text)
                {
                    MessageBox.Show("Las contraseñas introducidas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (crud.UserNameDuplicado(txtNombreUsuario.Text))
                    {
                        MessageBox.Show("Ya existe un usuario registrado con ese nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea asignar estas credenciales al usuario " + Usuario.RazonSocial + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            crud.AsingarCredenciales(Usuario.Id, txtNombreUsuario.Text, txtContrasegna.Text);
                            MessageBox.Show("¡Las credenciales fueron asignadas con éxito!", "CREDENCIALES ASIGNADAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "" || txtContrasegna.Text == "" || txtConfirmarContrasegna.Text == "")
            {
                MessageBox.Show("¡Complete todos los campos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (crud.UserNameDuplicado(txtNombreUsuario.Text))
                {
                    MessageBox.Show("Ya existe un usuario registrado con ese nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("¿Desea actualizar las credenciales de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        crud.ActualizarCredenciales(Usuario.Id, txtNombreUsuario.Text, txtContrasegna.Text);
                        MessageBox.Show("¡Las credenciales fueron actualizadas con éxito!", "CREDENCIALES ASIGNADAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void chckMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chckMostrar.Checked == true)
            {
                txtContrasegna.PasswordChar = (char)0;
                txtConfirmarContrasegna.PasswordChar = (char)0;
                chckMostrar.Text = "Ocultar contraseña";
            }
            else
            {
                txtContrasegna.PasswordChar = '●';
                txtConfirmarContrasegna.PasswordChar = '●';
                chckMostrar.Text = "Mostrar contraseña";
            }
        }
    }
}
