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
    public partial class Monedas : UserControl
    {
        CRUD_IMMOTA crud = new CRUD_IMMOTA();
        public Monedas()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            TablaMonedas_Refresh();
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
                    txtID.Text = crud.NuevoId_Moneda().ToString();
                    txtNombre.Text = "";
                    break;
                case "ACTUALIZAR":
                    bttnNuevo.Enabled = true;
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    break;
            }
        }

        public void TablaMonedas_Refresh()
        {
            try
            {
                tablaMonedas.DataSource = crud.TablaMoneda();
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

        private void tablaMonedas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaMonedas.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaMonedas.Rows[e.RowIndex].Cells["ACTIVO"].Value) == true)
                {
                    if (MessageBox.Show("Desea eliminar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Eliminar(e, 0);
                    }
                }
                else
                {
                    if ((tablaMonedas.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaMonedas.Rows[e.RowIndex].Cells["ACTIVO"].Value) == false))
                    {
                        if (MessageBox.Show("Desea restaurar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Eliminar(e, 1);
                        }
                    }
                    else
                    {
                        if (tablaMonedas.Columns[e.ColumnIndex].Name == "TASACAMBIO")
                        {
                            int id = (int)tablaMonedas.Rows[e.RowIndex].Cells["ID"].Value;
                            
                            Form x = new Form();
                            TasasDeCambio y = new TasasDeCambio(id);
                            x.Size = y.Size;
                            x.FormBorderStyle = FormBorderStyle.None;
                            x.StartPosition = FormStartPosition.CenterScreen;
                            x.Controls.Add(y);
                            x.ShowDialog();
                        }
                        else
                        {
                            try
                            {
                                ConfigControles("ACTUALIZAR");
                                txtID.Text = tablaMonedas.Rows[e.RowIndex].Cells["ID"].Value.ToString(); ;
                                txtNombre.Text = tablaMonedas.Rows[e.RowIndex].Cells["MONEDA"].Value.ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }                        
                    }
                }
            }
        }

        public void Eliminar(DataGridViewCellEventArgs e, int x)
        {
            try
            {
                int id = Convert.ToInt32(tablaMonedas.Rows[e.RowIndex].Cells["ID"].Value);
                crud.Delete_Moneda(id, x);
                TablaMonedas_Refresh();
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
                    string moneda = txtNombre.Text;
                    crud.Update_Moneda(id, moneda);
                    TablaMonedas_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            tablaMonedas.ClearSelection();
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
                if (MessageBox.Show("Desea registrar esta moneda?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string moneda = txtNombre.Text;
                    crud.Create_Moneda(moneda);
                    TablaMonedas_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void tablaMonedas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaMonedas.Columns[e.ColumnIndex].Name == "ACTIVO")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    if (UserData.Nivel == 1)
                    {
                        tablaMonedas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        tablaMonedas.Rows[e.RowIndex].Cells["DELETE"].Value = Properties.Resources.restore;
                    }
                    else
                    {
                        tablaMonedas.Rows[e.RowIndex].Visible = false;
                    }
                }
            }
        }
    }
}
