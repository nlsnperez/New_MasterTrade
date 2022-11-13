using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Base_de_Datos.DataSet_ReportesTableAdapters;
using New_MasterTrade.Reportes;
using System;
using System.Windows.Forms;

namespace New_MasterTrade.Objetos
{
    class Reporte : DataSet_Reportes
    {
        DataSet_Reportes dataset = new DataSet_Reportes();
        Orden_CompraTableAdapter orden_compra = new Base_de_Datos.DataSet_ReportesTableAdapters.Orden_CompraTableAdapter();
        

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
    }
}
