using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUDExtras : Conexion
    {
        public void CreateCategorie(string nombre)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `categorias`(`nombre`, `visible`) VALUES (@nombre, @visible)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre.ToUpper();
                    command.Parameters.Add("@visible", MySqlDbType.Int32).Value = 1;

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
        }

        public void UpdateCategoria(string id, string nombre)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `categorias` SET `nombre`=@nombre WHERE `categorias`.`id` = @id;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = nombre.ToUpper();

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

        public void DeleteCategoria(string id)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `categorias` SET `visible`= 0 WHERE `categorias`.`id` = @id;";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

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

        public DataTable GetTable()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `categorias` WHERE `visible` = 1", con);
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

        public int GetLastID()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id`) AS categorias FROM categorias", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["categorias"].ToString());
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
