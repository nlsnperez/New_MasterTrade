using New_MasterTrade.Cache;
using New_MasterTrade.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace New_MasterTrade
{
    public partial class SesionIniciada : Form
    {
        Panel p = new Panel();
        public SesionIniciada()
        {
            InitializeComponent();
        }

        private void SesionIniciada_Load(object sender, EventArgs e)
        {
            bttnPersonas_Click(null, e);
        }

        private void bttnMouseEnter(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            panelMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(255, 212, 100);
            p.Size = new Size(160, 5);
            p.Location = new Point(bttn.Location.X, bttn.Location.Y + 38);
        }

        private void MostrarUserControl(object pantalla)
        {
            if (panelContenedor.Controls.Count > 0) panelContenedor.Controls.Clear();
            UserControl control = pantalla as UserControl;
            control.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(control);
            this.panelContenedor.Tag = control;
            control.Show();
        }

        private void bttnMouseLeave(object sender, EventArgs e)
        {
            panelMenu.Controls.Remove(p);
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login salir_al_login = new Login();
                this.Hide();
                this.Dispose();
                salir_al_login.Show();
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
            MostrarUserControl(new Productos());
        }

        private void bttnComprar_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Comprar());
        }

        private void bttnPersonas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Personas());
        }

        private void bttnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Usuarios());
        }

        private void bttnArchivo_Click(object sender, EventArgs e)
        {
            if (panelArchivo.Visible == false)
            {
                panelArchivo.Visible = true;
                bttnArchivo.Image = Properties.Resources.FlechaArriba;
                panelArchivo.Focus();
            }
            else
            {
                panelArchivo.Visible = false;
                bttnArchivo.Image = Properties.Resources.FlechaAbajo;
            }
        }

        private void bttnTransacciones_Click(object sender, EventArgs e)
        {
            if (panelTransacciones.Visible == false)
            {
                panelTransacciones.Visible = true;
                bttnTransacciones.Image = Properties.Resources.FlechaArriba;
            }
            else
            {
                panelTransacciones.Visible = false;
                bttnTransacciones.Image = Properties.Resources.FlechaAbajo;
            }
        }

        private void bttnMantenimiento_Click(object sender, EventArgs e)
        {
            if (panelMantenimiento.Visible == false)
            {
                panelMantenimiento.Visible = true;
                bttnMantenimiento.Image = Properties.Resources.FlechaArriba;
            }
            else
            {
                panelMantenimiento.Visible = false;
                bttnMantenimiento.Image = Properties.Resources.FlechaAbajo;
            }
        }
    }
}
