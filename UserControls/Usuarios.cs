using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
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
    public partial class Usuarios : UserControl
    {
        CRUD_Usuarios crud;
        public Usuarios()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUD_Usuarios();
            tablaUsuarios.AutoGenerateColumns = false;
            txtBuscar.Enabled = false;
            Controles("OFF");
            CargarTabla();
        }

        public void Controles(string modo)
        {
            switch (modo)
            {
                case "ON":
                    bttnGuardar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    bttnRegistrar.Enabled = false;
                    break;
                case "OFF":
                    bttnGuardar.Enabled = false;
                    bttnCancelar.Enabled = false;
                    bttnRegistrar.Enabled = true;
                    break;
            }
        }

        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Form x = new Form();
                FormularioUsuarios y = new FormularioUsuarios();
                y.SetDatos(tablaUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                x.Size = new Size(y.Width, y.Height);
                x.Controls.Add(y);
                x.StartPosition = FormStartPosition.CenterScreen;
                x.FormBorderStyle = FormBorderStyle.None;
                x.ShowDialog();
            }     
        }

        private void CargarTabla()
        {
            if (crud.Usuarios().Rows.Count > 0)
            {
                tablaUsuarios.DataSource = crud.Usuarios();
                txtBuscar.Enabled = true;
            }
            else MessageBox.Show("No se encontraron registros en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            tablaUsuarios.DataSource = crud.BuscarTabla(txtBuscar.Text);
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            FormularioUsuarios y = new FormularioUsuarios();
            x.Size = new Size(y.Width, y.Height);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.FormBorderStyle = FormBorderStyle.None;
            x.ShowDialog();
        }
    }
}
