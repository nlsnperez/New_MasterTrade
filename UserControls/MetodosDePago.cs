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
    public partial class MetodosDePago : UserControl
    {
        CRUD_CAMAMO crud = new CRUD_CAMAMO();
        public MetodosDePago()
        {
            InitializeComponent();
            Config();
        }
        public void Config()
        {
            TablaMetodoPago_Refresh();
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
                    txtID.Text = crud.NuevoId_MetodoPago().ToString();
                    txtNombre.Text = "";
                    break;
                case "ACTUALIZAR":
                    bttnNuevo.Enabled = true;
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    break;
            }
        }

        public void TablaMetodoPago_Refresh()
        {
            try
            {
                tablaMetodosPago.DataSource = crud.TablaMetodoPago();
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

        private void tablaMetodosPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaMetodosPago.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaMetodosPago.Rows[e.RowIndex].Cells["ACTIVO"].Value) == true)
                {
                    if (MessageBox.Show("Desea eliminar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Eliminar(e, 0);
                    }
                }
                else
                {
                    if ((tablaMetodosPago.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaMetodosPago.Rows[e.RowIndex].Cells["ACTIVO"].Value) == false))
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
                            txtID.Text = tablaMetodosPago.Rows[e.RowIndex].Cells["ID"].Value.ToString(); ;
                            txtNombre.Text = tablaMetodosPago.Rows[e.RowIndex].Cells["METODOPAGO"].Value.ToString();
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
                int id = Convert.ToInt32(tablaMetodosPago.Rows[e.RowIndex].Cells["ID"].Value);
                crud.Delete_MetodoPago(id, x);
                TablaMetodoPago_Refresh();
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
                    string metodopago = txtNombre.Text;
                    crud.Update_MetodoPago(id, metodopago);
                    TablaMetodoPago_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            tablaMetodosPago.ClearSelection();
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
                if (MessageBox.Show("Desea registrar este metodo de pago?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string metodopago = txtNombre.Text;
                    crud.Create_MetodoPago(metodopago);
                    TablaMetodoPago_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void tablaMetodosPago_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaMetodosPago.Columns[e.ColumnIndex].Name == "ACTIVO")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    if (UserData.Nivel == 1)
                    {
                        tablaMetodosPago.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        tablaMetodosPago.Rows[e.RowIndex].Cells["DELETE"].Value = Properties.Resources.restore;
                    }
                }
            }
        }
    }
}
