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
    public partial class Categorias : UserControl
    {
        CRUDExtras crud;
        bool IsCollapsed;
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            Config();
        }

        public void Config()
        {
            crud = new CRUDExtras();
            panelDropDown.Size = panelDropDown.MinimumSize;
            tablaCategorias.AutoGenerateColumns = false;
            tablaCategorias.DataSource = crud.GetTable();
        }

        private void timerDropDown_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timerDropDown.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timerDropDown.Stop();
                    IsCollapsed = true;
                }
            }
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                txtId.Enabled = false;
                txtId.Text = crud.GetLastID().ToString();
                timerDropDown.Start();
                bttnGuardar.Text = "GUARDAR";
                bttnAgregar.Text = "ATRÁS";
            }
            else
            {
                timerDropDown.Start();
                Clear();
                bttnAgregar.Text = "AGREGAR";
            }
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            bttnGuardarAction(bttnGuardar.Text);
        }

        private void bttnGuardarAction(string accion)
        {
            switch (accion)
            {
                case "GUARDAR":
                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Introduzca un nombre para la categoría", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea registrar la categoría: " + txtNombre.Text.ToUpper() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            crud.CreateCategorie(txtNombre.Text);
                            MessageBox.Show("¡Categoría registrada con éxito!", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            tablaCategorias.DataSource = crud.GetTable();
                        }
                    }
                    break;
                case "ACTUALIZAR":
                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Introduzca un nombre para la categoría", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea actualizar la categoría cómo: " + txtNombre.Text.ToUpper() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            crud.UpdateCategoria(txtId.Text, txtNombre.Text);
                            Clear();
                            timerDropDown.Start();
                            tablaCategorias.DataSource = crud.GetTable();
                        }
                    }
                    break;
            }
        }

        public void Clear()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            bttnAgregar.Text = "AGREGAR";
            bttnGuardar.Text = "GUARDAR";
            if (!IsCollapsed) timerDropDown.Start();
        }

        private void tablaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                txtId.Text = tablaCategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtId.Enabled = false;
                txtNombre.Text = tablaCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                bttnGuardar.Text = "ACTUALIZAR";
                timerDropDown.Start();
            }
            else
            {
                if (e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("Desea eliminar la categoría: " + tablaCategorias.Rows[e.RowIndex].Cells[1].Value.ToString() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        crud.DeleteCategoria(tablaCategorias.Rows[e.RowIndex].Cells[0].Value.ToString());
                        Clear();
                        tablaCategorias.DataSource = crud.GetTable();
                    }
                }
            }
        }
    }
}
