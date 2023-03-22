using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade
{
    public partial class Login : Form
    {
        CRUD_Usuarios crud;
        public Login()
        {
            InitializeComponent();
            crud = new CRUD_Usuarios();
            txtPassword.PasswordChar = '●';
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (crud.CanLogin(txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show("Bienvenido "+UserData.Nombre, "¡BIENVENIDO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SesionIniciada sesion_iniciada = new SesionIniciada();
                this.Hide();
                sesion_iniciada.Show();
            }
            else
            {
                MessageBox.Show("No existe un usuario registrado con los datos introducidos.", "USUARIO NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form x = new Form();
            RecuperarContrasegna y = new RecuperarContrasegna();
            x.Controls.Add(y);
            x.Size = y.Size;
            x.FormBorderStyle = FormBorderStyle.None;
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = (char)0;
                checkBox1.Text = "Ocultar contraseña";
            }
            else
            {
                txtPassword.PasswordChar = '●';
                checkBox1.Text = "Mostrar contraseña";
            }
        }
    }
}
