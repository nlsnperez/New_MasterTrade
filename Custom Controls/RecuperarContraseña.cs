using New_MasterTrade.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Custom_Controls
{
    public partial class RecuperarContrasegna : UserControl
    {
        CRUD_Usuarios crud;
        public RecuperarContrasegna()
        {
            InitializeComponent();
            crud = new CRUD_Usuarios();
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            if (txtParametro.Text == "")
            {
                MessageBox.Show("Introduzca un nombre de usuario o correo electrónico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!crud.RecuperarContrasegna(txtParametro.Text))
                {
                    MessageBox.Show("No hay un usuario registrado con los datos suministrados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.ParentForm.Close();
                }                
            }
        }

        private void txtParametro_Enter(object sender, EventArgs e)
        {
            if (txtParametro.Text == "Usuario o correo electrónico")
            {
                txtParametro.ForeColor = Color.Black;
                txtParametro.Text = "";
            }
        }

        private void txtParametro_Leave(object sender, EventArgs e)
        {
            if (txtParametro.Text == "")
            {
                txtParametro.ForeColor = SystemColors.InactiveCaptionText;
                txtParametro.Text = "Usuario o correo electrónico";
            }
        }
    }
}
