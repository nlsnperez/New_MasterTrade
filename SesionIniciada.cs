using New_MasterTrade.UserControls;
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
    public partial class SesionIniciada : Form
    {
        
        public SesionIniciada()
        {
            InitializeComponent();
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }        

        private void bttnPersonas_Click(object sender, EventArgs e)
        {
            FormPersonas.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProductos.Clear();
            FormProductos.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVender.Clear();
            FormVender.BringToFront();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login salir_al_login = new Login();
                this.Hide();
                salir_al_login.Show();
            }
        }

        private void bttnComprar_Click(object sender, EventArgs e)
        {
            FormComprar.BringToFront();
        }
    }
}
