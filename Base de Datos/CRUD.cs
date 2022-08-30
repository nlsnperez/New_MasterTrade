using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD : Conexion
    {
        
        public void Create(Persona cliente, String tabla)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `"+tabla+ "`(`documento_identidad`, `razon_social`, `direccion`, `telefono`, `correo`, `visible`, `fecha_registro`, `fecha_eliminado`) VALUES (@documento,@nombre,@direccion,@telefono,@correo,@visible,@fregistro,@feliminado)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = cliente.Documento;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = cliente.RazonSocial;
                    command.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = cliente.Direccion;
                    command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = cliente.Telefono;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = cliente.Correo;
                    command.Parameters.Add("@visible", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@fregistro", MySqlDbType.DateTime).Value = System.DateTime.Now;
                    command.Parameters.Add("@feliminado", MySqlDbType.DateTime).Value = null;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se completó de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update(Persona usuario, String tabla)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `" + tabla + "` SET `razon_social`=@razonsocial,`direccion`=@direccion,`telefono`=@telefono,`correo`=@correo WHERE `" + tabla + "`.`documento_identidad` = @documento;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@razonsocial", MySqlDbType.VarChar).Value = usuario.RazonSocial;
                    command.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = usuario.Direccion;
                    command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = usuario.Telefono;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = usuario.Correo;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = usuario.Documento;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("La actualización se completó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(String documento, String tabla)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `" + tabla + "` SET `visible` = '0', `fecha_eliminado`= @feliminado WHERE `" + tabla + "`.`documento_identidad` = @documento;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@feliminado", MySqlDbType.DateTime).Value = System.DateTime.Now;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = documento;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("El registro se eliminó de manera satisfactoria.", "¡DATOS ELIMINADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable GetTable()
        {
            try
            {
            con.Open();
            DataTable resultados = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `documento_identidad`, `razon_social`, `direccion`, `telefono`, `correo` FROM `clientes` WHERE visible = 1", con);
                adapter.Fill(resultados);
                con.Close();
            }
            Console.WriteLine("Tabla clientes encontrada!");
            return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable GetTableProveedores()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `documento_identidad`, `razon_social`, `direccion`, `telefono`, `correo` FROM `proveedores` WHERE visible = 1", con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla clientes encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable SearchTable(String tabla, String filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM "+tabla+ " p WHERE p.visible = 1 AND (p.documento_identidad LIKE '%" + filtro + "%' OR p.razon_social LIKE '" + filtro + "%' OR p.direccion LIKE '" + filtro + "%' OR p.telefono LIKE '" + filtro + "%' OR p.correo LIKE '" + filtro + "%')", con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla clientes encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
