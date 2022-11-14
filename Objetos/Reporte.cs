using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Base_de_Datos.DataSet_ReportesTableAdapters;
using New_MasterTrade.Reportes;
using System;
using System.Management;
using System.Windows.Forms;

namespace New_MasterTrade.Objetos
{
    class Reporte : DataSet_Reportes
    {
        //DataSet
        DataSet_Reportes dataset = new DataSet_Reportes();
        //TableAdapters
        Orden_CompraTableAdapter orden_compra = new Orden_CompraTableAdapter();
        ClienteTableAdapter cliente = new ClienteTableAdapter();
        ProveedorTableAdapter proveedor = new ProveedorTableAdapter();
        //TableAdapters

        public void Reporte_Orden_Compra(int id)
        {
            try
            {
                orden_compra.Fill(dataset.Orden_Compra, id);
                OrdenCompra_Reporte reporte = new OrdenCompra_Reporte();
                string direccion = @"~\Reportes\OrdenCompra_Reporte.rpt";
                reporte.Load(direccion);
                reporte.SetDataSource(dataset);
                FormReportes ventana = new FormReportes(reporte);
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reporte_Cliente()
        {
            try
            {
                cliente.Fill(dataset.Cliente);
                Cliente_Reporte reporte = new Cliente_Reporte();
                string direccion = @"~\Reportes\Cliente_Reporte.rpt";
                reporte.Load(direccion);
                reporte.SetDataSource(dataset);
                FormReportes ventana = new FormReportes(reporte);
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reporte_Proveedor()
        {
            try
            {
                proveedor.Fill(dataset.Proveedor);
                Proveedor_Reporte reporte = new Proveedor_Reporte();
                string direccion = @"~\Reportes\Proveedor_Reporte.rpt";
                reporte.Load(direccion);
                reporte.SetDataSource(dataset);
                FormReportes ventana = new FormReportes(reporte);
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
