using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.Objetos;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Clientes : UserControl
    {
        private DataTable tabla = new DataTable();
        private int total_filas = 0;
        private int pagina = 0;
        private int total_paginas = 0;
        private int limite_registro = 20;
        CRUD_Usuarios crud = new CRUD_Usuarios();

        public Clientes()
        {
            InitializeComponent();
            Config();
        }

        public void Config()
        {
            tablaPersonas.AutoGenerateColumns = false;
            tablaPersonas.DataSource = null;
            CargarDatos(crud.Usuarios());
            CargarCombos();
        }

        public void CargarDatos(DataTable resultados)
        {
            tabla = resultados;
            total_filas = tabla.Rows.Count-1;
            total_paginas = total_filas / limite_registro;            
            tablaPersonas.DataSource = Resultados(tabla);
        }

        private DataTable Resultados(DataTable resultados)
        {
            HabilitarBotones();
            return resultados.AsEnumerable().Skip(limite_registro * pagina).Take(limite_registro).CopyToDataTable();
        }

        public void CargarCombos()
        {
            try
            {
                for (int i = 0; i <= total_paginas; i++)
                {
                    comboPaginas.Items.Add(i + 1);
                }
                comboPaginas.SelectedIndex = 0;

                //comboNivel.ValueMember = "id_niv";
                //comboNivel.DisplayMember = "des_niv";
                //comboNivel.DataSource = crud.Nivel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Detalles")
            {
                int id = Convert.ToInt32(tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value);
                string documento = tablaPersonas.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                Persona usuario = crud.Usuario(id, documento);
                FormularioPersonas y = new FormularioPersonas(0);
                y.DatosPersona(usuario);

                SesionIniciada.Instancia.MostrarUserControl(y);
            }
            else
            {
                if (e.ColumnIndex >= 0 && tablaPersonas.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    if (Convert.ToBoolean(tablaPersonas.Rows[e.RowIndex].Cells["Activo"].Value) == true)
                    {
                        if (MessageBox.Show("¿Desea eliminar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int id = (int)tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value;
                            crud.Delete(id, 0);
                            CargarDatos(crud.Usuarios());
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(tablaPersonas.Rows[e.RowIndex].Cells["Activo"].Value) == false)
                        {
                            if (MessageBox.Show("¿Desea restaurar los datos de este usuario?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                int id = (int)tablaPersonas.Rows[e.RowIndex].Cells["columnId"].Value;
                                crud.Delete(id, 1);
                                CargarDatos(crud.Usuarios());
                            }
                        }
                    }
                    
                }
            }
        }

        public void ReiniciarPaginador()
        {
            total_filas = 0;
            pagina = 0;
            total_paginas = 0;
            limite_registro = 20;
        }

        private void txtBuscar_KeyUp_1(object sender, KeyEventArgs e)
        {
            //tablaPersonas.DataSource = crud.BuscarTabla((int)comboNivel.SelectedValue, txtBuscar.Text);
            DataTable resultados = crud.BuscarTabla(0, txtBuscar.Text);
            if (resultados.Rows.Count <= 0)
            {
                MessageBox.Show("No hay registros en la base de datos", "RESULTADOS NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReiniciarPaginador();
                CargarDatos(resultados);
                CargarCombos();
            }
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            SesionIniciada.Instancia.MostrarUserControl(new FormularioPersonas(0));
        }

        private void tablaPersonas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tablaPersonas.Columns[e.ColumnIndex].Name == "Activo")
            {
                if (Convert.ToBoolean(e.Value) == false)
                {
                    if (UserData.Nivel == 1)
                    {
                        tablaPersonas.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        tablaPersonas.Rows[e.RowIndex].Cells["Eliminar"].Value = Properties.Resources.restore;
                    }
                    else
                    {
                        tablaPersonas.Rows[e.RowIndex].Visible = false;
                    }
                }
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
                pagina = Int32.Parse(comboPaginas.Text)-1;
                tablaPersonas.DataSource = Resultados(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
