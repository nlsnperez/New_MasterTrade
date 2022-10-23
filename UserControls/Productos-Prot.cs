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
    public partial class Productos_Prot : UserControl
    {
        public Productos_Prot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Productos_Prot_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                string imagen = openImage.FileName;
                pbImagen.Image = Image.FromFile(imagen);
            }            
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (pbImagen.Image != null)
            {
                pbImagen.Image = null;
            }            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
