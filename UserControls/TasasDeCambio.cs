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
    public partial class TasasDeCambio : UserControl
    {
        CRUD_IMMOTA crud = new CRUD_IMMOTA();
        int Id_Moneda = 0;
        public TasasDeCambio( int id)
        {
            InitializeComponent();
            Id_Moneda = id;
            labelTitulo.Text = "TASAS DE CAMBIO: "+crud.NombreMoneda(Id_Moneda);
            Config();
        }

        public void Config()
        {
            tablaTasasCambio.AutoGenerateColumns = false;
            TablaTasasCambio_Refresh();
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
                    txtID.Text = crud.NuevoId_TasaCambio().ToString();
                    txtNombre.Text = "";
                    break;
                case "ACTUALIZAR":
                    bttnNuevo.Enabled = true;
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    break;
            }
        }

        public void TablaTasasCambio_Refresh()
        {
            try
            {
                tablaTasasCambio.DataSource = crud.TablaTasaCambio(Id_Moneda);
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

        private void tablaTasasCambio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tablaTasasCambio.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaTasasCambio.Rows[e.RowIndex].Cells["ACTIVO"].Value) == true)
                {
                    if (MessageBox.Show("Desea eliminar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Eliminar(e, 0);
                    }
                }
                else
                {
                    if ((tablaTasasCambio.Columns[e.ColumnIndex].Name == "DELETE" && Convert.ToBoolean(tablaTasasCambio.Rows[e.RowIndex].Cells["ACTIVO"].Value) == false))
                    {
                        if (MessageBox.Show("Desea restaurar los datos de este registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Eliminar(e, 1);
                        }
                    }
                    else
                    {
                        if (tablaTasasCambio.Columns[e.ColumnIndex].Name == "TASACAMBIO")
                        {

                        }
                        else
                        {
                            try
                            {
                                ConfigControles("ACTUALIZAR");
                                txtID.Text = tablaTasasCambio.Rows[e.RowIndex].Cells["ID"].Value.ToString(); ;
                                txtNombre.Text = tablaTasasCambio.Rows[e.RowIndex].Cells["TASACAMBIO"].Value.ToString();
                                txtValor.Text = tablaTasasCambio.Rows[e.RowIndex].Cells["VALOR"].Value.ToString();
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
                int id = Convert.ToInt32(tablaTasasCambio.Rows[e.RowIndex].Cells["ID"].Value);
                crud.Delete_TasaCambio(id, x);
                TablaTasasCambio_Refresh();
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
                    string tasa_cambio = txtNombre.Text;
                    decimal valor = Convert.ToDecimal(txtValor.Text);
                    crud.Update_TasaCambio(id, tasa_cambio, valor);
                    TablaTasasCambio_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            tablaTasasCambio.ClearSelection();
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
                if (MessageBox.Show("Desea registrar esta tasa de cambio?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tasa_cambio = txtNombre.Text;
                    decimal valor = Convert.ToDecimal(txtValor.Text);
                    crud.Create_TasaCambio(Id_Moneda, tasa_cambio, valor);
                    TablaTasasCambio_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void tablaTasasCambio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaTasasCambio.Columns[e.ColumnIndex].Name == "ACTIVO")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    if (UserData.Nivel == 1)
                    {
                        tablaTasasCambio.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        tablaTasasCambio.Rows[e.RowIndex].Cells["DELETE"].Value = Properties.Resources.restore;
                    }
                    else
                    {
                        tablaTasasCambio.Rows[e.RowIndex].Visible = false;
                    }
                }
            }
        }
    }
}
