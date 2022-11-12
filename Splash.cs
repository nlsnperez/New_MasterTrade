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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int punto_de_inicio = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            punto_de_inicio += 2;
            Progreso.Value = punto_de_inicio;
            if (Progreso.Value == 100)
            {
                Progreso.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }          

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
