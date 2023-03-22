using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Objetos;
using New_MasterTrade.UserControls;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace New_MasterTrade
{
    public partial class Proveedores : UserControl
    {
        private CRUD_Proveedores crud;
        public Proveedores()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            crud = new CRUD_Proveedores();
            tablaPersonas.AutoGenerateColumns = false;
            tablaPersonas.DataSource = null;
            CargarTabla();
            
        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Detalles")
            {
                //int id = Convert.ToInt32(tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value);
                //Persona proveedor = crud.Proveedor(id);
                //Form x = new Form();
                //FormularioPersonas y = new FormularioPersonas(1);

                //y.DatosPersona(proveedor, 1);
                //SesionIniciada.Instancia.MostrarUserControl(y);

                //x.Controls.Add(y);
                //x.Size = new Size(y.Width + 30, y.Height + 40);                
                //x.StartPosition = FormStartPosition.CenterScreen;
                //x.ShowDialog();
                //CargarTabla();
            }
            else
            {
                if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (Convert.ToBoolean(tablaPersonas.Rows[e.RowIndex].Cells["Activo"].Value) == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar los datos de este proveedor?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                            if (MessageBox.Show("¿Desea restaurar los datos de este proveedor?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            try
            {
                tablaPersonas.DataSource = crud.Tabla();
                txtBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            tablaPersonas.DataSource = crud.BuscarTabla(txtBuscar.Text);
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarUserControl(new FormularioPersonas(1));
            //Form x = new Form();
            //FormularioPersonas y = new FormularioPersonas(1);
            //x.Size = new Size(y.Width + 30, y.Height + 40);
            //x.Controls.Add(y);
            //x.StartPosition = FormStartPosition.CenterScreen;
            //x.ShowDialog();
            //CargarTabla();
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
