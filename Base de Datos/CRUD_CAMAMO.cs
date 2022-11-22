using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    internal class CRUD_CAMAMO : Conexion
    {
        public DataTable TablaCategoria()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `categoria`", con);
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

        public void Create_Categoria(string categoria)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `categoria`(`nom_cat`, `act_cat`) VALUES (@categoria, @activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = categoria;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se registró de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update_Categoria(int id, string categoria)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `categoria` SET `nom_cat`=@categoria WHERE `id_cat` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = categoria;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se actualizó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete_Categoria(int id, int x)
        {
            string mensaje = "";
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `categoria` SET `act_cat`=@activo WHERE `id_cat` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;

                    command.ExecuteNonQuery();
                }

                if (x == 0)
                {
                    mensaje = "El registro se eliminó de manera satisfactoria.";
                }
                else
                {
                    mensaje = "El registro se restauró de manera satisfactoria.";
                }

                MessageBox.Show(mensaje, "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int NuevoId_Categoria()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id_cat`) AS categorias FROM categoria", con);
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
            return x + 1;
        }

        public DataTable TablaMarca()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `marca`", con);
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

        public void Create_Marca(string marca)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `marca`(`nom_mar`, `act_mar`) VALUES (@marca, @activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@marca", MySqlDbType.VarChar).Value = marca;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se registró de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update_Marca(int id, string marca)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `marca` SET `nom_mar`=@marca WHERE `id_mar` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@marca", MySqlDbType.VarChar).Value = marca;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se actualizó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete_Marca(int id, int x)
        {
            string mensaje = "";
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `marca` SET `act_mar`=@activo WHERE `id_mar` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;

                    command.ExecuteNonQuery();
                }

                if (x == 0)
                {
                    mensaje = "El registro se eliminó de manera satisfactoria.";
                }
                else
                {
                    mensaje = "El registro se restauró de manera satisfactoria.";
                }

                MessageBox.Show(mensaje, "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int NuevoId_Marca()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM marca ORDER BY id_mar DESC", con);
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
            return x + 1;
        }

        public DataTable TablaModelo()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `modelo`", con);
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

        public void Create_Modelo(string modelo)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `modelo`(`nom_mod`, `act_mod`) VALUES (@modelo, @activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = modelo;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se registró de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update_Modelo(int id, string modelo)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `modelo` SET `nom_mod`=@modelo WHERE `id_mar` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@marca", MySqlDbType.VarChar).Value = modelo;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se actualizó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete_Modelo(int id, int x)
        {
            string mensaje = "";
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `modelo` SET `act_mod`=@activo WHERE `id_mod` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;

                    command.ExecuteNonQuery();
                }

                if (x == 0)
                {
                    mensaje = "El registro se eliminó de manera satisfactoria.";
                }
                else
                {
                    mensaje = "El registro se restauró de manera satisfactoria.";
                }

                MessageBox.Show(mensaje, "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int NuevoId_Modelo()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM modelo ORDER BY id_mod DESC", con);
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
            return x + 1;
        }
    }
}
