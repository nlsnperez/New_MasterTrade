using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Mensajes
{
    public partial class ConfirmarForm : Form
    {
        public ConfirmarForm()
        {
            InitializeComponent();
        }

        public ConfirmarForm(string titulo, string mensaje)
        {
            labelMensaje.Text = mensaje;
            this.Text = titulo;
        }
    }
}
