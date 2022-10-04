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
    class CRUDTransacciones : Conexion
    {
        CRUDProductos crud = new CRUDProductos();
        public void Create_Compra(Compra compra)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `compras`(`numero_control`, `proveedor`, `visible`, `fecha_registro`, `fecha_eliminado`) VALUES (@numerocontrol,@proveedor,@visible,@fregistro,@feliminado)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@numerocontrol", MySqlDbType.VarChar).Value = compra.Numero_Control;
                    command.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = compra.Proveedor;
                    command.Parameters.Add("@visible", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@fregistro", MySqlDbType.DateTime).Value = System.DateTime.Now;
                    command.Parameters.Add("@feliminado", MySqlDbType.DateTime).Value = null;

                    command.ExecuteNonQuery();
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
            Create_Detalle(ComprasRealizadas()-1, compra.Detalle, 1);
        }

        public void Create_Venta(Venta venta)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `ventas`(`numero_control`, `cliente`, `metodo_pago`, `visible`, `fecha_registro`, `fecha_eliminado`) VALUES (@numerocontrol,@cliente,@metodopago,@visible,@fregistro,@feliminado)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@numerocontrol", MySqlDbType.VarChar).Value = venta.Numero_Control;
                    command.Parameters.Add("@cliente", MySqlDbType.Int32).Value = venta.Cliente;
                    command.Parameters.Add("@metodopago", MySqlDbType.Int32).Value = venta.MetodoPago;
                    command.Parameters.Add("@visible", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@fregistro", MySqlDbType.DateTime).Value = System.DateTime.Now;
                    command.Parameters.Add("@feliminado", MySqlDbType.DateTime).Value = null;
                    command.ExecuteNonQuery();
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
            Create_Detalle(VentasRealizadas()-1, venta.Detalle, 2);
        }

        public void Create_Detalle(int venta, List<Detalle> detalle, int x)
        {
            int y = 0;
            string comando = "";
            switch (x)
            {
                case 1:
                    comando = "INSERT INTO `detalle_compras`(`compra`, `producto`, `cantidad`, `precio`) VALUES (@operacion,@producto,@cantidad,@precio)";
                    break;
                case 2:
                    comando = "INSERT INTO `detalle_ventas`(`venta`, `producto`, `cantidad`, `precio`) VALUES (@operacion,@producto,@cantidad,@precio)";
                    break;
            }

            try
            {
                con.Open();
                foreach (Detalle producto in detalle)
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.CommandText = comando;
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        command.Parameters.Add("@operacion", MySqlDbType.VarChar).Value = venta;
                        command.Parameters.Add("@producto", MySqlDbType.VarChar).Value = detalle[y].Producto;
                        command.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle[y].Cantidad;
                        command.Parameters.Add("@precio", MySqlDbType.Double).Value = detalle[y].Precio;

                        command.ExecuteNonQuery();
                        Console.WriteLine(detalle[y].Producto);
                        y++;
                    }
                }
                
                MessageBox.Show("La operación se registró de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Persona FindPersona (String documento, string tabla)
        {

            Persona proveedor = null; 
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT `documento_identidad`, `razon_social`, `direccion`, `telefono`, `correo` FROM `" + tabla + "` WHERE `documento_identidad` = '" + documento + "' AND `visible` = 1", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    proveedor = new Persona(reader["documento_identidad"].ToString(),
                                            reader["razon_social"].ToString(),
                                            reader["direccion"].ToString(),
                                            reader["telefono"].ToString(),
                                            reader["correo"].ToString());
                }
                reader.Close();
                con.Close();
                Console.WriteLine("Proveedor encontrado!");
                return proveedor;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return proveedor;
        }

        public int ComprasRealizadas()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id_compra`) AS compras FROM compras", con);
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
            return crud.ProductosComprados(codigo) - crud.ProductosVendidos(codigo);
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
    }
}
