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
    public partial class Usuarios : UserControl
    {
        CRUDUsuarios crud;
        public Usuarios()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUDUsuarios();
            tablaUsuarios.AutoGenerateColumns = false;
            tablaUsuarios.DataSource = crud.GetTable();
            Controles("OFF");
            ConfigCombos();
        }

        public void Controles(string modo)
        {
            switch (modo)
            {
                case "ON":
                    txtID.Text = "0";
                    comboDocumento.Enabled = true;
                    txtDocumento.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtContrasegna.Enabled = true;
                    comboNivel.Enabled = true;
                    bttnGuardar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    bttnNuevo.Enabled = false;
                    break;
                case "OFF":
                    txtID.Enabled = false;
                    comboDocumento.Enabled = false;
                    txtDocumento.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtContrasegna.Enabled = false;
                    comboNivel.Enabled = false;
                    bttnGuardar.Enabled = false;
                    bttnCancelar.Enabled = false;
                    bttnNuevo.Enabled = true;
                    break;
            }
        }

        public void Clear()
        {
            txtID.Text = "";
            comboDocumento.SelectedIndex = 0;
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtContrasegna.Text = "";
            comboNivel.SelectedIndex = 1;
            bttnGuardar.Text = "GUARDAR";
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
            comboNivel.SelectedIndex = 1;
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            Controles("ON");
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
            Controles("OFF");
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

        private Usuario GetUsuario() 
        {
            Usuario user = new Usuario(Int32.Parse(txtID.Text),
                                        txtUsuario.Text,
                                        txtContrasegna.Text,
                                        comboDocumento.SelectedItem.ToString()+txtDocumento.Text,
                                        txtNombre.Text,
                                        txtApellido.Text,
                                        comboNivel.SelectedItem.ToString());
            return user;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            switch (bttnGuardar.Text)
            {
                case "GUARDAR":
                    if (MessageBox.Show("¿Desea registrar el usuario " + txtUsuario.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        crud.Create(GetUsuario());
                        Clear();
                        Controles("OFF");
                        tablaUsuarios.DataSource = crud.GetTable();
                    }
                    break;
                case "ACTUALIZAR":
                    if (MessageBox.Show("¿Desea actualizar los datos del usuario " + txtUsuario.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        crud.Update(GetUsuario());
                        Clear();
                        Controles("OFF");
                        tablaUsuarios.DataSource = crud.GetTable();
                    }
                    break;
            }
        }

        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controles("ON");
            txtID.Text = tablaUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = tablaUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContrasegna.Text = tablaUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNombre.Text = tablaUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtApellido.Text = tablaUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (tablaUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString() == "ADMINISTRADOR")
            {
                comboNivel.SelectedIndex = 0;
            }
            else
            {
                comboNivel.SelectedIndex = 1;
            }
            bttnGuardar.Text = "ACTUALIZAR";            
        }
    }
}
