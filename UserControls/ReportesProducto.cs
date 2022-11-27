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
    public partial class ReportesProducto : UserControl
    {
        CRUD_Productos crud = new CRUD_Productos();
        Reporte reporte = new Reporte();
        int estado = 0;
        string filtro = "";

        public ReportesProducto()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            ConfigComboBoxes();
        }

        public void ConfigComboBoxes()
        {
            comboProductos.Items.Add("TODOS");
            comboProductos.Items.Add("ACTIVOS");
            comboProductos.Items.Add("DESACTIVOS");
            comboProductos.Items.Add("PRODUCTO MÁS VENDIDO");
            comboProductos.SelectedIndex = 0;

            comboGrupo.Items.Add("TODO");
            comboGrupo.Items.Add("CATEGORIA");
            comboGrupo.Items.Add("MARCA");
            comboGrupo.Items.Add("MODELO");
            comboGrupo.SelectedIndex = 0;
        }

        private void bttnGenerar_Click(object sender, EventArgs e)
        {
            if (comboProductos.SelectedIndex == 0 && comboGrupo.SelectedIndex == 0)
            {
                reporte.Reporte_Producto();
            }
            else
            {
                if (comboProductos.SelectedIndex > 0 && comboProductos.SelectedIndex < 3)
                {
                    reporte.Reporte_ProductoParametro(estado, filtro);
                }
            }
        }

        private void comboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboGrupo.SelectedIndex)
            {
                case 0:
                    if (comboFiltro.Items.Count > 0) comboFiltro.Items.Clear();
                    comboFiltro.Enabled = false;
                    filtro = "";
                    break;
                case 1:
                    if (comboFiltro.Items.Count > 0) comboFiltro.Items.Clear();
                    comboFiltro.Enabled = true;
                    comboFiltro.Enabled = true;
                    ConfigCombo("CATEGORIAS");
                    comboFiltro.SelectedIndex = 0;
                    break;
                case 2:
                    if (comboFiltro.Items.Count > 0) comboFiltro.Items.Clear();
                    comboFiltro.Enabled = true;
                    comboFiltro.Enabled = true;
                    ConfigCombo("MARCAS");
                    comboFiltro.SelectedIndex = 0;
                    break;
                case 3:
                    if (comboFiltro.Items.Count > 0) comboFiltro.Items.Clear();
                    comboFiltro.Enabled = true;
                    comboFiltro.Enabled = true;
                    ConfigCombo("MODELOS");
                    comboFiltro.SelectedIndex = 0;
                    break;
            }
        }

        public void ConfigCombo(string filtro)
        {
            try
            {
                DataTable resultado = crud.TablaSeleccionada(filtro);
                for (int i = 0; i <= resultado.Rows.Count-1; i++)
                {
                    comboFiltro.Items.Add(resultado.Rows[i][1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void comboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboProductos.SelectedIndex)
            {
                case 0:
                    comboGrupo.Enabled = true;
                    comboFiltro.Enabled = true;
                    break;
                case 1:
                    comboGrupo.Enabled = true;
                    comboFiltro.Enabled = true;
                    estado = 1;
                    break;
                case 2:
                    comboGrupo.Enabled = true;
                    comboFiltro.Enabled = true;
                    estado = 0;
                    break;
                case 3:
                    comboGrupo.Enabled = false;
                    comboFiltro.Enabled = false;
                    break;
            }
        }

        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltro.Items.Count > 0)
            {
                filtro = comboFiltro.Text;
            }
        }
    }
}
