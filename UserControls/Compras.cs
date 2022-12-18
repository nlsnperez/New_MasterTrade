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
    public partial class Compras : UserControl
    {
        private DataTable tabla = new DataTable();
        private int total_filas = 0;
        private int pagina = 0;
        private int total_paginas = 0;
        private int limite_registro = 20;
        CRUD_Compras crud;
        public Compras()
        {
            InitializeComponent();
            crud = new CRUD_Compras();
            CargarDatos(crud.Compras());
            ConfigComboPaginas();
        }

        public void CargarTabla()
        {
            tablaCompras.AutoGenerateColumns = false;
            try
            {
                tablaCompras.DataSource = crud.Compras();
                txtBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //MÉTODOS PARA EL PAGINADOR
        public void ReiniciarPaginador()
        {
            total_filas = 0;
            pagina = 0;
            total_paginas = 0;
            limite_registro = 20;
        }

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
            tablaCompras.DataSource = Resultados(tabla);
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
                tablaCompras.DataSource = Resultados(tabla);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable resultados = crud.BuscarCompras(txtBuscar.Text);
            if (resultados.Rows.Count <= 0)
            {
                MessageBox.Show("No hay registros en la base de datos", "RESULTADOS NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReiniciarPaginador();
                CargarDatos(resultados);
                ConfigComboPaginas();
            }
        }

        private void tablaCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCompras.Columns[e.ColumnIndex].Name == "Detalle")
            {
                string x = tablaCompras.Rows[e.RowIndex].Cells["NOrden"].Value.ToString();
                Reporte reporte = new Reporte();
                reporte.Reporte_Orden_Compra(x);
            }
        }
    }
}
