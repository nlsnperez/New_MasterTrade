using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD_Productos : Conexion
    {
        public void Create(Producto producto)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `producto`(`id_cat`, `id_mar`, `id_mod`, `serial`, `descr`, `p_com`, `p_ven`, `estado`, `imagen`) VALUES (@categoria,@marca,@modelo,@serial,@descripcion,@preciocompra,@precioventa,@estado,@imagen)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@serial", MySqlDbType.VarChar).Value = producto.Serial;
                    command.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = producto.Descripcion;
                    command.Parameters.Add("@marca", MySqlDbType.Int32).Value = producto.Marca;
                    command.Parameters.Add("@categoria", MySqlDbType.Int32).Value = producto.Categoria;
                    command.Parameters.Add("@modelo", MySqlDbType.Int32).Value = producto.Modelo;
                    command.Parameters.Add("@preciocompra", MySqlDbType.Decimal).Value = producto.Precio_Compra;
                    command.Parameters.Add("@precioventa", MySqlDbType.Decimal).Value = producto.Precio_Venta;
                    command.Parameters.Add("@estado", MySqlDbType.Int32).Value = producto.Estado;
                    command.Parameters.Add("@imagen", MySqlDbType.LongBlob).Value = producto.Imagen;

                    command.ExecuteNonQuery();
                    
                }
                MessageBox.Show("El registro se completó de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update(Producto producto, int id)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `producto` SET `serial`=@serial,`descr`=@descripcion,`id_mar`=@marca,`id_cat`=@categoria, `id_mod`=@modelo,`p_com`=@preciocompra,`p_ven`=@precioventa,`estado`=@estado,`imagen`=@imagen WHERE `id`=@id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@serial", MySqlDbType.VarChar).Value = producto.Serial;
                    command.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = producto.Descripcion;
                    command.Parameters.Add("@marca", MySqlDbType.Int32).Value = producto.Marca;
                    command.Parameters.Add("@categoria", MySqlDbType.Int32).Value = producto.Categoria;
                    command.Parameters.Add("@modelo", MySqlDbType.Int32).Value = producto.Modelo;
                    command.Parameters.Add("@preciocompra", MySqlDbType.Decimal).Value = producto.Precio_Compra;
                    command.Parameters.Add("@precioventa", MySqlDbType.Decimal).Value = producto.Precio_Venta;
                    command.Parameters.Add("@estado", MySqlDbType.Int32).Value = producto.Estado;
                    command.Parameters.Add("@imagen", MySqlDbType.LongBlob).Value = producto.Imagen;

                    command.ExecuteNonQuery();

                }
                MessageBox.Show("El registro se completó de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable Categorias()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `categoria` ORDER BY nombre ASC";
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

        public DataTable Marcas()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `marca` ORDER BY nombre ASC";
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

        public DataTable Modelos()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `modelo` ORDER BY nombre ASC";
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

        public DataTable TablaProductos()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT p.*, c.nombre AS categoria, m.nombre AS marca, mo.nombre as modelo FROM `producto` p INNER JOIN categoria c ON p.`id_cat` = c.id INNER JOIN marca m ON p.`id_mar` = m.id INNER JOIN modelo mo ON p.`id_mod` = mo.id ORDER BY id ASC";
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

        public DataTable BuscarProductos(String filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT p.*, c.nombre AS categoria, m.nombre AS marca, mo.nombre as modelo FROM `producto` p INNER JOIN categoria c ON p.`id_cat` = c.id INNER JOIN marca m ON p.`id_mar` = m.id INNER JOIN modelo mo ON p.`id_mod` = mo.id WHERE `serial` LIKE '" + filtro + "%' OR `descr` LIKE '%" + filtro + "%' ORDER BY id ASC", con);
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

        public DataTable ProductoDatos(string filtro)
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `producto` WHERE `serial` LIKE '" + filtro + "%' OR `descr` LIKE '%" + filtro + "%'";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(categorias);
                Console.WriteLine("¡Yei!");
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

        public int GetLastID()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id`) AS productos FROM producto", con);
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
                MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(DISTINCT dc.cantidad), 0) AS productos_comprados, COALESCE(SUM(DISTINCT dv.cantidad), 0) AS productos_vendidos FROM detalle_compras dc INNER JOIN productos p ON dc.producto = p.codigo_producto INNER JOIN detalle_ventas dv ON p.codigo_producto = dv.producto WHERE p.codigo_producto = '" + documento + "'", con);
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
    }
}
