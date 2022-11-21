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

        public void Create(string categoria)
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

        public void Update(int id, string categoria)
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
    }
}
