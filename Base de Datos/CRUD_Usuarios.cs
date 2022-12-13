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
        public void Create(Persona persona)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `usuario`(`id_niv`, `doc_usu`, `raz_usu`, `dir_usu`, `tel_usu`, `cor_usu`, `act_usu`) VALUES (@nivel,@documento,@razonsocial,@direccion,@telefono,@correo,@activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = persona.Nivel;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = persona.Documento;
                    command.Parameters.Add("@razonsocial", MySqlDbType.VarChar).Value = persona.RazonSocial;
                    command.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = persona.Direccion;
                    command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = persona.Telefono;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = persona.Correo;
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

        public void AsingarCredenciales(int id, string nombreusuario, string contrasegna)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `credencial`(`id_usu`, `nom_usu`, `pas_usu`) VALUES (@idusuario,@nombreusuario,@contrasegna)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@idusuario", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@nombreusuario", MySqlDbType.VarChar).Value = nombreusuario;
                    command.Parameters.Add("@contrasegna", MySqlDbType.VarChar).Value = contrasegna;
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

        public void Update(Persona persona)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `usuario` SET `id_niv`=@nivel, `raz_usu`=@razonsocial,`dir_usu`=@direccion,`tel_usu`=@telefono,`cor_usu`=@correo WHERE `doc_usu` =@documento";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@nivel", MySqlDbType.Int32).Value = persona.Nivel;
                    command.Parameters.Add("@razonsocial", MySqlDbType.VarChar).Value = persona.RazonSocial;
                    command.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = persona.Direccion;
                    command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = persona.Telefono;
                    command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = persona.Correo;
                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = persona.Documento;

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

        public void ActualizarCredenciales(int id, string nombreusuario, string contrasegna)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `credencial` SET `nom_usu`=@nombreusuario,`pas_usu`=@contrasegna WHERE `id_usu` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@nombreusuario", MySqlDbType.VarChar).Value = nombreusuario;
                    command.Parameters.Add("@contrasegna", MySqlDbType.VarChar).Value = contrasegna;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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

        public DataTable UsuariosActivos()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `usuario` WHERE act_usu = 1", con);
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

        public DataTable BuscarTabla(int nivel, string filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM nivel n INNER JOIN usuario u ON u.id_niv = n.id_niv INNER JOIN credencial c ON c.id_usu = u.id_usu WHERE n.id_niv = "+nivel+" AND (u.`id_usu` LIKE '%" + filtro + "%' OR u.`raz_usu` LIKE '%" + filtro + "%' OR u.`cor_usu` LIKE '%" + filtro + "%' OR u.`doc_usu` LIKE '%" + filtro + "%' OR u.`tel_usu` LIKE '%" + filtro + "%' OR u.`dir_usu` LIKE '%" + filtro + "%') ORDER BY u.id_usu ASC", con);
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

        public DataTable Nivel()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM nivel", con);
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM usuario u INNER JOIN credencial c ON c.id_usu = u.id_usu WHERE u.id_niv < 3 AND (c.nom_usu = '"+user+"' AND c.pas_usu = '"+password+"')", con);
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
                UserData.NombreUsuario = reader["nom_usu"].ToString();
                UserData.Contrasegna = reader["pas_usu"].ToString();
                UserData.Nombre = reader["raz_usu"].ToString();
                UserData.Nivel = Int32.Parse(reader["id_niv"].ToString());
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

        public Persona Usuario(int id, string documento)
        {
            Persona resultado = null;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `usuario` WHERE `id_usu` = " + id + " OR `doc_usu` LIKE '%"+documento+"%'", con);
                Console.WriteLine("SELECT * FROM `usuario` WHERE `id_usu` = " + id + " OR `doc_usu` LIKE '%" + documento + "%'");
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Persona persona = new Persona(reader.GetInt32(0),
                                                  reader.GetInt32(1),
                                                  reader.GetString(2),
                                                  reader.GetString(3),
                                                  reader.GetString(4),
                                                  reader.GetString(5),
                                                  reader.GetString(6));
                    resultado = persona;
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

        public Credencial Credenciales(int id)
        {
            Credencial resultado = null;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `credencial` WHERE `id_usu` = "+id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    Credencial credenciales = new Credencial(reader.GetInt32(0),
                                                             reader.GetString(1),
                                                             reader.GetString(2));
                    resultado = credenciales;
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM `credencial` WHERE `nom_usu` = '" + username+ "'", con);
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
