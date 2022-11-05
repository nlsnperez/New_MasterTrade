using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Data;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUDProveedores : Conexion
    {
        
        public void Create(Persona persona, String tabla)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `"+tabla+ "`(`doc_cli`, `raz_cli`, `dir_cli`, `tel_cli`, `cor_cli`) VALUES (@documento,@nombre,@direccion,@telefono,@email)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = persona.Documento;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = persona.RazonSocial;
                    command.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = persona.Direccion;
                    command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = persona.Telefono;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = persona.Correo;

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

        public void Update(Persona persona, String tabla)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `" + tabla + "` SET `raz_cli`=@razonsocial,`dir_cli`=@direccion,`tel_cli`=@telefono,`cor_cli`=@correo WHERE `" + tabla + "`.`doc_id` = @documento;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@razonsocial", MySqlDbType.VarChar).Value = persona.RazonSocial;
                    command.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = persona.Direccion;
                    command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = persona.Telefono;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = persona.Correo;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = persona.Documento;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("La actualización se completó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable Tabla(string tabla)
        {
            try
            {
            con.Open();
            DataTable resultados = new DataTable();
            using (MySqlCommand command = new MySqlCommand())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `"+tabla+"`", con);
                adapter.Fill(resultados);
                con.Close();
            }
            Console.WriteLine("Tabla encontrada!");
            return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable BuscarTabla(string tabla, string filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `"+tabla+ "`  WHERE `doc_cli` LIKE '%" + filtro + "%' OR `raz_cli` LIKE '%" + filtro + "%' ORDER BY id_cli ASC", con);
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

        public DataTable PersonaDatos(string tabla, string filtro)
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `"+tabla+ "` WHERE `id_cli` LIKE '" + filtro + "%' OR `doc_cli` LIKE '%" + filtro + "%' OR `raz_cli` LIKE '%" + filtro + "%'";
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
    }
}
