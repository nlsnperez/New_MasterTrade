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
        public Credenciales()
        {
            InitializeComponent();
            bttnActualizar.Enabled = false;
        }

        public void AcomodarDatos(Credencial datos)
        {
            txtId.Text = datos.Id.ToString();
            txtNombreUsuario.Text = datos.NombreUsuario;
            txtContrasegna.Text = datos.Contrasegna;
            txtConfirmarContrasegna.Visible = false;
            bttnGuardar.Enabled = false;
            bttnActualizar.Enabled = true;
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
    }
}
