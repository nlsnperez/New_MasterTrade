﻿using New_MasterTrade.Base_de_Datos;
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
        string categoria = "";
        string marca = "";
        string modelo = "";
        int estado = 0;
        decimal precio_venta = 0;
        decimal precio_compra = 0;

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
            comboProductos.Items.Add("ACTIVOS");
            comboProductos.Items.Add("DESACTIVOS");
            comboProductos.SelectedIndex = 0;

            try
            {
                DataTable categorias = crud.Categorias();
                for (int i = 0; i <= categorias.Rows.Count-1; i++)
                {
                    combocategoria.Items.Add(categorias.Rows[i][1].ToString());
                }
                combocategoria.SelectedIndex = 0;

                DataTable marcas = crud.Marcas();
                for (int i = 0; i <= marcas.Rows.Count - 1; i++)
                {
                    comboMarca.Items.Add(marcas.Rows[i][1].ToString());
                }
                comboMarca.SelectedIndex = 0;

                DataTable modelos = crud.Modelos();
                for (int i = 0; i <= modelos.Rows.Count - 1; i++)
                {
                    comboModelo.Items.Add(modelos.Rows[i][1].ToString());
                }
                comboModelo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            comboPrecioCompra.Items.Add("CUALQUIER PRECIO");
            comboPrecioCompra.Items.Add("MAYOR A 1000Bs");
            comboPrecioCompra.Items.Add("MAYOR A 10.000Bs");
            comboPrecioCompra.SelectedIndex = 0;

            comboPrecioVenta.Items.Add("CUALQUIER PRECIO");
            comboPrecioVenta.Items.Add("MAYOR A 1000Bs");
            comboPrecioVenta.Items.Add("MAYOR A 10.000Bs");
            comboPrecioVenta.SelectedIndex = 0;
        }

        private void comboPrecioCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboPrecioCompra.SelectedIndex)
            {
                case 0:
                    precio_compra = 0;
                    break;
                case 1:
                    precio_compra = 100;
                    break;
                case 2:
                    precio_compra = 1000;
                    break;
            }
            Console.WriteLine(precio_compra);
        }

        private void comboPrecioVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboPrecioVenta.SelectedIndex)
            {
                case 0:
                    precio_venta = 0;
                    break;
                case 1:
                    precio_venta = 100;
                    break;
                case 2:
                    precio_venta = 1000;
                    break;
            }
            Console.WriteLine(precio_venta);
        }

        private void combocategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combocategoria.SelectedIndex == 0)
            {
                categoria = "";
            }
            else
            {
                categoria = combocategoria.Text;
            }
            Console.WriteLine(categoria);
        }

        private void comboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMarca.SelectedIndex == 0)
            {
                marca = "";
            }
            else
            {
                marca = comboMarca.Text;
            }
            Console.WriteLine(marca);
        }

        private void comboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModelo.SelectedIndex == 0)
            {
                modelo = "";
            }
            else
            {
                modelo = comboModelo.Text;
            }
            Console.WriteLine(modelo);
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void bttnGenerar_Click(object sender, EventArgs e)
        {
            if (!checkParametros.Checked)
            {
                reporte.Reporte_Producto();
            }
            else
            {
                if (comboProductos.SelectedIndex == 0)
                {
                    estado = 1;
                    reporte.Reporte_ProductoParametro(estado, combocategoria.Text, comboMarca.Text, comboModelo.Text, precio_compra, precio_venta);
                }
                else
                {
                    estado = 0;
                    reporte.Reporte_ProductoParametro(estado, combocategoria.Text, comboMarca.Text, comboModelo.Text, precio_compra, precio_venta);
                }
            }
        }

        private void checkParametros_CheckedChanged(object sender, EventArgs e)
        {
            if (checkParametros.Checked)
            {
                ActivarCombos(true);
            }
            else
            {
                ActivarCombos(false);
            }
        }

        public void ActivarCombos(bool estado)
        {
            comboProductos.Enabled = estado;
            combocategoria.Enabled = estado;
            comboMarca.Enabled = estado;
            comboModelo.Enabled = estado;
            comboPrecioCompra.Enabled = estado;
            comboPrecioVenta.Enabled = estado;
        }
    }
}
