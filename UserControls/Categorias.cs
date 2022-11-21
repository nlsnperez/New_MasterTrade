using New_MasterTrade.Base_de_Datos;
using System;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Categorias : UserControl
    {
        CRUD_CAMAMO crud = new CRUD_CAMAMO();
        public Categorias()
        {
            InitializeComponent();
            tablaCategorias.AutoGenerateColumns = false;
            Config();
        }

        public void Config()
        {
          TablaCategorias_Refresh();
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
                    txtID.Text = crud.NuevoId_Categoria().ToString();
                    txtNombre.Text = "";
                    break;
                case "ACTUALIZAR":
                    bttnNuevo.Enabled = true;
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    break;
            }
        }

        public void TablaCategorias_Refresh()
        {
            try
            {
                tablaCategorias.DataSource = crud.TablaCategoria();
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

        private void tablaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    ConfigControles("ACTUALIZAR");
                    txtID.Text = tablaCategorias.Rows[e.RowIndex].Cells["ID"].Value.ToString(); ;
                    txtNombre.Text = tablaCategorias.Rows[e.RowIndex].Cells["CATEGORIA"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    string categoria = txtNombre.Text;
                    crud.Update(id, categoria);
                    TablaCategorias_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
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
                if (MessageBox.Show("Desea registrar esta nueva categoría?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string categoria = txtNombre.Text;
                    crud.Create(categoria);
                    TablaCategorias_Refresh();
                    ConfigControles("INICIO");
                }
            }
        }
    }
}
