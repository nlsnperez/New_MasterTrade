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
                crud.RecuperarContrasegna(txtParametro.Text);
                this.ParentForm.Close();
            }
        }
    }
}
