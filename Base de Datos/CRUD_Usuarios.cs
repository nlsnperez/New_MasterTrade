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
    class CRUD_Usuarios : Conexion
    {
        public void Crear(Usuario user)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `usuario`(`user`, `passwr`, `doc_id`, `nombre`, `nivel`, `estatus`) VALUES (@user,@password,@documento,@nombre,@nivel,@estatus)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Contrasegna;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = user.Documento;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = user.Nombre;
                    command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = user.Nivel;
                    command.Parameters.Add("@estatus", MySqlDbType.Int32).Value = 1;

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

        public void Update(Usuario user)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `usuarios` SET `usuario`=@usuario,`contrasegna`=@contrasegna,`nombre`=@nombre,`apellido`=@apellido,`nivel`=@nivel WHERE `id_usuario`= @Id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@Id", MySqlDbType.Int32).Value = user.ID;
                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@contrasegna", MySqlDbType.VarChar).Value = user.Contrasegna;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = user.Nombre;
                    command.Parameters.Add("@nivel", MySqlDbType.VarChar).Value = user.Nivel;

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Los datos se actualizaron con éxito", "¡ACTUALIZACIÓN EXITOSA!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Usuarios()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `usuario`", con);
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

        public DataTable BuscarTabla(string filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `usuario`  WHERE `user` LIKE '%" + filtro + "%' OR `doc_id` LIKE '%" + filtro + "%' OR `nombre` LIKE '%" + filtro + "%' ORDER BY id ASC", con);
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

        public DataTable UsuarioDatos(string id)
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `usuario` WHERE `id` = '"+id+"'";
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
