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
        private bool IsCollapsed;
        public SesionIniciada()
        {
            InitializeComponent();
            panelDropDown.Size = panelDropDown.MinimumSize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    IsCollapsed = true;
                }
            }
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
            FormPersonas.Clear();
            FormPersonas.Config();
            FormPersonas.BringToFront();
        }

        private void bttnProductos_Click(object sender, EventArgs e)
        {
            FormProductos.Clear();
            FormProductos.Config();
            FormProductos.BringToFront();
        }

        private void bttnVender_Click(object sender, EventArgs e)
        {
            FormVender.ClearData("RESET");
            FormVender.Config();
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
            FormComprar.ClearData("RESET");
            FormComprar.Config();
            FormComprar.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bttnCategorias_Click(object sender, EventArgs e)
        {
            formCategorias.Clear();
            formCategorias.Config();
            formCategorias.BringToFront();
        }
    }
}
