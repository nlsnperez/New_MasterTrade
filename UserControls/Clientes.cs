using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Objetos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Clientes : UserControl
    {
        CRUD_Clientes crud = new CRUD_Clientes();

        public Clientes()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            tablaPersonas.AutoGenerateColumns = false;
            tablaPersonas.DataSource = null;
            txtBuscar.Enabled = false;
            CargarTabla();

        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Detalles")
            {
                int id = Convert.ToInt32(tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value);
                Persona cliente = crud.Cliente(id);
                Form x = new Form();
                FormularioPersonas y = new FormularioPersonas(0);

                y.DatosPersona(cliente, 0);
                x.Controls.Add(y);
                x.Size = new Size(y.Width + 30, y.Height + 40);
                x.StartPosition = FormStartPosition.CenterScreen;
                x.ShowDialog();
                CargarTabla();
            }
            else
            {
                if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (Convert.ToBoolean(tablaPersonas.Rows[e.RowIndex].Cells["Activo"].Value) == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar los datos de este cliente?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string documento = tablaPersonas.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                            crud.Delete(documento, 0);
                            CargarTabla();
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(tablaPersonas.Rows[e.RowIndex].Cells["Activo"].Value) == false)
                        {
                            if (MessageBox.Show("¿Desea restaurar los datos de este cliente?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string documento = tablaPersonas.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                                crud.Delete(documento, 1);
                                CargarTabla();
                            }
                        }
                    }
                    
                }
            }
        }

        private void CargarTabla()
        {
            if (crud.Tabla().Rows.Count > 0)
            {
                tablaPersonas.DataSource = crud.Tabla();
                txtBuscar.Enabled = true;
                txtBuscar.Focus();
            }
            else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTabla(txtBuscar.Text);
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Form x = new Form();
            FormularioPersonas y = new FormularioPersonas(0);
            x.Size = new Size(y.Width + 30, y.Height + 40);
            x.Controls.Add(y);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.ShowDialog();
            tablaPersonas.DataSource = crud.Tabla();
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Reporte_Cliente();
        }

        private void tablaPersonas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaPersonas.Columns[e.ColumnIndex].Name == "Activo")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    if (UserData.Nivel == 1)
                    {
                        tablaPersonas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        tablaPersonas.Rows[e.RowIndex].Cells["Eliminar"].Value = Properties.Resources.restore;
                    }
                    else
                    {
                        tablaPersonas.Rows[e.RowIndex].Visible = false;
                    }
                }
            }
        }
    }
}
