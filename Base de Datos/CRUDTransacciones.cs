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
            Create_Detalle(compra.Numero_Control, compra.Detalle);
        }

        public void Create_Detalle(string compra, List<Detalle_Compra> detalle)
        {
            int y = 0;
            try
            {
                con.Open();
                foreach (Detalle_Compra producto in detalle)
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.CommandText = "INSERT INTO `detalle_compras`(`compra`, `producto`, `cantidad`, `precio`) VALUES (@compra,@producto,@cantidad,@precio)";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        command.Parameters.Add("@compra", MySqlDbType.VarChar).Value = compra;
                        command.Parameters.Add("@producto", MySqlDbType.VarChar).Value = detalle[y].Producto;
                        command.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle[y].Cantidad;
                        command.Parameters.Add("@precio", MySqlDbType.Double).Value = detalle[y].Precio;

                        command.ExecuteNonQuery();
                        Console.WriteLine(detalle[y].Producto);
                        y++;
                    }
                }
                
                MessageBox.Show("La compra se registró de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable FindProductos(String proveedor)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `codigo_producto`, `nombre`, `costo` FROM `productos` WHERE productos.proveedor = '"+proveedor+"' AND visible = 1", con);
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

        public DataTable BuscarProductos(String proveedor, String busqueda)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `codigo_producto`, `nombre`, `costo` FROM `productos` WHERE productos.proveedor = '" + proveedor + "' AND visible = 1 AND (productos.codigo_producto LIKE '%" + busqueda + "%' OR productos.nombre LIKE '" + busqueda + "%' OR productos.costo LIKE '" + busqueda + "%')", con);
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

        public Persona FindPersona (String documento)
        {

            Persona proveedor = null; 
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT `documento_identidad`, `razon_social`, `direccion`, `telefono`, `correo` FROM `proveedores` WHERE `documento_identidad` = '" + documento + "' AND `visible` = 1", con);
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
    }
}
