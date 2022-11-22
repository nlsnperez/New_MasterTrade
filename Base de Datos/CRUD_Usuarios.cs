using MySql.Data.MySqlClient;
using New_MasterTrade.Cache;
using New_MasterTrade.Objetos;
using New_MasterTrade.Servicios_de_Correo;
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
                    command.CommandText = "INSERT INTO `usuario`(`usr_usu`, `pas_usu`, `nom_usu`, `doc_usu`, `cor_usu`, `niv_usu`, `est_usu`) VALUES (@user,@password,@documento,@correo,@nombre,@nivel,@estatus)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Contrasegna;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = user.Documento;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = user.Correo;
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

        public void CrearVendedor(int user)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `vendedor`(`id_user`) VALUES (@user)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;

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

        public void Actualizar(Usuario user, int id)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `usuario` SET `usr_usu`=@user,`pas_usu`=@password,`nom_usu`=@nombre,`cor_usu`=@correo,`niv_usu`=@nivel,`est_usu`=@estatus WHERE `id_usu`=@id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Contrasegna;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = user.Documento;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = user.Nombre;
                    command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = user.Nivel;
                    command.Parameters.Add("@estatus", MySqlDbType.Int32).Value = 1;

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

        public bool VendedorRegistrado(int id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `vendedor` WHERE `id_usu` = '"+id+"'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    reader.Close();
                    con.Close();
                    return false;
                }
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
            return true;
        }

        public DataTable BuscarTabla(string filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `usuario`  WHERE `id_usu` LIKE '%" + filtro + "%' OR `nom_usu` LIKE '%" + filtro + "%' OR `cor_usu` LIKE '%" + filtro + "%' ORDER BY id ASC", con);
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

        public bool CanLogin(string user, string password)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` WHERE `usr_usu` = '"+user+"' AND `pas_usu` = '"+password+"'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.HasRows)
                {
                    reader.Close();
                    con.Close();
                    return false;
                }
                UserData.Id = Int32.Parse(reader["id_usu"].ToString());
                UserData.NombreUsuario = reader["usr_usu"].ToString();
                UserData.Contrasegna = reader["pas_usu"].ToString();
                UserData.Nombre = reader["nom_usu"].ToString();
                UserData.Nivel = Int32.Parse(reader["niv_usu"].ToString());
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
            return true;
        }

        public bool RecuperarContrasegna(string parametro)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` WHERE `usr_usu` = '"+ parametro + "' OR `cor_usu` = '"+ parametro + "'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    string contrasegna = reader.GetString(2);
                    string nombre = reader.GetString(3);
                    string correo = reader.GetString(4);

                    SistemaSoporteCorreo servicioCorreo = new SistemaSoporteCorreo();
                    servicioCorreo.EnviarCorreo(asunto: "SOLICITUD PARA RECUPERAR CONTRASEÑA",
                                                cuerpo: "¡Hola! "+nombre+".\n\nRecibimos tu solicitud para recuperar tu contraseña. Tu actual contraseña es: "+contrasegna+"\nPor favor cambia tu contraseña al ingresar de nuevo en el sistema.\n\nInversiones MasterTrade C. A.",
                                                destinatario: correo);

                    MessageBox.Show("Solicitud recibida, por favor revise su correo electrónico.", "¡Solicitud recibida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader.Close();
                    con.Close();
                    return true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public DataTable UsuarioDatos(string id)
        {
            DataTable usuario = new DataTable();
            String sql = "SELECT * FROM `usuario` WHERE `id_usu` = '"+id+"'";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(usuario);
                return usuario;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return usuario;
        }

        public int GetId()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` ORDER BY id_usu DESC", con);
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
            return x;
        }

        public int VendedorId(int user_id)
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `vendedor` WHERE `id_usu` = "+user_id, con);
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
            return x;
        }

        public bool IsVendedor(int user_id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `vendedor` WHERE `id_usu` = " + user_id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    
                    reader.Close();
                    con.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
    }
}
