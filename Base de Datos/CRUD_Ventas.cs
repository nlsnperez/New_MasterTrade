using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD_Ventas : Conexion
    {
        CRUD_Productos crud = new CRUD_Productos();
        CRUD_Usuarios crudv = new CRUD_Usuarios();

        public void Crear(Venta venta)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `orden_venta`(`id_ove`, `id_cli`, `id_tca`, `num_ove`, `fec_ove`, `hor_ove`) VALUES (@id, @cliente,@tasacambio,@norden,@fecha,@hora)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = venta.Id;
                    command.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = venta.Cliente;
                    command.Parameters.Add("@tasacambio", MySqlDbType.VarChar).Value = venta.Tasa_Cambio; 
                    command.Parameters.Add("@norden", MySqlDbType.VarChar).Value = venta.NumeroOrden;
                    command.Parameters.Add("@fecha", MySqlDbType.Date).Value = System.DateTime.Now.Date.ToString("yyyy-MM-dd");
                    command.Parameters.Add("@hora", MySqlDbType.Time).Value = System.DateTime.Now.TimeOfDay;

                    command.ExecuteNonQuery();
                    MessageBox.Show("La factura fue registrada con éxito.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void CrearDetalle(List<Detalle> detalle)
        {
            for (int i = 0; i <= detalle.Count - 1; i++)
            {
                try
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.CommandText = "INSERT INTO `detalle_venta`(`id_ove`, `id_pro`, `can_dve`, `tot_dve`) VALUES (@oventa,@producto,@cantidad,@totBs)";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        command.Parameters.Add("@oventa", MySqlDbType.Int32).Value = detalle[i].IdOrden;
                        command.Parameters.Add("@producto", MySqlDbType.Int32).Value = detalle[i].Producto;
                        command.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle[i].Cantidad;
                        command.Parameters.Add("@totBs", MySqlDbType.Decimal).Value = detalle[i].TotalBs;

                        command.ExecuteNonQuery();
                        Console.WriteLine("Detalle registrado "+i+"!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void CrearFactura(Factura factura)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `factura_venta`(`id_ven`, `id_ove`, `id_imp`, `id_mpa`, `tim_fve`, `tot_fve`, `act_fve`) VALUES (@vendedor,@ordenventa,@impuesto,@metodopago,@totalimpuesto,@total,@activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@vendedor", MySqlDbType.Int32).Value = factura.Vendedor;
                    command.Parameters.Add("@ordenventa", MySqlDbType.Int32).Value = factura.OrdenVenta;
                    command.Parameters.Add("@impuesto", MySqlDbType.Int32).Value = factura.Impuesto;
                    command.Parameters.Add("@metodopago", MySqlDbType.Int32).Value = factura.MetodoPago;
                    command.Parameters.Add("@totalimpuesto", MySqlDbType.Decimal).Value = factura.TotalImpuesto;
                    command.Parameters.Add("@total", MySqlDbType.Decimal).Value = factura.Total;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                    Console.WriteLine("Factura registrada");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void CrearGarantia(List<int> detalles, List<int> dias)
        {
            for (int i = 0; i <= detalles.Count - 1; i++)
            {
                try
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.CommandText = "INSERT INTO `garantia`(`id_dve`, `fin_gar`, `ffi_gar`) VALUES (@detalle,@fechainicio,@fechafinal)";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        command.Parameters.Add("@detalle", MySqlDbType.Int32).Value = detalles[i];
                        command.Parameters.Add("@fechainicio", MySqlDbType.DateTime).Value = System.DateTime.Now;
                        command.Parameters.Add("@fechafinal", MySqlDbType.DateTime).Value = System.DateTime.Now.AddDays(dias[i]);

                        command.ExecuteNonQuery();
                        Console.WriteLine("Garantía registrada " + i + "!");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public List<int> Detalles(int id)
        {
            List<int> x = new List<int>();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `detalle_venta` WHERE  id_ove = " + id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    x.Add(reader.GetInt32(0));
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x;
        }

        public int GetIdVentas()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id_ove`) AS ventas FROM orden_venta", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["ventas"].ToString());
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x + 1;
        }

        public DataTable Impuestos()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `impuesto` WHERE act_imp = 1";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(categorias);
                return categorias;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return categorias;
        }

        public decimal PorcentajeImpuesto(int id)
        {
            decimal x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM impuesto WHERE id_imp = "+id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetDecimal(2);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x;
        }

        public int CantidadMax(int id)
        {
            return crud.ProductosComprados(id) - crud.ProductosVendidos(id);
        }

        public DataTable MetodosPago()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `metodo_pago` WHERE act_mpa = 1 ORDER BY des_mpa ASC";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(categorias);
                return categorias;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return categorias;
        }

        public DataTable Moneda()
        {
            DataTable moneda = new DataTable();
            String sql = "SELECT * FROM `moneda` WHERE act_mon = 1 ORDER BY id_mon ASC";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(moneda);
                return moneda;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return moneda;
        }

        public DataTable Tasa_Cambio(int id)
        {
            DataTable tasa_cambio = new DataTable();
            String sql = "SELECT * FROM `tasa_cambio` WHERE act_tca = 1 AND id_mon = "+id;
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(tasa_cambio);
                return tasa_cambio;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return tasa_cambio;
        }

        public decimal Valor_TasaCambio(int id)
        {
            decimal x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tasa_cambio WHERE id_tca = " + id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetDecimal(3);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x;
        }

        public DataTable Facturas()
        {
            DataTable facturas = new DataTable();
            String sql = "SELECT fv.id_fve, ov.num_ove, c.raz_cli, mp.des_mpa, fv.tot_fve FROM factura_venta fv INNER JOIN orden_venta ov ON fv.id_ove = ov.id_ove INNER JOIN metodo_pago mp ON fv.id_mpa = mp.id_mpa INNER JOIN cliente c ON ov.id_cli = c.id_cli ORDER BY id_fve ASC";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(facturas);
                return facturas;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return facturas;
        }

        public DataTable BuscarFacuras(string filtro)
        {
            DataTable facturas = new DataTable();
            String sql = "SELECT fv.id_fve, ov.num_ove, c.raz_cli, mp.des_mpa, fv.tot_fve FROM factura_venta fv INNER JOIN orden_venta ov ON fv.id_ove = ov.id_ove INNER JOIN metodo_pago mp ON fv.id_mpa = mp.id_mpa INNER JOIN cliente c ON ov.id_cli = c.id_cli WHERE fv.id_fve LIKE '" + filtro + "%' OR ov.num_ove LIKE '" + filtro + "%' OR c.raz_cli LIKE '" + filtro+ "%' OR c.doc_cli LIKE '%" + filtro+ "%'ORDER BY id_fve ASC";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(facturas);
                return facturas;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return facturas;
        }

        public int Vendedor(int id)
        {
            return crudv.VendedorId(id);
        }

        public int Garantia(int id)
        {
            return crud.Garantia(id);
        }
    }
}
