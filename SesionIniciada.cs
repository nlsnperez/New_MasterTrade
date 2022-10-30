﻿using New_MasterTrade.Cache;
using System;
using System.Windows.Forms;

namespace New_MasterTrade
{
    public partial class SesionIniciada : Form
    {
        private bool IsCollapsed;
        private bool IsCollapsed2;
        public SesionIniciada()
        {
            InitializeComponent();
            panelDropDown.Size = panelDropDown.MinimumSize;
            panelDropDown2.Size = panelDropDown2.MinimumSize;
            UserData.Nombre = "Nelson";
            lblUsuario.Text = UserData.Nombre;
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

        private void bttnProductos_Click(object sender, EventArgs e)
        {
            formProductos.BringToFront();
        }

        private void bttnVender_Click(object sender, EventArgs e)
        {
            
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
            //FormComprar.ClearData("RESET");
            //FormComprar.Config();
            FormComprar.ConfigControles("OFF");
            FormComprar.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bttnCategorias_Click(object sender, EventArgs e)
        {
            //formCategorias.Clear();
            //formCategorias.Config();
            //formCategorias.BringToFront();
        }        

        private void bttnAjustes_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void bttnPersonas_Click(object sender, EventArgs e)
        {
            FormPersonas.BringToFront();
        }
    }
}
