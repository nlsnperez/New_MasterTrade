using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUDProductos : Conexion
    {
        public void Create(Producto producto)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `productos`(`codigo_producto`, `categoria`, `nombre`, `costo`, `visible`, `fecha_registro`, `fecha_eliminado`) VALUES (@codigo, @categoria, @nombre, @costo, @visible, @fregistro, @feliminado)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = producto.Codigo;
                    command.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = producto.Categoria;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = producto.Nombre.ToUpper();
                    command.Parameters.Add("@costo", MySqlDbType.Float).Value = producto.Costo;
                    command.Parameters.Add("@visible", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@fregistro", MySqlDbType.DateTime).Value = System.DateTime.Now;
                    command.Parameters.Add("@feliminado", MySqlDbType.DateTime).Value = null;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("El registro se completó de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CreateStock(producto);
        }

        private void CreateStock(Producto producto)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `producto_stock`(`producto`, `minimo`, `maximo`) VALUES (@producto, @minimo, @maximo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@producto", MySqlDbType.Int32).Value = producto.Id;
                    command.Parameters.Add("@minimo", MySqlDbType.Int32).Value = producto.StockMin;
                    command.Parameters.Add("@maximo", MySqlDbType.Int32).Value = producto.StockMax;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("El registro se completó de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(Producto producto)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `productos` SET `categoria`=@categoria, `nombre`=@nombre,`costo`=@costo WHERE `productos`.`codigo_producto` = @codigo;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@categoria", MySqlDbType.Int32).Value = producto.Categoria;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = producto.Nombre;
                    command.Parameters.Add("@costo", MySqlDbType.Float).Value = producto.Costo;
                    command.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = producto.Codigo;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateStock(producto);
        }

        private void UpdateStock(Producto producto)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `producto_stock` SET `minimo`=@minimo,`maximo`=@maximo WHERE producto = @producto";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;
                    command.Parameters.Add("@producto", MySqlDbType.Int32).Value = producto.Id;
                    command.Parameters.Add("@minimo", MySqlDbType.Int32).Value = producto.StockMin;
                    command.Parameters.Add("@maximo", MySqlDbType.Int32).Value = producto.StockMax;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("La actualización se completó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(String id)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `productos` SET `visible` = '0', `fecha_eliminado`= @feliminado WHERE `productos`.`id` = @id;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@feliminado", MySqlDbType.DateTime).Value = System.DateTime.Now;
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("El registro se eliminó de manera satisfactoria.", "¡DATOS ELIMINADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Categorias()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT `id`, `nombre` FROM `categorias` WHERE visible = 1 ORDER BY nombre ASC";
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

        public DataTable GetTable()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`, `codigo_producto`, `categoria`, `nombre`, `costo` FROM `productos` WHERE visible = 1", con);
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
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable SearchTable(String filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `id`, `codigo_producto`, `categoria`, `nombre`, `costo` FROM `productos` WHERE visible = 1 AND (codigo_producto LIKE '" + filtro + "%' OR nombre LIKE '%" + filtro + "%' OR categoria LIKE '%"+ filtro +"%' OR costo LIKE '" + filtro + "%')", con);
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

        public int ProductosComprados(string documento)
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(dc.cantidad), 0) AS productos_comprados FROM detalle_compras dc INNER JOIN productos p ON dc.producto = p.codigo_producto WHERE p.codigo_producto = '" + documento + "'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["productos_comprados"].ToString());
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

        public int ProductosVendidos(string documento)
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(dv.cantidad), 0) AS productos_vendidos FROM detalle_ventas dv INNER JOIN productos p ON dv.producto = p.codigo_producto WHERE p.codigo_producto = '" + documento + "'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["productos_vendidos"].ToString());
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

        public int GetCantidad(string documento)
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(DISTINCT dc.cantidad), 0) AS productos_comprados, COALESCE(SUM(DISTINCT dv.cantidad), 0) AS productos_vendidos FROM detalle_compras dc INNER JOIN productos p ON dc.producto = p.codigo_producto INNER JOIN detalle_ventas dv ON p.codigo_producto = dv.producto WHERE p.codigo_producto = '"+documento+"'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["productos_comprados"].ToString()) - Int32.Parse(reader["productos_vendidos"].ToString());
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

        public int GetLastID()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id`) AS productos FROM productos", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["productos"].ToString());
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

        public Producto FindProducto(string id)
        {
            Producto producto = null;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT p.*, ps.minimo, ps.maximo FROM `productos` p INNER JOIN producto_stock ps ON p.`id` = ps.producto WHERE p.id = " + id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                producto = new Producto(Int32.Parse(reader["id"].ToString()),
                                        reader["codigo_producto"].ToString(),
                                        reader["nombre"].ToString(),
                                        reader["categoria"].ToString(),
                                        float.Parse(reader["costo"].ToString()),
                                        Int32.Parse(reader["maximo"].ToString()),
                                        Int32.Parse(reader["minimo"].ToString()));
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
            return producto;
        }
    }
}
