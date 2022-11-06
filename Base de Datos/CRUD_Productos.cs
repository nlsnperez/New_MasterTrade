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
                    command.CommandText = "INSERT INTO `producto`(`id_cat`, `id_mar`, `id_mod`, `ser_pro`, `des_pro`, `pco_pro`, `pve_pro`, `img_pro`, `est_pro`) VALUES (@categoria,@marca,@modelo,@serial,@descripcion,@preciocompra,@precioventa,@estado,@imagen)";
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
                    command.CommandText = "UPDATE `producto` SET `ser_pro`=@serial,`des_pro`=@descripcion,`id_mar`=@marca,`id_cat`=@categoria, `id_mod`=@modelo,`pco_pro`=@preciocompra,`pve_pro`=@precioventa,`est_pro`=@estado,`img_pro`=@imagen WHERE `id_pro`=@id";
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
            String sql = "SELECT * FROM `categoria` ORDER BY nom_cat ASC";
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
            String sql = "SELECT * FROM `marca` ORDER BY nom_mar ASC";
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
            String sql = "SELECT * FROM `modelo` ORDER BY nom_mod ASC";
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
            String sql = "SELECT p.*, c.nom_cat AS categoria, m.nom_mar AS marca, mo.nom_mod as modelo FROM `producto` p INNER JOIN categoria c ON p.`id_cat` = c.id_cat INNER JOIN marca m ON p.`id_mar` = m.id_mar INNER JOIN modelo mo ON p.`id_mod` = mo.id_mod ORDER BY id_pro ASC";
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT p.*, c.nom_cat AS categoria, m.nom_mar AS marca, mo.nom_mod as modelo FROM `producto` p INNER JOIN categoria c ON p.`id_cat` = c.id_cat INNER JOIN marca m ON p.`id_mar` = m.id_mar INNER JOIN modelo mo ON p.`id_mod` = mo.id_mod WHERE `ser_pro` LIKE '" + filtro + "%' OR `des_pro` LIKE '%" + filtro + "%' ORDER BY id_pro ASC", con);
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
            String sql = "SELECT * FROM `producto` WHERE `ser_pro` LIKE '" + filtro + "%' OR `des_pro` LIKE '%" + filtro + "%'";
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
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id_pro`) AS productos FROM producto", con);
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

        public int ProductosComprados(int id)
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(dc.can_dco), 0) AS productos_comprados FROM detalle_compra dc INNER JOIN producto p ON dc.id_pro = p.id_pro WHERE p.id_pro = '"+id+"'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetInt32(0);
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

        public int ProductosVendidos(int id)
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COALESCE(SUM(dv.can_dve), 0) AS productos_vendidos FROM detalle_venta dv INNER JOIN producto p ON dv.id_pro = p.id_pro WHERE p.id_pro = '"+id+"'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetInt32(0);
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
