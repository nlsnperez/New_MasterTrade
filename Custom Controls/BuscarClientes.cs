using New_MasterTrade.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Custom_Controls
{
    public partial class BuscarClientes : Form
    {
        public int x { get; set; }
        public string y { get; set; }

        private DataTable tabla = new DataTable();
        private int total_filas = 0;
        private int pagina = 0;
        private int total_paginas = 0;
        private int limite_registro = 2;
        CRUD_Usuarios crud = new CRUD_Usuarios();

        public BuscarClientes()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            tablaPersonas.AutoGenerateColumns = false;
            this.x = 0;
            this.y = "";
            CargarDatos(crud.UsuariosActivos());
            ConfigComboPaginas();
            //if (crud.Tabla().Rows.Count > 0)
            //{
            //    tablaPersonas.AutoGenerateColumns = false;
            //    tablaPersonas.DataSource = crud.TablaActivos();
            //    tablaPersonas.ClearSelection();
            //}
            //else MessageBox.Show("No existen registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //MÉTODOS PARA EL PAGINADOR
        public void ConfigComboPaginas()
        {
            if (comboPaginas.Items.Count > 0) comboPaginas.Items.Clear();
            for (int i = 0; i <= total_paginas; i++)
            {
                comboPaginas.Items.Add(i + 1);
            }
            comboPaginas.SelectedIndex = 0;
        }

        public void CargarDatos(DataTable resultados)
        {
            tabla = resultados;
            total_filas = tabla.Rows.Count - 1;
            total_paginas = total_filas / limite_registro;
            tablaPersonas.DataSource = Resultados(tabla);
        }

        private DataTable Resultados(DataTable resultados)
        {
            HabilitarBotones();
            return resultados.AsEnumerable().Skip(limite_registro * pagina).Take(limite_registro).CopyToDataTable();
        }

        private void HabilitarBotones()
        {
            if (pagina == 0)
            {
                bttnAnterior.Enabled = false;
            }
            else
            {
                bttnAnterior.Enabled = true;
            }

            if (pagina == total_paginas)
            {
                bttnSiguiente.Enabled = false;
            }
            else
            {
                bttnSiguiente.Enabled = true;
            }
        }

        private void comboPaginas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                pagina = Int32.Parse(comboPaginas.Text) - 1;
                tablaPersonas.DataSource = Resultados(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                comboPaginas.SelectedIndex += 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                comboPaginas.SelectedIndex -= 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //MÉTODOS PARA EL PAGINADOR

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaPersonas.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                this.x = (int)tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value;
                this.y = tablaPersonas.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                this.Close();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            //tablaPersonas.DataSource = crud.BuscarTablaActivos(txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
