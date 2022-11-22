using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
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
    public partial class Marcas : UserControl
    {
        CRUD_CAMAMO crud = new CRUD_CAMAMO();
        public Marcas()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            TablaMarcas_Refresh();
            ConfigControles("INICIO");
        }

        public void ConfigControles(string x)
        {
            switch (x)
            {
                case "INICIO":
                    bttnNuevo.Enabled = true;
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = false;
                    txtID.Text = "";
                    txtNombre.Text = "";
                    break;
                case "NUEVO":
                    bttnNuevo.Enabled = false;
                    bttnGuardar.Enabled = true;
                    bttnActualizar.Enabled = false;
                    txtID.Text = crud.NuevoId_Marca().ToString();
                    txtNombre.Text = "";
                    break;
                case "ACTUALIZAR":
                    bttnNuevo.Enabled = true;
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    break;
            }
        }

        public void TablaMarcas_Refresh()
        {
            try
            {
                tablaMarcas.DataSource = crud.TablaMarca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            this.Dispose();
        }

        private void tablaMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3 && Convert.ToBoolean(tablaMarcas.Rows[e.RowIndex].Cells["ACTIVO"].Value) == true)
                {
                    if (MessageBox.Show("Desea eliminar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Eliminar(e, 0);
                    }
                }
                else
                {
                    if ((e.ColumnIndex == 3 && Convert.ToBoolean(tablaMarcas.Rows[e.RowIndex].Cells["ACTIVO"].Value) == false))
                    {
                        if (MessageBox.Show("Desea restaurar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Eliminar(e, 1);
                        }
                    }
                    else
                    {
                        try
                        {
                            ConfigControles("ACTUALIZAR");
                            txtID.Text = tablaMarcas.Rows[e.RowIndex].Cells["ID"].Value.ToString(); ;
                            txtNombre.Text = tablaMarcas.Rows[e.RowIndex].Cells["MARCA"].Value.ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        public void Eliminar(DataGridViewCellEventArgs e, int x)
        {
            try
            {
                int id = Convert.ToInt32(tablaMarcas.Rows[e.RowIndex].Cells["ID"].Value);
                crud.Delete_Marca(id, x);
                TablaMarcas_Refresh();
                ConfigControles("INICIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea actualizar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    string marca = txtNombre.Text;
                    crud.Update_Marca(id, marca);
                    TablaMarcas_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            tablaMarcas.ClearSelection();
            ConfigControles("NUEVO");
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Desea registrar esta marca?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string marca = txtNombre.Text;
                    crud.Create_Marca(marca);
                    TablaMarcas_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void tablaMarcas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaMarcas.Columns[e.ColumnIndex].Name == "ACTIVO")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    if (UserData.Nivel == 1)
                    {
                        tablaMarcas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        tablaMarcas.Rows[e.RowIndex].Cells["DELETE"].Value = Properties.Resources.restore;
                    }
                    else
                    {
                        tablaMarcas.Rows[e.RowIndex].Visible = false;
                    }
                }
            }
        }
    }
}
