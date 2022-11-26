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
    public partial class Impuestos : UserControl
    {
        CRUD_IMMOTA crud = new CRUD_IMMOTA();
        public Impuestos()
        {
            InitializeComponent();
            Config();
        }
        public void Config()
        {
            TablaImpuestos_Refresh();
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
                    txtID.Enabled = false;
                    txtPorcentaje.Enabled = false;
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtPorcentaje.Text = "";
                    break;
                case "NUEVO":
                    bttnNuevo.Enabled = false;
                    bttnGuardar.Enabled = true;
                    bttnActualizar.Enabled = false;
                    txtNombre.Enabled = true;
                    txtPorcentaje.Enabled = true;
                    txtID.Text = crud.NuevoId_Impuesto().ToString();
                    txtNombre.Text = "";
                    break;
                case "ACTUALIZAR":
                    bttnNuevo.Enabled = true;
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtPorcentaje.Enabled = true;
                    break;
            }
        }

        public void TablaImpuestos_Refresh()
        {
            try
            {
                tablaImpuestos.DataSource = crud.TablaImpuestos();
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

        private void tablaImpuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaImpuestos.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaImpuestos.Rows[e.RowIndex].Cells["ACTIVO"].Value) == true)
                {
                    if (MessageBox.Show("Desea eliminar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Eliminar(e, 0);
                    }
                }
                else
                {
                    if ((tablaImpuestos.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaImpuestos.Rows[e.RowIndex].Cells["ACTIVO"].Value) == false))
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
                            txtID.Text = tablaImpuestos.Rows[e.RowIndex].Cells["ID"].Value.ToString(); ;
                            txtNombre.Text = tablaImpuestos.Rows[e.RowIndex].Cells["IMPUESTO"].Value.ToString();
                            txtPorcentaje.Text = tablaImpuestos.Rows[e.RowIndex].Cells["PORCENTAJE"].Value.ToString();
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
                int id = Convert.ToInt32(tablaImpuestos.Rows[e.RowIndex].Cells["ID"].Value);
                crud.Delete_Impuesto(id, x);
                TablaImpuestos_Refresh();
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
                    string impuesto = txtNombre.Text;
                    decimal porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                    crud.Update_Impuesto(id, txtNombre.Text, porcentaje);
                    TablaImpuestos_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            tablaImpuestos.ClearSelection();
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
                if (MessageBox.Show("Desea registrar este impuesto?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal porcentaje = Convert.ToDecimal(txtPorcentaje.Text);
                    crud.Create_Impuesto(txtNombre.Text, porcentaje);
                    TablaImpuestos_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void tablaImpuestos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaImpuestos.Columns[e.ColumnIndex].Name == "ACTIVO")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    tablaImpuestos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    tablaImpuestos.Rows[e.RowIndex].Cells["DELETE"].Value = Properties.Resources.restore;
                }
            }
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
