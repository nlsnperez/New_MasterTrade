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
        Orden_VentaTableAdapter orden_venta = new Orden_VentaTableAdapter();
        ClienteTableAdapter cliente = new ClienteTableAdapter();
        ProveedorTableAdapter proveedor = new ProveedorTableAdapter();
        ProductoTableAdapter producto = new ProductoTableAdapter();
        VentaTableAdapter venta = new VentaTableAdapter();
        CompraTableAdapter compra = new CompraTableAdapter();
        Producto_VendidoTableAdapter producto_vendido = new Producto_VendidoTableAdapter();
        Vendedor_EficienteTableAdapter vendedor_eficiente = new Vendedor_EficienteTableAdapter();
        VentasPorClienteTableAdapter ventas_por_cliente = new VentasPorClienteTableAdapter();
        ProductosPorProveedorTableAdapter productos_proveedor = new ProductosPorProveedorTableAdapter();
        MarcasVendidasTableAdapter marcas_vendidas = new MarcasVendidasTableAdapter();
        VentasPorAgnoTableAdapter ventas_agno = new VentasPorAgnoTableAdapter();
        ComprasPorAgnoTableAdapter compras_agno = new ComprasPorAgnoTableAdapter();
        //TableAdapters

        public void Reporte_Orden_Compra(string numero_orden)
        {
            try
            {
                orden_compra.Fill(dataset.Orden_Compra, numero_orden);
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

        public void Reporte_Orden_Venta(string numero_orden)
        {
            try
            {
                orden_venta.Fill(dataset.Orden_Venta, numero_orden);
                OrdenVenta_Reporte reporte = new OrdenVenta_Reporte();
                string direccion = @"~\Reportes\OrdenVenta_Reporte.rpt";
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

        public void Reporte_Cliente(string x)
        {
            try
            {
                cliente.Fill(dataset.Cliente, x + "%");
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

        public void Reporte_ClienteParametro(int x, string y)
        {
            try
            {
                cliente.FillBy(dataset.Cliente, x, y+"%");
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

        public void Reporte_Proveedor(string x)
        {
            try
            {
                proveedor.Fill(dataset.Proveedor, x + "%");
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

        public void Reporte_ProveedorParametro(int x, string y)
        {
            try
            {
                proveedor.FillBy(dataset.Proveedor, x, y + "%");
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
                producto.FillByAll(dataset.Producto);
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
                producto.Fill(dataset.Producto, filtro, filtro, filtro);
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

        public void Reporte_ProductoParametroEstado(int estado, string filtro)
        {
            filtro += "%";
            try
            {
                producto.FillBy(dataset.Producto, estado, filtro, estado, filtro, estado, filtro);
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

        public void Reporte_Venta()
        {
            try
            {
                venta.Fill(dataset.Venta);
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

        public void Reporte_Compra()
        {
            try
            {
                compra.Fill(dataset.Compra);
                Compra_Reporte reporte = new Compra_Reporte();
                string direccion = @"~\Reportes\Compra_Reporte.rpt";
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
                producto_vendido.Fill(dataset.Producto_Vendido);
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
                vendedor_eficiente.Fill(dataset.Vendedor_Eficiente);
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
                ventas_por_cliente.Fill(dataset.VentasPorCliente);
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
                productos_proveedor.Fill(dataset.ProductosPorProveedor);
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
                marcas_vendidas.Fill(dataset.MarcasVendidas);
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
                ventas_agno.Fill(dataset.VentasPorAgno, agno);
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
                compras_agno.Fill(dataset.ComprasPorAgno, agno);
                ComprasPorAgno reporte = new ComprasPorAgno();
                string direccion = @"~\Reportes\ComprasPorAgno.rpt";
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
