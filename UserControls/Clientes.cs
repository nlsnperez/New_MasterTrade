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
        CRUD_Usuarios crud = new CRUD_Usuarios();

        public Clientes()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            tablaPersonas.AutoGenerateColumns = false;
            tablaPersonas.DataSource = null;
            CargarTabla();
            CargarCombos();

        }

        public void CargarCombos()
        {
            try
            {
                comboNivel.ValueMember = "id_niv";
                comboNivel.DisplayMember = "des_niv";
                comboNivel.DataSource = crud.Nivel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Detalles")
            {
                int id = Convert.ToInt32(tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value);
                Persona usuario = crud.Usuario(id);
                FormularioPersonas y = new FormularioPersonas(0);
                y.DatosPersona(usuario);

                SesionIniciada.Instancia.MostrarUserControl(y);
            }
            else
            {
                if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (Convert.ToBoolean(tablaPersonas.Rows[e.RowIndex].Cells["Activo"].Value) == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int id = (int)tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value;
                            crud.Delete(id, 0);
                            CargarTabla();
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(tablaPersonas.Rows[e.RowIndex].Cells["Activo"].Value) == false)
                        {
                            if (MessageBox.Show("¿Desea restaurar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                int id = (int)tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value;
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
            try
            {
                tablaPersonas.DataSource = crud.Usuarios();
                txtBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTabla((int)comboNivel.SelectedValue, txtBuscar.Text);
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarUserControl(new FormularioPersonas((int)comboNivel.SelectedValue));
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

        private void tablaPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
