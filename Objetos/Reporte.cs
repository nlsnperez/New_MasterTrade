using CrystalDecisions.Shared;
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
        //Orden_CompraTableAdapter orden_compra = new Orden_CompraTableAdapter();
        //Orden_VentaTableAdapter orden_venta = new Orden_VentaTableAdapter();
        ////ClienteTableAdapter cliente = new ClienteTableAdapter();
        ////ProveedorTableAdapter proveedor = new ProveedorTableAdapter();
        //ProductoTableAdapter producto = new ProductoTableAdapter();
        //VentaTableAdapter venta = new VentaTableAdapter();
        //CompraTableAdapter compra = new CompraTableAdapter();
        ////Producto_VendidoTableAdapter producto_vendido = new Producto_VendidoTableAdapter();
        //Vendedor_EficienteTableAdapter vendedor_eficiente = new Vendedor_EficienteTableAdapter();
        ////VentasPorClienteTableAdapter ventas_por_cliente = new VentasPorClienteTableAdapter();
        ////ProductosPorProveedorTableAdapter productos_proveedor = new ProductosPorProveedorTableAdapter();
        ////MarcasVendidasTableAdapter marcas_vendidas = new MarcasVendidasTableAdapter();
        //VentasPorAgnoTableAdapter ventas_agno = new VentasPorAgnoTableAdapter();
        //ComprasPorAgnoTableAdapter compras_agno = new ComprasPorAgnoTableAdapter();
        //PruebaTableAdapter prueba = new PruebaTableAdapter();
        Factura_VentaTableAdapter factura_venta = new Factura_VentaTableAdapter();
        Nuevo_OrdenCompraTableAdapter orden_compra = new Nuevo_OrdenCompraTableAdapter();
        ClienteTableAdapter cliente = new ClienteTableAdapter();
        ProveedorTableAdapter proveedor = new ProveedorTableAdapter();
        ProductoTableAdapter producto = new ProductoTableAdapter();
        ProductoMasVendidoTableAdapter producto_vendido = new ProductoMasVendidoTableAdapter();
        VendedorMasEficienteTableAdapter vendedor_eficiente = new VendedorMasEficienteTableAdapter();
        ClienteFrecuenteTableAdapter cliente_frecuente = new ClienteFrecuenteTableAdapter();
        ProveedorPrincipalTableAdapter proveedor_principal = new ProveedorPrincipalTableAdapter();
        MarcaMasVendidaTableAdapter marca_vendida = new MarcaMasVendidaTableAdapter();
        VentasAlAgnoTableAdapter ventas_agno = new VentasAlAgnoTableAdapter();
        VentasTableAdapter venta = new VentasTableAdapter();
        TOP10ClienteFrecuenteTableAdapter top_cliente_frecuente = new TOP10ClienteFrecuenteTableAdapter();
        //TableAdapters

        public void Reporte_Orden_Compra(string numero_orden)
        {
            try
            {
                orden_compra.Fill(dataset.Nuevo_OrdenCompra, numero_orden);
                OrdenCompra2_Reporte reporte = new OrdenCompra2_Reporte();
                string direccion = @"~\Reportes\OrdenCompra2_Reporte.rpt";
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

        public void Reporte_Orden_Venta(string numero_orden)
        {
            try
            {
                factura_venta.Fill(dataset.Factura_Venta, numero_orden);
                FacturaVenta_Reporte reporte = new FacturaVenta_Reporte();
                string direccion = @"~\Reportes\FacturaVenta_Reporte.rpt";
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

        public void Reporte_Producto()
        {
            try
            {
                producto.Fill(dataset.Producto);
                Producto_Reporte reporte = new Producto_Reporte();
                string direccion = @"~\Reportes\Producto_Reporte.rpt";
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

        public void Reporte_ProductoParametro(string filtro)
        {
            try
            {
                //producto.Fill(dataset.Producto, filtro, filtro, filtro);
                //Producto_Reporte reporte = new Producto_Reporte();
                //string direccion = @"~\Reportes\Producto_Reporte.rpt";
                //reporte.Load(direccion);
                //reporte.SetDataSource(dataset);
                //FormReportes ventana = new FormReportes(reporte);
                //ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reporte_ProductoParametroEstado(int estado, string filtro)
        {
            filtro += "%";
            try
            {
                //producto.FillBy(dataset.Producto, estado, filtro, estado, filtro, estado, filtro);
                //Producto_Reporte reporte = new Producto_Reporte();
                //string direccion = @"~\Reportes\Producto_Reporte.rpt";
                //reporte.Load(direccion);
                //reporte.SetDataSource(dataset);
                //FormReportes ventana = new FormReportes(reporte);
                //ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Reporte_Venta()
        {
            try
            {
                venta.Fill(dataset.Ventas);
                Venta_Reporte reporte = new Venta_Reporte();
                string direccion = @"~\Reportes\Venta_Reporte.rpt";
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

        public void Reporte_ProductoMasVendido()
        {
            try
            {
                producto_vendido.Fill(dataset.ProductoMasVendido);
                ProductoVendido_Reporte reporte = new ProductoVendido_Reporte();
                string direccion = @"~\Reportes\ProductoVendido_Reporte.rpt";
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

        public void Reporte_VendedorEficiente()
        {
            try
            {
                vendedor_eficiente.Fill(dataset.VendedorMasEficiente);
                VendedorEficiencia_Reporte reporte = new VendedorEficiencia_Reporte();
                string direccion = @"~\Reportes\VendedorEficiencia_Reporte.rpt";
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

        public void Reporte_VentasPorCliente()
        {
            try
            {
                top_cliente_frecuente.Fill(dataset.TOP10ClienteFrecuente);
                VentasPorClientes_Reporte reporte = new VentasPorClientes_Reporte();
                string direccion = @"~\Reportes\VentasPorClientes_Reporte.rpt";
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

        public void Reporte_ProductosPorProveedor()
        {
            try
            {
                proveedor_principal.Fill(dataset.ProveedorPrincipal);
                ProductosPorProveedor_Reporte reporte = new ProductosPorProveedor_Reporte();
                string direccion = @"~\Reportes\ProductosPorProveedor_Reporte.rpt";
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

        public void Reporte_MarcasVendidas()
        {
            try
            {
                marca_vendida.Fill(dataset.MarcaMasVendida);
                MarcaMasVendida reporte = new MarcaMasVendida();
                string direccion = @"~\Reportes\MarcaMasVendida.rpt";
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

        public void Reporte_VentasPorAgno(string agno)
        {
            try
            {
                ventas_agno.Fill(dataset.VentasAlAgno, agno);
                VentasPorAgno_Reporte reporte = new VentasPorAgno_Reporte();
                string direccion = @"~\Reportes\VentasPorAgno_Reporte.rpt";
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

        public void Reporte_ComprasPorAgno(string agno)
        {
            try
            {
                //compras_agno.Fill(dataset.ComprasPorAgno, agno);
                //ComprasPorAgno reporte = new ComprasPorAgno();
                //string direccion = @"~\Reportes\ComprasPorAgno.rpt";
                //reporte.Load(direccion);
                //reporte.SetDataSource(dataset);
                //FormReportes ventana = new FormReportes(reporte);
                //ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}   
