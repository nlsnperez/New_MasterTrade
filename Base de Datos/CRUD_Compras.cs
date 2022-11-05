using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD_Compras : Conexion
    {
        //CRUDProductos crud = new CRUDProductos();
        public void Crear(Compra compra)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `orden_compra`(`n_orden`, `id_prov`, `fecha`) VALUES (@norden,@proveedor,@fecha)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@norden", MySqlDbType.VarChar).Value = compra.NumeroOrden;
                    command.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = compra.Proveedor;
                    command.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = compra.Fecha;

                    command.ExecuteNonQuery();
                    MessageBox.Show("La orden de compra fue registrada con éxito.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        command.CommandText = "INSERT INTO `detalle_compra`(`id_ordc`, `id_pro`, `cantidad`, `total`, `tot_usd`) VALUES (@ocompra,@producto,@cantidad,@totBs,@totUsd)";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        command.Parameters.Add("@ocompra", MySqlDbType.Int32).Value = detalle[i].IdOrden;
                        command.Parameters.Add("@producto", MySqlDbType.Int32).Value = detalle[i].Producto;
                        command.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle[i].Cantidad;
                        command.Parameters.Add("@totBs", MySqlDbType.Decimal).Value = detalle[i].TotalBs;
                        command.Parameters.Add("@totUsd", MySqlDbType.Decimal).Value = detalle[i].TotalUSD;

                        command.ExecuteNonQuery();
                        Console.WriteLine("Detalle registrado");
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

        public DataTable Ventas()
        {
            string comando = "SELECT `id`, `numero_control`, `cliente`, `metodo_pago`, `visible`, DATE_FORMAT(`fecha_registro`,'%d/%m/%Y') AS fecha_registro, `fecha_eliminado` FROM `ventas` ORDER BY `ventas`.`fecha_registro` DESC";

            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando, con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla ventas encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable VentasByDate(string fecha)
        {
            string comando = "SELECT `id`, `numero_control`, `cliente`, `metodo_pago`, `visible`, DATE_FORMAT(`fecha_registro`,'%d/%m/%Y') AS fecha_registro, `fecha_eliminado` FROM `ventas` WHERE `fecha_registro` LIKE '" + fecha + "%' ORDER BY `ventas`.`fecha_registro` DESC";

            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando, con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla ventas encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable FindProductos(int x)
        {
            string comando = "";
            switch (x)
            {
                case 1:
                    comando = "SELECT `codigo_producto`, `nombre`, `stock_minimo`, `stock_maximo`, `costo` FROM `productos` WHERE visible = 1";
                    break;
                case 2:
                    comando = "SELECT DISTINCT `codigo_producto`, `nombre`, `costo` FROM `productos` INNER JOIN `detalle_compras` ON productos.codigo_producto = detalle_compras.producto WHERE productos.visible = 1";
                    break;
            }
            
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando, con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla productos encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable BuscarProductos(String busqueda, int x)
        {
            string comando = "";
            switch (x)
            {
                case 1:
                    comando = "SELECT `codigo_producto`, `nombre`, `stock_minimo`, `stock_maximo`, `costo` FROM `productos` WHERE visible = 1 AND (productos.codigo_producto LIKE '%" + busqueda + "%' OR productos.nombre LIKE '" + busqueda + "%' OR productos.costo LIKE '" + busqueda + "%')";
                    break;
                case 2:
                    comando = "SELECT DISTINCT `codigo_producto`, `nombre`, `costo` FROM `productos` INNER JOIN `detalle_compras` ON productos.codigo_producto = detalle_compras.producto WHERE visible = 1 AND (productos.codigo_producto LIKE '%" + busqueda + "%' OR productos.nombre LIKE '" + busqueda + "%' OR productos.costo LIKE '" + busqueda + "%')";
                    break;
            }

            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando, con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla productos encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public int GetIdCompras()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id`) AS compras FROM orden_compra", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["compras"].ToString());
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
            return x+1;
        }

        public int VentasRealizadas()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id`) AS ventas FROM ventas", con);
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

        public int CantidadDisponible(string codigo)
        {
            return 0;
        }

        public DataTable MetodosPago()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `metodos_pago` ORDER BY `metodos_pago`.`descripcion` ASC";
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

        private int ID()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `ventas` ORDER BY id DESC", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["id"].ToString());
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

        public DataTable GetDetalle(int id)
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT dv.venta, p.nombre, dv.cantidad, p.costo, dv.precio FROM detalle_ventas dv INNER JOIN productos p ON dv.producto = p.codigo_producto WHERE dv.venta = " + id.ToString();
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

        public DataTable Impuestos()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `impuesto`";
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
    }
}
