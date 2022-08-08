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
        public Login()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SesionIniciada sesion_iniciada = new SesionIniciada();
            this.Hide();
            sesion_iniciada.Show();
        }
    }
}
