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
                    command.CommandText = "INSERT INTO `productos`(`codigo_producto`, `nombre`, `costo`, `stock_maximo`, `stock_minimo`, `visible`, `fecha_registro`, `fecha_eliminado`) VALUES (@codigo,@nombre,@costo,@stockmax,@stockmin,@visible,@fregistro,@feliminado)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = producto.Codigo;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = producto.Nombre;
                    command.Parameters.Add("@costo", MySqlDbType.Float).Value = producto.Costo;
                    command.Parameters.Add("@stockmax", MySqlDbType.Int32).Value = producto.StockMax;
                    command.Parameters.Add("@stockmin", MySqlDbType.Int32).Value = producto.StockMin;
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
        }
        public void Update(Producto producto)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `productos` SET `nombre`=@nombre,`costo`=@costo, `stock_maximo`=@stockmax, `stock_minimo`=@stockmin WHERE `productos`.`codigo_producto` = @codigo;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = producto.Nombre;
                    command.Parameters.Add("@costo", MySqlDbType.Float).Value = producto.Costo;
                    command.Parameters.Add("@stockmax", MySqlDbType.Int32).Value = producto.StockMax;
                    command.Parameters.Add("@stockmin", MySqlDbType.Int32).Value = producto.StockMin;
                    command.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = producto.Codigo;

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

        public void Delete(String codigo)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `productos` SET `visible` = '0', `fecha_eliminado`= @feliminado WHERE `productos`.`codigo_producto` = @codigo;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@feliminado", MySqlDbType.DateTime).Value = System.DateTime.Now;
                    command.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo;

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

        public DataTable FindProveedores()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CONCAT(documento_identidad, ' - ',razon_social) AS nombre_proveedor FROM proveedores WHERE proveedores.visible = 1", con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla clientes encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable GetTable()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `codigo_producto`, `nombre`, `costo`, `stock_maximo`, `stock_minimo` FROM `productos` WHERE visible = 1", con);
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

        public DataTable SearchTable(String filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `productos` p WHERE p.visible = 1 AND (p.codigo_producto LIKE '" + filtro + "%' OR p.nombre LIKE '%" + filtro + "%' OR p.costo LIKE '" + filtro + "%' OR p.stock_maximo LIKE '" + filtro + "%' OR p.stock_minimo LIKE '" + filtro + "%')", con);
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
    }
}
