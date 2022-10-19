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
    class CRUDUsuarios : Conexion
    {
        public void Create(Usuario user)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `usuarios`(`usuario`, `contrasegna`, `documento_identidad`, `nombre`, `apellido`, `nivel`, `estatus`, `fecha_registro`, `fecha_eliminado`) VALUES (@usuario,@contrasegna,@documento,@nombre,@apellido,@nivel,@visible,@fregistro,@feliminado)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@contrasegna", MySqlDbType.VarChar).Value = user.Contrasegna;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = user.Documento;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = user.Nombre;
                    command.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = user.Apellido;
                    command.Parameters.Add("@nivel", MySqlDbType.VarChar).Value = user.Nivel;
                    command.Parameters.Add("@visible", MySqlDbType.Int32).Value = 1;
                    command.Parameters.Add("@fregistro", MySqlDbType.DateTime).Value = DateTime.Now;
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
                    command.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = user.Apellido;
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

        public DataTable GetTable()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `usuarios`", con);
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
    }
}
