﻿using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Mensajes;
using New_MasterTrade.Objetos;
using System;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace New_MasterTrade
{
    public partial class Personas : UserControl
    {
        private CRUD crud;
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            crud = new CRUD();
            Config_Botones("INICIO");
            tablaPersonas.AutoGenerateColumns = false;
            FillComboBoxes();
            RefreshTable(1);
        }

        //BOTONES//

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (GetPersona().IsEmpty())
            {
                MessageBox.Show("Complete todos los campos!");
            }
            else
            {
                if (MessageBox.Show("Desea registrar el " + comboOcupacion.SelectedItem.ToString().ToLower() + ": " + GetPersona().Documento + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (comboOcupacion.SelectedIndex == 0)
                    {
                        crud.Create(GetPersona(), "clientes");
                        Clear();
                        comboTabla.SelectedIndex = 0;
                        RefreshTable(1);
                    }
                    else
                    {
                        crud.Create(GetPersona(), "proveedores");
                        Clear();
                        comboTabla.SelectedIndex = 1;
                        RefreshTable(2);
                    }
                }
                
            }            
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea actualizar los datos del " + comboOcupacion.SelectedItem.ToString().ToLower() + ": " + GetPersona().Documento + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (comboOcupacion.SelectedIndex == 0)
                {
                    crud.Update(GetPersona(), "clientes");
                    Clear();
                    RefreshTable(1);
                }
                else
                {
                    crud.Update(GetPersona(), "proveedores");
                    Clear();
                    RefreshTable(2);
                }
            }            
        }
        
        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar los datos del " + comboOcupacion.SelectedItem.ToString().ToLower() + ": " + GetPersona().Documento + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (comboOcupacion.SelectedIndex == 0)
                {
                    crud.Delete(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, "clientes");
                    Clear();
                    RefreshTable(1);
                }
                else
                {
                    crud.Delete(txtDocumento.Text, "proveedores");
                    Clear();
                    RefreshTable(2);
                }
            }            
        }

        //BOTONES//

        //CONFIGURACIÓN///

        public void Clear()
        {
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            comboOcupacion.SelectedIndex = 0;
            comboDocumento.SelectedIndex = 0;
            comboOcupacion.Enabled = true;
            comboDocumento.Enabled = true;
            txtDocumento.Enabled = true;
            comboTabla.Enabled = true;
            Config_Botones("INICIO");
        }

        
        public void FillComboBoxes()
        {
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");
            comboDocumento.SelectedIndex = 0;

            comboOcupacion.Items.Add("CLIENTE");
            comboOcupacion.Items.Add("PROVEEDOR");
            comboOcupacion.SelectedIndex = 0;

            comboTabla.Items.Add("CLIENTES");
            comboTabla.Items.Add("PROVEEDORES");
            comboTabla.SelectedIndex = 0;
        }

        public void Config_Botones(String modo)
        {
            switch (modo)
            {
                case "INICIO":
                    bttnGuardar.Enabled = true;
                    bttnActualizar.Enabled = false;
                    bttnEliminar.Enabled = false;
                    bttnCancelar.Enabled = true;
                    break;
                case "SELECCIÓN":
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    bttnEliminar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    break;
            }
        }

        //CONFIGURACIÓN///

        //TABLA//

        public void RefreshTable(int x)
        {
            switch (x)
            {
                case 1:
                    tablaPersonas.DataSource = crud.GetTable();
                    break;
                case 2:
                    tablaPersonas.DataSource = crud.GetTableProveedores();
                    break;
                case 3:
                    tablaPersonas.DataSource = crud.SearchTable(comboTabla.SelectedItem.ToString().ToLower(), txtBuscar.Text);
                    break;
            }
        }

        private void comboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTabla.SelectedIndex == 0)
            {
                RefreshTable(1);
            }
            else
            {
                RefreshTable(2);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshTable(3);
        }

        private void tablaPersonas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboDocumento.SelectedIndex = DocumentoIndex(tablaPersonas.SelectedRows[0].Cells[0].Value.ToString()[0]);
            txtDocumento.Text = tablaPersonas.SelectedRows[0].Cells[0].Value.ToString().Remove(0, 1);
            txtRazonSocial.Text = tablaPersonas.SelectedRows[0].Cells[1].Value.ToString();
            txtDireccion.Text = tablaPersonas.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefono.Text = tablaPersonas.SelectedRows[0].Cells[3].Value.ToString();
            txtCorreo.Text = tablaPersonas.SelectedRows[0].Cells[4].Value.ToString();
            txtDocumento.Enabled = false;
            comboDocumento.Enabled = false;
            comboTabla.Enabled = false;
            comboOcupacion.Enabled = false;
            Config_Botones("SELECCIÓN");
            if (comboTabla.SelectedIndex == 0)
            {
                comboOcupacion.SelectedIndex = 0;
            }
            else
            {
                comboOcupacion.SelectedIndex = 1;
            }
        }

        //TABLA//

        public int DocumentoIndex(char x)
        {
            switch (x)
            {
                case 'V':
                    return 0;
                    break;
                case 'E':
                    return 1;
                    break;
                case 'J':
                    return 2;
                    break;
                case 'G':
                    return 3;
                    break;
            }
            return 0;
        }

        private Persona GetPersona()
        {
            Persona persona = new Persona(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, txtRazonSocial.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
            return persona;
        }  

        
    }
}
