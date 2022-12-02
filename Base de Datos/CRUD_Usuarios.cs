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
        public void Create(Usuario user)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `usuario`(`usr_usu`, `pas_usu`, `nom_usu`, `doc_usu`, `cor_usu`, `niv_usu`, `act_usu`) VALUES (@usuario, @contrasegna, @nombre, @documento, @correo, @nivel, @activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@contrasegna", MySqlDbType.VarChar).Value = user.Contrasegna;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = user.Nombre;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = user.Documento;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = user.Correo;
                    command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = user.Nivel;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

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
                    command.CommandText = "INSERT INTO `vendedor`(`id_usu`) VALUES (@user)";
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

        public void Update(Usuario user)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `usuario` SET `usr_usu`=@usuario,`pas_usu`=@contrasegna,`nom_usu`=@nombre,`doc_usu`=@documento,`cor_usu`=@correo,`niv_usu`=@nivel WHERE `usr_usu` = @username";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@contrasegna", MySqlDbType.VarChar).Value = user.Contrasegna;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = user.Nombre;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = user.Documento;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = user.Correo;
                    command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = user.Nivel;

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

        public void Delete(int id, int x)
        {
            string mensaje = "";
            if (x == 0)
            {
                mensaje = "El registro se eliminó de manera satisfactoria.";
            }
            else
            {
                mensaje = "El registro se restauró de manera satisfactoria.";
            }

            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `usuario` SET `act_usu`=@activo WHERE `id_usu`=@id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show(mensaje, "¡DATOS ACTUAIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `usuario`  WHERE `id_usu` LIKE '%" + filtro + "%' OR `nom_usu` LIKE '%" + filtro + "%' OR `cor_usu` LIKE '%" + filtro + "%' ORDER BY id_usu ASC", con);
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
                    string correo = reader.GetString(5);

                    SistemaSoporteCorreo servicioCorreo = new SistemaSoporteCorreo();
                    servicioCorreo.EnviarCorreo(asunto: "SOLICITUD PARA RECUPERAR CONTRASEÑA",
                                                cuerpo: "¡Hola! "+nombre+".\n\nRecibimos tu solicitud para recuperar tu contraseña. Tu actual contraseña es: "+contrasegna+"\nPor favor comunicarse con un administrador para cambiar su contraseña.\n\nInversiones MasterTrade C. A.",
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

        public Usuario Usuario(int id)
        {
            Usuario resultado = null;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` WHERE `id_usu` = " + id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Usuario cliente = new Usuario(reader.GetInt32(0),
                                                  reader.GetString(1),
                                                  reader.GetString(2),
                                                  reader.GetString(5),
                                                  reader.GetString(4),
                                                  reader.GetString(3),
                                                  reader.GetInt32(6));
                    resultado = cliente;
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
            return resultado;
        }

        public bool UserNameDuplicado(string username)
        {
            bool duplicado = false;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` WHERE `usr_usu` = '" + username+ "'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    duplicado = true;
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
            return duplicado;
        }

        public bool DocumentoDuplicado(string documento)
        {
            bool duplicado = false;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` WHERE `doc_usu` = '" + documento + "'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    duplicado = true;
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
            return duplicado;
        }

        public bool CorreoDuplicado(string correo)
        {
            bool duplicado = false;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` WHERE `cor_usu` = '" + correo + "'", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    duplicado = true;
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
            return duplicado;
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
            return x+1;
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `vendedor` WHERE act_ven = 1 AND `id_usu` = " + user_id, con);
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

        public DataTable Vendedor()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT *, u.nom_usu, u.doc_usu FROM vendedor v INNER JOIN usuario u ON v.id_usu = u.id_usu;", con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla vendedor encontrada!");
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

        public DataTable BuscarVendedor(string parametro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT *, u.nom_usu, u.doc_usu FROM vendedor v INNER JOIN usuario u ON v.id_usu = u.id_usu WHERE v.id_ven LIKE '%"+parametro+ "%' OR v.id_usu LIKE '%"+parametro+ "%' OR u.nom_usu LIKE '%"+parametro+ "%' OR u.doc_usu LIKE '%"+parametro+"%'", con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla vendedor encontrada!");
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

        public void DeleteUsuario(int id, int x)
        {
            string mensaje = "";
            if (x == 0)
            {
                mensaje = "El registro se eliminó de manera satisfactoria.";
            }
            else
            {
                mensaje = "El registro se restauró de manera satisfactoria.";
            }

            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `vendedor` SET `act_ven`=@activo WHERE `id_ven`=@id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;
                    command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show(mensaje, "¡DATOS ACTUAIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
