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
            if (e.RowIndex >= 0 && tablaUsuarios.Columns[e.ColumnIndex].Name == "Detalles")
            {
                int id = (int)tablaUsuarios.Rows[e.RowIndex].Cells["Id"].Value;
                Usuario usuario = crud.Usuario(id);
                Form x = new Form();
                FormularioUsuarios y = new FormularioUsuarios();

                y.DatosUsuario(usuario);
                SesionIniciada.Instancia.MostrarUserControl(y);

                //x.Size = new Size(y.Width + 10, y.Height + 40);
                //x.Controls.Add(y);
                //x.StartPosition = FormStartPosition.CenterScreen;
                //x.ShowDialog();
                //CargarTabla();
            }
            else
            {
                if (e.ColumnIndex >= 0 && tablaUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (Convert.ToBoolean(tablaUsuarios.Rows[e.RowIndex].Cells["Activo"].Value) == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int id = (int)tablaUsuarios.Rows[e.RowIndex].Cells["Id"].Value;
                            crud.Delete(id, 0);
                            CargarTabla();
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(tablaUsuarios.Rows[e.RowIndex].Cells["Activo"].Value) == false)
                        {
                            if (MessageBox.Show("¿Desea restaurar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                int id = (int)tablaUsuarios.Rows[e.RowIndex].Cells["Id"].Value;
                                crud.Delete(id, 1);
                                CargarTabla();
                            }
                        }
                    }

                }
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
            SesionIniciada.Instancia.MostrarUserControl(new FormularioUsuarios());
            //Form x = new Form();
            //FormularioUsuarios y = new FormularioUsuarios();
            //x.Size = new Size(y.Width + 10, y.Height + 40);
            //x.Controls.Add(y);
            //x.StartPosition = FormStartPosition.CenterScreen;
            //x.ShowDialog();
            //CargarTabla();
        }

        private void tablaUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaUsuarios.Columns[e.ColumnIndex].Name == "Activo")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    tablaUsuarios.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    tablaUsuarios.Rows[e.RowIndex].Cells["Eliminar"].Value = Properties.Resources.restore;
                }
            }
        }
    }
}
