using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD_Productos : Conexion2
    {
        public void Create(Producto2 producto)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `productos`(`serial`, `descripcion`, `marca`, `categoria`, `precio_compra`, `precio_venta`, `estado`, `imagen`) VALUES (@serial,@descripcion,@marca,@categoria,@preciocompra,@precioventa,@estado,@imagen)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@serial", MySqlDbType.VarChar).Value = producto.Serial;
                    command.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = producto.Descripcion;
                    command.Parameters.Add("@marca", MySqlDbType.Int32).Value = producto.Marca;
                    command.Parameters.Add("@categoria", MySqlDbType.Int32).Value = producto.Categoria;
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

        public void Update(Producto2 producto, int id)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `productos` SET `serial`=@serial,`descripcion`=@descripcion,`marca`=@marca,`categoria`=@categoria,`precio_compra`=@preciocompra,`precio_venta`=@precioventa,`estado`=@estado,`imagen`=@imagen WHERE `id`=@id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@serial", MySqlDbType.VarChar).Value = producto.Serial;
                    command.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = producto.Descripcion;
                    command.Parameters.Add("@marca", MySqlDbType.Int32).Value = producto.Marca;
                    command.Parameters.Add("@categoria", MySqlDbType.Int32).Value = producto.Categoria;
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
            String sql = "SELECT * FROM `categorias` ORDER BY nombre ASC";
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
            String sql = "SELECT * FROM `marcas` ORDER BY nombre ASC";
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
            String sql = "SELECT * FROM `productos`";
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

        public DataTable ProductoDatos(string serial)
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `productos` WHERE `serial` =" + serial;
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
    }
}
