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

namespace New_MasterTrade.UserControls
{
    public partial class RegistrosBitacora : UserControl
    {
        private DataTable tabla = new DataTable();
        private int total_filas = 0;
        private int pagina = 0;
        private int total_paginas = 0;
        private int limite_registro = 20;
        CRUD_Bitacora crud = new CRUD_Bitacora();
        public RegistrosBitacora()
        {
            InitializeComponent();
            CargarDatos(crud.RegistrosBitacora());
            ConfigComboPaginas();
        }

        public void CargarTabla()
        {
            tablaBitacora.AutoGenerateColumns = false;
            if (crud.RegistrosBitacora().Rows.Count > 0)
            {
                tablaBitacora.DataSource = crud.RegistrosBitacora();
                txtBuscar.Enabled = true;
                txtBuscar.Focus();
            }
            else
            {
                MessageBox.Show("No hay registros en la base de datos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            tablaBitacora.DataSource = Resultados(tabla);
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
                tablaBitacora.DataSource = Resultados(tabla);
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
            DataTable resultados = crud.BuscarBitacora(txtBuscar.Text);
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

        private void tablaBitacora_MouseEnter(object sender, EventArgs e)
        {
            tablaBitacora.Focus();
        }
    }
}
